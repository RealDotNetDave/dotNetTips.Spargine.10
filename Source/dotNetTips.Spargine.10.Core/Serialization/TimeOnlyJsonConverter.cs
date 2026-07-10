// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : Copilot Agent
// Created          : 07-09-2026
//
// Last Modified By : David McCarter
// Last Modified On : 07-10-2026
// ***********************************************************************
// <copyright file="TimeOnlyJsonConverter.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>JSON converter for TimeOnly values using an invariant, ISO-style format.</summary>
// ***********************************************************************
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;
using DotNetTips.Spargine.Core.Properties;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Serialization;

/// <summary>
/// Converts <see cref="TimeOnly"/> values to and from JSON using an invariant time format.
/// </summary>
[Information(nameof(TimeOnlyJsonConverter), Status = Status.New)]
internal sealed class TimeOnlyJsonConverter : JsonConverter<TimeOnly>
{
	private const string Format = "HH:mm:ss.fff";

	/// <summary>
	/// Reads and converts JSON to a <see cref="TimeOnly"/> value.
	/// </summary>
	/// <param name="reader">The <see cref="Utf8JsonReader"/> to read from.</param>
	/// <param name="typeToConvert">The type to convert.</param>
	/// <param name="options">The <see cref="JsonSerializerOptions"/> to use.</param>
	/// <returns>The deserialized <see cref="TimeOnly"/> value.</returns>
	/// <exception cref="JsonException">Thrown when the JSON value is null, whitespace, or not a valid time string matching HH:mm:ss.fff.</exception>
	public override TimeOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var value = reader.GetString();

		if (string.IsNullOrWhiteSpace(value))
		{
			throw new JsonException(Resources.ErrorThereWasAnErrorWithJsonSerialization);
		}

		try
		{
			return TimeOnly.ParseExact(value, Format, CultureInfo.InvariantCulture);
		}
		catch (FormatException ex)
		{
			throw new JsonException(Resources.ErrorThereWasAnErrorWithJsonSerialization, ex);
		}
	}

	/// <summary>
	/// Writes a <see cref="TimeOnly"/> value as JSON.
	/// </summary>
	/// <param name="writer">The <see cref="Utf8JsonWriter"/> to write to.</param>
	/// <param name="value">The <see cref="TimeOnly"/> value to write.</param>
	/// <param name="options">The <see cref="JsonSerializerOptions"/> to use.</param>
	public override void Write(Utf8JsonWriter writer, TimeOnly value, JsonSerializerOptions options)
	{
		writer = writer.ArgumentNotNull();

		writer.WriteStringValue(value.ToString(Format, CultureInfo.InvariantCulture));
	}
}
