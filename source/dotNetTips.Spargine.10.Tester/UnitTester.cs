// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Tester
// Author           : David McCarter
// Created          : 10-22-2023
//
// Last Modified By : David McCarter
// Last Modified On : 12-29-2025
// ***********************************************************************
// <copyright file="UnitTester.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// The UnitTester class is an abstract base class designed to
// facilitate unit testing by providing utility methods for debugging
// and saving object properties.
// </summary>
// ***********************************************************************

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)
namespace DotNetTips.Spargine.Tester;

/// <summary>
/// Provides utility methods for debugging and saving object properties.
/// This class is intended to be used as a base class for unit testing scenarios.
/// </summary>
/// <remarks>
/// Initializes a new instance of the <see cref="UnitTester"/> class.
/// </remarks>
/// <param name="outputDirectory">The directory where output files will be saved. Defaults to the current directory if not specified.</param>
[ExcludeFromCodeCoverage]
[DebuggerStepThrough]
[Information(Status = Status.Available, Documentation = "https://bit.ly/SpargineUnitTester")]
public abstract class UnitTester(string? outputDirectory = null)
{

	/// <summary>
	/// Gets the output directory where files will be saved.
	/// </summary>
	/// <value>
	/// A string representing the directory path where output files will be saved.
	/// </value>
	[Information(nameof(OutputDirectory), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public string OutputDirectory { get; } = outputDirectory ?? App.ExecutingFolder();

	/// <summary>
	/// Writes the specified input string to the debug output.
	/// </summary>
	/// <param name="input">The string to write to the debug output. Cannot be null or empty.</param>
	/// <param name="methodName">
	/// The name of the calling method. This is automatically populated by the compiler unless explicitly provided.
	/// </param>
	/// <remarks>
	/// If the <paramref name="input"/> is null or empty, the method will return without writing anything to the debug output.
	/// </remarks>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="input"/> is null or empty.</exception>
	[DebuggerStepThrough]
	[Information(nameof(PrintToDebug), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public void PrintToDebug([NotNull] string input, [CallerMemberName] string methodName = ControlChars.EmptyString)
	{
		if (input.IsNullOrEmpty())
		{
			return;
		}

		Debug.WriteLine(new string(ControlChars.Equal, 80));
		Debug.WriteLineIf(methodName.HasValue(), $"Method: {methodName}");
		Debug.WriteLine(input);
		Debug.WriteLine(new string(ControlChars.Equal, 80));
	}

	/// <summary>
	/// Prints the properties of each object in a input to the debug output.
	/// </summary>
	/// <typeparam name="T">The type of the objects in the input.</typeparam>
	/// <param name="collection">The input of objects whose properties will be printed to the debug output.</param>
	/// <param name="propertySelector">A function that determines which properties to include in the output.</param>
	/// <param name="methodName">
	/// The name of the calling method. This is automatically populated by the compiler unless explicitly provided.
	/// </param>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="collection"/> or <paramref name="propertySelector"/> is null.</exception>
	[DebuggerStepThrough]
	[Information(nameof(PrintToDebug), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public void PrintToDebug<T>([NotNull] IEnumerable<T> collection, [NotNull] Func<PropertyInfo, bool> propertySelector, [CallerMemberName] string methodName = ControlChars.EmptyString)
	{
		collection = collection.ArgumentNotNull();
		propertySelector = propertySelector.ArgumentNotNull();

		Debug.WriteLine(new string(ControlChars.Equal, 80));

		Debug.WriteLineIf(methodName.HasValue(), $"Method: {methodName}");

		foreach (var item in collection)
		{
			var itemString = item!.PropertiesToString(propertySelector);

			Debug.WriteLine(itemString);
		}

		Debug.WriteLine(new string(ControlChars.Equal, 80));
	}

	/// <summary>
	/// Prints the properties of an object to the debug output.
	/// </summary>
	/// <typeparam name="T">The type of the object.</typeparam>
	/// <param name="input">The object whose properties will be printed to the debug output.</param>
	/// <param name="propertySelector">A function that determines which properties to include in the output.</param>
	/// <param name="methodName">
	/// The name of the calling method. This is automatically populated by the compiler unless explicitly provided.
	/// </param>
	/// <exception cref="ArgumentNullException">
	/// Thrown when <paramref name="input"/> or <paramref name="propertySelector"/> is null.
	/// </exception>
	[DebuggerStepThrough]
	[Information(nameof(PrintToDebug), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public void PrintToDebug<T>(T input, [NotNull] Func<PropertyInfo, bool> propertySelector, [CallerMemberName] string methodName = ControlChars.EmptyString)
	{
		input = input.ArgumentNotNull();
		propertySelector = propertySelector.ArgumentNotNull();

		Debug.WriteLineIf(methodName.HasValue(), $"Method: {methodName}");
		Debug.WriteLine(input.PropertiesToString(propertySelector));
	}

	/// <summary>
	/// Saves the specified input string to a file in the output directory.
	/// </summary>
	/// <param name="input">The string content to save to the file. Cannot be null or empty.</param>
	/// <param name="methodName">
	/// The name of the calling method. This parameter is automatically populated by the compiler
	/// using the <see cref="CallerMemberNameAttribute"/>. Used to generate the output file name.
	/// If empty, a random key is used as the file name.
	/// </param>
	/// <returns>
	/// The full path of the saved file if successful; otherwise, <see cref="string.Empty"/> if the input is null or empty.
	/// </returns>
	/// <remarks>
	/// <para>
	/// This method generates a file name based on the calling method name. The file is saved with a .txt extension
	/// in the directory specified by <see cref="OutputDirectory"/>.
	/// </para>
	/// <para>
	/// If the <paramref name="input"/> parameter is null or empty, the method returns <see cref="string.Empty"/>
	/// without attempting to write to the file system.
	/// </para>
	/// <para>
	/// <b>File Naming Convention:</b>
	/// <list type="bullet">
	/// <item><description>If <paramref name="methodName"/> has a value: <c>{methodName}.txt</c></description></item>
	/// <item><description>If <paramref name="methodName"/> is empty: <c>{RandomKey}.txt</c></description></item>
	/// </list>
	/// </para>
	/// </remarks>
	/// <exception cref="IOException">Thrown when an I/O error occurs while writing to the file.</exception>
	/// <exception cref="UnauthorizedAccessException">Thrown when the caller does not have the required permission to write to the directory.</exception>
	/// <exception cref="System.IO.DirectoryNotFoundException">Thrown when the output directory does not exist.</exception>
	/// <exception cref="PathTooLongException">Thrown when the resulting file path exceeds the system-defined maximum length.</exception>
	/// <example>
	/// This example shows how to use <see cref="SaveToFile(string, string)"/> to save content to a file.
	/// <code>
	/// var tester = new MyUnitTester();
	/// string content = "Test data to save";
	/// string savedPath = tester.SaveToFile(content);
	/// Console.WriteLine($"File saved to: {savedPath}");
	/// // Output might be: File saved to: C:\Output\MyTestMethod.txt
	/// </code>
	/// </example>
	/// <seealso cref="SaveToFile(string, DirectoryInfo, string)"/>
	/// <seealso cref="SaveToFile{T}(T, Func{PropertyInfo, bool}, string)"/>
	/// <seealso cref="OutputDirectory"/>
	[DebuggerStepThrough]
	[Information(nameof(SaveToFile), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public string SaveToFile([NotNull] string input, [CallerMemberName] string methodName = ControlChars.EmptyString)
	{
		if (input.IsNullOrEmpty())
		{
			return string.Empty;
		}

		var filePath = Path.Combine(this.OutputDirectory, GenerateFileName(methodName));

		File.WriteAllText(filePath, input);

		return filePath;
	}

	/// <summary>
	/// Saves the specified input string to a file in the specified directory.
	/// </summary>
	/// <param name="input">The string to save to the file. Cannot be null or empty.</param>
	/// <param name="directory">The directory where the file will be saved. Cannot be null.</param>
	/// <param name="methodName">
	/// The name of the calling method. This is automatically populated by the compiler unless explicitly provided.
	/// Used to generate the output file name.
	/// </param>
	/// <returns>The full path of the saved file.</returns>
	/// <remarks>
	/// This method generates a file name based on the calling method name. If the method name is empty,
	/// a random key is used as the file name. The file is saved with a .txt extension in the specified directory.
	/// </remarks>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="input"/> or <paramref name="directory"/> is null.</exception>
	/// <exception cref="IOException">Thrown when an I/O error occurs while writing to the file.</exception>
	/// <exception cref="UnauthorizedAccessException">Thrown when the caller does not have the required permission to write to the directory.</exception>
	/// <exception cref="System.IO.DirectoryNotFoundException">Thrown when the specified directory does not exist.</exception>
	/// <example>
	/// This example shows how to use <see cref="SaveToFile(string, DirectoryInfo, string)"/> to save content to a specific directory.
	/// <code>
	/// var tester = new MyUnitTester();
	/// var outputDir = new DirectoryInfo(@"C:\TestOutput");
	/// string content = "Test data to save";
	/// string savedPath = tester.SaveToFile(content, outputDir);
	/// Console.WriteLine($"File saved to: {savedPath}");
	/// </code>
	/// </example>
	[DebuggerStepThrough]
	[Information(nameof(SaveToFile), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public string SaveToFile([NotNull] string input, DirectoryInfo directory, [CallerMemberName] string methodName = ControlChars.EmptyString)
	{
		if (input.IsNullOrEmpty())
		{
			return string.Empty;
		}

		directory = directory.ArgumentNotNull();

		var filePath = Path.Combine(directory.FullName, GenerateFileName(methodName));

		File.WriteAllText(filePath, input);

		return filePath;
	}

	/// <summary>
	/// Saves the properties of each object in a collection to a file in the current directory.
	/// </summary>
	/// <typeparam name="T">The type of the objects in the collection.</typeparam>
	/// <param name="collection">The collection of objects whose properties will be saved to the file.</param>
	/// <param name="propertySelector">A function that determines which properties to include in the output.</param>
	/// <param name="methodName">
	/// The name of the calling method. This is automatically populated by the compiler unless explicitly provided.
	/// </param>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="collection"/> or <paramref name="propertySelector"/> is null.</exception>
	[DebuggerStepThrough]
	[Information(nameof(SaveToFile), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public string SaveToFile<T>([NotNull] IEnumerable<T> collection, [NotNull] Func<PropertyInfo, bool> propertySelector, [CallerMemberName] string methodName = ControlChars.EmptyString)
	{
		collection = collection.ArgumentNotNull();
		propertySelector = propertySelector.ArgumentNotNull();

		var filePath = Path.Combine(this.OutputDirectory, GenerateFileName(methodName));

		var content = collection
			.Select(item => item!.PropertiesToString(propertySelector))
			.ToArray(); // Materialize the content to avoid deferred execution issues.

		File.WriteAllLines(filePath, content);

		return filePath;
	}

	/// <summary>
	/// Saves the properties of an object to a file in the current directory.
	/// </summary>
	/// <typeparam name="T">The type of the object.</typeparam>
	/// <param name="input">The object whose properties will be saved to the file.</param>
	/// <param name="propertySelector">A function that determines which properties to include in the output.</param>
	/// <param name="methodName">
	/// The name of the calling method. This is automatically populated by the compiler unless explicitly provided.
	/// </param>
	/// <exception cref="ArgumentNullException">
	/// Thrown when <paramref name="input"/> or <paramref name="propertySelector"/> is null.
	/// </exception>
	[DebuggerStepThrough]
	[Information(nameof(SaveToFile), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public string SaveToFile<T>(T input, [NotNull] Func<PropertyInfo, bool> propertySelector, [CallerMemberName] string methodName = ControlChars.EmptyString)
	{
		input = input.ArgumentNotNull();
		propertySelector = propertySelector.ArgumentNotNull();

		var content = input.PropertiesToString(propertySelector);

		if (string.IsNullOrEmpty(content))
		{
			return string.Empty;
		}

		var filePath = Path.Combine(this.OutputDirectory, GenerateFileName(methodName));

		File.WriteAllText(filePath, content);

		return filePath;
	}

	/// <summary>
	/// Saves the properties of an object to a file in the specified directory.
	/// </summary>
	/// <typeparam name="T">The type of the object.</typeparam>
	/// <param name="input">The object whose properties will be saved to the file. Cannot be null.</param>
	/// <param name="propertySelector">A function that determines which properties to include in the output. Cannot be null.</param>
	/// <param name="directory">The directory where the file will be saved. Cannot be null.</param>
	/// <param name="methodName">
	/// The name of the calling method. This is automatically populated by the compiler unless explicitly provided.
	/// Used to generate the output file name.
	/// </param>
	/// <returns>The full path of the saved file.</returns>
	/// <remarks>
	/// This method generates a file name based on the calling method name. If the method name is empty,
	/// a random key is used as the file name. The file is saved with a .txt extension in the specified directory.
	/// The object's properties are converted to a string representation using the property selector function,
	/// formatting each property as "PropertyName: PropertyValue" and joining them with comma-space separators.
	/// </remarks>
	/// <exception cref="ArgumentNullException">
	/// Thrown when <paramref name="input"/>, <paramref name="propertySelector"/>, or <paramref name="directory"/> is null.
	/// </exception>
	/// <exception cref="ArgumentException">Thrown when <paramref name="methodName"/> is null or empty.</exception>
	/// <exception cref="IOException">Thrown when an I/O error occurs while writing to the file.</exception>
	/// <exception cref="UnauthorizedAccessException">Thrown when the caller does not have the required permission to write to the directory.</exception>
	/// <exception cref="System.IO.DirectoryNotFoundException">Thrown when the specified directory does not exist.</exception>
	/// <example>
	/// This example shows how to use <see cref="SaveToFile{T}(T, Func{PropertyInfo, bool}, DirectoryInfo, string)"/> to save an object's properties to a specific directory.
	/// <code>
	/// var tester = new MyUnitTester();
	/// var outputDir = new DirectoryInfo(@"C:\TestOutput");
	/// var person = new Person { FirstName = "John", LastName = "Doe", Age = 30 };
	/// string savedPath = tester.SaveToFile(person, p => p.PropertyType == typeof(string), outputDir);
	/// Console.WriteLine($"File saved to: {savedPath}");
	/// </code>
	/// </example>
	[DebuggerStepThrough]
	[Information(nameof(SaveToFile), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public string SaveToFile<T>(T input, [NotNull] Func<PropertyInfo, bool> propertySelector, DirectoryInfo directory, [CallerMemberName] string methodName = ControlChars.EmptyString)
	{
		input = input.ArgumentNotNull();
		propertySelector = propertySelector.ArgumentNotNull();
		directory = directory.ArgumentNotNull();

		var filePath = Path.Combine(directory.FullName, GenerateFileName(methodName));

		var content = input.PropertiesToString(propertySelector);

		File.WriteAllText(filePath, content);

		return filePath;
	}

	/// <summary>
	/// Saves the properties of each object in a collection to a file in the specified directory.
	/// </summary>
	/// <typeparam name="T">The type of the objects in the collection.</typeparam>
	/// <param name="collection">The collection of objects whose properties will be saved to the file. Cannot be null.</param>
	/// <param name="propertySelector">A function that determines which properties to include in the output. Cannot be null.</param>
	/// <param name="directory">The directory where the file will be saved. Cannot be null.</param>
	/// <param name="methodName">
	/// The name of the calling method. This is automatically populated by the compiler unless explicitly provided.
	/// Used to generate the output file name.
	/// </param>
	/// <returns>The full path of the saved file.</returns>
	/// <remarks>
	/// This method generates a file name based on the calling method name. If the method name is empty,
	/// a random key is used as the file name. The file is saved with a .txt extension in the specified directory.
	/// Each object in the collection is converted to a string representation using the property selector,
	/// and each object's properties are written as a separate line in the file.
	/// The collection is materialized to an array before writing to avoid deferred execution issues.
	/// </remarks>
	/// <exception cref="ArgumentNullException">
	/// Thrown when <paramref name="collection"/>, <paramref name="propertySelector"/>, or <paramref name="directory"/> is null.
	/// </exception>
	/// <exception cref="ArgumentException">Thrown when <paramref name="methodName"/> is null or empty.</exception>
	/// <exception cref="IOException">Thrown when an I/O error occurs while writing to the file.</exception>
	/// <exception cref="UnauthorizedAccessException">Thrown when the caller does not have the required permission to write to the directory.</exception>
	/// <exception cref="System.IO.DirectoryNotFoundException">Thrown when the specified directory does not exist.</exception>
	/// <example>
	/// This example shows how to use <see cref="SaveToFile{T}(IEnumerable{T}, Func{PropertyInfo, bool}, DirectoryInfo, string)"/> to save a collection of objects to a specific directory.
	/// <code>
	/// var tester = new MyUnitTester();
	/// var outputDir = new DirectoryInfo(@"C:\TestOutput");
	/// var people = new List&lt;Person&gt; 
	/// { 
	///     new Person { FirstName = "John", LastName = "Doe" },
	///     new Person { FirstName = "Jane", LastName = "Smith" }
	/// };
	/// string savedPath = tester.SaveToFile(people, p => p.PropertyType == typeof(string), outputDir);
	/// Console.WriteLine($"File saved to: {savedPath}");
	/// </code>
	/// </example>
	[DebuggerStepThrough]
	[Information(nameof(SaveToFile), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public string SaveToFile<T>([NotNull] IEnumerable<T> collection, [NotNull] Func<PropertyInfo, bool> propertySelector, DirectoryInfo directory, [CallerMemberName] string methodName = ControlChars.EmptyString)
	{
		collection = collection.ArgumentNotNull();
		propertySelector = propertySelector.ArgumentNotNull();
		directory = directory.ArgumentNotNull();

		var filePath = Path.Combine(directory.FullName, GenerateFileName(methodName));

		var content = collection
			.Select(item => item!.PropertiesToString(propertySelector))
			.ToArray(); // Materialize the content to avoid deferred execution issues.

		File.WriteAllLines(filePath, content);

		return filePath;
	}

	/// <summary>
	/// Asynchronously saves the properties of each object in a collection to a file in the current directory.
	/// </summary>
	/// <typeparam name="T">The type of the objects in the collection.</typeparam>
	/// <param name="collection">The collection of objects whose properties will be saved to the file.</param>
	/// <param name="propertySelector">A function that determines which properties to include in the output.</param>
	/// <param name="methodName">
	/// The name of the calling method. This is automatically populated by the compiler unless explicitly provided.
	/// </param>
	/// <returns>A task that represents the asynchronous operation.</returns>
	/// <exception cref="ArgumentNullException">
	/// Thrown when <paramref name="collection"/> or <paramref name="propertySelector"/> is null.
	/// </exception>
	/// <exception cref="ArgumentException">
	/// Thrown when <paramref name="methodName"/> is null or empty.
	/// </exception>
	[AsyncStateMachine(typeof(Task))]
	[DebuggerStepThrough]
	[Information(nameof(SaveToFileAsync), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public async Task<string> SaveToFileAsync<T>([NotNull] IEnumerable<T> collection, [NotNull] Func<PropertyInfo, bool> propertySelector, [CallerMemberName] string methodName = ControlChars.EmptyString)
	{
		collection = collection.ArgumentNotNull();
		propertySelector = propertySelector.ArgumentNotNull();

		var filePath = Path.Combine(this.OutputDirectory, GenerateFileName(methodName));

		var content = collection
			.Select(item => item!.PropertiesToString(propertySelector))
			.ToArray();

		await File.WriteAllLinesAsync(filePath, content, CancellationToken.None).ConfigureAwait(false);

		return filePath;
	}

	/// <summary>
	/// Asynchronously saves the properties of each object in a collection to a file in the specified directory.
	/// </summary>
	/// <typeparam name="T">The type of the objects in the collection.</typeparam>
	/// <param name="collection">The collection of objects whose properties will be saved to the file. Cannot be null.</param>
	/// <param name="propertySelector">A function that determines which properties to include in the output. Cannot be null.</param>
	/// <param name="directory">The directory where the file will be saved. Cannot be null.</param>
	/// <param name="methodName">
	/// The name of the calling method. This is automatically populated by the compiler unless explicitly provided.
	/// Used to generate the output file name.
	/// </param>
	/// <returns>A task that represents the asynchronous operation. The task result contains the full path of the saved file.</returns>
	/// <remarks>
	/// This method generates a file name based on the calling method name. If the method name is empty,
	/// a random key is used as the file name. The file is saved with a .txt extension in the specified directory.
	/// Each object in the collection is converted to a string representation using the property selector,
	/// and each object's properties are written as a separate line in the file.
	/// The collection is materialized to an array before writing to avoid deferred execution issues.
	/// The asynchronous write operation uses <see cref="File.WriteAllLinesAsync(string, IEnumerable{string}, CancellationToken)"/>
	/// with ConfigureAwait(false) to avoid capturing the synchronization context.
	/// </remarks>
	/// <exception cref="ArgumentNullException">
	/// Thrown when <paramref name="collection"/>, <paramref name="propertySelector"/>, or <paramref name="directory"/> is null.
	/// </exception>
	/// <exception cref="ArgumentException">Thrown when <paramref name="methodName"/> is null or empty.</exception>
	/// <exception cref="IOException">Thrown when an I/O error occurs while writing to the file.</exception>
	/// <exception cref="UnauthorizedAccessException">Thrown when the caller does not have the required permission to write to the directory.</exception>
	/// <exception cref="System.IO.DirectoryNotFoundException">Thrown when the specified directory does not exist.</exception>
	/// <example>
	/// This example shows how to use <see cref="SaveToFileAsync{T}(IEnumerable{T}, Func{PropertyInfo, bool}, DirectoryInfo, string)"/> to asynchronously save a collection of objects to a specific directory.
	/// <code>
	/// var tester = new MyUnitTester();
	/// var outputDir = new DirectoryInfo(@"C:\TestOutput");
	/// var people = new List&lt;Person&gt; 
	/// { 
	///     new Person { FirstName = "John", LastName = "Doe" },
	///     new Person { FirstName = "Jane", LastName = "Smith" }
	/// };
	/// string savedPath = await tester.SaveToFileAsync(people, p => p.PropertyType == typeof(string), outputDir);
	/// Console.WriteLine($"File saved to: {savedPath}");
	/// </code>
	/// </example>
	[AsyncStateMachine(typeof(Task))]
	[DebuggerStepThrough]
	[Information(nameof(SaveToFileAsync), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public async Task<string> SaveToFileAsync<T>([NotNull] IEnumerable<T> collection, [NotNull] Func<PropertyInfo, bool> propertySelector, DirectoryInfo directory, [CallerMemberName] string methodName = ControlChars.EmptyString)
	{
		collection = collection.ArgumentNotNull();
		propertySelector = propertySelector.ArgumentNotNull();
		directory = directory.ArgumentNotNull();

		var filePath = Path.Combine(directory.FullName, GenerateFileName(methodName));

		var content = collection
			.Select(item => item!.PropertiesToString(propertySelector))
			.ToArray();

		await File.WriteAllLinesAsync(filePath, content, CancellationToken.None).ConfigureAwait(false);

		return filePath;
	}
	/// <summary>
	/// Generates a file name for output based on the calling method name.
	/// </summary>
	/// <param name="methodName">
	/// The name of the calling method. This is typically provided automatically via 
	/// <see cref="CallerMemberNameAttribute"/> in the public methods.
	/// </param>
	/// <returns>
	/// A string representing the file name with a .txt extension. 
	/// If <paramref name="methodName"/> is null or empty, returns a file name based on a randomly generated key.
	/// Otherwise, returns a file name based on the method name.
	/// </returns>
	/// <remarks>
	/// <para>
	/// This private helper method is used by all file-saving methods in the <see cref="UnitTester"/> class
	/// to generate consistent file names based on the calling test method.
	/// </para>
	/// <para>
	/// <b>File Naming Strategy:</b>
	/// </para>
	/// <list type="bullet">
	/// <item>
	/// <description>
	/// When <paramref name="methodName"/> has a value: <c>{methodName}.txt</c>
	/// <example>If called from a method named "TestPersonValidation", generates "TestPersonValidation.txt"</example>
	/// </description>
	/// </item>
	/// <item>
	/// <description>
	/// When <paramref name="methodName"/> is null or empty: <c>{RandomKey}.txt</c>
	/// <example>Generates something like "a1b2c3d4-e5f6-7890-abcd-ef1234567890.txt"</example>
	/// </description>
	/// </item>
	/// </list>
	/// <para>
	/// The random key fallback ensures that files are always uniquely named even when the calling method name
	/// cannot be determined, preventing accidental file overwrites during test execution.
	/// </para>
	/// </remarks>
	/// <seealso cref="RandomData.GenerateKey"/>
	/// <seealso cref="SaveToFile(string, string)"/>
	private static string GenerateFileName([NotNull] string methodName)
	{
		var fileName = methodName.FastIsNullOrEmpty() ? $"{RandomData.GenerateKey}.txt" : $"{methodName}.txt";

		return fileName;
	}
}
