// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 01-10-2025
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-17-2026
// ***********************************************************************
// <copyright file="RegionConverter.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Provides a custom System.Text.Json converter for serializing and
// deserializing Region enumeration values to and from their string
// representations.
// </summary>
// ***********************************************************************

using System.Text.Json;
using System.Text.Json.Serialization;
using DotNetTips.Spargine.Core;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Tester.Data.Converters;

/// <summary>
/// Provides custom serialization and deserialization for <see cref="Region"/> enumeration values.
/// This converter enables the conversion of enumeration values to their corresponding string representations in JSON and vice versa.
/// </summary>
internal sealed class RegionConverter : JsonConverter<Region>
{

	/// <summary>
	/// Provides a singleton instance of the <see cref="RegionConverter"/> for reuse across the application.
	/// </summary>
	public static readonly RegionConverter Singleton = new();

	/// <summary>
	/// Determines whether this instance can convert the specified type.
	/// </summary>
	/// <param name="t">The type to check for conversion capability.</param>
	/// <returns><c>true</c> if this instance can convert the specified type; otherwise, <c>false</c>.</returns>
	public override bool CanConvert(Type t) => t == typeof(Region);

	/// <summary>
	/// Reads and converts the JSON to type <see cref="Region"/>.
	/// </summary>
	/// <param name="reader">The reader.</param>
	/// <param name="typeToConvert">The type to convert.</param>
	/// <param name="options">An object that specifies serialization options to use.</param>
	/// <returns>The converted value.</returns>
	/// <remarks>A converter may throw any Exception, but should throw <see cref="JsonException"/> when the JSON is invalid.</remarks>
	public override Region Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var value = reader.GetString();

		return value switch
		{
			"Africa" => Region.Africa,
			"Americas" => Region.Americas,
			"Asia" => Region.Asia,
			"Europe" => Region.Europe,
			"Oceania" => Region.Oceania,
			"Polar" => Region.Polar,
			_ => Region.Empty,
		};
	}

	/// <summary>
	/// Writes a specified value as JSON.
	/// </summary>
	/// <param name="writer">The writer to write to.</param>
	/// <param name="value">The value to convert to JSON.</param>
	/// <param name="options">An object that specifies serialization options to use.</param>
	/// <exception cref="Exception">Cannot marshal type Region</exception>
	/// <remarks>A converter may throw any Exception, but should throw <see cref="JsonException"/> when the JSON
	/// cannot be created.</remarks>
	[Information(nameof(Write), UnitTestStatus = UnitTestStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public override void Write(Utf8JsonWriter writer, Region value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case Region.Africa:
				writer.WriteStringValue("Africa");
				return;
			case Region.Americas:
				writer.WriteStringValue("Americas");
				return;
			case Region.Asia:
				writer.WriteStringValue("Asia");
				return;
			case Region.Europe:
				writer.WriteStringValue("Europe");
				return;
			case Region.Oceania:
				writer.WriteStringValue("Oceania");
				return;
			case Region.Polar:
				writer.WriteStringValue("Polar");
				return;
			case Region.Empty:
				writer.WriteStringValue(string.Empty);
				break;
			default:
				writer.WriteStringValue(string.Empty);
				break;
		}
	}

}

