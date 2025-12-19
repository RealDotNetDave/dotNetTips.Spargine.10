// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 09-01-2025
//
// Last Modified By : David McCarter
// Last Modified On : 09-01-2025
// ***********************************************************************
// <copyright file="CountryPhonePostalInfo.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Text.Json.Serialization;

namespace DotNetTips.Spargine.Core.Data.Models;

/// <summary>
/// Represents phone and postal-related data for a country, including ISO codes, name, phone code, phone number length, and postal information.
/// </summary>
public record CountryPhonePostalInfo
{
	/// <summary>
	/// Gets the unique identifier for the country.
	/// </summary>
	[JsonPropertyName("id")]
	public required long Id { get; init; }

	/// <summary>
	/// Gets the ISO 3166-1 alpha-2 code for the country.
	/// </summary>
	[JsonPropertyName("iso2")]
	public required string Iso2 { get; init; }

	/// <summary>
	/// Gets the ISO 3166-1 alpha-3 code for the country.
	/// </summary>
	[JsonPropertyName("iso3")]
	public required string Iso3 { get; init; }

	/// <summary>
	/// Gets the name of the country.
	/// </summary>
	[JsonPropertyName("name")]
	public required string Name { get; init; }

	/// <summary>
	/// Gets the international phone code for the country.
	/// </summary>
	[JsonPropertyName("phoneCode")]
	public required string PhoneCode { get; init; }

	/// <summary>
	/// Gets the expected length of phone numbers for the country.
	/// </summary>
	[JsonPropertyName("phoneNumberLength")]
	public required int PhoneNumberLength { get; init; }

	/// <summary>
	/// Gets the format specification for postal codes in the country.
	/// </summary>
	[JsonPropertyName("postalFormat")]
	public required string PostalFormat { get; init; }

	/// <summary>
	/// Gets the regular expression used to validate postal codes for the country.
	/// </summary>
	[JsonPropertyName("postalRegex")]
	public required string PostalRegex { get; init; }
}
