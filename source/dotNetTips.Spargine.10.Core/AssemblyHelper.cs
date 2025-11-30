// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 04-09-2025
//
// Last Modified By : David McCarter
// Last Modified On : 09-06-2025
// ***********************************************************************
// <copyright file="AssemblyHelper.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Reflection;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Runtime.Loader;
using DotNetTips.Spargine.Core.Properties;
using DotNetTips.Spargine.Core.RegularExpressions;
using Microsoft.Extensions.Caching.Memory;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Provides static helper methods for working with assemblies.
/// </summary>
[Information(Status = Status.Available, Documentation = "https://bit.ly/SpargineAssemblyHelper")]
public static class AssemblyHelper
{
	private static readonly MemoryCache _assemblyTypeCache = new(new MemoryCacheOptions());

	/// <summary>
	/// Finds the root folder of the .NET installation.
	/// </summary>
	/// <remarks>
	/// This method first checks the <c>DOTNET_ROOT</c> environment variable. If it is not set or is empty,
	/// it falls back to the default installation path for the current operating system:
	/// <list type="bullet">
	/// <item><description>Windows: <c>C:\Program Files\dotnet</c></description></item>
	/// <item><description>macOS/Linux: <c>/usr/local/share/dotnet</c></description></item>
	/// </list>
	/// </remarks>
	/// <returns>
	/// The path to the .NET root folder as a <see cref="string"/>.
	/// </returns>
	private static string FindDotNetRootFolder()
	{
		var root = Environment.GetEnvironmentVariable("DOTNET_ROOT");

		if (string.IsNullOrEmpty(root))
		{
			root = Environment.OSVersion.Platform == PlatformID.Win32NT
				? @"C:\Program Files\dotnet"
				: "/usr/local/share/dotnet";
		}

		return root;
	}

	/// <summary>
	/// Determines whether the provided stream represents a .NET assembly.
	/// </summary>
	/// <param name="stream">The stream to analyze.</param>
	/// <returns><c>true</c> if the stream represents a .NET assembly; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsDotNetAssembly), author: "David McCarter", createdOn: "5/20/2024", OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
	private static bool IsDotNetAssembly(in Stream stream)
	{
		try
		{
			using var peReader = new PEReader(stream);

			if (!peReader.HasMetadata)
			{
				return false;
			}

			// If peReader.PEHeaders doesn't throw, it is a valid PEImage
			return peReader.PEHeaders.CorHeader != null && peReader.GetMetadataReader().IsAssembly;
		}
		catch (BadImageFormatException)
		{
			return false;
		}
		catch (IOException ex)
		{
			Trace.WriteLine(ex);
			return false;
		}
		catch (UnauthorizedAccessException ex)
		{
			Trace.WriteLine(ex);
			return false;
		}
	}

	/// <summary>
	/// Safely parses a version string, falling back to <c>Version(0,0)</c> if parsing fails.
	/// </summary>
	/// <param name="input">The version string to parse.</param>
	/// <returns>A <see cref="Version"/> object representing the parsed version, or <c>Version(0,0)</c> if parsing fails.</returns>
	/// <remarks>
	/// This method attempts to parse the input string as a version. If the parsing fails, it tries to extract a version-like pattern
	/// using a regular expression and parses that. If all attempts fail, it returns <c>Version(0,0)</c>.
	/// </remarks>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="input"/> is null.</exception>
	private static Version VersionParseSafe(string input)
	{
		if (Version.TryParse(input, out var version))
		{
			return version;
		}

		// Try to extract version from things like "1.2.3-preview" or similar
		var extractedVersion = RegexProcessor.ExtractVersion(input);

		return string.IsNullOrEmpty(extractedVersion) is false ? Version.Parse(extractedVersion) : new Version(0, 0);
	}

	/// <summary>
	/// Checks if the specified assembly references another assembly by name.
	/// </summary>
	/// <param name="assemblyFile">The <see cref="FileInfo"/> representing the assembly file.</param>
	/// <param name="referencedAssemblyName">The name of the referenced assembly.</param>
	/// <returns><c>true</c> if the assembly references the specified assembly; otherwise, <c>false</c>.</returns>
	[Pure]
	[Information(nameof(DoesAssemblyReference), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static bool DoesAssemblyReference([DisallowNull] FileInfo assemblyFile, [DisallowNull] string referencedAssemblyName)
	{
		assemblyFile = assemblyFile.ArgumentExists(assemblyFile);
		referencedAssemblyName = referencedAssemblyName.ArgumentNotNull();

		// Ensure the file is a valid .NET assembly before loading
		if (!IsDotNetAssembly(assemblyFile))
		{
			Trace.WriteLine($"The file '{assemblyFile.FullName}' is not a valid .NET assembly.");
			return false;
		}

		try
		{
			var assembly = Assembly.LoadFrom(assemblyFile.FullName);
			return assembly.GetReferencedAssemblies()
				.Any(reference => string.Equals(reference.Name, referencedAssemblyName, StringComparison.OrdinalIgnoreCase));
		}
		catch (Exception ex) //Write out all exceptions
		{
			Trace.WriteLine($"Error checking assembly references: {ex.Message}");
			return false;
		}
	}

	/// <summary>
	/// Checks if the specified type exists in the assembly.
	/// </summary>
	/// <param name="assemblyFile">The <see cref="FileInfo"/> representing the assembly file.</param>
	/// <param name="typeName">The fully qualified name of the type to check.</param>
	/// <returns><c>true</c> if the type exists; otherwise, <c>false</c>.</returns>
	[Pure]
	[Information(nameof(DoesTypeExistInAssembly), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static bool DoesTypeExistInAssembly([DisallowNull] FileInfo assemblyFile, [DisallowNull] string typeName)
	{
		assemblyFile = assemblyFile.ArgumentExists(assemblyFile);
		typeName = typeName.ArgumentNotNull();

		// Ensure the file is a valid .NET assembly before loading
		if (!IsDotNetAssembly(assemblyFile))
		{
			Trace.WriteLine($"The file '{assemblyFile.FullName}' is not a valid .NET assembly.");
			return false;
		}

		try
		{
			var assembly = Assembly.LoadFrom(assemblyFile.FullName);
			return assembly.GetTypes().Any(type => string.Equals(type.FullName, typeName, StringComparison.Ordinal));
		}
		catch (ReflectionTypeLoadException ex)
		{
			// Handle partial type loading and check loaded assemblyTypes
			Trace.WriteLine($"Error loading types from assembly '{assemblyFile.FullName}': {ex.Message}");
			return ex.Types
				.Where(type => type != null)
				.Any(type => string.Equals(type!.FullName, typeName, StringComparison.Ordinal));
		}
		catch (Exception ex) //Write out all exceptions
		{
			Trace.WriteLine($"Error checking type existence in assembly '{assemblyFile.FullName}': {ex.Message}");
			return false;
		}
	}

	/// <summary>
	/// Finds all assembly files in the specified directory.
	/// </summary>
	/// <param name="directory">The directory to search for assemblies.</param>
	/// <returns>A read-only collection of <see cref="FileInfo"/> objects representing the assembly files found.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="directory"/> is null.</exception>
	/// <exception cref="DirectoryNotFoundException">Thrown if the specified directory does not exist.</exception>
	[Pure]
	[Information(nameof(FindAssembliesFromDirectory), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static ReadOnlyCollection<FileInfo> FindAssembliesFromDirectory([DisallowNull] DirectoryInfo directory)
	{
		directory = directory.ArgumentExists(directory);

		try
		{
			var assemblyFiles = directory.GetFiles("*.dll")
				.Concat(directory.GetFiles("*.exe"))
				.Where(IsDotNetAssembly) // Ensure the file is a valid .NET assembly
				.ToList(); // Materialize the result to avoid deferred execution issues

			return assemblyFiles.AsReadOnly();
		}
		catch (Exception ex) //Write out all exceptions
		{
			Trace.WriteLine($"Error finding assemblies in directory '{directory.FullName}': {ex.Message}");
			return new ReadOnlyCollection<FileInfo>(Array.Empty<FileInfo>());
		}
	}

	/// <summary>
	/// Finds all types in the specified assembly file that implement or inherit from any of the specified types.
	/// </summary>
	/// <param name="file">The <see cref="FileInfo"/> representing the assembly file to search.</param>
	/// <param name="types">An array of <see cref="Type"/> objects to check for implementation or inheritance.</param>
	/// <returns>A read-only collection of <see cref="Type"/> objects that implement or inherit from the specified types.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="file"/> or <paramref name="types"/> is null.</exception>
	/// <exception cref="FileNotFoundException">Thrown if the specified assembly file does not exist.</exception>
	[Pure]
	[Information(nameof(FindTypesImplementing), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Updated)]
	public static ReadOnlyCollection<Type> FindTypesImplementing([DisallowNull] this FileInfo file, [DisallowNull] params ReadOnlyCollection<Type> types)
	{
		file = file.ArgumentNotNull();
		types = types.ArgumentNotNull();

		//Load all assemblyTypes
		var assemblyTypes = GetAssemblyTypes(file);

		var matchingTypes = assemblyTypes
			  .Where(type => types.Any(targetType => targetType.IsAssignableFrom(type) && type != targetType))
			  .ToList();

		return matchingTypes.AsReadOnly();
	}

	/// <summary>
	/// Retrieves custom attributes applied to the specified assembly.
	/// </summary>
	/// <param name="assemblyFile">The <see cref="FileInfo"/> representing the assembly file.</param>
	/// <returns>A read-only collection of custom attributes.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="assemblyFile"/> is null.</exception>
	/// <exception cref="FileNotFoundException">Thrown if the specified assembly file does not exist.</exception>
	/// <exception cref="FileLoadException">Thrown if an assembly cannot be loaded.</exception>
	[Pure]
	[Information(nameof(GetAssemblyCustomAttributes), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static ReadOnlyCollection<Attribute> GetAssemblyCustomAttributes([DisallowNull] FileInfo assemblyFile)
	{
		assemblyFile = assemblyFile.ArgumentExists(assemblyFile);

		// Ensure the file is a valid .NET assembly before loading
		if (!IsDotNetAssembly(assemblyFile))
		{
			Trace.WriteLine($"The file '{assemblyFile.FullName}' is not a valid .NET assembly.");
			return Array.Empty<Attribute>().AsReadOnly();
		}

		try
		{
			var assembly = Assembly.LoadFrom(assemblyFile.FullName);
			var attributes = assembly.GetCustomAttributes().ToList();

			return attributes.AsReadOnly();
		}
		catch (Exception ex) //Write out all exceptions
		{
			Trace.WriteLine($"Error retrieving custom attributes from assembly '{assemblyFile.FullName}': {ex.Message}");
			return Array.Empty<Attribute>().AsReadOnly();
		}
	}

	/// <summary>
	/// Gets the entry point method of the specified assembly.
	/// </summary>
	/// <param name="assemblyFile">The <see cref="FileInfo"/> representing the assembly file.</param>
	/// <returns>The entry point <see cref="MethodInfo"/>, or <c>null</c> if none exists.</returns>
	[Pure]
	[Information(nameof(GetAssemblyEntryPoint), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static MethodInfo? GetAssemblyEntryPoint([DisallowNull] FileInfo assemblyFile)
	{
		assemblyFile = assemblyFile.ArgumentExists(assemblyFile);

		// Ensure the file is a valid .NET assembly before loading
		if (!IsDotNetAssembly(assemblyFile))
		{
			Trace.WriteLine($"The file '{assemblyFile.FullName}' is not a valid .NET assembly.");
			return null;
		}

		try
		{
			var assembly = Assembly.LoadFrom(assemblyFile.FullName);

			return assembly.EntryPoint;
		}
		catch (Exception ex) //Write out all exceptions
		{
			Trace.WriteLine($"Error retrieving entry point from assembly '{assemblyFile.FullName}': {ex.Message}");

			return null;
		}
	}

	/// <summary>
	/// Retrieves metadata information from the specified assembly.
	/// </summary>
	/// <param name="assemblyFile">The <see cref="FileInfo"/> representing the assembly file.</param>
	/// <returns>A read-only collection containing metadata key-value pairs.</returns>
	[Pure]
	[Information(nameof(GetAssemblyMetadata), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static ReadOnlyCollection<KeyValuePair<string, string>> GetAssemblyMetadata([DisallowNull] FileInfo assemblyFile)
	{
		assemblyFile = assemblyFile.ArgumentExists(assemblyFile);

		// Ensure the file is a valid .NET assembly before loading
		if (!IsDotNetAssembly(assemblyFile))
		{
			Trace.WriteLine($"The file '{assemblyFile.FullName}' is not a valid .NET assembly.");

			return new ReadOnlyCollection<KeyValuePair<string, string>>([new("Error", "Invalid .NET assembly")]);
		}

		try
		{
			var assembly = Assembly.LoadFrom(assemblyFile.FullName);
			var assemblyName = assembly.GetName();

			return new ReadOnlyCollection<KeyValuePair<string, string>>(
				[
				new("Name", assemblyName.Name ?? string.Empty),
				new("Version", assemblyName.Version?.ToString() ?? "Unknown"),
				new("Culture", string.IsNullOrWhiteSpace(assemblyName.CultureInfo?.Name) ? "Neutral" : assemblyName.CultureInfo.Name),
				new("FullName", assembly.FullName ?? string.Empty)
				]);
		}
		catch (Exception ex) //Write out all exceptions
		{
			Trace.WriteLine($"Error retrieving metadata from assembly '{assemblyFile.FullName}': {ex.Message}");
			return new ReadOnlyCollection<KeyValuePair<string, string>>(Array.Empty<KeyValuePair<string, string>>());
		}
	}

	/// <summary>
	/// Retrieves all public assemblyTypes from the specified assembly.
	/// </summary>
	/// <param name="assemblyFile">The <see cref="FileInfo"/> representing the assembly file.</param>
	/// <returns>A read-only collection of public <see cref="Type"/> objects.</returns>
	[Pure]
	[Information(nameof(GetAssemblyPublicTypes), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static ReadOnlyCollection<Type> GetAssemblyPublicTypes([DisallowNull] FileInfo assemblyFile)
	{
		assemblyFile = assemblyFile.ArgumentExists(assemblyFile);

		// Ensure the file is a valid .NET assembly before loading
		if (!IsDotNetAssembly(assemblyFile))
		{
			Trace.WriteLine($"The file '{assemblyFile.FullName}' is not a valid .NET assembly.");
			return new ReadOnlyCollection<Type>(Array.Empty<Type>());
		}

		try
		{
			var assembly = Assembly.LoadFrom(assemblyFile.FullName);
			var publicTypes = assembly.GetTypes().Where(type => type.IsPublic).ToList();

			return publicTypes.AsReadOnly();
		}
		catch (ReflectionTypeLoadException ex)
		{
			// Handle partial type loading and return only successfully loaded public assemblyTypes
			Trace.WriteLine($"Error loading types from assembly '{assemblyFile.FullName}': {ex.Message}");
			var publicTypes = ex.Types
				.Where(type => type != null && type.IsPublic)
				.Select(type => type!)
				.ToList();

			return publicTypes.AsReadOnly();
		}
		catch (Exception ex)
		{
			Trace.WriteLine($"Error retrieving public types from assembly '{assemblyFile.FullName}': {ex.Message}");
			return new ReadOnlyCollection<Type>(Array.Empty<Type>());
		}
	}

	/// <summary>
	/// Loads the assembly from the specified file and extracts all assemblyTypes within it.
	/// </summary>
	/// <param name="assemblyFile">The <see cref="FileInfo"/> representing the assembly file to load.</param>
	/// <returns>A collection of <see cref="Type"/> objects representing all assemblyTypes in the assembly.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="assemblyFile"/> is null.</exception>
	[Pure]
	[Information(nameof(GetAssemblyTypes), "David McCarter", "4/9/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<Type> GetAssemblyTypes([DisallowNull] FileInfo assemblyFile)
	{
		assemblyFile = assemblyFile.ArgumentExists(assemblyFile);

		if (!_assemblyTypeCache.TryGetValue(assemblyFile.FullName, out ReadOnlyCollection<Type>? cachedTypes))
		{
			try
			{
				var assembly = Assembly.LoadFrom(assemblyFile.FullName);
				var types = assembly.GetTypes().ToList().AsReadOnly();

				// Add to cache with a sliding expiration of 30 minutes
				_ = _assemblyTypeCache.Set(assemblyFile.FullName, types, new MemoryCacheEntryOptions
				{
					SlidingExpiration = TimeSpan.FromMinutes(30)
				});

				return types;
			}
			catch (Exception ex) //Write out all exceptions
			{
				Trace.WriteLine($"Error loading assembly types: {ex.Message}");
				return new ReadOnlyCollection<Type>(Array.Empty<Type>());
			}
		}

		return cachedTypes!;
	}

	/// <summary>
	/// Retrieves all assemblies that the specified assembly depends on.
	/// </summary>
	/// <param name="assemblyFile">The <see cref="FileInfo"/> representing the assembly file.</param>
	/// <returns>A read-only collection of dependent assemblies.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="assemblyFile"/> is null.</exception>
	/// <exception cref="FileNotFoundException">Thrown if the specified assembly file does not exist.</exception>
	/// <exception cref="FileLoadException">Thrown if an assembly cannot be loaded.</exception>
	[Pure]
	[Information(nameof(GetDependentAssemblies), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static ReadOnlyCollection<AssemblyName> GetDependentAssemblies([DisallowNull] FileInfo assemblyFile)
	{
		assemblyFile = assemblyFile.ArgumentExists(assemblyFile);

		// Ensure the file is a valid .NET assembly before loading
		if (!IsDotNetAssembly(assemblyFile))
		{
			Trace.WriteLine($"The file '{assemblyFile.FullName}' is not a valid .NET assembly.");
			return new ReadOnlyCollection<AssemblyName>(Array.Empty<AssemblyName>());
		}

#pragma warning disable CA1031 // Do not catch general exception assemblyTypes
		try
		{
			var assembly = Assembly.LoadFrom(assemblyFile.FullName);
			var dependentAssemblies = assembly.GetReferencedAssemblies().ToList();

			return dependentAssemblies.AsReadOnly();
		}
		catch (Exception ex) //Write out all exceptions
		{
			Trace.WriteLine($"Error retrieving dependent assemblies from '{assemblyFile.FullName}': {ex.Message}");
			return new ReadOnlyCollection<AssemblyName>(Array.Empty<AssemblyName>());
		}
#pragma warning restore CA1031 // Do not catch general exception assemblyTypes
	}

	/// <summary>
	/// Retrieves all methods in the specified type within an assembly.
	/// </summary>
	/// <param name="assemblyFile">The <see cref="FileInfo"/> representing the assembly file.</param>
	/// <param name="typeName">The fully qualified name of the type.</param>
	/// <returns>A read-only collection of <see cref="MethodInfo"/> objects.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="assemblyFile"/> or <paramref name="typeName"/> is null.</exception>
	/// <exception cref="FileNotFoundException">Thrown if the specified assembly file does not exist.</exception>
	/// <exception cref="TypeLoadException">Thrown if the specified type cannot be loaded from the assembly.</exception>
	[Pure]
	[Information(nameof(GetMethodsInType), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static ReadOnlyCollection<MethodInfo> GetMethodsInType([DisallowNull] FileInfo assemblyFile, [DisallowNull] string typeName)
	{
		assemblyFile = assemblyFile.ArgumentExists(assemblyFile);
		typeName = typeName.ArgumentNotNull();

		// Ensure the file is a valid .NET assembly before loading
		if (!IsDotNetAssembly(assemblyFile))
		{
			Trace.WriteLine($"The file '{assemblyFile.FullName}' is not a valid .NET assembly.");
			return new ReadOnlyCollection<MethodInfo>(Array.Empty<MethodInfo>());
		}

		try
		{
			var assembly = Assembly.LoadFrom(assemblyFile.FullName);
			var type = assembly.GetType(typeName);

			if (type == null)
			{
				Trace.WriteLine($"Type '{typeName}' not found in assembly '{assemblyFile.FullName}'.");
				return new ReadOnlyCollection<MethodInfo>(Array.Empty<MethodInfo>());
			}

			var methods = type.GetMethods().ToList();

			return methods.AsReadOnly();
		}
		catch (Exception ex) //Write out all exceptions
		{
			Trace.WriteLine($"Error retrieving methods from type '{typeName}' in assembly '{assemblyFile.FullName}': {ex.Message}");
			return new ReadOnlyCollection<MethodInfo>(Array.Empty<MethodInfo>());
		}
	}

	/// <summary>
	/// Finds .NET SDK files in the specified version or the highest available version.
	/// </summary>
	/// <param name="version">The specific version to search for. If null, the highest version is used.</param>
	/// <returns>A <see cref="ReadOnlyCollection{FileInfo}"/> containing .NET SDK file information.</returns>
	/// <remarks>
	/// This method searches the .NET SDK packs directory for the specified version or the highest available version.
	/// It retrieves DLL files from the "ref" folder of the selected version and target framework.
	/// </remarks>
	/// <exception cref="DirectoryNotFoundException">Thrown if the .NET packs directory does not exist.</exception>
	[Pure]
	[Information(nameof(GetNetSdkDllFiles), "David McCarter", "4/9/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<FileInfo> GetNetSdkDllFiles(string? version = null)
	{
		var root = FindDotNetRootFolder();

		if (string.IsNullOrEmpty(root))
		{
			throw new System.IO.DirectoryNotFoundException(message: Resources.TheDOTNETROOTEnvironmentVariableIsNotSetOr);
		}

		var dotnetPacksPath = new DirectoryInfo(Path.Combine(root, "packs"));

		if (!dotnetPacksPath.Exists)
		{
			Trace.WriteLine("The .NET packs path does not exist.");
			return new ReadOnlyCollection<FileInfo>([]);
		}

		var dllFiles = dotnetPacksPath.GetDirectories()
			.AsParallel()
			.SelectMany(packDir =>
			{
				var versionDirs = packDir.GetDirectories()
					.Select(dir => dir.Name)
					.Where(name => !string.IsNullOrWhiteSpace(name))
					.OrderByDescending(VersionParseSafe)
					.ToList();

				var versionToUse = string.IsNullOrWhiteSpace(version) ? versionDirs.FirstOrDefault() : version;

				if (!string.IsNullOrWhiteSpace(versionToUse))
				{
					var refPath = new DirectoryInfo(Path.Combine(packDir.FullName, versionToUse, "ref"));

					if (refPath.Exists)
					{
						var targetFrameworks = refPath.GetDirectories()
							.OrderByDescending(dir => dir.Name)
							.FirstOrDefault();

						return targetFrameworks?.GetFiles("*.dll", SearchOption.AllDirectories)
							.Where(IsDotNetAssembly) ?? [];
					}
				}

				return [];
			})
			.ToList();

		return dllFiles.AsReadOnly();
	}

	/// <summary>
	/// Determines whether the specified file is a .NET assembly.
	/// </summary>
	/// <param name="file">The file to check.</param>
	/// <returns><c>true</c> if the file is a .NET assembly; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown when the file argument is null.</exception>
	/// <exception cref="FileNotFoundException">Thrown when the file does not exist.</exception>
	/// <exception cref="IOException">Thrown when an I/O error occurs.</exception>
	/// <exception cref="UnauthorizedAccessException">Thrown when access to the file is unauthorized.</exception>
	[Pure]
	[Information("Original code by GÉRALD BARRÉ", author: "David McCarter", createdOn: "5/20/2024", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2024")]
	public static bool IsDotNetAssembly([DisallowNull] FileInfo file)
	{
		file = file.ArgumentExists();

		using var stream = File.OpenRead(file.FullName);

		return IsDotNetAssembly(stream);
	}

	/// <summary>
	/// Unloads the specified assembly.
	/// </summary>
	/// <param name="assemblyFile">The <see cref="FileInfo"/> representing the assembly file.</param>
	[Information(nameof(UnloadAssembly), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static void UnloadAssembly([DisallowNull] FileInfo assemblyFile)
	{
		assemblyFile = assemblyFile.ArgumentExists(assemblyFile);

		// Ensure the file is a valid .NET assembly before attempting to unload
		if (!IsDotNetAssembly(assemblyFile))
		{
			Trace.WriteLine($"The file '{assemblyFile.FullName}' is not a valid .NET assembly.");
			return;
		}

		var context = new AssemblyLoadContext(null, isCollectible: true);
		_ = context.LoadFromAssemblyPath(assemblyFile.FullName);

		context.Unload();
	}
}
