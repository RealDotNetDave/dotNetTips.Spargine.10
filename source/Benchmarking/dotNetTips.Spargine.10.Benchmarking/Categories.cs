// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Benchmarking
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-19-2026
// ***********************************************************************
// <copyright file="Categories.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Defines constant string values used with the BenchmarkCategory attribute
// to classify and filter benchmarks by functionality or feature area.
// </summary>
// ***********************************************************************

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)


using DotNetTips.Spargine.Core;

namespace DotNetTips.Spargine.Benchmarking;

/// <summary>
/// Provides a list of categories used to classify benchmarks. These categories help in organizing and filtering benchmarks based on their functionality or the features they demonstrate.
/// </summary>
[Information(Documentation = "https://bit.ly/BenchmarkLikeDotNetDave", Status = Status.Available)]
public static class Categories
{

	/// <summary>
	/// The anti pattern
	/// </summary>
	public const string AntiPattern = "Anti-Pattern";

	/// <summary>
	/// Category for benchmarks involving arrays.
	/// </summary>
	public const string Array = "Array";

	/// <summary>
	/// Category for benchmarks involving asynchronous operations.
	/// </summary>
	public const string Async = "Async";

	/// <summary>
	/// The binary
	/// </summary>
	public const string Binary = "Binary";

	/// <summary>
	/// Category for benchmarks related to cloud computing and operations.
	/// </summary>
	public const string Cloud = "Cloud";

	/// <summary>
	/// Category for benchmarks that deal with collections.
	/// </summary>
	public const string Collections = "Collections";

	/// <summary>
	/// Category for benchmarks involving data compression techniques.
	/// </summary>
	public const string Compression = "Compression";

	/// <summary>
	/// The concurrent
	/// </summary>
	public const string Concurrent = "Concurrent";

	/// <summary>
	/// The database
	/// </summary>
	public const string Database = "Database";

	/// <summary>
	/// The early binding
	/// </summary>
	public const string EarlyBinding = "Early Binding";

	/// <summary>
	/// Category for benchmarks involving encryption algorithms.
	/// </summary>
	public const string Encryption = "Encryption";

	/// <summary>
	/// Category for benchmarks that involve exception handling operations.
	/// </summary>
	public const string Exceptions = "Exceptions";

	/// <summary>
	/// Special category for benchmarks that are meant for comparison purposes.
	/// </summary>
	public const string ForComparison = "**FOR COMPARISON**";

	/// <summary>
	/// Category for benchmarks that use generic collections.
	/// </summary>
	public const string GenericCollections = "Collections<>";

	/// <summary>
	/// Category for benchmarks involving globalization features.
	/// </summary>
	public const string Globalization = "Globalization";

	/// <summary>
	/// Category for benchmarks that involve immutable data structures.
	/// </summary>
	public const string Immutable = "Immutable";

	/// <summary>
	/// The interop
	/// </summary>
	public const string Interop = "Interop";

	/// <summary>
	/// Category for benchmarks that involve input/output operations.
	/// </summary>
	public const string IO = "IO";

	/// <summary>
	/// Category for benchmarks that involve JSON operations.
	/// </summary>
	public const string JSON = "JSON";

	/// <summary>
	/// The late binding
	/// </summary>
	public const string LateBinding = "Late Binding";

	/// <summary>
	/// Category for benchmarks that involve LINQ operations.
	/// </summary>
	public const string LINQ = "LINQ";

	/// <summary>
	/// Category for benchmarks that involve logging operations.
	/// </summary>
	public const string Logging = "LOGGING";

	/// <summary>
	/// The marshalling
	/// </summary>
	public const string Marshalling = "Marshalling";

	/// <summary>
	/// The math
	/// </summary>
	public const string Math = "MATH";

	/// <summary>
	/// The memory
	/// </summary>
	public const string Memory = "MEMORY";

	/// <summary>
	/// The network
	/// </summary>
	public const string Network = "NETWORK";

	/// <summary>
	/// Special category for new benchmarks or benchmarks that have been recently added.
	/// </summary>
	public const string New = "**NEW**";

	/// <summary>
	/// The p invoke
	/// </summary>
	public const string PInvoke = "P/Invoke";

	/// <summary>
	/// Category for benchmarks that involve queue data structures.
	/// </summary>
	public const string Queues = "Queues";

	/// <summary>
	/// The real world
	/// </summary>
	public const string RealWorld = "Real World";

	/// <summary>
	/// Category for benchmarks that involve record types.
	/// </summary>
	public const string RecordType = "Record Type";

	/// <summary>
	/// Category for benchmarks that involve reference types.
	/// </summary>
	public const string ReferenceType = "Ref Type";

	/// <summary>
	/// Category for benchmarks that involve reflection.
	/// </summary>
	public const string Reflection = "Reflection";

	/// <summary>
	/// Category for benchmarks that involve serialization operations.
	/// </summary>
	public const string Serialization = "Serialization";

	/// <summary>
	/// The simd
	/// </summary>
	public const string SIMD = "SIMD";

	/// <summary>
	/// Category for benchmarks that involve Span operations.
	/// </summary>
	public const string Span = "Span";

	/// <summary>
	/// Category for benchmarks that involve string operations.
	/// </summary>
	public const string Strings = "Strings";

	/// <summary>
	/// Category for benchmarks that involve threading and concurrency.
	/// </summary>
	public const string Threading = "Threading";

	/// <summary>
	/// Special category for benchmarks that have been updated.
	/// </summary>
	public const string Updated = "**Updated**";

	/// <summary>
	/// Category for benchmarks that involve validation operations.
	/// </summary>
	public const string Validation = "Validation";

	/// <summary>
	/// Category for benchmarks that involve value types.
	/// </summary>
	public const string ValueType = "Value Type";

	/// <summary>
	/// Category for benchmarks that involve XML operations.
	/// </summary>
	public const string XML = "XML";

}
