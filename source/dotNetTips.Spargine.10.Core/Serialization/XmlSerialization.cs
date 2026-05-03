// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 02-07-2021
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-03-2026
// ***********************************************************************
// <copyright file="XmlSerialization.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Facilitates seamless serialization and deserialization of strings to
// and from the XML format.
// </summary>
// ***********************************************************************
using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using DotNetTips.Spargine.Core.Properties;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Serialization;

/// <summary>
/// Provides functionality for serializing objects to XML strings and deserializing XML strings to objects.
/// This class contains static methods for both serialization to, and deserialization from, XML format.
/// It supports operations on both strings and files, offering a flexible API for working with XML data in .NET applications.
/// </summary>
[Information(Status = Status.NeedsDocumentation)]
public static class XmlSerialization
{
	/// <summary>
	/// Cache of <see cref="XmlSerializer"/> instances keyed by type to avoid costly per-call re-creation.
	/// </summary>
	private static readonly ConcurrentDictionary<Type, XmlSerializer> _serializerCache = new();

	/// <summary>
	/// Deserializes the specified XML string into an object of the specified type.
	/// </summary>
	/// <typeparam name="TResult">The type of the object to deserialize to.</typeparam>
	/// <param name="xml">The XML string to deserialize.</param>
	/// <returns>An instance of the specified type containing the deserialized data.</returns>
	/// <exception cref="ArgumentNullException">Thrown if the xml parameter is null or empty.</exception>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[RequiresUnreferencedCode("Uses XmlSerializer which requires unreferenced code for type metadata.")]
	[Information(nameof(Deserialize), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static TResult Deserialize<TResult>([DisallowNull][StringSyntax(StringSyntaxAttribute.Xml)] string xml)
		where TResult : new()
	{
		xml = xml.ArgumentNotNullOrEmpty();

		using (var sr = new StringReader(xml))
		{
			using (var xmlReader = XmlReader.Create(sr))
			{
				var deserializedObject = GetSerializer(typeof(TResult)).Deserialize(xmlReader);

				return deserializedObject is null
					? throw new InvalidOperationException(Resources.DeserializationResultedInANullObject)
					: (TResult)deserializedObject;
			}
		}
	}

	/// <summary>
	/// Deserializes an XML file into an object of the specified type.
	/// </summary>
	/// <typeparam name="TResult">The type of the object to deserialize to.</typeparam>
	/// <param name="file">The file containing the XML to deserialize.</param>
	/// <returns>An instance of the specified type containing the deserialized data from the file.</returns>
	/// <exception cref="FileNotFoundException">Thrown if the specified file does not exist.</exception>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[RequiresUnreferencedCode("Uses XmlSerializer via Deserialize<TResult> which requires unreferenced code for type metadata.")]
	[Information(nameof(DeserializeFromFile), OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static TResult DeserializeFromFile<TResult>([DisallowNull] FileInfo file) where TResult : new()
	{
		file = file.ArgumentNotNull();

		return file.Exists is false
			? throw ExceptionThrower.CreateFileNotFoundException(Resources.FileNotFoundCannotDeserializeFromXML, file.FullName)
			: Deserialize<TResult>(File.ReadAllText(file.FullName));
	}

	/// <summary>
	/// Serializes the specified object to an XML string.
	/// </summary>
	/// <param name="obj">The object to serialize.</param>
	/// <returns>A string containing the XML representation of the object.</returns>
	/// <exception cref="ArgumentNullException">Thrown if the obj parameter is null.</exception>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[RequiresUnreferencedCode("Uses XmlSerializer which requires unreferenced code for type metadata.")]
	[Information(nameof(Serialize), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string Serialize([DisallowNull] object obj)
	{
		obj = obj.ArgumentNotNull();

		using (var writer = new StringWriter())
		{
			using (var xmlWriter = XmlWriter.Create(writer))
			{
				GetSerializer(obj.GetType()).Serialize(xmlWriter, obj);
			}

			return writer.ToString();
		}
	}

	/// <summary>
	/// Serializes the specified object to an XML file.
	/// </summary>
	/// <param name="obj">The object to serialize.</param>
	/// <param name="file">The file to write the XML to.</param>
	/// <exception cref="ArgumentNullException">Thrown if any parameter is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[RequiresUnreferencedCode("Uses XmlSerializer which requires unreferenced code for type metadata.")]
	[Information(nameof(SerializeToFile), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static void SerializeToFile([DisallowNull] object obj, [DisallowNull] FileInfo file)
	{
		obj = obj.ArgumentNotNull();
		file = file.ArgumentNotNull();

		if (file.Exists)
		{
			file.Delete();
		}

		var directoryName = file.DirectoryName!;

		if (Directory.Exists(directoryName) is false)
		{
			_ = Directory.CreateDirectory(directoryName);
		}

		using (var writer = new StreamWriter(file.FullName))
		{
			using (var xmlWriter = XmlWriter.Create(writer))
			{
				GetSerializer(obj.GetType()).Serialize(xmlWriter, obj);
			}
		}
	}

	/// <summary>
	/// Converts a string to an XDocument securely.
	/// </summary>
	/// <param name="input">The input string to convert.</param>
	/// <returns>An XDocument instance representing the XML content of the input string.</returns>
	/// <exception cref="ArgumentNullException">Thrown if the input parameter is null or empty.</exception>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(StringToXDocument), "David McCarter", "9/9/2020", "9/9/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static XDocument StringToXDocument([DisallowNull] string input)
	{
		return StringToXDocument(input.ArgumentNotNullOrEmpty(), null);
	}

	/// <summary>
	/// Converts a string to an XDocument securely, with an optional XML resolver.
	/// </summary>
	/// <param name="input">The input string to convert.</param>
	/// <param name="resolver">The XML resolver to use during conversion.</param>
	/// <returns>An XDocument instance representing the XML content of the input string.</returns>
	/// <remarks>Uses DtdProcessing.Prohibit to enhance security.</remarks>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(StringToXDocument), "David McCarter", "9/9/2020", "9/9/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static XDocument StringToXDocument([DisallowNull] string input, [AllowNull] XmlResolver resolver)
	{
		using (var stringReader = new StringReader(input.ArgumentNotNullOrEmpty()))
		{
			var options = new XmlReaderSettings { DtdProcessing = DtdProcessing.Prohibit, XmlResolver = resolver };

			using (var reader = XmlReader.Create(stringReader, options))
			{
				return XDocument.Load(reader);
			}
		}
	}

	/// <summary>
	/// Returns a cached <see cref="XmlSerializer"/> for the specified type.
	/// </summary>
	/// <param name="type">The type to obtain a serializer for.</param>
	/// <returns>A cached <see cref="XmlSerializer"/> instance.</returns>
	[RequiresUnreferencedCode("Uses XmlSerializer which requires unreferenced code for type metadata.")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static XmlSerializer GetSerializer([DisallowNull] Type type)
	{
		return _serializerCache.GetOrAdd(type, static t => new XmlSerializer(t));
	}
}
