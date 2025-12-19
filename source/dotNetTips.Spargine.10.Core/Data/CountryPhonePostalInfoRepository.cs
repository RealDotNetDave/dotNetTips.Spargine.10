// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 09-01-2025
//
// Last Modified By : David McCarter
// Last Modified On : 12-17-2025
// ***********************************************************************
// <copyright file="CountryPhonePostalInfoRepository.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Provides static methods for accessing and validating country phone and postal information.
// This includes retrieving country data by name or ISO code, validating phone numbers and postal codes
// according to country-specific formats, and deserializing country data from embedded resources.
// The repository is designed for efficient lookups and validation in globalized applications.
// </summary>
// ***********************************************************************

using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Core.Data.Models;
using DotNetTips.Spargine.Core.Properties;
using DotNetTips.Spargine.Core.RegularExpressions;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Data;

/// <summary>
/// Provides methods for accessing and validating country phone and postal information.
/// </summary>
[Information(Status = Status.New)]
public static class CountryPhonePostalInfoRepository
{
	private static ReadOnlyCollection<CountryPhonePostalInfo>? _countries;
	private static readonly JsonSerializerOptions? _options = ConfigureSerializerOptions();

	/// <summary>
	/// Configures and returns the serializer options for JSON serialization.
	/// </summary>
	/// <returns>A <see cref="JsonSerializerOptions"/> object configured with custom settings for serialization.</returns>
	/// <remarks>
	/// This method sets up JSON serializer options to handle numbers as strings and adds custom converters.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static JsonSerializerOptions ConfigureSerializerOptions()
	{
		var options = new JsonSerializerOptions()
		{
			NumberHandling = JsonNumberHandling.AllowReadingFromString,
		};

		return options;
	}

	/// <summary>
	/// Deserializes the country phone and postal information from the embedded JSON resource.
	/// </summary>
	/// <returns>A <see cref="ReadOnlyCollection{CountryPhonePostalInfo}"/> containing country data.</returns>
	/// <exception cref="InvalidOperationException">Thrown if deserialization fails.</exception>
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static ReadOnlyCollection<CountryPhonePostalInfo> DeserializeCountryPhonePostalInfo()
	{
		try
		{
			var countries = JsonSerializer.Deserialize<CountryPhonePostalInfo[]>(Resources.CountryPhonePostalInfo, _options);
			return countries?.AsReadOnly() ?? new ReadOnlyCollection<CountryPhonePostalInfo>([]);
		}
		catch (JsonException ex)
		{
			// Log the exception or handle it as needed.
			throw new InvalidOperationException(Resources.FailedToDeserializeCountriesData, ex);
		}
	}

	/// <summary>
	/// Retrieves a read-only collection containing all country phone and postal information records.
	/// </summary>
	/// <returns>
	/// A <see cref="ReadOnlyCollection{T}"/> of <see cref="CountryPhonePostalInfo"/> containing all available country data.
	/// The collection includes phone codes, postal code formats, and ISO country identifiers for all supported countries.
	/// </returns>
	/// <remarks>
	/// This method provides access to the complete repository of country phone and postal information.
	/// <para>
	/// <strong>Thread Safety:</strong>
	/// The method is marked with <see cref="MethodImplAttribute"/> using <see cref="MethodImplOptions.Synchronized"/>,
	/// which ensures thread-safe initialization of the cached data. Multiple concurrent calls during initial load
	/// are serialized to prevent race conditions and duplicate deserialization.
	/// </para>
	/// <para>
	/// <strong>Performance Characteristics:</strong>
	/// <list type="bullet">
	/// <item><description>First call: O(n) - deserializes JSON and creates ReadOnlyCollection (where n = number of countries)</description></item>
	/// <item><description>Subsequent calls: O(1) - returns cached reference, no allocation or computation</description></item>
	/// <item><description>Memory: Single allocation persists for application lifetime (typical size: ~250+ countries)</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Immutability:</strong>
	/// The returned <see cref="ReadOnlyCollection{T}"/> provides read-only access to the underlying data,
	/// preventing accidental modification of the cached country information.
	/// </para>
	/// </remarks>
	/// <example>
	/// Example usage for retrieving and enumerating all country data:
	/// <code>
	/// // Get all country information
	/// var allCountries = CountryPhonePostalInfoRepository.GetCountryPhonePostalInfo();
	/// 
	/// Console.WriteLine($"Total countries: {allCountries.Count}");
	/// 
	/// // Find all countries with a specific phone code
	/// var northAmericanCountries = allCountries
	///     .Where(c => c.PhoneCode?.Contains("+1") == true)
	///     .Select(c => c.Name);
	/// 
	/// // Get all ISO-2 codes
	/// var iso2Codes = allCountries
	///     .Select(c => c.Iso2)
	///     .OrderBy(code => code);
	/// 
	/// // Filter countries by postal code availability
	/// var countriesWithPostalCodes = allCountries
	///     .Where(c => !string.IsNullOrEmpty(c.PostalRegex))
	///     .ToList();
	/// </code>
	/// </example>
	/// <exception cref="InvalidOperationException">
	/// Thrown by <see cref="DeserializeCountryPhonePostalInfo"/> if the embedded JSON resource cannot be deserialized.
	/// This typically indicates corrupted resource data or incompatible schema changes.
	/// </exception>
	/// <seealso cref="GetCountryPhonePostalInfo(string)"/>
	/// <seealso cref="DeserializeCountryPhonePostalInfo"/>
	/// <seealso cref="CountryPhonePostalInfo"/>
	[Pure]
	[MethodImpl(MethodImplOptions.Synchronized)]
	[Information(nameof(GetCountryPhonePostalInfo), "David McCarter", "9/1/2025", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.New)]
	public static ReadOnlyCollection<CountryPhonePostalInfo> GetCountryPhonePostalInfo()
	{
		_countries ??= DeserializeCountryPhonePostalInfo();

		return _countries;
	}

	/// <summary>
	/// Retrieves country phone and postal information by country name or ISO code.
	/// </summary>
	/// <param name="countryNameOrIso">
	/// The country identifier, which can be one of the following:
	/// <list type="bullet">
	/// <item><description>Full country name (e.g., "United States", "United Kingdom")</description></item>
	/// <item><description>ISO 3166-1 alpha-2 two-letter country code (e.g., "US", "GB")</description></item>
	/// <item><description>ISO 3166-1 alpha-3 three-letter country code (e.g., "USA", "GBR")</description></item>
	/// </list>
	/// Cannot be <c>null</c>.
	/// </param>
	/// <returns>
	/// The <see cref="CountryPhonePostalInfo"/> record if a match is found; otherwise, <c>null</c>.
	/// </returns>
	/// <remarks>
	/// This method performs intelligent lookup based on the input string length:
	/// <list type="bullet">
	/// <item><description>Length 2: Searches by ISO 3166-1 alpha-2 code</description></item>
	/// <item><description>Length 3: Searches by ISO 3166-1 alpha-3 code</description></item>
	/// <item><description>Other lengths: Searches by full country name</description></item>
	/// </list>
	/// All comparisons are case-insensitive.
	/// <para>
	/// <strong>Performance Characteristics:</strong>
	/// <list type="bullet">
	/// <item><description>Time Complexity: O(n) where n = number of countries (~250+)</description></item>
	/// <item><description>Uses linear search with <see cref="Enumerable.FirstOrDefault{TSource}(IEnumerable{TSource}, Func{TSource, bool})"/></description></item>
	/// <item><description>Data is cached after first access via <see cref="GetCountryPhonePostalInfo()"/></description></item>
	/// </list>
	/// </para>
	/// </remarks>
	/// <example>
	/// Example usage:
	/// <code>
	/// // Lookup by ISO 3166-1 alpha-2 code
	/// var usInfo = CountryPhonePostalInfoRepository.GetCountryPhonePostalInfo("US");
	/// Console.WriteLine(usInfo?.Name);  // Output: United States
	/// 
	/// // Lookup by ISO 3166-1 alpha-3 code
	/// var usaInfo = CountryPhonePostalInfoRepository.GetCountryPhonePostalInfo("USA");
	/// Console.WriteLine(usaInfo?.PhoneCode);  // Output: +1
	/// 
	/// // Lookup by full country name
	/// var ukInfo = CountryPhonePostalInfoRepository.GetCountryPhonePostalInfo("United Kingdom");
	/// Console.WriteLine(ukInfo?.Iso2);  // Output: GB
	/// 
	/// // Case-insensitive lookup
	/// var franceInfo = CountryPhonePostalInfoRepository.GetCountryPhonePostalInfo("fr");
	/// Console.WriteLine(franceInfo?.Iso3);  // Output: FRA
	/// 
	/// // Non-existent country returns null
	/// var invalidInfo = CountryPhonePostalInfoRepository.GetCountryPhonePostalInfo("ZZ");
	/// Console.WriteLine(invalidInfo == null);  // Output: True
	/// </code>
	/// </example>
	/// <exception cref="ArgumentNullException">
	/// Thrown when <paramref name="countryNameOrIso"/> is <c>null</c>.
	/// </exception>
	/// <seealso cref="GetCountryPhonePostalInfo()"/>
	/// <seealso cref="ValidatePhoneNumber(string, string, bool)"/>
	/// <seealso cref="ValidatePostalCode(string, string)"/>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GetCountryPhonePostalInfo), "David McCarter", "9/1/2025", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
	public static CountryPhonePostalInfo? GetCountryPhonePostalInfo(string countryNameOrIso)
	{
		countryNameOrIso = countryNameOrIso.ArgumentNotNull();

		var countryData = GetCountryPhonePostalInfo();

		CountryPhonePostalInfo? info = null;

		if (countryNameOrIso.Length == 2)
		{
			// Get by iso 2
			info = countryData.FirstOrDefault(p => string.Equals(p.Iso2, countryNameOrIso, StringComparison.OrdinalIgnoreCase));
		}
		else if (countryNameOrIso.Length == 3)
		{
			// Get by iso 3
			info = countryData.FirstOrDefault(p => string.Equals(p.Iso3, countryNameOrIso, StringComparison.OrdinalIgnoreCase));
		}
		else
		{
			// Get by country name
			info = countryData.FirstOrDefault(p => string.Equals(p.Name, countryNameOrIso, StringComparison.OrdinalIgnoreCase));
		}

		return info;
	}

	/// <summary>
	/// Validates a phone number for a given country by name or ISO code.
	/// </summary>
	/// <param name="countryNameOrIso">
	/// The country identifier, which can be one of the following:
	/// <list type="bullet">
	/// <item><description>Full country name (e.g., "United States")</description></item>
	/// <item><description>ISO 3166-1 alpha-2 two-letter country code (e.g., "US")</description></item>
	/// <item><description>ISO 3166-1 alpha-3 three-letter country code (e.g., "USA")</description></item>
	/// </list>
	/// Cannot be <c>null</c>.
	/// </param>
	/// <param name="phoneNumber">
	/// The phone number to validate. Can include formatting characters (spaces, hyphens, parentheses) 
	/// which will be stripped during validation.
	/// </param>
	/// <param name="validateCountryCode">
	/// If <c>true</c>, validates that the phone number includes and starts with a valid country code prefix.
	/// If <c>false</c>, only validates the phone number length. Defaults to <c>false</c>.
	/// </param>
	/// <returns>
	/// <c>true</c> if the phone number is valid for the specified country according to the validation criteria; 
	/// otherwise, <c>false</c>.
	/// </returns>
	/// <remarks>
	/// This method validates phone numbers based on country-specific rules.
	/// <para>
	/// <strong>Validation Process:</strong>
	/// <list type="number">
	/// <item><description>Retrieves country information using <see cref="GetCountryPhonePostalInfo(string)"/></description></item>
	/// <item><description>Returns <c>false</c> if country is not found or has no phone code defined</description></item>
	/// <item><description>Extracts only numeric digits from the phone number</description></item>
	/// <item><description>If <paramref name="validateCountryCode"/> is <c>true</c>, validates and strips the country code prefix</description></item>
	/// <item><description>Validates the remaining number length matches the country's expected length</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Multiple Country Codes:</strong>
	/// Some countries support multiple phone codes (e.g., Caribbean countries with "+1").
	/// The method parses comma-separated phone codes efficiently using <see cref="ReadOnlySpan{T}"/>.
	/// </para>
	/// </remarks>
	/// <example>
	/// Example validation scenarios:
	/// <code>
	/// // Validate US number without country code check
	/// bool isValid = CountryPhonePostalInfoRepository.ValidatePhoneNumber("US", "2025551234");
	/// // Returns: true (10 digits for US)
	/// 
	/// // Validate with country code
	/// bool isValidWithCode = CountryPhonePostalInfoRepository.ValidatePhoneNumber(
	///     "US", 
	///     "+1-202-555-1234", 
	///     validateCountryCode: true
	/// );
	/// // Returns: true (country code +1 is valid, 10 digits after removal)
	/// 
	/// // Invalid number - wrong length
	/// bool isInvalid = CountryPhonePostalInfoRepository.ValidatePhoneNumber("US", "123456");
	/// // Returns: false (only 6 digits, US requires 10)
	/// 
	/// // With formatting characters
	/// bool formatted = CountryPhonePostalInfoRepository.ValidatePhoneNumber("US", "(202) 555-1234");
	/// // Returns: true (formatting is stripped, 10 digits remain)
	/// </code>
	/// </example>
	/// <exception cref="ArgumentNullException">
	/// Thrown when <paramref name="countryNameOrIso"/> is <c>null</c>.
	/// </exception>
	/// <seealso cref="GetCountryPhonePostalInfo(string)"/>
	/// <seealso cref="ValidatePostalCode(string, string)"/>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ValidatePhoneNumber), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, Status = Status.New)]
	public static bool ValidatePhoneNumber(string countryNameOrIso, string phoneNumber, bool validateCountryCode = false)
	{
		var country = GetCountryPhonePostalInfo(countryNameOrIso.ArgumentNotNull());

		if (country is null || string.IsNullOrEmpty(country.PhoneCode))
		{
			return false;
		}

		var number = RegexProcessor.GetNumbers(phoneNumber);

		if (validateCountryCode)
		{
			// Use Span for efficient splitting and comparison
			var phoneCodeSpan = country.PhoneCode.AsSpan();
			var start = 0;
			var codeFound = false;

			for (var charIndex = 0; charIndex <= phoneCodeSpan.Length; charIndex++)
			{
				if (charIndex == phoneCodeSpan.Length || phoneCodeSpan[charIndex] == ControlChars.Comma)
				{
					var codeSpan = phoneCodeSpan[start..charIndex].Trim();
					var strippedCode = RegexProcessor.GetNumbers(codeSpan.ToString());

					if (number.StartsWith(strippedCode, StringComparison.Ordinal))
					{
						codeFound = true;
						number = number[strippedCode.Length..];
						break;
					}
					start = charIndex + 1;
				}
			}

			if (!codeFound)
			{
				return false;
			}
		}

		return number.Length == country.PhoneNumberLength;
	}

	/// <summary>
	/// Validates a postal code for a given country by name or ISO code.
	/// </summary>
	/// <param name="countryNameOrIso">
	/// The country identifier, which can be one of the following:
	/// <list type="bullet">
	/// <item><description>Full country name (e.g., "United States")</description></item>
	/// <item><description>ISO 3166-1 alpha-2 two-letter country code (e.g., "US")</description></item>
	/// <item><description>ISO 3166-1 alpha-3 three-letter country code (e.g., "USA")</description></item>
	/// </list>
	/// Cannot be <c>null</c>.
	/// </param>
	/// <param name="postalCode">The postal code to validate against the country's postal code format.</param>
	/// <returns>
	/// A <see cref="PostalCodeState"/> value indicating the validation result:
	/// <list type="bullet">
	/// <item><description><see cref="PostalCodeState.Valid"/>: The postal code matches the country's format</description></item>
	/// <item><description><see cref="PostalCodeState.Invalid"/>: The postal code is invalid or doesn't match the format</description></item>
	/// <item><description><see cref="PostalCodeState.Unknown"/>: The country has no postal code format defined</description></item>
	/// </list>
	/// </returns>
	/// <remarks>
	/// This method validates postal codes using country-specific regular expression patterns.
	/// <para>
	/// <strong>Validation Process:</strong>
	/// <list type="number">
	/// <item><description>Retrieves country information using <see cref="GetCountryPhonePostalInfo(string)"/></description></item>
	/// <item><description>Returns <see cref="PostalCodeState.Unknown"/> if country is not found or has no postal regex defined</description></item>
	/// <item><description>Returns <see cref="PostalCodeState.Invalid"/> if the postal code is null, empty, or whitespace</description></item>
	/// <item><description>Validates the postal code against the country's regular expression pattern</description></item>
	/// </list>
	/// </para>
	/// </remarks>
	/// <example>
	/// Example validation scenarios:
	/// <code>
	/// // Validate US ZIP code
	/// var usResult = CountryPhonePostalInfoRepository.ValidatePostalCode("US", "90210");
	/// // Returns: PostalCodeState.Valid
	/// 
	/// // Validate US ZIP+4 code
	/// var usZip4 = CountryPhonePostalInfoRepository.ValidatePostalCode("US", "90210-1234");
	/// // Returns: PostalCodeState.Valid
	/// 
	/// // Invalid US postal code
	/// var invalidUs = CountryPhonePostalInfoRepository.ValidatePostalCode("US", "ABCDE");
	/// // Returns: PostalCodeState.Invalid
	/// 
	/// // Validate UK postcode
	/// var ukResult = CountryPhonePostalInfoRepository.ValidatePostalCode("GB", "SW1A 1AA");
	/// // Returns: PostalCodeState.Valid
	/// 
	/// // Country without postal codes
	/// var noPostal = CountryPhonePostalInfoRepository.ValidatePostalCode("CountryWithoutCodes", "12345");
	/// // Returns: PostalCodeState.Unknown
	/// 
	/// // Empty postal code
	/// var empty = CountryPhonePostalInfoRepository.ValidatePostalCode("US", "   ");
	/// // Returns: PostalCodeState.Invalid
	/// </code>
	/// </example>
	/// <exception cref="ArgumentNullException">
	/// Thrown when <paramref name="countryNameOrIso"/> is <c>null</c>.
	/// </exception>
	/// <seealso cref="GetCountryPhonePostalInfo(string)"/>
	/// <seealso cref="ValidatePhoneNumber(string, string, bool)"/>
	/// <seealso cref="PostalCodeState"/>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ValidatePostalCode), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, Status = Status.New)]
	public static PostalCodeState ValidatePostalCode(string countryNameOrIso, string postalCode)
	{
		var country = GetCountryPhonePostalInfo(countryNameOrIso.ArgumentNotNull());

		// Fast null/empty check and avoid unnecessary Regex call
		var regex = country?.PostalRegex;

		if (string.IsNullOrEmpty(regex))
		{
			return PostalCodeState.Unknown;
		}

		// Use string.IsNullOrWhiteSpace to avoid unnecessary Trim and handle null/empty/whitespace
		if (string.IsNullOrWhiteSpace(postalCode))
		{
			return PostalCodeState.Invalid;
		}

		// Use Regex.IsMatch
		return Regex.IsMatch(postalCode, regex)
			? PostalCodeState.Valid
			: PostalCodeState.Invalid;
	}
}
