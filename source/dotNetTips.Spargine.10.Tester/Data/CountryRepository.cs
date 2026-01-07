// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 01-10-2025
//
// Last Modified By : David McCarter
// Last Modified On : 01-07-2026
// ***********************************************************************
// <copyright file="CountryRepository.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Provides static methods for retrieving, searching, and managing comprehensive country data, including regions, states, and cities.
// Utilizes embedded resources and JSON serialization for efficient access and manipulation of country information.
// </summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Tester.Data.Converters;
using DotNetTips.Spargine.Tester.Data.Models;
using DotNetTips.Spargine.Tester.Properties;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Tester.Data;

/// <summary>
/// Provides static methods for retrieving comprehensive data about countries, including their regions, states, and cities.
/// Utilizes resources and serialization to efficiently manage and access country data.
/// </summary>
[Information(Status = Status.Available, Documentation = "https://bit.ly/SpargineCountryRepository")]
public static class CountryRepository
{
	/// <summary>
	/// Holds a read-only collection of all countries, lazily initialized upon first access.
	/// </summary>
	private static ReadOnlyCollection<Country>? _countries;

	/// <summary>
	/// The serializer options configured for JSON operations within the CountryRepository class.
	/// </summary>
	private static readonly JsonSerializerOptions? _options = ConfigureSerializerOptions();

	/// <summary>
	/// Retrieves a read-only collection of all countries.
	/// </summary>
	/// <returns>
	/// A <see cref="ReadOnlyCollection{Country}"/> representing the comprehensive list of countries.
	/// </returns>
	/// <remarks>
	/// This method ensures thread-safe initialization and retrieval of the country collection.
	/// It leverages lazy loading to initialize the collection only once, upon the first request.
	/// </remarks>
	[Pure]
	[MethodImpl(MethodImplOptions.Synchronized)]
	[Information(nameof(GetCountries), "David McCarter", "3/24/2023", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.None, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<Country> GetCountries()
	{
		_countries ??= DeserializeCountries();

		return _countries;
	}

	/// <summary>
	/// Retrieves a country by its <see cref="CountryName"/> enum value.
	/// </summary>
	/// <param name="countryName">The <see cref="CountryName"/> value to retrieve. Cannot be null.</param>
	/// <returns>
	/// The <see cref="Country"/> object if found; otherwise, <c>null</c>.
	/// </returns>
	/// <exception cref="ArgumentNullException">
	/// Thrown if <paramref name="countryName"/> is null.
	/// </exception>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GetCountry), "David McCarter", "12/14/2023", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static Country? GetCountry(CountryName countryName)
	{
		countryName = countryName.ArgumentDefined();
		var countryNameDescription = countryName.GetDescription();

		return GetCountries().FirstOrDefault(p => string.Equals(p.Name, countryNameDescription, StringComparison.Ordinal));
	}

	/// <summary>
	/// Retrieves a country by its name or ISO code.
	/// </summary>
	/// <param name="countryNameOrIso">The country name, ISO2, or ISO3 code.</param>
	/// <returns>
	/// The <see cref="Country"/> object if found; otherwise, <c>null</c>.
	/// </returns>
	/// <exception cref="ArgumentNullException">
	/// Thrown if <paramref name="countryNameOrIso"/> is null.
	/// </exception>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GetCountry), "David McCarter", "9/1/2025", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, Status = Status.Available)]
	public static Country? GetCountry(string countryNameOrIso)
	{
		countryNameOrIso = countryNameOrIso.ArgumentNotNullOrEmpty();

		var countryData = GetCountries();
		var length = countryNameOrIso.Length;

		// Single pass through collection checking all conditions
		foreach (var country in countryData)
		{
			// Fast path: Check ISO2 (2 chars) - most common case
			if (length == 2 && string.Equals(country.Iso2, countryNameOrIso, StringComparison.OrdinalIgnoreCase))
			{
				return country;
			}

			// Check ISO3 (3 chars)
			if (length == 3 && string.Equals(country.Iso3, countryNameOrIso, StringComparison.OrdinalIgnoreCase))
			{
				return country;
			}

			// Check country name (any other length)
			if (length != 2 && length != 3 && string.Equals(country.Name, countryNameOrIso, StringComparison.OrdinalIgnoreCase))
			{
				return country;
			}
		}

		return null;
	}

	/// <summary>
	/// Configures and returns the serializer options for JSON serialization.
	/// </summary>
	/// <returns>
	/// A <see cref="JsonSerializerOptions"/> object configured with custom settings for serialization.
	/// </returns>
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

		foreach (var converter in CountryConverter.Settings.Converters)
		{
			options.Converters.Add(converter);
		}

		return options;
	}

	/// <summary>
	/// Deserializes the JSON string from resources into a collection of <see cref="Country"/>.
	/// This method is marked with <see cref="MethodImplOptions.NoInlining"/> to suggest that
	/// the JIT compiler should not inline this method, potentially to improve debugging or
	/// to work around JIT compilation behaviors.
	/// </summary>
	/// <returns>
	/// A read-only collection of <see cref="Country"/> objects.
	/// </returns>
	/// <exception cref="InvalidOperationException">
	/// Thrown when deserialization fails due to invalid JSON format.
	/// </exception>
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static ReadOnlyCollection<Country> DeserializeCountries()
	{
		try
		{
			var countries = JsonSerializer.Deserialize<Country[]>(Resources.CountryData, _options);
			return countries?.AsReadOnly() ?? new ReadOnlyCollection<Country>([]);
		}
		catch (JsonException ex)
		{
			// Log the exception or handle it as needed.
			throw new InvalidOperationException(Resources.FailedToDeserializeCountriesData, ex);
		}
	}
}
