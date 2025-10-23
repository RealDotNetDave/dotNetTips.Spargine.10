// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 09-01-2025
//
// Last Modified By : David McCarter
// Last Modified On : 09-16-2025
// ***********************************************************************
// <copyright file="CountryPhonePostalInfoRepository.cs" company="David McCarter - dotNetTips.com">
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
	/// Gets a read-only collection of all <see cref="CountryPhonePostalInfo"/> records.
	/// </summary>
	/// <returns>A <see cref="ReadOnlyCollection{CountryPhonePostalInfo}"/> containing all country phone and postal info.</returns>
	[Pure]
	[MethodImpl(MethodImplOptions.Synchronized)]
	[Information(nameof(GetCountryPhonePostalInfo), "David McCarter", "9/1/2025", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.New)]
	public static ReadOnlyCollection<CountryPhonePostalInfo> GetCountryPhonePostalInfo()
	{
		_countries ??= DeserializeCountryPhonePostalInfo();

		return _countries;
	}

	/// <summary>
	/// Gets the <see cref="CountryPhonePostalInfo"/> for a country by name or ISO code.
	/// </summary>
	/// <param name="countryNameOrIso">The country name, ISO2, or ISO3 code.</param>
	/// <returns>The <see cref="CountryPhonePostalInfo"/> if found; otherwise, <c>null</c>.</returns>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GetCountryPhonePostalInfo), "David McCarter", "9/1/2025", UnitTestStatus = UnitTestStatus.None, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
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
	/// <param name="countryNameOrIso">The country name, ISO2, or ISO3 code.</param>
	/// <param name="phoneNumber">The phone number to validate.</param>
	/// <param name="validateCountryCode">If <c>true</c>, validates the country code prefix.</param>
	/// <returns><c>true</c> if the phone number is valid for the country; otherwise, <c>false</c>.</returns>
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
	/// Validates the postal code for a given country by name or ISO code.
	/// </summary>
	/// <param name="countryNameOrIso">The country name, ISO2, or ISO3 code.</param>
	/// <param name="postalCode">The postal code to validate.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="countryNameOrIso"/> is null.</exception>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ValidatePostalCode), UnitTestStatus = UnitTestStatus.None, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, Status = Status.New)]
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
