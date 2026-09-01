// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 02-07-2021
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-20-2026
// ***********************************************************************
// <copyright file="Config.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Adaptable type designed to simplify the creation of custom
// configuration objects, with a focus on easy disk saving in
// applications.
// </summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Xml.Serialization;
using DotNetTips.Spargine.Core.Serialization;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Provides a generic configuration management class that simplifies the creation, loading, and saving of configuration objects to disk.
/// This class is designed to be adaptable for various types of configuration needs, supporting XML serialization for persistent storage.
/// The configuration files are stored in the user's local application data directory under a company and product-specific folder structure.
/// </summary>
/// <typeparam name="T">The type of the configuration object. Must be a reference type with a parameterless constructor to support serialization.</typeparam>
/// <remarks>
/// This class uses the singleton pattern to maintain a single instance of the configuration throughout the application lifecycle.
/// Configuration files are stored in XML format in the user's LocalApplicationData folder.
/// The class requires unreferenced code access for XML serialization, which may not be fully compatible with trimming scenarios.
/// </remarks>
[Serializable]
[Information(Documentation = "https://bit.ly/SpargineConfig", Status = Status.Available)]
public class Config<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicFields)] T>
	where T : class, new()
{
	/// <summary>
	/// The singleton instance of the configuration object. This field holds the current configuration state throughout the application lifecycle.
	/// </summary>
	private static T _instance = new();

	/// <summary>
	/// Initializes a new instance of the <see cref="Config{T}"/> class.
	/// Sets up default paths for the configuration file based on application information retrieved from <see cref="App.AppInfo"/>.
	/// </summary>
	/// <remarks>
	/// This constructor delegates to the overload that accepts company and product names, using values from App.AppInfo.Company and App.AppInfo.Product.
	/// </remarks>
	protected Config()
		: this(App.AppInfo.Company!, App.AppInfo.Product!)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="Config{T}"/> class with the specified company and product names.
	/// Sets up paths for the configuration file and folder under the user's local application data directory.
	/// </summary>
	/// <param name="companyName">The company name used to construct the configuration folder path. Must not be null or empty.</param>
	/// <param name="productName">The product name used to construct the configuration file name. Must not be null or empty.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="companyName"/> or <paramref name="productName"/> is null or empty.</exception>
	/// <remarks>
	/// The configuration folder is created at: %LocalApplicationData%\{companyName}\
	/// The configuration file is created at: %LocalApplicationData%\{companyName}\{productName}.config
	/// Both parameters are validated using <see cref="Validator"/> extension methods before use.
	/// </remarks>
	[Information("Config", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	protected Config([DisallowNull] string companyName, [DisallowNull] string productName)
	{
		companyName = companyName.ArgumentNotNullOrEmpty();
		productName = productName.ArgumentNotNullOrEmpty();

		var localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

		this.ConfigFolderName = Path.Combine(localAppData, companyName);
		this.ConfigFileName = Path.Combine(this.ConfigFolderName, $"{productName}.config");
	}

	/// <summary>
	/// Gets the full path of the configuration file where the configuration will be saved or loaded from.
	/// </summary>
	/// <value>The full path of the configuration file, typically located at %LocalApplicationData%\{CompanyName}\{ProductName}.config.</value>
	/// <remarks>
	/// This property is marked with <see cref="XmlIgnoreAttribute"/> and will not be included in the serialized configuration.
	/// </remarks>
	[XmlIgnore]
	public string ConfigFileName { [return: NotNull] get; }

	/// <summary>
	/// Gets the full path of the configuration folder where the configuration file is stored.
	/// </summary>
	/// <value>The full path of the configuration folder, typically located at %LocalApplicationData%\{CompanyName}.</value>
	/// <remarks>
	/// This property is marked with <see cref="XmlIgnoreAttribute"/> and will not be included in the serialized configuration.
	/// </remarks>
	[XmlIgnore]
	public string ConfigFolderName { [return: NotNull] get; }

	/// <summary>
	/// Gets the singleton instance of the configuration object.
	/// </summary>
	/// <value>The instance of the configuration object of type <typeparamref name="T"/>.</value>
	/// <remarks>
	/// This property provides access to the current configuration state. The instance is created when the class is first instantiated
	/// and persists throughout the application lifecycle. This property is marked with <see cref="XmlIgnoreAttribute"/> and will not be included in the serialized configuration.
	/// </remarks>
	[XmlIgnore]
	public T Instance
	{
		[return: NotNull]
		get
		{
			return _instance;
		}
	}

	/// <summary>
	/// Loads the configuration from the disk if it exists.
	/// </summary>
	/// <returns><c>true</c> if the configuration was successfully loaded and deserialized; otherwise, <c>false</c> if the file does not exist.</returns>
	/// <remarks>
	/// This method attempts to deserialize the configuration object from a file specified by <see cref="ConfigFileName"/>.
	/// If the file does not exist, the method returns <c>false</c> and the existing instance remains unchanged.
	/// The configuration is loaded using <see cref="XmlSerialization.DeserializeFromFile{T}"/>, which requires unreferenced code access.
	/// </remarks>
	/// <exception cref="InvalidOperationException">Thrown if the XML file is malformed or cannot be deserialized to type <typeparamref name="T"/>.</exception>
	/// <exception cref="UnauthorizedAccessException">Thrown if the process does not have permission to read the configuration file.</exception>
	/// <exception cref="IOException">Thrown if an I/O error occurs while reading the configuration file.</exception>
	[RequiresUnreferencedCode("XML serialization uses reflection and may require members that are removed by trimming.")]
	[Information(nameof(Load), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public virtual bool Load()
	{
		if (File.Exists(this.ConfigFileName))
		{
			_instance = XmlSerialization.DeserializeFromFile<T>(new FileInfo(this.ConfigFileName));

			return true;
		}

		return false;
	}

	/// <summary>
	/// Saves the current instance of the configuration to the disk.
	/// </summary>
	/// <returns><c>true</c> if the configuration was successfully saved; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// If a configuration file already exists at <see cref="ConfigFileName"/>, it is deleted before the new file is written to ensure a clean save.
	/// The configuration is serialized to XML format using <see cref="XmlSerialization.SerializeToFile"/>, which requires unreferenced code access.
	/// The method creates the configuration folder if it does not already exist.
	/// </remarks>
	/// <exception cref="UnauthorizedAccessException">Thrown if the process does not have permission to write to the configuration file path or delete the existing file.</exception>
	/// <exception cref="IOException">Thrown if an I/O error occurs while deleting the existing file or writing the new configuration file.</exception>
	/// <exception cref="InvalidOperationException">Thrown if the configuration object cannot be serialized to XML.</exception>
	[RequiresUnreferencedCode("XML serialization uses reflection and may require members that are removed by trimming.")]
	[Information(nameof(Save), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public virtual bool Save()
	{
		if (File.Exists(this.ConfigFileName))
		{
			File.Delete(this.ConfigFileName);
		}

		XmlSerialization.SerializeToFile(this.Instance, new FileInfo(this.ConfigFileName));

		return true;
	}
}
