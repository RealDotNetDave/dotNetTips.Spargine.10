// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 01-10-2025
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-27-2026
// ***********************************************************************
// <copyright file="DateOnlyConverter.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Provides a custom System.Text.Json converter for serializing and
// deserializing DateOnly values with a configurable format string.
// </summary>
// ***********************************************************************

using System.Text.Json;
using System.Text.Json.Serialization;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Tester.Properties;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Tester.Data.Converters;

/// <summary>
/// Initializes a new instance of the <see cref="DateOnlyConverter"/> class with an optional serialization format.
/// </summary>
/// <param name="serializationFormat">The serialization format to use for <see cref="DateOnly"/> values. If null, defaults to "yyyy-MM-dd".</param>
public class DateOnlyConverter(string? serializationFormat) : JsonConverter<DateOnly>
{

	/// <summary>
	/// The serialization format
	/// </summary>
	private readonly string _serializationFormat = serializationFormat ?? "yyyy-MM-dd";

	/// <summary>
	/// Initializes a new instance of the <see cref="DateOnlyConverter"/> class with the default serialization format.
	/// </summary>
	public DateOnlyConverter() : this(null) { }

	/// <summary>
	/// Reads and converts the JSON to type <see cref="DateOnly"/>.
	/// </summary>
	/// <param name="reader">The reader.</param>
	/// <param name="typeToConvert">The type to convert.</param>
	/// <param name="options">An object that specifies serialization options to use.</param>
	/// <returns>The converted value.</returns>
	/// <exception cref="JsonException">Thrown when the JSON is invalid or cannot be converted to <see cref="DateOnly"/>.</exception>
	[Information(nameof(Read), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public override DateOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var value = reader.GetString() ?? throw new JsonException(Resources.ErrorDateTextIsNullOrEmpty);

		try
		{
			return DateOnly.Parse(value, IsoDateTimeOffsetConverter.Singleton.Culture);
		}
		catch (FormatException e)
		{
			ExceptionThrower.ThrowJsonException(Resources.ErrorInvalidDateFormat, e);
		}

		return default;
	}

	/// <summary>
	/// Writes the <see cref="DateOnly"/> value as JSON.
	/// </summary>
	/// <param name="writer">The writer to write to.</param>
	/// <param name="value">The <see cref="DateOnly"/> value to convert to JSON.</param>
	/// <param name="options">An object that specifies serialization options to use.</param>
	/// <exception cref="ArgumentNullException">Thrown if the writer is null.</exception>
	[Information(nameof(Write), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public override void Write(Utf8JsonWriter writer, DateOnly value, JsonSerializerOptions options)
	{
		writer = writer.ArgumentNotNull();

		writer.WriteStringValue(value.ToString(this._serializationFormat, IsoDateTimeOffsetConverter.Singleton.Culture));
	}

}
