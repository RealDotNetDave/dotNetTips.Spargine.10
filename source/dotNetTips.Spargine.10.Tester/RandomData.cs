// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Tester
// Author           : David McCarter
// Created          : 01-19-2019
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-14-2026
// ***********************************************************************
// <copyright file="RandomData.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) dotNetTips.com - McCarter Consulting. All rights reserved.
// </copyright>
// <summary>
// Provides methods for generating random data (strings, numbers,
// collections, Person instances, etc.) for unit and benchmark testing.
// </summary>
// ***********************************************************************

using System.Buffers;
using System.Collections.Concurrent;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Data;
using DotNetTips.Spargine.Tester.Data.Models;
using DotNetTips.Spargine.Tester.Models.Common;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using DotNetTips.Spargine.Tester.Properties;
using Microsoft.Extensions.ObjectPool;
using Microsoft.VisualBasic;
using Address = DotNetTips.Spargine.Tester.Models.RefTypes.Address;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Tester;

/// <summary>
/// Provides methods for generating random data for various types. This class is useful for testing and simulation purposes,
/// offering functions to create random names, addresses, emails, phone numbers, and more.
/// </summary>
/// <remarks>
/// Utilizes <see cref="RandomNumberGenerator"/> for generating cryptographically secure random data where necessary.
/// This class is designed to be thread-safe and efficient in generating large volumes of random data.
/// </remarks>
[Information(Status = Status.UpdateDocumentation, Documentation = "https://bit.ly/SpargineTester")]
public static class RandomData
{

	/// <summary>
	/// The default maximum character used in various string generation methods.
	/// </summary>
	public const char DefaultMaxCharacter = 'z';

	/// <summary>
	/// The default maximum character used when generating random file names.
	/// </summary>
	public const char DefaultMaxCharacterRandomFile = 'Z';

	/// <summary>
	/// The default minimum character used when generating random file names.
	/// </summary>
	public const char DefaultMinCharacter = 'a';

	/// <summary>
	/// The default minimum character used when generating random file names.
	/// </summary>
	public const char DefaultMinCharacterRandomFile = 'A';

	/// <summary>
	/// Specifies the number of digits in an address number.
	/// </summary>
	private const int AddressNumberCount = 5;

	/// <summary>
	/// The default file extension used when generating random file names.
	/// </summary>
	private const string DefaultFileExtension = "dotnettips.temp";

	/// <summary>
	/// The default length for generated files.
	/// </summary>
	private const int DefaultFileLength = 1024;

	/// <summary>Factory functions for address creation by type.</summary>
	private static readonly Dictionary<Type, Func<AddressComponents, object>> _addressFactories = new()
	{
		[typeof(Address)] = c => new Address
		{
			Id = c.Id,
			Address1 = c.Address1,
			Address2 = c.Address2,
			City = c.CityName,
			Country = c.CountryName,
			CountyProvince = c.CountyProvince,
			Phone = c.Phone,
			PostalCode = c.PostalCode,
			State = c.StateName
		},
		[typeof(Models.ValueTypes.Address)] = c => new Models.ValueTypes.Address
		{
			Id = c.Id,
			Address1 = c.Address1,
			Address2 = c.Address2,
			City = c.CityName,
			Country = c.CountryName,
			CountyProvince = c.CountyProvince,
			Phone = c.Phone,
			PostalCode = c.PostalCode,
			State = c.StateName
		},
		[typeof(AddressRecord)] = c => new AddressRecord(c.Id, c.Address1, c.Address2, c.CityName, c.StateName, c.CountyProvince, c.CountryName, c.PostalCode, c.Phone),
	};

	/// <summary>
	/// A lazy-loaded read-only collection of countries.
	/// </summary>
	private static readonly Lazy<ReadOnlyCollection<Country>> _countries = CountryRepository.GetCountries().ToReadOnlyCollection().ToLazy();

	/// <summary>
	/// A lazy-loaded array of domain extensions.
	/// </summary>
	private static readonly Lazy<string[]> _domainExtensions = Resources.DomainExtentions.Split(Core.ControlChars.Comma, StringSplitOptions.RemoveEmptyEntries).ToLazy();

	/// <summary>
	/// Cached composite format for the enum-without-values error message.
	/// </summary>
	private static readonly CompositeFormat _errorEnumHasNoDefinedValues = CompositeFormat.Parse(Resources.ErrorEnumHasNoDefinedValues);

	/// <summary>
	/// Cached composite format for the "type not supported by method" error message.
	/// </summary>
	private static readonly CompositeFormat _errorTypeNotSupportedByMethod = CompositeFormat.Parse(Resources.ErrorTypeNotSupportedByMethod);

	/// <summary>
	/// A lazy-loaded array of first names.
	/// </summary>
	private static readonly Lazy<string[]> _firstNames = Resources.FirstNames.Split(Core.ControlChars.Comma, StringSplitOptions.TrimEntries).ToLazy();

	/// <summary>
	/// A lazy-loaded array of last names.
	/// </summary>
	private static readonly Lazy<string[]> _lastNames = Resources.LastNames.Split(Core.ControlChars.Comma, StringSplitOptions.TrimEntries).ToLazy();

	/// <summary>
	/// Pre-built flat arrays for O(1) direct-indexed random selection of country/state/city.
	/// Avoids per-call <see cref="Collection{T}"/> virtual dispatch, null checks, and
	/// <c>IsNotEmpty()</c> extension overhead inside <see cref="GenerateRandomLocationData"/>.
	/// </summary>
	private static readonly Lazy<(Country[] Countries, State[][] States, City[][][] Cities)> _locationData = new(() =>
	{
		var countries = _countries!.Value;
		var countryArr = new Country[countries.Count];
		var stateArr = new State[countries.Count][];
		var cityArr = new City[countries.Count][][];

		for (var countryIndex = 0; countryIndex < countries.Count; countryIndex++)
		{
			var country = countries[countryIndex];
			countryArr[countryIndex] = country;

			var states = country.States!;
			stateArr[countryIndex] = new State[states.Count];
			cityArr[countryIndex] = new City[states.Count][];

			for (var stateIndex = 0; stateIndex < states.Count; stateIndex++)
			{
				var state = states[stateIndex];
				stateArr[countryIndex][stateIndex] = state;

				var cities = state.Cities!;
				cityArr[countryIndex][stateIndex] = new City[cities.Count];

				for (var cityIndex = 0; cityIndex < cities.Count; cityIndex++)
				{
					cityArr[countryIndex][stateIndex][cityIndex] = cities[cityIndex];
				}
			}
		}

		return (countryArr, stateArr, cityArr);
	});

	/// <summary>Factory functions for person creation by type.</summary>
	private static readonly Dictionary<Type, Func<int, int, int, object>> _personFactories = new()
	{
		[typeof(Person)] = GeneratePersonRef,
		[typeof(Models.ValueTypes.Person)] = (ac, al, cpl) => GeneratePersonVal(ac, al, cpl),
		[typeof(PersonRecord)] = (ac, al, cpl) => GeneratePersonRecord(ac, al, cpl),
	};

	/// <summary>
	/// A thread-safe cache for phone code splits, keyed by country.
	/// Avoids repeated <c>string.Split</c> calls on the comma-separated <see cref="Country.PhoneCode"/> string.
	/// </summary>
	private static readonly ConcurrentDictionary<Country, string[]> _phoneCodeCache = new();

	/// <summary>
	/// A thread-safe cache for postal formats, keyed by country.
	/// </summary>
	private static readonly ConcurrentDictionary<Country, string[]> _postalFormatsCache = new();

	/// <summary>
	/// An object pool for reusing instances of StringBuilder, reducing allocations.
	/// </summary>
	private static readonly ObjectPool<StringBuilder> _stringBuilderPool = new DefaultObjectPoolProvider().CreateStringBuilderPool();

	/// <summary>
	/// Cached system temp path — never changes at runtime, avoids repeated OS calls.
	/// </summary>
	private static readonly string _tempPath = Path.GetTempPath();

	/// <summary>
	/// A thread-local RandomNumberGenerator instance for non-zero byte generation, avoiding lock contention.
	/// </summary>
	[ThreadStatic]
	private static RandomNumberGenerator? _threadLocalRng;

	/// <summary>
	/// Provides an extensive string for testing purposes, with a length of 969 characters, including spaces.
	/// </summary>
	/// <value>
	/// The long test string loaded from <see cref="Resources.LongTestString"/>.
	/// </value>
	[Information(nameof(LongTestString), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static string LongTestString => Resources.LongTestString;

	/// <summary>
	/// Generates an address instance populated with random data for the specified address type.
	/// </summary>
	/// <typeparam name="TAddress">
	/// The address type to generate. Supported types:
	/// <list type="bullet">
	///   <item><description><see cref="DotNetTips.Spargine.Tester.Models.RefTypes.Address"/></description></item>
	///   <item><description><see cref="DotNetTips.Spargine.Tester.Models.ValueTypes.Address"/></description></item>
	///   <item><description><see cref="DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord"/></description></item>
	/// </list>
	/// </typeparam>
	/// <param name="country">
	/// The country to base the address data on. If <see langword="null"/>, a random country is selected from the country repository.
	/// </param>
	/// <param name="addressLength">
	/// The desired length for address lines. Must be in the range [5..100]. Default is 25.
	/// </param>
	/// <param name="countyProvinceLength">
	/// The desired length for the county/province name. Must be in the range [5..50]. Default is 20.
	/// </param>
	/// <returns>
	/// A new instance of <typeparamref name="TAddress"/> populated with random, length-validated fields
	/// (Id, Address1, Address2, City, Country, CountyProvince, Phone, PostalCode, State).
	/// </returns>
	/// <exception cref="NotSupportedException">
	/// Thrown when <typeparamref name="TAddress"/> is not one of the supported address types.
	/// </exception>
	/// <remarks>
	/// - Uses <see cref="GenerateKey"/> for the identifier.
	/// - Address lines are produced by <see cref="GenerateAddressLineOne(int)"/> and <see cref="GenerateAddressLineTwo(int)"/>.
	/// - City and state are chosen from the provided or randomly selected <paramref name="country"/> (if available).
	/// - Phone number length is based on the selected country's specification.
	/// - Postal code formatting is based on country-specific formats via <see cref="GeneratePostalCode(Country, City)"/>.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GenerateAddress), author: "David McCarter", createdOn: "6/4/2025", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static TAddress GenerateAddress<TAddress>(Country? country = null, int addressLength = 25, int countyProvinceLength = 20)
	{
		country ??= _countries.Value.PickRandom();
		addressLength = addressLength.ArgumentInRange(min: 5, max: 100);
		countyProvinceLength = countyProvinceLength.ArgumentInRange(min: 5, max: 50);

		return !_addressFactories.TryGetValue(typeof(TAddress), out var factory)
			? throw new NotSupportedException(string.Format(CultureInfo.CurrentCulture, _errorTypeNotSupportedByMethod, typeof(TAddress).FullName, nameof(GenerateAddress)))
			: (TAddress)factory(BuildAddressComponents(country!, addressLength, countyProvinceLength));
	}

	/// <summary>
	/// Generates a collection of addresses for a randomly selected country.
	/// </summary>
	/// <param name="count">The number of addresses to generate. Defaults to 2.</param>
	/// <param name="addressLength">The length of the address line. Defaults to 25.</param>
	/// <param name="countyProvinceLength">The length of the county or province. Defaults to 20.</param>
	/// <returns>A collection of addresses of the specified type for a random country.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GenerateAddressCollection), "David McCarter", "6/1/2025", Status = Status.Available)]
	public static Collection<TAddress> GenerateAddressCollection<TAddress>(in int count = 2, in int addressLength = 25, in int countyProvinceLength = 20) where TAddress : IAddress<TAddress>
	{
		return GenerateAddressCollection<TAddress>(_countries.Value.PickRandom()!, count, addressLength, countyProvinceLength);
	}

	/// <summary>
	/// Generates a collection of addresses, where each address is populated with random data.
	/// </summary>
	/// <typeparam name="TAddress">The type of address to generate. Must implement <see cref="IAddress{TAddress}"/>.</typeparam>
	/// <param name="country">The country for which to generate addresses. Must not be null.</param>
	/// <param name="count">The number of addresses to generate. Defaults to 2.</param>
	/// <param name="addressLength">The length of the address line. Defaults to 25.</param>
	/// <param name="countyProvinceLength">The length of the county or province. Defaults to 20.</param>
	/// <returns>A collection of addresses of the specified type.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="country"/> is null.</exception>
	/// <remarks>
	/// Each address is generated using <see cref="GenerateAddress{TAddress}(Country, int, int)"/>.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GenerateAddressCollection), "David McCarter", "12/4/2023", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static Collection<TAddress> GenerateAddressCollection<TAddress>(Country country, int count = 2, int addressLength = 25, int countyProvinceLength = 20)
		 where TAddress : IAddress<TAddress>
	{
		country = country.ArgumentNotNull();
		count = count.ArgumentInRange(min: 1, defaultValue: 2);
		addressLength = addressLength.ArgumentInRange(min: 5, max: 100);
		countyProvinceLength = countyProvinceLength.ArgumentInRange(min: 5, max: 50);


		var addresses = new Collection<TAddress>();

		for (var i = 0; i < count; i++)
		{
			addresses.Add(GenerateAddress<TAddress>(country, addressLength, countyProvinceLength));
		}

		return addresses;

	}

	/// <summary>
	/// Generates a random boolean value.
	/// </summary>
	/// <returns><c>true</c> or <c>false</c> with equal probability.</returns>
	/// <example>
	/// <code>
	/// bool randomBool = RandomData.GenerateBoolean();
	/// // Output: true or false
	/// </code>
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GenerateBoolean), "Copilot Agent", "07/10/2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, Status = Status.New)]
	public static bool GenerateBoolean()
	{
		return RandomNumberGenerator.GetInt32(0, 2) == 1;
	}

	/// <summary>
	/// Generates a byte array of a specified size filled with cryptographically secure random data.
	/// </summary>
	/// <param name="count">The number of bytes to generate in the array. Must be at least 1.</param>
	/// <returns>A byte array of the specified size filled with cryptographically secure random bytes.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="count"/> is less than 1.</exception>
	/// <remarks>
	/// <para>
	/// This method creates a byte array of the exact size specified by <paramref name="count"/> and 
	/// fills it with cryptographically secure random bytes using <see cref="RandomNumberGenerator"/>.
	/// </para>
	/// <para>
	/// The method employs locking around the <see cref="RandomNumberGenerator.GetBytes(byte[])"/> call
	/// to ensure thread safety when accessed concurrently from multiple threads.
	/// </para>
	/// <para>
	/// This implementation is optimized with <see cref="MethodImplOptions.AggressiveInlining"/> to 
	/// improve performance in high-frequency scenarios. The method has been fully tested, optimized,
	/// and benchmarked as indicated by the Information attribute.
	/// </para>
	/// </remarks>
	/// <example>
	/// <code>
	/// // Generate a 1KB array of random bytes
	/// byte[] randomData = RandomData.GenerateByteArray(1024);
	/// 
	/// // Use the random bytes for cryptographic operations
	/// using (var aes = Aes.ToUniqueCollection())
	/// {
	///     // Use first 16 bytes for IV
	///     byte[] iv = randomData[..16];
	///     // Use next 32 bytes for key
	///     byte[] key = randomData[16..48];
	///     // Initialize encryption with random data
	///     aes.Key = key;
	///     aes.IV = iv;
	/// }
	/// </code>
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GenerateByteArray), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static byte[] GenerateByteArray(int count)
	{
		count = count.ArgumentInRange(min: 1, defaultValue: 1);

		var bytes = GC.AllocateUninitializedArray<byte>(count);

		RandomNumberGenerator.Fill(bytes);

		return bytes;
	}

	/// <summary>
	/// Generates a random character using the default minimum and maximum character constraints.
	/// </summary>
	/// <returns>A random character between <see cref="DefaultMinCharacter"/> and <see cref="DefaultMaxCharacter"/>.</returns>
	/// <example>Output: 82 'R'</example>
	[Information(nameof(GenerateCharacter), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static char GenerateCharacter()
	{
		return GenerateCharacter(DefaultMinCharacter, DefaultMaxCharacter);
	}

	/// <summary>
	/// Generates a random character within a specified range.
	/// </summary>
	/// <param name="minValue">The minimum value of the character to generate.</param>
	/// <param name="maxValue">The maximum value of the character to generate.</param>
	/// <returns>A random character between <paramref name="minValue"/> and <paramref name="maxValue"/>.</returns>
	/// <example>Output: 65 'A'</example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GenerateCharacter), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static char GenerateCharacter(char minValue, char maxValue)
	{
		return (char)GenerateInteger(minValue, maxValue);
	}

	/// <summary>
	/// Generates a random company name.
	/// </summary>
	/// <returns>A random company name string.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GenerateCompanyName), "Copilot Agent", "07/10/2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
	public static string GenerateCompanyName()
	{
		var suffixes = new[] { "Inc", "Corp", "LLC", "Ltd", "Group", "Solutions", "Technologies", "Systems", "Industries", "Enterprises" };
		var word = GenerateWord(5, 12, 'a', 'z');

		return $"{char.ToUpperInvariant(word[0])}{word.AsSpan(1)} {suffixes[RandomNumberGenerator.GetInt32(0, suffixes.Length)]}";
	}

	/// <summary>
	/// Generates a coordinate with random values for X, Y, and Z using the specified <typeparamref name="T"/> which must implement <see cref="ICoordinate"/>.
	/// </summary>
	/// <typeparam name="T">The type of the coordinate to generate. Must implement <see cref="ICoordinate"/>.</typeparam>
	/// <returns>A new instance of <typeparamref name="T"/> with random values for X, Y, and Z.</returns>
	/// <example>Output: X: 178765551 Y: -2145952440</example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GenerateCoordinate), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static T GenerateCoordinate<T>() where T : ICoordinate, new()
	{
		Span<int> values = stackalloc int[3];
		RandomNumberGenerator.Fill(MemoryMarshal.AsBytes(values));

		return new() { X = values[0], Y = values[1], Z = values[2] };
	}

	/// <summary>
	/// Generates a collection of coordinates with random values for X, Y, and Z.
	/// </summary>
	/// <typeparam name="T">The type of the coordinate to generate. Must implement <see cref="ICoordinate"/>.</typeparam>
	/// <param name="count">The number of coordinates to generate in the collection.</param>
	/// <returns>A read-only collection of <typeparamref name="T"/> with random values for X, Y, and Z.</returns>
	/// <example>Output: [0]: {2089369587--284215139} [1]: {244137335-1577361939}</example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GenerateCoordinateCollection), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<T> GenerateCoordinateCollection<T>(int count = 2) where T : ICoordinate, new()
	{
		count = count.ArgumentInRange(min: 1, defaultValue: 2);

		// Fill all coordinates in a single RNG call instead of one per element.
		// Each coordinate needs 3 ints (X, Y, Z) = 12 bytes.
		var intBuffer = ArrayPool<int>.Shared.Rent(count * 3);

		try
		{
			RandomNumberGenerator.Fill(MemoryMarshal.AsBytes(intBuffer.AsSpan(0, count * 3)));

			var coordinates = new List<T>(count);

			for (var coordinateIndex = 0; coordinateIndex < count; coordinateIndex++)
			{
				var offset = coordinateIndex * 3;

				coordinates.Add(new T { X = intBuffer[offset], Y = intBuffer[offset + 1], Z = intBuffer[offset + 2] });
			}

			return coordinates.ToReadOnlyCollection();
		}
		finally
		{
			ArrayPool<int>.Shared.Return(intBuffer);
		}
	}

	/// <summary>
	/// Generates a random credit card number.
	/// </summary>
	/// <returns>A string representing a random credit card number.</returns>
	/// <remarks>
	/// This method utilizes the <see cref="RandomCreditCardNumberGenerator.GetCreditCardNumber"/> method to generate a valid credit card number.
	/// </remarks>
	[Information(nameof(GenerateCreditCard), "David McCarter", "3/13/2023", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static string? GenerateCreditCard()
	{
		return RandomCreditCardNumberGenerator.GetCreditCardNumber();
	}

	/// <summary>
	/// Generates a read-only collection of random credit card numbers.
	/// </summary>
	/// <param name="count">The number of credit card numbers to generate. Default is 1.</param>
	/// <returns>A read-only collection of random credit card numbers.</returns>
	/// <remarks>
	/// This method leverages the <see cref="GenerateCreditCard"/> method to generate each credit card number in the collection.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GenerateCreditCard), "David McCarter", "3/13/2023", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<string> GenerateCreditCards(int count = 2)
	{
		count = count.ArgumentInRange(min: 1, defaultValue: 2);

		return RandomCreditCardNumberGenerator.GetCreditCardNumbers(count).ToReadOnlyCollection();
	}

	/// <summary>
	/// Generates a random currency amount with the specified decimal places.
	/// </summary>
	/// <param name="minValue">The minimum value. Default is 0.01.</param>
	/// <param name="maxValue">The maximum value. Default is 10000.00.</param>
	/// <returns>A random currency amount with 2 decimal places.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GenerateCurrencyAmount), "Copilot Agent", "07/10/2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
	public static decimal GenerateCurrencyAmount(decimal minValue = 0.01m, decimal maxValue = 10000.00m)
	{
		return GenerateDecimal(minValue, maxValue, 2);
	}

	/// <summary>
	/// Generates a random <see cref="DateOnly"/> within a specified range.
	/// </summary>
	/// <param name="minValue">The minimum date. Defaults to January 1, 2000.</param>
	/// <param name="maxValue">The maximum date. Defaults to December 31, 2099.</param>
	/// <returns>A random <see cref="DateOnly"/> between <paramref name="minValue"/> and <paramref name="maxValue"/>.</returns>
	/// <example>
	/// <code>
	/// DateOnly randomDate = RandomData.GenerateDateOnly();
	/// // Output: 2045-07-15
	/// </code>
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GenerateDateOnly), "Copilot Agent", "07/10/2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, Status = Status.New)]
	public static DateOnly GenerateDateOnly(DateOnly? minValue = null, DateOnly? maxValue = null)
	{
		var min = minValue ?? new DateOnly(2000, 1, 1);
		var max = maxValue ?? new DateOnly(2099, 12, 31);

		var range = max.DayNumber - min.DayNumber;

		if (range <= 0)
		{
			return min;
		}

		var randomDays = RandomNumberGenerator.GetInt32(0, range + 1);

		return min.AddDays(randomDays);
	}

	/// <summary>
	/// Generates a random <see cref="DateTimeOffset"/> within a specified range.
	/// </summary>
	/// <param name="minValue">The minimum date/time. Defaults to January 1, 2000 at midnight UTC.</param>
	/// <param name="maxValue">The maximum date/time. Defaults to December 31, 2099 at 23:59:59 UTC.</param>
	/// <returns>A random <see cref="DateTimeOffset"/> between <paramref name="minValue"/> and <paramref name="maxValue"/>.</returns>
	/// <example>
	/// <code>
	/// DateTimeOffset randomDateTime = RandomData.GenerateDateTimeOffset();
	/// // Output: 2045-07-15T14:32:18+00:00
	/// </code>
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GenerateDateTimeOffset), "Copilot Agent", "07/10/2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, Status = Status.New)]
	public static DateTimeOffset GenerateDateTimeOffset(DateTimeOffset? minValue = null, DateTimeOffset? maxValue = null)
	{
		var min = minValue ?? new DateTimeOffset(2000, 1, 1, 0, 0, 0, TimeSpan.Zero);
		var max = maxValue ?? new DateTimeOffset(2099, 12, 31, 23, 59, 59, TimeSpan.Zero);

		var range = (max - min).Ticks;

		if (range <= 0)
		{
			return min;
		}

		// Generate a cryptographically secure random long by combining two 32-bit integers
		Span<byte> buffer = stackalloc byte[8];

		RandomNumberGenerator.Fill(buffer);

		var randomValue = Math.Abs(BitConverter.ToInt64(buffer)) % (range + 1);

		return min.AddTicks(randomValue);
	}

	/// <summary>
	/// Generates a random decimal number within a specified range and with a specified number of decimal places.
	/// </summary>
	/// <param name="minValue">The inclusive lower bound of the random number returned.</param>
	/// <param name="maxValue">The exclusive upper bound of the random number returned. <paramref name="maxValue"/> must be greater than or equal to <paramref name="minValue"/>.</param>
	/// <param name="decimalPlaces">The number of decimal places for the generated number.</param>
	/// <returns>A decimal number that is greater than or equal to <paramref name="minValue"/>, less than <paramref name="maxValue"/>, and rounded to <paramref name="decimalPlaces"/> decimal places.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="minValue"/> is greater than <paramref name="maxValue"/>, or <paramref name="decimalPlaces"/> is negative.</exception>
	/// <example>Output: 95.15</example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GenerateDecimal), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static decimal GenerateDecimal(in decimal minValue, in decimal maxValue, int decimalPlaces)
	{
		decimalPlaces = decimalPlaces.ArgumentInRange(min: 0, defaultValue: 0);

		var multiplier = (decimal)Math.Pow(10, decimalPlaces);

		return GenerateInteger((int)(minValue * multiplier), (int)(maxValue * multiplier)) / multiplier;
	}

	/// <summary>
	/// Generates a random domain extension from a predefined list.
	/// </summary>
	/// <returns>
	/// A string representing a randomly selected domain extension from the predefined list.
	/// </returns>
	/// <remarks>
	/// This method uses the <see cref="Of(ReadOnlyCollection{string})"/> method to randomly select a domain extension
	/// from a predefined collection of domain extensions.
	/// </remarks>
	/// <example>
	/// This example demonstrates how to use the <see cref="GenerateDomainExtension"/> method:
	/// <code>
	/// var domainExtension = RandomData.GenerateDomainExtension();
	/// Console.WriteLine(domainExtension); // Output: e.g., ".com", ".org", ".net"
	/// </code>
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GenerateDomainExtension), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string GenerateDomainExtension()
	{
		var extensions = _domainExtensions.Value;

		return extensions[GenerateInteger(0, extensions.Length - 1)];
	}

	/// <summary>
	/// Generates a random email address.
	/// </summary>
	/// <returns>
	/// A string representing a randomly generated email address in the format 
	/// "username@domain.extension" where:
	/// <list type="bullet">
	///   <item><description>username: a random string between 5-25 lowercase characters</description></item>
	///   <item><description>domain: a random string between 5-15 lowercase characters</description></item>
	///   <item><description>extension: a random domain extension (e.g., "com", "org", "net")</description></item>
	/// </list>
	/// </returns>
	/// <remarks>
	/// <para>
	/// This method constructs a randomized email address by combining:
	/// </para>
	/// <list type="number">
	///   <item><description>A username generated with <see cref="GenerateWord(int, int, char,  char)"/> (5-25 chars)</description></item>
	///   <item><description>The "@" symbol</description></item>
	///   <item><description>A domain name generated with <see cref="GenerateWord(int, int, char,  char)"/> (5-15 chars)</description></item>
	///   <item><description>A dot separator</description></item>
	///   <item><description>A domain extension from <see cref="GenerateDomainExtension"/></description></item>
	/// </list>
	/// <para>
	/// This is ideal for creating realistic test data or filling databases with sample users.
	/// </para>
	/// </remarks>
	/// <example>
	/// <code>
	/// string randomEmail = RandomData.GenerateEmailAddress();
	/// Console.WriteLine(randomEmail); // Output example: "fbxpfvtanqysqmuqfh@kiuvf.fr"
	/// </code>
	/// </example>
	/// <seealso cref="GenerateEmailAddressWithName"/>
	/// <seealso cref="GenerateDomainExtension"/>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GenerateEmailAddress), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string GenerateEmailAddress()
	{
		var username = GenerateWord(5, 25, 'a', 'z');
		var domain = GenerateWord(5, 15, 'a', 'z');
		var extension = GenerateDomainExtension();

		return string.Create(
			username.Length + domain.Length + extension.Length + 2,
			(username, domain, extension),
			static (span, state) =>
			{
				var position = 0;

				state.username.AsSpan().CopyTo(span);
				position += state.username.Length;

				span[position++] = '@';

				state.domain.AsSpan().CopyTo(span[position..]);
				position += state.domain.Length;

				span[position++] = '.';

				state.extension.AsSpan().CopyTo(span[position..]);
			});
	}

	/// <summary>
	/// Generates a random value from the specified enum type.
	/// </summary>
	/// <typeparam name="TEnum">The enum type to generate a random value from.</typeparam>
	/// <returns>A random value from <typeparamref name="TEnum"/>.</returns>
	/// <exception cref="InvalidOperationException">Thrown when the enum has no defined values.</exception>
	/// <example>
	/// <code>
	/// DayOfWeek randomDay = RandomData.GenerateEnum&lt;DayOfWeek&gt;();
	/// // Output: Wednesday
	/// </code>
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GenerateEnum), "Copilot Agent", "07/10/2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, Status = Status.New)]
	public static TEnum GenerateEnum<TEnum>() where TEnum : struct, Enum
	{
		var values = Enum.GetValues<TEnum>();

		if (values.Length == 0)
		{
			ExceptionThrower.ThrowInvalidOperationException(string.Format(CultureInfo.InvariantCulture, _errorEnumHasNoDefinedValues, Array.Empty<object>()));
		}

		var randomIndex = RandomNumberGenerator.GetInt32(0, values.Length);

		return values[randomIndex];
	}

	/// <summary>
	/// Generates a file with random content.
	/// </summary>
	/// <param name="fileName">The name of the file to generate.</param>
	/// <param name="fileLength">The length of the file in characters. Default is <see cref="DefaultFileLength"/>.</param>
	/// <returns>The path to the generated file.</returns>
	/// <remarks>
	/// This method uses <see cref="GenerateCharacter()"/> to generate random content for the file.
	/// </remarks>
	/// <example>Output: C:\\Users\\user folder\\AppData\\Roaming\\UnitTest.test</example>
	[Information(nameof(GenerateFile), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static string GenerateFile([NotNull] string fileName, int fileLength = DefaultFileLength)
	{
		fileName = fileName.ArgumentNotNullOrEmpty(trim: true);
		fileLength = fileLength.ArgumentInRange(min: 1, defaultValue: DefaultFileLength);

		CreateFile(fileName, fileLength);

		return fileName;
	}

	/// <summary>
	/// Generates a specified number of files with random content, each having a specified length and file extension.
	/// </summary>
	/// <param name="count">The number of files to generate. Default is 1.</param>
	/// <param name="fileLength">The length of each file in characters. Default is <see cref="DefaultFileLength"/>.</param>
	/// <param name="fileExtension">The file extension for each generated file. Default is <see cref="DefaultFileExtension"/>.</param>
	/// <returns>A tuple containing the path where files are generated and a read-only collection of the names of the generated files.</returns>
	[Information(nameof(GenerateFiles), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static (string Path, ReadOnlyCollection<string> Files) GenerateFiles(int count = 2, int fileLength = DefaultFileLength, string fileExtension = DefaultFileExtension)
	{
		count = count.ArgumentInRange(min: 1, defaultValue: 2);
		fileLength = fileLength.ArgumentInRange(min: 1, defaultValue: DefaultFileLength);
		fileExtension = fileExtension.ArgumentNotNullOrEmpty(defaultValue: DefaultFileExtension);

		var files = new List<string>(count);

		for (var fileIndex = 0; fileIndex < count; fileIndex++)
		{
			files.Add(GenerateFile(GenerateRandomFileName(fileNameLength: 25, extension: fileExtension), fileLength));
		}

		return (Path.GetTempPath(), files.ToReadOnlyCollection());
	}

	/// <summary>
	/// Generates a specified number of files with random content at the given path, each having a specified length and file extension.
	/// </summary>
	/// <param name="path">The directory path where the files will be generated. Must not be null.</param>
	/// <param name="count">The number of files to generate. Default is 100.</param>
	/// <param name="fileLength">The length of each file in characters. Default is <see cref="DefaultFileLength"/>.</param>
	/// <remarks>
	/// This method leverages <see cref="CreateFile"/> for file creation and GenerateRandomFileName to generate unique file names.
	/// </remarks>
	/// <example>Output: [0]: "c:\\temp\\dobybcyx.lj"  [1]: "c:\\temp\\zo2ggwub.3ro"</example>
	[Information(nameof(GenerateFiles), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static ReadOnlyCollection<string> GenerateFiles([NotNull] string path, int count = 100, int fileLength = DefaultFileLength)
	{
		path = path.ArgumentNotNullOrEmpty();
		count = count.ArgumentInRange(min: 1, defaultValue: 2);
		fileLength = fileLength.ArgumentInRange(min: 1, defaultValue: DefaultFileLength);

		_ = Directory.CreateDirectory(path);

		var files = new List<string>(count);

		for (var fileCount = 0; fileCount < count; fileCount++)
		{
			var fileName = GenerateRandomFileName(path);

			CreateFile(fileName, fileLength);

			files.Add(fileName);
		}

		return files.ToReadOnlyCollection();
	}

	/// <summary>
	/// Generates a random first name from a predefined list from a pool containing over 1,800 names.
	/// </summary>
	/// <returns>A string representing a random first name.</returns>
	/// <remarks>
	/// This method selects a random first name from a predefined list using the PickRandom{T}(IEnumerable{T}) extension method on <see cref="_firstNames"/>.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GenerateFirstName), "David McCarter", "3/11/2023", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string? GenerateFirstName()
	{
		var names = _firstNames.Value;

		return names[GenerateInteger(0, names.Length - 1)];
	}

	/// <summary>
	/// Generates a new GUID value.
	/// </summary>
	/// <returns>A new <see cref="Guid"/>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GenerateGuid), "Copilot Agent", "07/10/2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, Status = Status.New)]
	public static Guid GenerateGuid()
	{
		return Guid.NewGuid();
	}

	/// <summary>
	/// Generates a random hexadecimal hash string of the specified length.
	/// </summary>
	/// <param name="length">The length of the hash string in characters. Must be at least 1 and at most 128. Default is 32.</param>
	/// <returns>A random hexadecimal hash string.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GenerateHashString), "Copilot Agent", "07/10/2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
	public static string GenerateHashString(int length = 32)
	{
		length = length.ArgumentInRange(min: 1, max: 128, defaultValue: 32);

		var byteCount = (length + 1) / 2;
		Span<byte> bytes = stackalloc byte[byteCount];
		RandomNumberGenerator.Fill(bytes);

		return Convert.ToHexStringLower(bytes)[..length];
	}

	/// <summary>
	/// Generates a random integer within a specified range.
	/// </summary>
	/// <param name="min">The inclusive lower bound of the random number returned. Default is <see cref="int.MinValue"/>.</param>
	/// <param name="max">The exclusive upper bound of the random number returned. Must be greater than or equal to <paramref name="min"/>. Default is <see cref="int.MaxValue"/>.</param>
	/// <returns>A 32-bit signed integer greater than or equal to <paramref name="min"/> and less than <paramref name="max"/>.</returns>
	/// <exception cref="ArgumentOutOfRangeException"><paramref name="min"/> is greater than <paramref name="max"/>.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GenerateInteger), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static int GenerateInteger(in int min = int.MinValue, int max = int.MaxValue)
	{
		//Ensure maxLength is +1 of minLength so the _randomNumberGenerator does not cause an exception.
		max = max.EnsureMinimum(min + 1);

		return RandomNumberGenerator.GetInt32(min, max);
	}

	/// <summary>
	/// Generates a random IPv4 address string.
	/// </summary>
	/// <returns>A string representing a random IPv4 address (e.g., "192.168.1.100").</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GenerateIPv4Address), "Copilot Agent", "07/10/2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
	public static string GenerateIPv4Address()
	{
		Span<byte> octets = stackalloc byte[4];
		RandomNumberGenerator.Fill(octets);

		return $"{octets[0]}.{octets[1]}.{octets[2]}.{octets[3]}";
	}

	/// <summary>
	/// Generates a random IPv6 address string.
	/// </summary>
	/// <returns>A string representing a random IPv6 address (e.g., "2001:0db8:85a3:0000:0000:8a2e:0370:7334").</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GenerateIPv6Address), "Copilot Agent", "07/10/2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
	public static string GenerateIPv6Address()
	{
		Span<byte> bytes = stackalloc byte[16];
		RandomNumberGenerator.Fill(bytes);

		return $"{bytes[0]:x2}{bytes[1]:x2}:{bytes[2]:x2}{bytes[3]:x2}:{bytes[4]:x2}{bytes[5]:x2}:{bytes[6]:x2}{bytes[7]:x2}:{bytes[8]:x2}{bytes[9]:x2}:{bytes[10]:x2}{bytes[11]:x2}:{bytes[12]:x2}{bytes[13]:x2}:{bytes[14]:x2}{bytes[15]:x2}";
	}

	/// <summary>
	/// Generates a random JSON object string with the specified number of properties.
	/// </summary>
	/// <param name="propertyCount">The number of properties in the JSON object. Must be at least 1. Default is 5.</param>
	/// <returns>A random JSON object string.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GenerateJsonObject), "Copilot Agent", "07/10/2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
	public static string GenerateJsonObject(int propertyCount = 5)
	{
		propertyCount = propertyCount.ArgumentInRange(min: 1, defaultValue: 5);

		var sb = _stringBuilderPool.Get();

		try
		{
			_ = sb.Append(Core.ControlChars.StartBrace);

			for (var propertyIndex = 0; propertyIndex < propertyCount; propertyIndex++)
			{
				if (propertyIndex > 0)
				{
					_ = sb.Append(Core.ControlChars.Comma);
				}

				var key = GenerateWord(5, 10, 'a', 'z');
				var value = GenerateWord(5, 15, 'a', 'z');

				_ = sb.Append(Core.ControlChars.Quote);
				_ = sb.Append(key);
				_ = sb.Append(Core.ControlChars.Quote);
				_ = sb.Append(Core.ControlChars.Colon);
				_ = sb.Append(Core.ControlChars.Quote);
				_ = sb.Append(value);
				_ = sb.Append(Core.ControlChars.Quote);
			}

			_ = sb.Append(Core.ControlChars.EndBrace);

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb.Clear());
		}
	}

	/// <summary>
	/// Generates a unique key using the <see cref="KeyGenerator"/>.
	/// </summary>
	/// <returns>A unique key as a string.</returns>
	/// <example>Output: f7f0af78003d4ab194b5a4024d02112a</example>
	[Information(nameof(GenerateKey), "David McCarter", "1/19/2019", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static string GenerateKey()
	{
		return KeyGenerator.GenerateKey();
	}

	/// <summary>
	/// Generates a random last name from a predefined list from a pool containing over 2,000 names.
	/// </summary>
	/// <returns>A string representing a random last name.</returns>
	/// <remarks>
	/// This method selects a random last name from a predefined list using the PickRandom{T}System.Collections.Generic.IEnumerable{T} extension method on <see cref="_lastNames"/>.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GenerateLastName), "David McCarter", "3/11/2023", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string? GenerateLastName()
	{
		var names = _lastNames.Value;

		return names[GenerateInteger(0, names.Length - 1)];
	}

	/// <summary>
	/// Generates a byte array of a specified size filled with non-zero cryptographically secure random data.
	/// </summary>
	/// <param name="count">The number of bytes to generate in the array. Must be at least 1.</param>
	/// <returns>A byte array of the specified size filled with non-zero cryptographically secure random bytes.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="count"/> is less than 1.</exception>
	/// <remarks>
	/// <para>
	/// This method creates a byte array of the exact size specified by <paramref name="count"/> and 
	/// fills it with non-zero cryptographically secure random bytes using RandomNumberGenerator.GetNonZeroBytes.
	/// </para>
	/// <para>
	/// Unlike <see cref="GenerateByteArray"/>, this method ensures that none of the generated bytes have a value of zero,
	/// which can be useful for certain cryptographic operations or when zero values would create issues.
	/// </para>
	/// <para>
	/// The method employs locking around the <see cref="RandomNumberGenerator.GetNonZeroBytes(byte[])"/> call
	/// to ensure thread safety when accessed concurrently from multiple threads.
	/// </para>
	/// <para>
	/// This implementation is optimized with <see cref="MethodImplOptions.AggressiveInlining"/> to 
	/// improve performance in high-frequency scenarios. The method has been fully tested, optimized,
	/// and benchmarked as indicated by the Information attribute.
	/// </para>
	/// </remarks>
	/// <example>
	/// <code>
	/// // Generate a 1KB array of random non-zero bytes
	/// byte[] nonZeroData = RandomData.GenerateNonZeroByteArray(1024);
	/// 
	/// // Use the non-zero bytes for scenarios requiring no zero bytes
	/// // For example, when generating keys where zero values might cause issues
	/// </code>
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GenerateNonZeroByteArray), "David McCarter", "10/21/2025", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static byte[] GenerateNonZeroByteArray(int count)
	{
		count = count.ArgumentInRange(min: 1, defaultValue: 1);

		var bytes = GC.AllocateUninitializedArray<byte>(count);

		(_threadLocalRng ??= RandomNumberGenerator.Create()).GetNonZeroBytes(bytes);

		return bytes;
	}

	/// <summary>
	/// Generates a string representation of a random number with the specified length.
	/// </summary>
	/// <param name="length">The length of the number to generate. Default is 1.</param>
	/// <returns>A string containing a random number of the specified length.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="length"/> is less than 1.</exception>
	/// <remarks>
	/// This method uses <see cref="Random"/> for generating each digit of the number. Ensure that the <see cref="Random"/> instance is properly initialized to avoid generating predictable sequences.
	/// </remarks>
	/// <example>Output: "446085072052112"</example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GenerateNumber), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string GenerateNumber(int length = 1)
	{
		length = length.ArgumentInRange(min: 1, defaultValue: 1);

		// Fill all bytes in a single RNG call, map each to an ASCII digit '0'–'9' via modulo,
		// then build the string from a span — avoids N individual GetInt32 calls,
		// the StringBuilder pool round-trip, and the redundant Trim() allocation.
		const int stackAllocThreshold = 256;

		byte[]? rentedBytes = null;
		char[]? rentedChars = null;

		var bytes = length <= stackAllocThreshold
			? stackalloc byte[length]
			: (rentedBytes = ArrayPool<byte>.Shared.Rent(length)).AsSpan(0, length);

		var chars = length <= stackAllocThreshold
			? stackalloc char[length]
			: (rentedChars = ArrayPool<char>.Shared.Rent(length)).AsSpan(0, length);

		try
		{
			RandomNumberGenerator.Fill(bytes);

			for (var digitIndex = 0; digitIndex < length; digitIndex++)
			{
				chars[digitIndex] = (char)('0' + (bytes[digitIndex] % 10));
			}

			return new string(chars);
		}
		finally
		{
			if (rentedBytes is not null)
			{
				ArrayPool<byte>.Shared.Return(rentedBytes);
			}

			if (rentedChars is not null)
			{
				ArrayPool<char>.Shared.Return(rentedChars);
			}
		}
	}

	/// <summary>
	/// Generates a random paragraph with the specified number of sentences.
	/// </summary>
	/// <param name="sentenceCount">The number of sentences in the paragraph. Must be at least 1. Default is 5.</param>
	/// <param name="wordsPerSentence">The number of words per sentence. Must be at least 1. Default is 10.</param>
	/// <returns>A random paragraph with multiple sentences.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GenerateParagraph), "Copilot Agent", "07/10/2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
	public static string GenerateParagraph(int sentenceCount = 5, int wordsPerSentence = 10)
	{
		sentenceCount = sentenceCount.ArgumentInRange(min: 1, defaultValue: 5);
		wordsPerSentence = wordsPerSentence.ArgumentInRange(min: 1, defaultValue: 10);

		var sb = _stringBuilderPool.Get();

		try
		{
			for (var sentenceIndex = 0; sentenceIndex < sentenceCount; sentenceIndex++)
			{
				if (sentenceIndex > 0)
				{
					_ = sb.Append(Core.ControlChars.Space);
				}

				_ = sb.Append(GenerateSentence(wordsPerSentence));
			}

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb.Clear());
		}
	}

	/// <summary>
	/// Generates a person of the specified type: RefTypes.Person, ValueTypes.Person, or PersonRecord.
	/// </summary>
	/// <typeparam name="TPerson">The type of person to generate.</typeparam>
	/// <param name="addressCount">The number of addresses to generate. Default is 2.</param>
	/// <param name="addressLength">The length of each address line. Default is 25.</param>
	/// <param name="countyProvinceLength">The length of the county or province name. Default is 20.</param>
	/// <returns>An instance of the specified person type populated with random data.</returns>
	/// <exception cref="NotSupportedException">Thrown if the type is not supported.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GeneratePerson), author: "David McCarter", createdOn: "6/4/2025", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static TPerson GeneratePerson<TPerson>(in int addressCount = 2, in int addressLength = 25, in int countyProvinceLength = 20)
	{
		return !_personFactories.TryGetValue(typeof(TPerson), out var factory)
			? throw new NotSupportedException(string.Format(CultureInfo.CurrentCulture, _errorTypeNotSupportedByMethod, typeof(TPerson).FullName, nameof(GeneratePerson)))
			: (TPerson)factory(addressCount, addressLength, countyProvinceLength);
	}

	/// <summary>
	/// Generates a collection of <see cref="PersonName"/> objects.
	/// </summary>
	/// <param name="count">The number of <see cref="PersonName"/> objects to generate. Default is 1.</param>
	/// <returns>A read-only collection of <see cref="PersonName"/> objects.</returns>
	/// <remarks>
	/// This method leverages <see cref="GenerateFirstName"/> and <see cref="GenerateLastName"/> to create each <see cref="PersonName"/>.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GeneratePersonNames), "David McCarter", "12/15/2023", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<PersonName> GeneratePersonNames(int count = 2)
	{
		count = count.ArgumentInRange(min: 1, defaultValue: 2);

		var names = new List<PersonName>(count);

		for (var nameIndex = 0; nameIndex < count; nameIndex++)
		{
			if (names.AddIfNotExists(GeneratePersonNameInternal()) is false)
			{
				nameIndex--;
			}
		}

		return names.ToReadOnlyCollection();
	}

	/// <summary>
	/// Generates a collection of <see cref="PersonRecord"/> objects.
	/// </summary>
	/// <param name="count">The number of <see cref="PersonRecord"/> objects to generate. Default is 1.</param>
	/// <returns>A read-only collection of <see cref="PersonRecord"/> objects.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GeneratePersonRecordCollection), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<PersonRecord> GeneratePersonRecordCollection(int count = 2)
	{
		count = count.ArgumentInRange(min: 1, defaultValue: 2);

		var records = new List<PersonRecord>(count);

		for (var recordIndex = 0; recordIndex < count; recordIndex++)
		{
			records.Add(GeneratePersonRecord());
		}

		return records.ToReadOnlyCollection();
	}

	/// <summary>
	/// Generates a read-only collection of <see cref="Person"/> objects.
	/// </summary>
	/// <param name="count">The number of <see cref="Person"/> objects to generate. Default is 1.</param>
	/// <returns>A read-only collection of <see cref="Person"/> objects.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GeneratePersonRefCollection), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<Person> GeneratePersonRefCollection(int count = 2)
	{
		count = count.ArgumentInRange(min: 1, defaultValue: 2);

		var people = new List<Person>(count);

		for (var index = 0; index < count; index++)
		{
			people.Add(GeneratePersonRef());
		}

		return people.ToReadOnlyCollection();
	}

	/// <summary>
	/// Generates a read-only collection of <see cref="Models.ValueTypes.Person"/> objects.
	/// </summary>
	/// <param name="count">The number of <see cref="Models.ValueTypes.Person"/> objects to generate. Default is 1.</param>
	/// <returns>A read-only collection of <see cref="Models.ValueTypes.Person"/> objects.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GeneratePersonValCollection), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<Models.ValueTypes.Person> GeneratePersonValCollection(int count = 2)
	{
		count = count.ArgumentInRange(min: 1, defaultValue: 2);

		var people = new List<Models.ValueTypes.Person>(count);

		for (var index = 0; index < count; index++)
		{
			people.Add(GeneratePersonVal());
		}

		return people.ToReadOnlyCollection();
	}

	/// <summary>
	/// Generates a phone number for the specified <paramref name="country"/>. Optionally includes the country code.
	/// </summary>
	/// <param name="country">The country for which to generate the phone number. Must not be null.</param>
	/// <param name="includeCountryCode">If set to <c>true</c>, includes the country code in the generated phone number.</param>
	/// <returns>A string representing the generated phone number.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="country"/> is null.</exception>
	/// <remarks>
	/// This method utilizes the <see cref="Country"/> enumeration to determine the format of the generated phone number.
	/// </remarks>
	/// <example>Output for Taiwan: 886-352346002</example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GeneratePhoneNumber), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string GeneratePhoneNumber(Country country, bool includeCountryCode = false)
	{
		country = country.ArgumentNotNull();

		return includeCountryCode
			? $"{GetPhoneCode(country)}-{GenerateNumber(country.PhoneNumberLength)}"
			: GenerateNumber(country.PhoneNumberLength);
	}

	/// <summary>
	/// Generates a phone number for the specified country. Optionally includes the country code.
	/// </summary>
	/// <param name="countryName">The country for which to generate the phone number. Uses the <see cref="CountryName"/> enum.</param>
	/// <param name="includeCountryCode">If set to <c>true</c>, includes the country code in the generated phone number.</param>
	/// <returns>A string representing the generated phone number.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="countryName"/> is null.</exception>
	/// <remarks>
	/// This method utilizes the <see cref="CountryName"/> enumeration to determine the format of the generated phone number.
	/// </remarks>
	/// <example>Output for Taiwan: 886-352346002</example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GeneratePhoneNumber), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string GeneratePhoneNumber(CountryName countryName, bool includeCountryCode = false)
	{
		countryName = countryName.ArgumentDefined();

		var country = CountryRepository.GetCountry(countryName);

		return includeCountryCode
			? $"{GetPhoneCode(country)}-{GenerateNumber(GetCountryPhoneLength(country))}"
			: GenerateNumber(GetCountryPhoneLength(country));
	}

	/// <summary>
	/// Generates a random file name with the specified length and extension in the temp path.
	/// </summary>
	/// <param name="fileNameLength">The length of the file name. Default is 10.</param>
	/// <param name="extension">The file extension. Default is <see cref="DefaultFileExtension"/>.</param>
	/// <returns>A random file name with the specified length and extension.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="extension"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GenerateRandomFileName), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string GenerateRandomFileName(int fileNameLength = 10, [NotNull] string extension = DefaultFileExtension)
	{
		fileNameLength = fileNameLength.ArgumentInRange(min: 1, max: 256);
		extension = extension.ArgumentNotNullOrEmpty(defaultValue: DefaultFileExtension);

		var fileName = string.Concat(GenerateFileNameWord(fileNameLength), Core.ControlChars.Dot.ToString(), extension);

		return Path.Combine(_tempPath, fileName);
	}

	/// <summary>
	/// Generates a random file name with the specified length and extension at the given path.
	/// </summary>
	/// <param name="path">The path where the file will be generated. Must not be null.</param>
	/// <param name="fileNameLength">The length of the file name. Default is 10.</param>
	/// <param name="extension">The file extension. Default is <see cref="DefaultFileExtension"/>.</param>
	/// <returns>A string representing the full path of the generated file.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="path"/> or <paramref name="extension"/> is null.</exception>
	/// <example>Output: c:\\temp\\FFDHRBMDXP.dotnettips</example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GenerateRandomFileName), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string GenerateRandomFileName([NotNull] string path, int fileNameLength = 10, [NotNull] string extension = DefaultFileExtension)
	{
		fileNameLength = fileNameLength.ArgumentInRange(min: 1, max: 256);
		extension = extension.ArgumentNotNullOrEmpty(defaultValue: DefaultFileExtension);

		var fileName = string.Concat(GenerateFileNameWord(fileNameLength), Core.ControlChars.Dot.ToString(), extension);

		return Path.Combine(path, fileName);
	}

	/// <summary>
	/// Generates random real location data including country, state, and city.
	/// </summary>
	/// <returns>A tuple containing a <see cref="Country"/>, <see cref="State"/>, and <see cref="City"/>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[SuppressMessage("Security", "CA5394:Do not use insecure randomness", Justification = "Random.Shared is appropriate here — location selection is non-security random sampling, not cryptographic.")]
	[Information(nameof(GenerateRandomLocationData), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static (Country country, State state, City city) GenerateRandomLocationData()
	{
		var (countries, states, cities) = _locationData.Value;

		var countryIndex = Random.Shared.Next(countries.Length);
		var country = countries[countryIndex];

		State? state = null;
		City? city = null;

		var countryStates = states[countryIndex];

		if (countryStates.Length > 0)
		{
			var stateIndex = Random.Shared.Next(countryStates.Length);
			state = countryStates[stateIndex];

			var stateCities = cities[countryIndex][stateIndex];

			if (stateCities.Length > 0)
			{
				city = stateCities[Random.Shared.Next(stateCities.Length)];
			}
		}

		return (country!, state!, city!);
	}

	/// <summary>
	/// Generates random person data including first name, last name, and email.
	/// </summary>
	/// <returns>A <see cref="PersonData"/> object populated with random values.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GenerateRandomPersonData), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static PersonData GenerateRandomPersonData()
	{
		var (country, _, _) = GenerateRandomLocationData();
		var (firstName, lastName) = GenerateRandomPersonName();

		var data = new PersonData
		{
			BornOn = DateTimeOffset.Now.Subtract(new TimeSpan(365 * GenerateInteger(1, 90), 0, 0, 0)),
			CellPhone = GenerateNumber(country.PhoneNumberLength),
			Country = country,
			Email = GenerateEmailAddressWithName(firstName!, lastName!),
			FirstName = firstName!,
			LastName = lastName!,
			Phone = GenerateNumber(country.PhoneNumberLength),
		};

		return data;
	}

	/// <summary>
	/// Generates a random person's first and last name.
	/// </summary>
	/// <returns>A tuple containing the first name and last name of a person. The first name is generated using <see cref="GenerateFirstName"/> and the last name is generated using <see cref="GenerateLastName"/>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GenerateRandomLocationData), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static (string? firstName, string? lastName) GenerateRandomPersonName()
	{
		return (GenerateFirstName(), GenerateLastName());
	}

	/// <summary>
	/// Generates a relative URL.
	/// </summary>
	/// <returns>A string representing a relative URL.</returns>
	/// <remarks>
	/// This method can be used to generate relative URLs for web applications. It's a part of the <see cref="RandomData"/> class which provides various methods for generating random data.
	/// </remarks>
	/// <example>Output:"/ljsylu/rsglcurkiylqld/wejdbuainlgjofnv/uwbrjftyt/"</example>
	[SuppressMessage("Security", "CA5394:Do not use insecure randomness", Justification = "Random.Shared is appropriate here — URL path generation is non-security random sampling, not cryptographic.")]
	[Information(nameof(GenerateRelativeUrl), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string GenerateRelativeUrl()
	{
		var sb = _stringBuilderPool.Get();

		try
		{
			var segmentCount = Random.Shared.Next(1, 10);

			for (var segmentIndex = 0; segmentIndex < segmentCount; segmentIndex++)
			{
				var segmentLength = Random.Shared.Next(1, 26);

				_ = sb.Append('/');

				for (var charIndex = 0; charIndex < segmentLength; charIndex++)
				{
					_ = sb.Append((char)('a' + Random.Shared.Next(26)));
				}
			}

			_ = sb.Append('/');

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb.Clear());
		}
	}

	/// <summary>
	/// Generates a random sentence with the specified number of words.
	/// </summary>
	/// <param name="wordCount">The number of words in the sentence. Must be at least 1. Default is 10.</param>
	/// <returns>A random sentence with proper capitalization and punctuation.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GenerateSentence), "Copilot Agent", "07/10/2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
	public static string GenerateSentence(int wordCount = 10)
	{
		wordCount = wordCount.ArgumentInRange(min: 1, defaultValue: 10);

		var sb = _stringBuilderPool.Get();

		try
		{
			for (var wordIndex = 0; wordIndex < wordCount; wordIndex++)
			{
				var word = GenerateWord(3, 10, 'a', 'z');

				if (wordIndex == 0)
				{
					_ = sb.Append(char.ToUpperInvariant(word[0]));
					_ = sb.Append(word.AsSpan(1));
				}
				else
				{
					_ = sb.Append(Core.ControlChars.Space);
					_ = sb.Append(word);
				}
			}

			_ = sb.Append(Core.ControlChars.Dot);

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb.Clear());
		}
	}

	/// <summary>
	/// Generates a temporary file with random content.
	/// </summary>
	/// <param name="fileLength">The length of the file in characters. Default is <see cref="DefaultFileLength"/>.</param>
	/// <returns>The path to the generated temporary file.</returns>
	/// <example>Output: C:\\Users\\user folder\\AppData\\Local\\Temp\\OFQCKBRAKQ.dotnettips.temp</example>
	[SuppressMessage("Security", "CA5394:Do not use insecure randomness", Justification = "Random.Shared is appropriate here — file content generation is non-security random sampling, not cryptographic.")]
	[Information(nameof(GenerateTempFile), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string GenerateTempFile(int fileLength = DefaultFileLength)
	{
		fileLength = fileLength.ArgumentInRange(min: 1, defaultValue: DefaultFileLength);

		var fileName = GenerateRandomFileName();
		var buffer = ArrayPool<byte>.Shared.Rent(fileLength);

		try
		{
			var content = buffer.AsSpan(0, fileLength);

			Random.Shared.NextBytes(content);

			// Map each byte to a printable lowercase ASCII character ('a'–'z').
			for (var byteIndex = 0; byteIndex < fileLength; byteIndex++)
			{
				content[byteIndex] = (byte)('a' + (content[byteIndex] % 26));
			}

			using var stream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);

			stream.Write(content);
		}
		finally
		{
			ArrayPool<byte>.Shared.Return(buffer);
		}

		return fileName;
	}

	/// <summary>
	/// Generates a random <see cref="TimeOnly"/> within a specified range.
	/// </summary>
	/// <param name="minValue">The minimum time. Defaults to midnight (00:00:00).</param>
	/// <param name="maxValue">The maximum time. Defaults to 23:59:59.9999999.</param>
	/// <returns>A random <see cref="TimeOnly"/> between <paramref name="minValue"/> and <paramref name="maxValue"/>.</returns>
	/// <example>
	/// <code>
	/// TimeOnly randomTime = RandomData.GenerateTimeOnly();
	/// // Output: 14:32:18
	/// </code>
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GenerateTimeOnly), "Copilot Agent", "07/10/2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, Status = Status.New)]
	public static TimeOnly GenerateTimeOnly(TimeOnly? minValue = null, TimeOnly? maxValue = null)
	{
		var min = minValue ?? TimeOnly.MinValue;
		var max = maxValue ?? TimeOnly.MaxValue;

		var range = max.Ticks - min.Ticks;

		if (range <= 0)
		{
			return min;
		}

		// Generate a cryptographically secure random long by combining two 32-bit integers
		Span<byte> buffer = stackalloc byte[8];
		RandomNumberGenerator.Fill(buffer);
		var randomValue = Math.Abs(BitConverter.ToInt64(buffer)) % (range + 1);

		return min.Add(TimeSpan.FromTicks(randomValue));
	}

	/// <summary>
	/// Generates a random <see cref="TimeSpan"/> within a specified range.
	/// </summary>
	/// <param name="minValue">The minimum time span. Defaults to <see cref="TimeSpan.Zero"/>.</param>
	/// <param name="maxValue">The maximum time span. Defaults to 365 days.</param>
	/// <returns>A random <see cref="TimeSpan"/> between <paramref name="minValue"/> and <paramref name="maxValue"/>.</returns>
	/// <example>
	/// <code>
	/// TimeSpan randomDuration = RandomData.GenerateTimeSpan();
	/// // Output: 15.07:32:18.1234567
	/// </code>
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GenerateTimeSpan), "Copilot Agent", "07/10/2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, Status = Status.New)]
	public static TimeSpan GenerateTimeSpan(TimeSpan? minValue = null, TimeSpan? maxValue = null)
	{
		var min = minValue ?? TimeSpan.Zero;
		var max = maxValue ?? TimeSpan.FromDays(365);

		var range = (max - min).Ticks;

		if (range <= 0)
		{
			return min;
		}

		// Generate a cryptographically secure random long by combining two 32-bit integers
		Span<byte> buffer = stackalloc byte[8];
		RandomNumberGenerator.Fill(buffer);
		var randomValue = Math.Abs(BitConverter.ToInt64(buffer)) % (range + 1);

		return min.Add(TimeSpan.FromTicks(randomValue));
	}

	/// <summary>
	/// Generates a full URL by combining a randomly generated host name with a randomly generated relative URL.
	/// </summary>
	/// <returns>A string representing the full URL.</returns>
	/// <remarks>
	/// This method combines the output of <see cref="GenerateUrlHostName"/> and <see cref="GenerateRelativeUrl"/> to construct the full URL.
	/// </remarks>
	/// <example>Output: https://www.rp.red/wyfkxbfft/pqypmdstoydnootvdvnsqkn/</example>
	[Information(nameof(GenerateUrl), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string GenerateUrl()
	{
		return string.Concat(GenerateUrlHostName(), GenerateRelativeUrl());
	}

	/// <summary>
	/// Generates a URL fragment.
	/// </summary>
	/// <returns>A string representing a URL fragment.</returns>
	/// <example>Output: /rregyyjxpjiats</example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GenerateUrlFragment), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string GenerateUrlFragment()
	{
		return string.Concat("/", GenerateWord(1, 25, 'a', 'z'));
	}

	/// <summary>
	/// Generates a URL host name with HTTPS protocol.
	/// </summary>
	/// <returns>A string representing a URL host name prefixed with HTTPS protocol.</returns>
	/// <remarks>
	/// This method constructs a full URL host name by prefixing the HTTPS protocol to the host name generated by <see cref="GenerateUrlHostNameNoProtocol"/>.
	/// </remarks>
	/// <example>Output: https://www.ukrsusbrtjijfktfj.shouji</example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GenerateUrlHostName), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string GenerateUrlHostName()
	{
		return string.Concat("https://", GenerateUrlHostNameNoProtocol());
	}

	/// <summary>
	/// Generates a URL host name without the protocol (such as http:// or https://).
	/// </summary>
	/// <returns>A string representing a URL host name in the format "www.{random-domain}.{tld}". The domain name is 
	/// generated using <see cref="GenerateWord(int, int, char, char)"/> with a length between 1-25 lowercase letters, 
	/// and the top-level domain is generated using <see cref="GenerateUrlHostNameNoSubDomain"/>.</returns>
	/// <remarks>
	/// This method generates realistic-looking domain names that can be used for testing and simulation purposes.
	/// It always prefixes the domain with "www." and uses randomly generated strings for the domain name.
	/// </remarks>
	/// <example>
	/// <code>
	/// string hostName = RandomData.GenerateUrlHostNameNoProtocol();
	/// // Example output: "www.txtkixvsxgryixbwrtje.shangrila"
	/// </code>
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GenerateUrlHostNameNoProtocol), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string GenerateUrlHostNameNoProtocol()
	{
		return string.Concat("www.", GenerateWord(1, 25, 'a', 'z'), ".", GenerateUrlHostNameNoSubDomain());
	}

	/// <summary>
	/// Generates a URL host name without the protocol by using a randomly generated domain extension.
	/// </summary>
	/// <returns>A string representing a URL host name without the protocol. The domain extension is generated using <see cref="GenerateDomainExtension"/>.</returns>
	/// <example>Output: dz</example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GenerateUrlHostNameNoSubDomain), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string GenerateUrlHostNameNoSubDomain()
	{
		return GenerateDomainExtension();
	}

	/// <summary>
	/// Generates a word of the specified length.
	/// </summary>
	/// <param name="length">The length of the word to generate. Default is 1.</param>
	/// <returns>A randomly generated word of the specified length.</returns>
	/// <remarks>
	/// This method utilizes <see cref="GenerateWord(int, int)"/> internally to generate a word within a specific range.
	/// </remarks>
	/// <example>Output: mL_g[E_E_CsoJvjshI]CFjFKa</example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GenerateWord), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string GenerateWord(int length = 1)
	{
		return GenerateWord(length, DefaultMinCharacter, DefaultMaxCharacter);
	}

	/// <summary>
	/// Generates a random word with a length between the specified minimum and maximum lengths.
	/// </summary>
	/// <param name="minLength">The minimum length of the word.</param>
	/// <param name="maxLength">The maximum length of the word.</param>
	/// <returns>A randomly generated word.</returns>
	/// <example>Output: anvpwufadtxpfysguavguwm</example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GenerateWord), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string GenerateWord(int minLength = 1, int maxLength = 1)
	{
		return GenerateWord(minLength, maxLength, DefaultMinCharacter, DefaultMaxCharacter);
	}

	/// <summary>
	/// Generates a word of the specified length using characters within the specified range.
	/// </summary>
	/// <param name="length">The length of the word to generate.</param>
	/// <param name="minCharacter">The minimum character to use for word generation. Default is 'a'.</param>
	/// <param name="maxCharacter">The maximum character to use for word generation. Default is 'Z'.</param>
	/// <returns>A randomly generated word.</returns>
	/// <remarks>
	/// This method utilizes the <see cref="Random"/> class for generating random characters within the specified range.
	/// </remarks>
	/// <example>Output: LBEEUMHHHK</example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GenerateWord), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string GenerateWord(int length = 1, char minCharacter = 'a', char maxCharacter = 'Z')
	{
		length = length.ArgumentInRange(min: 1, defaultValue: 1);

		var range = maxCharacter - minCharacter + 1;

		// stackalloc for small words (no heap); ArrayPool for large words to avoid untracked allocations.
		const int stackAllocThreshold = 256;

		if (length <= stackAllocThreshold)
		{
			Span<byte> randomBytes = stackalloc byte[length];
			Span<char> chars = stackalloc char[length];

			RandomNumberGenerator.Fill(randomBytes);
			FillWordChars(chars, randomBytes, minCharacter, range);

			return new string(chars);
		}

		var rentedBytes = ArrayPool<byte>.Shared.Rent(length);
		var rentedChars = ArrayPool<char>.Shared.Rent(length);

		try
		{
			RandomNumberGenerator.Fill(rentedBytes.AsSpan(0, length));
			FillWordChars(rentedChars.AsSpan(0, length), rentedBytes.AsSpan(0, length), minCharacter, range);

			return new string(rentedChars, 0, length);
		}
		finally
		{
			ArrayPool<byte>.Shared.Return(rentedBytes);
			ArrayPool<char>.Shared.Return(rentedChars);
		}
	}

	/// <summary>
	/// Generates a word with a random length within the specified range and character limits.
	/// </summary>
	/// <param name="minLength">The minimum length of the word. Must be greater than 0.</param>
	/// <param name="maxLength">The maximum length of the word. Must be greater than or equal to <paramref name="minLength"/>.</param>
	/// <param name="minCharacter">The minimum ASCII character to use for the word. Default is 'a'.</param>
	/// <param name="maxCharacter">The maximum ASCII character to use for the word. Default is 'Z'.</param>
	/// <returns>A randomly generated word.</returns>
	/// <remarks>
	/// This method utilizes the <see cref="Random"/> class for generating random characters within the specified range.
	/// </remarks>
	/// <example>Output: ACRNFTPAE</example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GenerateWord), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string GenerateWord(int minLength = 1, int maxLength = 1, char minCharacter = 'a', char maxCharacter = 'Z')
	{
		minLength = minLength.ArgumentInRange(1, defaultValue: 1);
		maxLength = maxLength.ArgumentInRange(1, defaultValue: 1);

		return GenerateWord(GenerateInteger(minLength, maxLength), minCharacter, maxCharacter);
	}

	/// <summary>
	/// Generates a collection of random words.
	/// </summary>
	/// <param name="count">The number of words to generate. Default is 1.</param>
	/// <param name="minLength">The minimum length of each word. Default is 1.</param>
	/// <param name="maxLength">The maximum length of each word. Default is 1.</param>
	/// <returns>A <see cref="ReadOnlyCollection{String}"/> containing the generated words.</returns>
	/// <remarks>
	/// This method utilizes <see cref="GenerateWord(int, int)"/> to generate each word in the collection.
	/// </remarks>
	/// <example>
	/// Output:
	/// [0]: "oKcMYETNvpiByRQVa^"
	/// [1]: "mnM\\wQwuluQ^VFxpOJEgLX"
	/// [2]: "Ad\\kCOMkmdK"
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GenerateWords), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<string> GenerateWords(int count = 1, int minLength = 1, int maxLength = 1)
	{
		count = count.ArgumentInRange(min: 1, defaultValue: 1);
		minLength = minLength.ArgumentInRange(min: 1, defaultValue: 1);
		maxLength = maxLength.ArgumentInRange(min: 1, defaultValue: 1);

		const char minChar = DefaultMinCharacter;
		const char maxChar = DefaultMaxCharacter;
		const int range = maxChar - minChar + 1;

		var (lengths, totalBytes) = ComputeWordLengths(count, minLength, maxLength);

		var rentedByteBuffer = ArrayPool<byte>.Shared.Rent(totalBytes);

		// Rent a single char buffer sized to the largest word; reuse it for every word to
		// avoid allocating a new char[] on each loop iteration (Issue 4).
		var rentedCharBuffer = ArrayPool<char>.Shared.Rent(maxLength);

		try
		{
			RandomNumberGenerator.Fill(rentedByteBuffer.AsSpan(0, totalBytes));

			var strings = new string[count];
			var byteOffset = 0;

			for (var wordIndex = 0; wordIndex < count; wordIndex++)
			{
				var length = lengths[wordIndex];
				var charSpan = rentedCharBuffer.AsSpan(0, length);
				FillWordChars(charSpan, rentedByteBuffer.AsSpan(byteOffset, length), minChar, range);
				strings[wordIndex] = new string(charSpan);
				byteOffset += length;
			}

			return new ReadOnlyCollection<string>(strings);
		}
		finally
		{
			ArrayPool<byte>.Shared.Return(rentedByteBuffer);
			ArrayPool<char>.Shared.Return(rentedCharBuffer);
		}
	}

	/// <summary>
	/// Creates a file with a specified length filled with random data.
	/// </summary>
	/// <param name="fileName">The name of the file to create. Cannot be null or empty.</param>
	/// <param name="fileLength">The length of the file in bytes. Defaults to <see cref="DefaultFileLength"/> if not specified.</param>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="fileName"/> is null.</exception>
	/// <exception cref="ArgumentException">Thrown when <paramref name="fileName"/> is empty.</exception>
	/// <remarks>
	/// This method uses <see cref="RandomNumberGenerator.Fill(Span{byte})"/> for generating random data to fill the file.
	/// A single pooled buffer is rented from <see cref="ArrayPool{T}.Shared"/> and reused for all writes,
	/// including the final partial block via a <see cref="Span{T}"/> slice — eliminating per-call allocations.
	/// </remarks>
	internal static void CreateFile([NotNull] string fileName, int fileLength = DefaultFileLength)
	{
		const int bufferSize = 4096; // Use a buffer size of 4KB.
		var iterations = fileLength / bufferSize;
		var remainingBytes = fileLength % bufferSize;
		var buffer = ArrayPool<byte>.Shared.Rent(bufferSize);

		try
		{
			using var fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None, bufferSize);

			for (var index = 0; index < iterations; index++)
			{
				RandomNumberGenerator.Fill(buffer.AsSpan(0, bufferSize));
				fileStream.Write(buffer, 0, bufferSize);
			}

			if (remainingBytes > 0)
			{
				RandomNumberGenerator.Fill(buffer.AsSpan(0, remainingBytes));
				fileStream.Write(buffer, 0, remainingBytes);
			}
		}
		finally
		{
			ArrayPool<byte>.Shared.Return(buffer);
		}
	}

	/// <summary>Appends the appropriate character for a postal-code format specifier to the StringBuilder.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(AppendPostalCodeFormatChar), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static void AppendPostalCodeFormatChar(StringBuilder sb, char character)
	{
		_ = character switch
		{
			'N' => sb.Append(GenerateNumber(1)),
			'A' => sb.Append(GenerateCharacter('A', 'Z')),
			_ => sb.Append(character),
		};
	}

	/// <summary>Replaces the CITY placeholder in the StringBuilder if city data is available.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ApplyCityReplacement), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static void ApplyCityReplacement(StringBuilder sb, string format, City? city)
	{
		if (city is not null && format.Contains("CITY", StringComparison.Ordinal))
		{
			_ = sb.Replace("CITY", city.Name);
		}
	}

	/// <summary>Builds address field values from the given country and lengths.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(BuildAddressComponents), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static AddressComponents BuildAddressComponents(Country country, int addressLength, int countyProvinceLength)
	{
		var (state, city) = PickStateAndCity(country);
		return new AddressComponents(
			Id: GenerateKey(),
			Address1: GenerateAddressLineOne(addressLength),
			Address2: GenerateAddressLineTwo(addressLength),
			CityName: GetCityName(city),
			CountryName: country.Name ?? Core.ControlChars.EmptyString,
			CountyProvince: GenerateWord(countyProvinceLength),
			Phone: GenerateNumber(country.PhoneNumberLength),
			PostalCode: GeneratePostalCode(country, city),
			StateName: GetStateName(state));
	}

	/// <summary>Pre-computes per-word lengths and the total byte count needed for <see cref="GenerateWords"/>.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ComputeWordLengths), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static (int[] Lengths, int TotalBytes) ComputeWordLengths(int count, int minLength, int maxLength)
	{
		var lengths = new int[count];
		var totalBytes = 0;

		for (var i = 0; i < count; i++)
		{
			var len = minLength == maxLength
				? minLength
				: RandomNumberGenerator.GetInt32(minLength, maxLength + 1);

			lengths[i] = len;
			totalBytes += len;
		}

		return (lengths, totalBytes);
	}

	/// <summary>Iterates the format string and fills the StringBuilder with generated postal-code characters.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(FillPostalCodeFromFormat), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static void FillPostalCodeFromFormat(StringBuilder sb, string format)
	{
		foreach (var character in format.AsSpan())
		{
			AppendPostalCodeFormatChar(sb, character);
		}
	}

	/// <summary>Fills <paramref name="chars"/> from <paramref name="randomBytes"/> using the given character range.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(FillWordChars), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static void FillWordChars(Span<char> chars, ReadOnlySpan<byte> randomBytes, char minCharacter, int range)
	{
		for (var i = 0; i < chars.Length; i++)
		{
			chars[i] = (char)(minCharacter + (randomBytes[i] % range));
		}
	}

	/// <summary>
	/// Generates the first line of an address.
	/// </summary>
	/// <param name="addressLength">The total desired length of the address line.</param>
	/// <returns>A string representing the first line of an address.</returns>
	/// <remarks>
	/// This method combines a number, generated by <see cref="GenerateNumber(int)"/>, and a word, generated by <see cref="GenerateWord(int)"/>, to form an address line.
	/// The address number is controlled by <see cref="AddressNumberCount"/>, ensuring the generated address line meets the specified length requirements.
	/// </remarks>
	private static string GenerateAddressLineOne(int addressLength)
	{
		return $"{GenerateNumber(AddressNumberCount)} {GenerateWord(addressLength - AddressNumberCount - 1)}";
	}

	/// <summary>
	/// Generates the second line of an address.
	/// </summary>
	/// <param name="addressLength">The total desired length of the address line.</param>
	/// <returns>A string representing the second line of an address.</returns>
	/// <remarks>
	/// This method combines a word, generated by <see cref="GenerateWord(int)"/>, and a number, generated by <see cref="GenerateNumber(int)"/>, to form an address line.
	/// The address number is controlled by <see cref="AddressNumberCount"/>, ensuring the generated address line meets the specified length requirements.
	/// </remarks>
	private static string GenerateAddressLineTwo(int addressLength)
	{
		return $"{GenerateWord(addressLength - AddressNumberCount - 1)} {GenerateNumber(AddressNumberCount)}";
	}

	/// <summary>
	/// Generates an email address using the provided first and last names. If either is null or empty, defaults are used.
	/// </summary>
	/// <param name="firstName">The first name to use in the email address. Defaults to "FIRSTNAME" if null or empty.</param>
	/// <param name="lastName">The last name to use in the email address. Defaults to "LASTNAME" if null or empty.</param>
	/// <returns>A string representing the generated email address.</returns>
	private static string GenerateEmailAddressWithName(string firstName, string lastName)
	{
		return $"{firstName.DefaultIfNullOrEmpty("FIRSTNAME")}.{lastName.DefaultIfNullOrEmpty("LASTNAME")}@{GenerateWord(5, 15, 'a', 'z')}.{GenerateDomainExtension()}";
	}

	/// <summary>
	/// Generates a random uppercase-letter word of the specified length for use in file names.
	/// Uses a stackalloc byte buffer for the RNG source and a pooled <see cref="char"/> array
	/// to map bytes to characters, avoiding all intermediate heap allocations.
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static string GenerateFileNameWord(int length)
	{
		const int range = DefaultMaxCharacterRandomFile - DefaultMinCharacterRandomFile + 1;

		Span<byte> randomBytes = stackalloc byte[length];
		RandomNumberGenerator.Fill(randomBytes);

		var charBuffer = ArrayPool<char>.Shared.Rent(length);

		try
		{
			for (var wordIndex = 0; wordIndex < length; wordIndex++)
			{
				charBuffer[wordIndex] = (char)(DefaultMinCharacterRandomFile + (randomBytes[wordIndex] % range));
			}

			return new string(charBuffer, 0, length);
		}
		finally
		{
			ArrayPool<char>.Shared.Return(charBuffer);
		}
	}

	/// <summary>Generates a single <see cref="PersonName"/> from the internal name pools.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GeneratePersonNameInternal), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static PersonName GeneratePersonNameInternal() =>
		new(_firstNames.Value.PickRandom() ?? Core.ControlChars.EmptyString, _lastNames.Value.PickRandom() ?? Core.ControlChars.EmptyString);

	/// <summary>
	/// Generates a <see cref="PersonRecord"/> with random data.
	/// </summary>
	/// <param name="addressCount">The number of addresses to generate for the person. Default is 2.</param>
	/// <param name="addressLength">The length of each address line. Default is 25.</param>
	/// <param name="countyProvinceLength">The length of the county or province name. Default is 20.</param>
	/// <returns>A <see cref="PersonRecord"/> populated with random data.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GeneratePersonRecord), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	private static PersonRecord GeneratePersonRecord(int addressCount = 2, in int addressLength = 25, in int countyProvinceLength = 20)
	{
		addressCount = addressCount.ArgumentInRange(min: 0, max: 100, defaultValue: 2);

		var personData = GenerateRandomPersonData();

		var person = new PersonRecord()
		{
			Addresses = new Collection<AddressRecord>([.. GenerateAddressCollection<AddressRecord>(personData.Country, addressCount, addressLength, countyProvinceLength)]),
			BornOn = personData.BornOn,
			CellPhone = personData.CellPhone,
			Email = personData.Email,
			FirstName = personData.FirstName,
			Id = GenerateKey(),
			LastName = personData.LastName,
			Phone = personData.Phone,
		};

		return person;
	}

	/// <summary>
	/// Generates a <see cref="Person"/> object with random data.
	/// </summary>
	/// <param name="addressCount">The number of addresses to generate for the person. Default is 2.</param>
	/// <param name="addressLength">The length of each address line. Default is 25.</param>
	/// <param name="countyProvinceLength">The length of the county or province name. Default is 20.</param>
	/// <returns>A <see cref="Person"/> object populated with random address data.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GeneratePersonRef), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	private static Person GeneratePersonRef(int addressCount = 2, int addressLength = 25, int countyProvinceLength = 20)
	{
		addressCount = addressCount.ArgumentInRange(min: 0, defaultValue: 2);
		addressLength = addressLength.ArgumentInRange(min: 5, max: 100);
		countyProvinceLength = countyProvinceLength.ArgumentInRange(min: 5, max: 50);

		var personData = GenerateRandomPersonData();

		var person = new Person()
		{
			Addresses = GenerateAddressCollection<Address>(personData.Country, addressCount, addressLength, countyProvinceLength),
			BornOn = personData.BornOn,
			CellPhone = personData.CellPhone,
			Email = personData.Email,
			FirstName = personData.FirstName,
			Id = GenerateKey(),
			LastName = personData.LastName,
			Phone = personData.Phone,
		};

		return person;
	}

	/// <summary>
	/// Generates a <see cref="Models.ValueTypes.Person"/> object with specified parameters.
	/// </summary>
	/// <param name="addressCount">The number of addresses to generate for the person. Default is 2.</param>
	/// <param name="addressLength">The length of each address line. Default is 25.</param>
	/// <param name="countyProvinceLength">The length of the county or province name. Default is 20.</param>
	/// <returns>A <see cref="Models.ValueTypes.Person"/> object.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GeneratePersonVal), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	private static Models.ValueTypes.Person GeneratePersonVal(int addressCount = 2, int addressLength = 25, int countyProvinceLength = 20)
	{
		addressCount = addressCount.ArgumentInRange(min: 0, defaultValue: 2);
		addressLength = addressLength.ArgumentInRange(min: 5, max: 100);
		countyProvinceLength = countyProvinceLength.ArgumentInRange(min: 5, max: 50);

		var personData = GenerateRandomPersonData();

		var person = new Models.ValueTypes.Person()
		{
			Addresses = GenerateAddressCollection<Models.ValueTypes.Address>(personData.Country, addressCount, addressLength, countyProvinceLength),
			BornOn = personData.BornOn,
			CellPhone = personData.CellPhone,
			Email = personData.Email,
			FirstName = personData.FirstName,
			Id = GenerateKey(),
			LastName = personData.LastName,
			Phone = personData.Phone,
		};

		return person;
	}

	/// <summary>
	/// Generates a postal code for the specified country and city.
	/// </summary>
	/// <param name="country">The country for which to generate a postal code. Cannot be null.</param>
	/// <param name="city">The city within the country for which to generate a postal code. Can be null.</param>
	/// <returns>A string representing the generated postal code.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="country"/> is null.</exception>
	/// <remarks>
	/// Utilizes <see cref="Country"/> to determine the format of the postal code. If <paramref name="city"/> is provided,
	/// it may influence the generated postal code based on city-specific rules.
	/// </remarks>
	private static string GeneratePostalCode([NotNull] Country country, [AllowNull] City city)
	{
		country = country.ArgumentNotNull();

		if (string.IsNullOrEmpty(country.PostalFormat))
		{
			return string.Empty;
		}

		var postalFormats = _postalFormatsCache.GetOrAdd(country, static c => c.PostalFormat!.Split(Core.ControlChars.Comma));

		var format = postalFormats.PickRandom();
		var sb = _stringBuilderPool.Get().SetCapacity(format.Length);

		try
		{
			FillPostalCodeFromFormat(sb, format);
			_ = sb.Replace("CC", country.Iso2);
			ApplyCityReplacement(sb, format, city);
			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb.Clear());
		}
	}

	/// <summary>Picks a random city from the state's cities, or <see langword="null"/> if the state is null.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GetCityFromState), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static City? GetCityFromState(State? state) =>
		state?.Cities?.PickRandom();

	/// <summary>Returns the city name or empty string.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GetCityName), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static string GetCityName(City? city) =>
		city?.Name ?? Core.ControlChars.EmptyString;

	/// <summary>Returns the phone number length for the given country, or the default of 10.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GetCountryPhoneLength), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static int GetCountryPhoneLength(Country? country) =>
		country?.PhoneNumberLength ?? 10;

	/// <summary>Returns a randomly selected phone code segment for the given country, or empty string.
	/// The comma-separated <see cref="Country.PhoneCode"/> string is split once and cached in <see cref="_phoneCodeCache"/>.
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GetPhoneCode), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static string GetPhoneCode(Country? country)
	{
		if (country is null)
		{
			return Core.ControlChars.EmptyString;
		}

		var phoneCodeString = GetPhoneCodeString(country);

		if (string.IsNullOrEmpty(phoneCodeString))
		{
			return Core.ControlChars.EmptyString;
		}

		var parts = _phoneCodeCache.GetOrAdd(country, static c => c.PhoneCode!.Split(Core.ControlChars.Comma));

		return parts.PickRandom() ?? Core.ControlChars.EmptyString;
	}

	/// <summary>Returns the raw phone code string for the given country (comma-separated list), or empty string if not available.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GetPhoneCodeString), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static string GetPhoneCodeString(Country? country) =>
		country?.PhoneCode ?? Core.ControlChars.EmptyString;

	/// <summary>Returns the state name or empty string.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GetStateName), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static string GetStateName(State? state) =>
		state?.Name ?? Core.ControlChars.EmptyString;

	/// <summary>Selects a random word from the provided collection of words.</summary>
	/// <param name="words">
	/// A read-only collection of words to select from. Must not be null or empty.
	/// </param>
	/// <returns>
	/// A randomly selected word from the collection.
	/// </returns>
	/// <exception cref="ArgumentNullException">
	/// Thrown when the <paramref name="words"/> collection is null.
	/// </exception>
	/// <exception cref="ArgumentException">
	/// Thrown when the <paramref name="words"/> collection is empty.
	/// </exception>
	private static string Of([NotNull] params ReadOnlyCollection<string> words) => words[GenerateInteger(0, words.Count - 1)];

	/// <summary>Picks a random state and city from the country.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(PickStateAndCity), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static (State? state, City? city) PickStateAndCity(Country country)
	{
		var state = country.States?.PickRandom();
		return (state, GetCityFromState(state));
	}

	/// <summary>Data container for address field values.</summary>
	private readonly record struct AddressComponents(
		string Id,
		string Address1,
		string Address2,
		string CityName,
		string CountryName,
		string CountyProvince,
		string Phone,
		string PostalCode,
		string StateName);


}
