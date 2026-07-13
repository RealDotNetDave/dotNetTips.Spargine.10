// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : Copilot Agent
// Created          : 07-09-2026
//
// Last Modified By : David McCarter
// Last Modified On : 07-11-2026
// ***********************************************************************
// <copyright file="DateOnlyJsonConverter.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>JSON converter for DateOnly values using an invariant, ISO-style format.</summary>
// ***********************************************************************
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;
using DotNetTips.Spargine.Core.Properties;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Serialization;

/// <summary>
/// Converts <see cref="DateOnly"/> values to and from JSON using an ISO-style invariant format.
/// </summary>
[Information(nameof(DateOnlyJsonConverter), Status = Status.Available)]
internal sealed class DateOnlyJsonConverter : JsonConverter<DateOnly>
{
	private const string Format = "yyyy-MM-dd";

	/// <summary>
	/// Reads and converts JSON to a <see cref="DateOnly"/> value.
	/// </summary>
	/// <param name="reader">The <see cref="Utf8JsonReader"/> to read from.</param>
	/// <param name="typeToConvert">The type to convert.</param>
	/// <param name="options">The <see cref="JsonSerializerOptions"/> to use.</param>
	/// <returns>The deserialized <see cref="DateOnly"/> value.</returns>
	/// <exception cref="JsonException">Thrown when the JSON value is null, whitespace, or not a valid ISO 8601 date.</exception>
	public override DateOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var value = reader.GetString();

		if (string.IsNullOrWhiteSpace(value))
		{
			throw new JsonException(Resources.ErrorThereWasAnErrorWithJsonSerialization);
		}

		try
		{
			return DateOnly.ParseExact(value, Format, CultureInfo.InvariantCulture);
		}
		catch (FormatException ex)
		{
			throw new JsonException(Resources.ErrorThereWasAnErrorWithJsonSerialization, ex);
		}
	}

	/// <summary>
	/// Writes a <see cref="DateOnly"/> value as JSON.
	/// </summary>
	/// <param name="writer">The <see cref="Utf8JsonWriter"/> to write to.</param>
	/// <param name="value">The <see cref="DateOnly"/> value to write.</param>
	/// <param name="options">The <see cref="JsonSerializerOptions"/> to use.</param>
	public override void Write(Utf8JsonWriter writer, DateOnly value, JsonSerializerOptions options)
	{
		writer = writer.ArgumentNotNull();

		writer.WriteStringValue(value.ToString(Format, CultureInfo.InvariantCulture));
	}
}
