// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 11-11-2020
//
// Last Modified By : David McCarter
// Last Modified On : 12-17-2025
// ***********************************************************************
// <copyright file="App.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Application Information and Utility Methods.</summary>
// ***********************************************************************
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security.Principal;
using DotNetTips.Spargine.Core.Properties;
using static DotNetTips.Spargine.Core.SourceGenerators;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Provides a centralized point of application-level properties and methods, including information about the application, culture settings, and system information.
/// </summary>
/// <remarks>
/// This class serves as a utility for accessing various application and system properties such as culture information, OS details, and processor information.
/// It also provides methods for changing culture settings, retrieving environment variables, and managing application processes.
/// </remarks>
[Information(Documentation = "https://bit.ly/SpargineApp", Status = Status.UpdateDocumentation)]
public static class App
{

	/// <summary>
	/// The temporary ASP files location.
	/// </summary>
	private const string TempAspFiles = "\\Temporary ASP.NET Files\\";

	/// <summary>
	/// Application information.
	/// </summary>
	private static readonly Lazy<AppInfo> _appInfo = new(InitAppInfo());

	/// <summary>
	/// A dictionary to store application state data.
	/// </summary>
	private static readonly ConcurrentDictionary<string, object> _appState = new(StringComparer.OrdinalIgnoreCase);


	/// <summary>
	/// Computer information.
	/// </summary>
	private static readonly Lazy<ComputerInfo> _computerInfo = new(() => new ComputerInfo());

	/// <summary>
	/// The culture names
	/// </summary>
	private static ReadOnlyCollection<string>? _cultureNames;

	/// <summary>
	/// Initializes the application information.
	/// </summary>
	/// <returns>AppInfo.</returns>
	private static AppInfo InitAppInfo()
	{
		var assembly = Assembly.GetEntryAssembly() ?? throw new InvalidOperationException(Resources.EntryAssemblyIsNullUnableToInitializeAppli);

		return new AppInfo
		{
			Company = assembly.GetCustomAttributes<AssemblyCompanyAttribute>().FirstOrDefault()?.Company ?? string.Empty,
			Configuration = assembly.GetCustomAttributes<AssemblyConfigurationAttribute>().FirstOrDefault()?.Configuration ?? string.Empty,
			Copyright = assembly.GetCustomAttributes<AssemblyCopyrightAttribute>().FirstOrDefault()?.Copyright ?? string.Empty,
			Description = assembly.GetCustomAttributes<AssemblyDescriptionAttribute>().FirstOrDefault()?.Description ?? string.Empty,
			FileVersion = assembly.GetCustomAttributes<AssemblyFileVersionAttribute>().FirstOrDefault()?.Version ?? string.Empty,
			MemoryAllocated = GC.GetTotalMemory(forceFullCollection: false),
			MemoryInfo = GC.GetGCMemoryInfo(),
			Product = assembly.GetCustomAttributes<AssemblyProductAttribute>().FirstOrDefault()?.Product ?? string.Empty,
			ThreadAllocatedBytes = GC.GetAllocatedBytesForCurrentThread(),
			Title = assembly.GetCustomAttributes<AssemblyTitleAttribute>().FirstOrDefault()?.Title ?? string.Empty,
			TotalAllocatedBytes = GC.GetTotalAllocatedBytes(precise: false),
			Version = assembly.GetName().Version?.ToString() ?? string.Empty,
		};
	}

	/// <summary>
	/// Kills the specified process by name.
	/// </summary>
	/// <param name="processName">The name of the process to kill.</param>
	/// <example>
	/// Here is how you can use the <see cref="KillProcess" /> method:
	/// <code>
	/// App.KillProcess("notepad");
	/// </code></example>
	private static void KillProcess(string processName)
	{
		processName = processName.ArgumentNotNullOrEmpty();

		var app = Process.GetProcessesByName(processName).FirstOrDefault();

		if (app is not null)
		{
			app.Kill();

			_ = app.WaitForExit(milliseconds: 6000);
		}
	}

	/// <summary>
	/// Changes the culture.
	/// </summary>
	/// <param name="cultureName">Name of the culture.</param>
	/// <example>
	/// Here is how you can use the ChangeCulture method:
	/// <code>
	/// App.ChangeCulture("en-US");
	/// </code>
	/// This will change the current culture to English (United States).
	/// </example>
	[Information(UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static void ChangeCulture([DisallowNull] string cultureName)
	{
		CultureInfo.CurrentCulture = new CultureInfo(cultureName.ArgumentNotNullOrEmpty());
	}

	/// <summary>
	/// Changes the current culture and UI culture.
	/// </summary>
	/// <param name="culture">The culture.</param>
	/// <example>
	/// Here is how you can use the ChangeCulture method:
	/// <code>
	/// App.ChangeCulture(new CultureInfo("en-US"));
	/// </code>
	/// This will change the current culture and UI culture to English (United States).
	/// </example>
	[Information(UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static void ChangeCulture([DisallowNull] CultureInfo culture)
	{
		CultureInfo.CurrentCulture = culture.ArgumentNotNull();
		CultureInfo.CurrentUICulture = culture;
	}

	/// <summary>
	/// Modifies the UI culture in the application, providing localized user interface adjustments.
	/// </summary>
	/// <param name="cultureName">Name of the culture.</param>
	/// <example>
	/// Here is how you can use the ChangeUICulture method:
	/// <code>
	/// App.ChangeUICulture("fr-FR");
	/// </code>
	/// This will change the current UI culture to French (France).
	/// </example>
	[Information(UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static void ChangeUICulture([DisallowNull] string cultureName)
	{
		CultureInfo.CurrentUICulture = new CultureInfo(cultureName.ArgumentNotNullOrEmpty());
	}

	/// <summary>
	/// Returns the folder path for the entry assembly.
	/// </summary>
	/// <returns>The directory name of the process executable in the default application domain. In other application domains, this is the first executable that was executed by AppDomain.ExecuteAssembly.</returns>
	/// <example>
	/// Here is how you can use the ExecutingFolder method:
	/// <code>
	/// var folderPath = App.ExecutingFolder();
	/// Console.WriteLine(folderPath);
	/// </code></example>
	[Pure]
	[Information(nameof(ExecutingFolder), author: "David McCarter", createdOn: "6/26/2017", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static string ExecutingFolder()
	{
		var currentWorkingDirectory = _computerInfo.Value.CurrentWorkingDirectory;
		return currentWorkingDirectory is not null ? Path.GetDirectoryName(currentWorkingDirectory) ?? string.Empty : string.Empty;
	}

	/// <summary>
	/// Generates a diagnostic report summarizing application and system information.
	/// </summary>
	/// <returns>A string containing details about the application, operating system, framework, and memory usage.</returns>
	/// <example>
	/// Example usage:
	/// <code>
	/// var report = App.GenerateDiagnosticReport();
	/// Console.WriteLine(report);
	/// </code>
	/// This will output a diagnostic report with application and system details.
	/// </example>
	/// <remarks>
	/// This method provides a quick overview of the application's environment, including product name, version, operating system details, framework description, and memory usage.
	/// It is useful for debugging, logging, or generating support information.
	/// </remarks>
	[Pure]
	[Information(nameof(GenerateDiagnosticReport), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.New)]
	public static string GenerateDiagnosticReport()
	{
		return $@"
			Application: {AppInfo.Product} v{AppInfo.Version}
			OS: {OSDescription} ({OSArchitecture})
			Framework: {FrameworkDescription}
			Memory Usage: {WorkingSet / 1024 / 1024} MB";
	}

	/// <summary>
	/// Retrieves a value from the application state dictionary in a thread-safe manner.
	/// </summary>
	/// <param name="key">The case-insensitive key to identify the state value. Must not be <c>null</c> or empty.</param>
	/// <returns>
	/// The value associated with the specified key, or <c>null</c> if the key does not exist in the application state.
	/// </returns>
	/// <remarks>
	/// This method uses <see cref="ConcurrentDictionary{TKey,TValue}.TryGetValue"/> to safely retrieve values
	/// from the thread-safe application state dictionary without requiring external synchronization.
	/// <para>
	/// <strong>Thread Safety:</strong>
	/// This method is thread-safe and can be called concurrently from multiple threads without additional locking.
	/// The underlying <see cref="ConcurrentDictionary{TKey,TValue}"/> handles all necessary synchronization internally.
	/// </para>
	/// <para>
	/// <strong>Key Comparison:</strong>
	/// The application state dictionary uses case-insensitive string comparison (<see cref="StringComparer.OrdinalIgnoreCase"/>),
	/// meaning "Theme", "theme", and "THEME" are treated as the same key.
	/// </para>
	/// <para>
	/// <strong>Performance Characteristics:</strong>
	/// <list type="bullet">
	/// <item><description>Time Complexity: O(1) average case for hash-based lookup</description></item>
	/// <item><description>Lock-free read operation - does not block concurrent reads or writes</description></item>
	/// <item><description>No allocations for successful lookups</description></item>
	/// </list>
	/// </para>
	/// </remarks>
	/// <example>
	/// Example usage:
	/// <code>
	/// // Set a value in application state
	/// App.SetAppState("Theme", "Dark");
	/// 
	/// // Retrieve the value
	/// var theme = App.GetAppState("Theme");
	/// if (theme != null)
	/// {
	///     Console.WriteLine($"Current theme: {theme}");
	/// }
	/// 
	/// // Case-insensitive key lookup
	/// var sameTheme = App.GetAppState("THEME"); // Returns "Dark"
	/// 
	/// // Non-existent key returns null
	/// var missing = App.GetAppState("NonExistentKey"); // Returns null
	/// 
	/// // Type-safe retrieval with pattern matching
	/// if (App.GetAppState("MaxRetries") is int maxRetries)
	/// {
	///     Console.WriteLine($"Max retries: {maxRetries}");
	/// }
	/// </code>
	/// </example>
	/// <exception cref="ArgumentNullException">
	/// Thrown when <paramref name="key"/> is <c>null</c> (enforced by <see cref="ConcurrentDictionary{TKey,TValue}"/>).
	/// </exception>
	/// <seealso cref="SetAppState(string, object)"/>
	[Pure]
	[Information(nameof(GetAppState), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.New)]
	public static object? GetAppState(string key)
	{
		return _appState.TryGetValue(key, out var value) ? value : null;
	}

	/// <summary>
	/// Parses and retrieves command-line arguments as a read-only dictionary of key-value pairs.
	/// </summary>
	/// <returns>
	/// An <see cref="IReadOnlyDictionary{TKey, TValue}"/> where the key is the argument name and the value is the argument value.
	/// Returns an empty dictionary if no command-line arguments were provided.
	/// </returns>
	/// <remarks>
	/// This method parses command-line arguments that follow the key=value format (e.g., --config=debug, timeout=30).
	/// <para>
	/// <strong>Argument Format:</strong>
	/// <list type="bullet">
	/// <item><description>Arguments are expected in the format: <c>key=value</c></description></item>
	/// <item><description>Arguments without an equals sign (=) are treated as keys with empty string values</description></item>
	/// <item><description>The first element (executable name) from <see cref="Environment.GetCommandLineArgs"/> is automatically skipped</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Parsing Behavior:</strong>
	/// The method splits each argument on the first equals sign (=). If an argument contains multiple equals signs,
	/// only the first one is used as a delimiter. For example:
	/// <list type="bullet">
	/// <item><description><c>key=value</c> → Key: "key", Value: "value"</description></item>
	/// <item><description><c>key=value=extra</c> → Key: "key", Value: "value=extra" (parts[1] only takes first element after split)</description></item>
	/// <item><description><c>standalone</c> → Key: "standalone", Value: "" (empty string)</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Limitations and Considerations:</strong>
	/// <list type="bullet">
	/// <item><description>Duplicate keys will cause an <see cref="ArgumentException"/> (from <see cref="Enumerable.ToDictionary{TSource, TKey, TElement}(IEnumerable{TSource}, Func{TSource, TKey}, Func{TSource, TElement})"/>)</description></item>
	/// <item><description>Does not support complex argument formats (switches, flags, multi-value arguments)</description></item>
	/// <item><description>For advanced command-line parsing, consider using <see href="https://learn.microsoft.com/en-us/dotnet/standard/commandline/">System.CommandLine</see> library</description></item>
	/// <item><description>Arguments are case-sensitive (use appropriate string comparison if needed)</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Performance Characteristics:</strong>
	/// <list type="bullet">
	/// <item><description>Time Complexity: O(n) where n is the number of command-line arguments</description></item>
	/// <item><description>Uses LINQ deferred execution with immediate materialization via <see cref="Enumerable.ToDictionary{TSource, TKey, TElement}(IEnumerable{TSource}, Func{TSource, TKey}, Func{TSource, TElement})"/></description></item>
	/// <item><description>Allocates a new dictionary on each call (not cached)</description></item>
	/// </list>
	/// </para>
	/// </remarks>
	/// <example>
	/// Example usage scenarios:
	/// <code>
	/// // Command line: myapp.exe config=debug timeout=30 verbose
	/// var args = App.GetCommandLineArguments();
	/// 
	/// // Result dictionary contains:
	/// // { "config" => "debug", "timeout" => "30", "verbose" => "" }
	/// 
	/// // Accessing values
	/// if (args.TryGetValue("config", out string configValue))
	/// {
	///     Console.WriteLine($"Config: {configValue}");  // Output: Config: debug
	/// }
	/// 
	/// // Check for flag-style arguments
	/// if (args.ContainsKey("verbose"))
	/// {
	///     Console.WriteLine("Verbose mode enabled");
	/// }
	/// 
	/// // Parse numeric values
	/// if (args.TryGetValue("timeout", out string timeoutStr) &amp;&amp; 
	///     int.TryParse(timeoutStr, out int timeout))
	/// {
	///     Console.WriteLine($"Timeout: {timeout} seconds");
	/// }
	/// 
	/// // Enumerate all arguments
	/// foreach (var arg in args)
	/// {
	///     Console.WriteLine($"{arg.Key}: {arg.Value}");
	/// }
	/// </code>
	/// </example>
	/// <exception cref="ArgumentException">
	/// Thrown when duplicate argument keys are detected in the command line.
	/// </exception>
	/// <seealso cref="Environment.GetCommandLineArgs"/>
	[Pure]
	[Information(nameof(GetCommandLineArguments), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.New)]
	public static IReadOnlyDictionary<string, string> GetCommandLineArguments()
	{
		return Environment.GetCommandLineArgs()
					.Skip(1)
					.Select(arg => arg.Split('='))
					.ToDictionary(parts => parts[0], parts => parts.Length > 1 ? parts[1] : string.Empty);
	}

	/// <summary>
	/// Gets the culture names based on the specified culture type.
	/// </summary>
	/// <param name="cultureType">Type of the culture. Defaults to AllCultures.</param>
	/// <returns>A read-only collection of culture names.</returns>
	/// <example>
	/// Here is how you can use the <see cref="GetCultureNames" /> method:
	/// <code>
	/// var cultureNames = App.GetCultureNames(CultureTypes.SpecificCultures);
	/// foreach(var name in cultureNames)
	/// {
	/// Console.WriteLine(name);
	/// }
	/// </code>
	/// This will print the names of all specific cultures.
	/// </example>
	[Pure]
	[Information(nameof(GetCultureNames), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static ReadOnlyCollection<string> GetCultureNames(CultureTypes cultureType = CultureTypes.AllCultures)
	{
		return _cultureNames ??= CultureInfo.GetCultures(cultureType).OrderBy(p => p.Name).Select(c => c.Name).ToList().AsReadOnly();
	}

	/// <summary>
	/// Retrieves all environment variables as an immutable dictionary with string keys and values.
	/// </summary>
	/// <remarks>
	/// This method enumerates all environment variables available to the current process,
	/// filters out any entries with null keys or values, and returns the result as an
	/// <see cref="IReadOnlyDictionary{TKey, TValue}"/> of <see cref="string"/> keys and values.
	/// </remarks>
	/// <returns>
	/// An <see cref="IReadOnlyDictionary{TKey, TValue}"/> containing all environment variables,
	/// where each key and value is a non-null string. If a key or value is null, it is replaced with an empty string.
	/// </returns>
	[Pure]
	[Information(UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static IReadOnlyDictionary<string, string> GetEnvironmentVariables()
	{
		return Environment.GetEnvironmentVariables()
					.Cast<DictionaryEntry>()
					.Where(de => de.Key is not null && de.Value is not null) // Filter out null keys and values
					.ToImmutableDictionary(
						de => de.Key?.ToString() ?? string.Empty, // Safely handle null keys
						de => de.Value?.ToString() ?? string.Empty // Safely handle null values
					);
	}

	/// <summary>
	/// Retrieves a localized string from the specified resource manager.
	/// </summary>
	/// <param name="resourceManager">
	/// The <see cref="ResourceManager"/> instance to use for retrieving the localized string.
	/// </param>
	/// <param name="key">
	/// The key of the localized string. Must not be <c>null</c> or empty.
	/// </param>
	/// <param name="cultureName">
	/// The name of the culture to use. If <c>null</c> or empty, the current UI culture is used.
	/// </param>
	/// <returns>
	/// The localized string associated with the specified key and culture, or an empty string if the key is not found.
	/// </returns>
	/// <exception cref="ArgumentNullException">
	/// Thrown if <paramref name="resourceManager"/> or <paramref name="key"/> is <c>null</c> or empty.
	/// </exception>
	/// <example>
	/// Example usage:
	/// <code>
	/// var resourceManager = new ResourceManager("MyNamespace.MyResources", typeof(MyClass).Assembly);
	/// var localizedString = App.GetLocalizedString(resourceManager, "WelcomeMessage", "fr-FR");
	/// Console.WriteLine(localizedString);
	/// </code>
	/// This will retrieve the localized string for the key "WelcomeMessage" in French from the specified resource manager.
	/// </example>
	[Pure]
	[Information(nameof(GetLocalizedString), UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public static string GetLocalizedString(ResourceManager resourceManager, [DisallowNull] string key, string cultureName)
	{
		key = key.ArgumentNotNullOrEmpty();
		resourceManager = resourceManager.ArgumentNotNull();

		return resourceManager.GetString(key, string.IsNullOrEmpty(cultureName) ? CurrentUICulture : new CultureInfo(cultureName)) ?? string.Empty;
	}

	/// <summary>
	/// Retrieves detailed information about the processor.
	/// </summary>
	/// <returns>A <see cref="ProcessorInformation" /> object containing various details about the processor such as architecture, speed, and core count.</returns>
	/// <example>
	/// Example output:<br />
	/// ActiveProcessorMask: 0x0000000000000fff
	/// AllocationGranularity: 65536
	/// MaximumApplicationAddress: 0x00007ffffffeffff
	/// MinimumApplicationAddress: 0x0000000000010000
	/// NumberOfProcessors: 12
	/// PageSize: 4096
	/// ProcessorArchitecture: X86
	/// ProcessorLevel: 6
	/// ProcessorRevision: 42243
	/// </example>
	/// <remarks>This method utilizes system-specific calls to gather comprehensive details about the processor. It's designed to work across different platforms, providing a unified interface for accessing processor information.</remarks>
	[Pure]
	[Information(nameof(GetProcessorInformation), "David McCarter", "3/20/2023", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static ProcessorInformation GetProcessorInformation()
	{
		var info = new SystemInfo();

		GetSystemInfoDllImport(ref info);

		//Convert data
		return new ProcessorInformation()
		{
			PageSize = (int)info._dwPageSize,
			MinimumApplicationAddress = info._lpMinimumApplicationAddress,
			MaximumApplicationAddress = info._lpMaximumApplicationAddress,
			ActiveProcessorMask = info._dwActiveProcessorMask,
			NumberOfProcessors = (int)info._dwNumberOfProcessors,
			ProcessorArchitecture = ConvertProcessorArchitecture((int)info._dwProcessorType),
			AllocationGranularity = (int)info._dwAllocationGranularity,
			ProcessorLevel = info._wProcessorLevel,
			ProcessorRevision = info._wProcessorRevision
		};
	}

	/// <summary>
	/// Checks if the current application is already running.
	/// </summary>
	/// <returns><c>true</c> if the application is already running; otherwise, <c>false</c>.</returns>
	/// <remarks>This method checks if there are any processes with the same name as the current process. If more than one is found, it indicates that the application is already running.</remarks>
	[Pure]
	[Information(UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static bool IsRunning()
	{
		return Process.GetProcessesByName(ProcessName).Count() > 0;
	}

	/// <summary>
	/// Checks to see if the current application is running from an ASP.NET context.
	/// </summary>
	/// <returns><c>true</c> if the application is running from an ASP.NET context; otherwise, <c>false</c>.</returns>
	/// <remarks>This method determines if the application is running within an ASP.NET context by checking the presence of ASP.NET temporary files in the application's dynamic directory.</remarks>
	[Pure]
	[Information(UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static bool IsRunningFromAspNet()
	{
		return (!string.IsNullOrEmpty(AppDomain.CurrentDomain.DynamicDirectory)) && AppDomain.CurrentDomain.DynamicDirectory.Contains(TempAspFiles, StringComparison.OrdinalIgnoreCase);
	}

	/// <summary>
	/// Determines whether the current user is an administrator.
	/// </summary>
	/// <returns><c>true</c> if the current user is an administrator; otherwise, <c>false</c>.</returns>
	/// <exception cref="PlatformNotSupportedException">Thrown when the operating system is not Windows, as administrator status can only be checked on Windows.</exception>
	[Pure]
	[Information(UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static bool IsUserAdministrator()
	{
		return !RuntimeInformation.IsOSPlatform(OSPlatform.Windows)
					? throw new PlatformNotSupportedException()
					: new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
	}

	/// <summary>
	/// Terminates the current process instantly, useful in critical failure scenarios.
	/// </summary>
	/// <remarks>This method retrieves the name of the process that started the currently executing application,
	/// removes the file extension to get the process name, and then calls <see cref="KillProcess" />
	/// with that name to terminate the process.</remarks>
	[Information(Status = Status.Available)]
	public static void Kill()
	{
		KillProcess(Path.GetFileNameWithoutExtension(AppContext.BaseDirectory));
	}

	/// <summary>
	/// Calculates the maximum number of tasks that can run concurrently, based on the system’s processor count.
	/// </summary>
	/// <returns>The maximum degree of parallelism.</returns>
	/// <remarks>This method calculates the maximum degree of parallelism by taking 75% of the processor count, doubling it, and rounding up to the nearest whole number.
	/// It is designed to optimize parallel operations by not overloading the system with too many concurrent tasks.</remarks>
	[Pure]
	[Information(nameof(MaxDegreeOfParallelism), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static int MaxDegreeOfParallelism()
	{
		return Convert.ToInt32(Math.Ceiling(_computerInfo.Value.ProcessorCount * 0.75 * 2.0));
	}

	/// <summary>
	/// Reboots the system programmatically.
	/// </summary>
	/// <exception cref="PlatformNotSupportedException">Thrown when the operating system is not supported.</exception>
	[Information(Status = Status.Available)]
	public static void RebootComputer()
	{
		if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
		{
			throw new PlatformNotSupportedException(Resources.RebootingIsOnlySupportedOnWindows);
		}

		var psi = new ProcessStartInfo("shutdown", "/r /t 0")
		{
			CreateNoWindow = true,
			UseShellExecute = false
		};

		_ = Process.Start(psi);
	}

	/// <summary>
	/// Loads a list of all assemblies referenced by the running application, aiding in diagnostics or reflective operations.
	/// </summary>
	/// <returns>A read-only collection of strings representing the full names of all assemblies referenced by the running assembly.</returns>
	/// <example>Example usage:
	/// <code>
	/// var referencedAssemblies = App.ReferencedAssemblies();
	/// foreach(var assembly in referencedAssemblies)
	/// {
	/// Console.WriteLine(assembly);
	/// }
	/// </code></example>
	[Pure]
	[Information(UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static ReadOnlyCollection<string> ReferencedAssemblies()
	{
		var entryAssembly = Assembly.GetEntryAssembly();
		return entryAssembly == null
			? throw new InvalidOperationException(Resources.EntryAssemblyIsNullUnableToRetrieveReferen)
			: entryAssembly.GetReferencedAssemblies()
							.Select(a => a.ToString())
							.ToList()
							.AsReadOnly();
	}

	/// <summary>
	/// Restarts the application with elevated administrative privileges, if required by the task at hand.
	/// </summary>
	/// <remarks>If the current user is not an administrator, this method will attempt to restart the application with administrator privileges.
	/// It prompts the user for permission to run as an administrator. If granted, the application restarts; otherwise, it exits.
	/// This method should be used cautiously, as it terminates the current process and starts a new one.</remarks>
	[Information(Status = Status.Available)]
	public static void RunAsAdministrator()
	{
		if (IsUserAdministrator())
		{
			return;
		}

		var processInfo = new ProcessStartInfo
		{
			FileName = _computerInfo.Value.CurrentWorkingDirectory,
			UseShellExecute = true,
			Verb = "runas",
		};

		_ = Process.Start(processInfo);

		Environment.ExitCode = 0;
		Environment.Exit(0);
	}

	/// <summary>
	/// Sets or updates a value in the application state dictionary in a thread-safe manner.
	/// </summary>
	/// <param name="key">The case-insensitive key to identify the state value. Must not be <c>null</c> or empty.</param>
	/// <param name="value">The value to store in the application state. Must not be <c>null</c>.</param>
	/// <remarks>
	/// This method stores or updates a value in the thread-safe application state dictionary using the specified key.
	/// If the key already exists, its value is replaced; otherwise, a new key-value pair is added.
	/// <para>
	/// <strong>Thread Safety:</strong>
	/// This method is thread-safe and can be called concurrently from multiple threads without additional locking.
	/// The underlying <see cref="ConcurrentDictionary{TKey,TValue}"/> handles all necessary synchronization internally.
	/// The indexer operation is atomic - the key-value pair is added or updated as a single operation.
	/// </para>
	/// <para>
	/// <strong>Key Comparison:</strong>
	/// The application state dictionary uses case-insensitive string comparison (<see cref="StringComparer.OrdinalIgnoreCase"/>),
	/// meaning "Theme", "theme", and "THEME" are treated as the same key and will overwrite each other.
	/// </para>
	/// <para>
	/// <strong>Performance Characteristics:</strong>
	/// <list type="bullet">
	/// <item><description>Time Complexity: O(1) average case for hash-based insertion/update</description></item>
	/// <item><description>Atomic operation - no race conditions when multiple threads update the same key</description></item>
	/// <item><description>May cause dictionary resizing if capacity is exceeded (infrequent, amortized O(1))</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Null Handling:</strong>
	/// Both <paramref name="key"/> and <paramref name="value"/> are validated to be non-null before the operation.
	/// Storing null values is not permitted to maintain data integrity and prevent unexpected null reference exceptions
	/// when retrieving values with <see cref="GetAppState(string)"/>.
	/// </para>
	/// </remarks>
	/// <example>
	/// Example usage:
	/// <code>
	/// // Store a string value
	/// App.SetAppState("Theme", "Dark");
	/// 
	/// // Store an integer value
	/// App.SetAppState("MaxRetries", 5);
	/// 
	/// // Store a complex object
	/// var config = new AppConfiguration { Timeout = 30, EnableLogging = true };
	/// App.SetAppState("Config", config);
	/// 
	/// // Update an existing value (case-insensitive key)
	/// App.SetAppState("THEME", "Light"); // Overwrites the "Theme" key
	/// 
	/// // Thread-safe concurrent updates
	/// Parallel.For(0, 100, i =>
	/// {
	///     App.SetAppState($"Item{i}", i * 10);
	/// });
	/// </code>
	/// </example>
	/// <exception cref="ArgumentNullException">
	/// Thrown when <paramref name="key"/> is <c>null</c> or empty, or when <paramref name="value"/> is <c>null</c>.
	/// </exception>
	/// <seealso cref="GetAppState(string)"/>
	[Information(nameof(SetAppState), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.New)]
	public static void SetAppState([DisallowNull] string key, [DisallowNull] object value)
	{
		key = key.ArgumentNotNullOrEmpty();
		value = value.ArgumentNotNull();

		_appState[key] = value;
	}

	/// <summary>
	/// Gets the application information.
	/// </summary>
	/// <value>The application information, including company, configuration, copyright, description, file version, memory allocated, memory info, product, thread allocated bytes, _title, total allocated bytes, and version.</value>
	/// <example>Example usage:
	/// <code>
	/// var appInfo = App.AppInfo;
	/// Console.WriteLine($"Company: {appInfo.Company}");
	/// </code>
	/// This will output the company name from the application's assembly information.
	/// </example>
	[Pure]
	[Information(nameof(AppInfo), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static AppInfo AppInfo
	{
		get
		{
			return _appInfo.Value;
		}
	}

	/// <summary>
	/// Gets the current culture of the application.
	/// </summary>
	/// <value>The current culture.</value>
	/// <remarks>This property provides access to the current culture used by the application. It is a wrapper around <see cref="CultureInfo.CurrentCulture" />.</remarks>
	[Pure]
	[Information(UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static CultureInfo CurrentCulture
	{
		get
		{
			return CultureInfo.CurrentCulture;
		}
	}

	/// <summary>
	/// Gets a unique identifier for the current managed thread.
	/// </summary>
	/// <value>The current thread identifier.</value>
	/// <remarks>This property provides the unique identifier of the currently executing thread. It is useful for logging, debugging, or tracking thread-specific operations.</remarks>
	[Pure]
	[Information(nameof(CurrentThreadId), "David McCarter", "1/20/2024", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, Status = Status.Available)]
	public static int CurrentThreadId
	{
		get
		{
			return _computerInfo.Value.CurrentManagedThreadId;
		}
	}

	/// <summary>
	/// Retrieves the current UI culture used by the application for localization.
	/// </summary>
	/// <value>The current UI culture.</value>
	/// <remarks>This property provides access to the current UI culture used by the application. It is a wrapper around <see cref="CultureInfo.CurrentUICulture" />.
	/// The UI culture is used for string localization, date and number formatting, and other culture-specific operations in the UI.</remarks>
	[Pure]
	[Information(UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static CultureInfo CurrentUICulture
	{
		get
		{
			return CultureInfo.CurrentUICulture;
		}
	}

	/// <summary>
	/// Provides a string describing the .NET installation running the application, useful for ensuring compatibility.
	/// </summary>
	/// <value>The framework description.</value>
	/// <example>Example output: ".NET 5.0.6"</example>
	[Pure]
	[Information(UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static string FrameworkDescription
	{
		get
		{
			return RuntimeInformation.FrameworkDescription;
		}
	}

	/// <summary>
	/// Returns the default UI culture installed on the system.
	/// </summary>
	/// <value>The installed UI culture.</value>
	[Pure]
	[Information(UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static CultureInfo InstalledUICulture
	{
		get
		{
			return CultureInfo.InstalledUICulture;
		}
	}

	/// <summary>
	/// Describes the architecture (e.g., x86, x64) of the operating system hosting the application.
	/// </summary>
	/// <value>The operating system platform.</value>
	[Pure]
	[Information(UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static Architecture OSArchitecture
	{
		get
		{
			return RuntimeInformation.OSArchitecture;
		}
	}

	/// <summary>
	/// Gets a string that describes the operating system on which the app is running.
	/// </summary>
	/// <value>The operating system description.</value>
	[Pure]
	[Information(UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static string OSDescription
	{
		get
		{
			return RuntimeInformation.OSDescription;
		}
	}

	/// <summary>
	/// Gets the process architecture of the currently running app.
	/// </summary>
	/// <value>The process architecture.</value>
	[Pure]
	[Information(UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static Architecture ProcessArchitecture
	{
		get
		{
			return RuntimeInformation.ProcessArchitecture;
		}
	}

	/// <summary>
	/// Provides the unique identifier for the current process, useful for diagnostics and logging.
	/// </summary>
	/// <value>The process identifier.</value>
	/// <example>Example usage:
	/// <code>
	/// var processId = App.ProcessId;
	/// Console.WriteLine(processId);
	/// </code>
	/// This will output the unique identifier of the current process.
	/// </example>
	[Pure]
	[Information(UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static int ProcessId
	{
		get
		{
			return Environment.ProcessId;
		}
	}

	/// <summary>
	/// The name of the process currently running, aiding in identification and tracking.
	/// </summary>
	/// <value>The name of the process.</value>
	/// <example>Example usage:
	/// <code>
	/// var processName = App.ProcessName;
	/// Console.WriteLine(processName);
	/// </code>
	/// This will output the name of the current process.
	/// </example>
	[Pure]
	[Information(nameof(ProcessName), "David McCarter", "7/26/2024", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static string ProcessName
	{
		get
		{
			return Process.GetCurrentProcess().ProcessName;
		}
	}

	/// <summary>
	/// Returns the path of the executable that started the currently executing process. Returns null when the path is not available.
	/// </summary>
	/// <value>The process path.</value>
	[Pure]
	[Information(nameof(GetProcessorInformation), "David McCarter", "1/20/2024", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static string ProcessPath
	{
		get
		{
			return _computerInfo.Value.CurrentWorkingDirectory;
		}
	}

	/// <summary>
	/// Gets the stack trace for the current thread.
	/// </summary>
	/// <value>A string that describes the stack trace for the current thread.</value>
	/// <remarks>
	/// This property provides a string representation of the stack trace, which can be useful for debugging purposes.
	/// It includes the sequence of method calls that led to the current point of execution.
	/// </remarks>
	[Pure]
	[Information(UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static string StackTrace
	{
		get
		{
			return Environment.StackTrace;
		}
	}

	/// <summary>
	/// Gets the working set of the current process.
	/// </summary>
	/// <value>The amount of physical memory mapped to the process context.</value>
	/// <remarks>
	/// This property provides the size of the working set, which is the set of memory pages currently visible to the process in physical RAM.
	/// It includes both shared and private data, such as the pages containing all the instructions that the process executes, as well as the pages containing the process's data.
	/// </remarks>
	[Pure]
	[Information(UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static long WorkingSet
	{
		get
		{
			return Environment.WorkingSet;
		}
	}
}
