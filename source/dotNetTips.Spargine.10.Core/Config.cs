// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 02-07-2021
//
// Last Modified By : David McCarter
// Last Modified On : 05-10-2026
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
/// This class is designed to be adaptable for various types of configuration needs.
/// </summary>
/// <typeparam name="T">The type of the configuration object.</typeparam>
[Serializable]
[Information(Documentation = "https://bit.ly/SpargineConfig", Status = Status.UpdateDocumentation)]
public class Config<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicFields)] T>
	where T : class, new()
{
	/// <summary>
	/// The singleton instance of the configuration object.
	/// </summary>
	private static T _instance = new();

	/// <summary>
	/// Initializes a new instance of the <see cref="Config{T}"/> class.
	/// Sets up default paths for the configuration file based on application information.
	/// </summary>
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
	[Information("Config", UnitTestStatus = UnitTestStatus.None, Status = Status.New)]
	protected Config([DisallowNull] string companyName, [DisallowNull] string productName)
	{
		companyName = companyName.ArgumentNotNullOrEmpty();
		productName = productName.ArgumentNotNullOrEmpty();

		var localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

		this.ConfigFolderName = Path.Combine(localAppData, companyName);
		this.ConfigFileName = Path.Combine(this.ConfigFolderName, $"{productName}.config");
	}

	/// <summary>
	/// Gets the full path of the configuration file.
	/// </summary>
	/// <value>The full path of the configuration file.</value>
	[XmlIgnore]
	public string ConfigFileName { [return: NotNull] get; }

	/// <summary>
	/// Gets the full path of the configuration folder.
	/// </summary>
	/// <value>The full path of the configuration folder.</value>
	[XmlIgnore]
	public string ConfigFolderName { [return: NotNull] get; }

	/// <summary>
	/// Gets the singleton instance of the configuration object.
	/// </summary>
	/// <value>The instance of the configuration object.</value>
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
	/// <returns><c>true</c> if the configuration was successfully loaded; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method attempts to deserialize the configuration object from a file specified by <see cref="ConfigFileName"/>.
	/// If the file does not exist, the method returns <c>false</c>.
	/// </remarks>
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
	/// If a configuration file already exists at <see cref="ConfigFileName"/>, it is deleted before the new file is written.
	/// The configuration is serialized to XML using <see cref="XmlSerialization.SerializeToFile"/>.
	/// </remarks>
	/// <exception cref="UnauthorizedAccessException">Thrown if the process does not have permission to write to the configuration file path.</exception>
	/// <exception cref="IOException">Thrown if an I/O error occurs while deleting the existing file or writing the new configuration file.</exception>
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
