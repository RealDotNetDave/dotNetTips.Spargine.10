// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Tester
// Author           : David McCarter
// Created          : 01-19-2019
//
// Last Modified By : David McCarter
// Last Modified On : 08-13-2025
// ***********************************************************************
// <copyright file="RandomData.cs" company="McCarter Consulting">
//     Copyright (c) dotNetTips.com - McCarter Consulting. All rights reserved.
// </copyright>
// <summary>Create random data for unit and benchmark testing.</summary>
// ***********************************************************************

using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
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

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

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
	/// A lazy-loaded read-only collection of countries.
	/// </summary>
	private static readonly Lazy<ReadOnlyCollection<Country>> _countries = new(CountryRepository.GetCountries().ToReadOnlyCollection());

	/// <summary>
	/// A lazy-loaded array of domain extensions.
	/// </summary>
	private static readonly Lazy<string[]> _domainExtensions = new(Resources.DomainExtentions.Split(Core.ControlChars.Comma, StringSplitOptions.RemoveEmptyEntries));

	/// <summary>
	/// A lazy-loaded read-only collection of first names.
	/// </summary>
	private static readonly Lazy<ReadOnlyCollection<string>> _firstNames = new(Resources.FirstNames.Split(Core.ControlChars.Comma, StringSplitOptions.TrimEntries).ToReadOnlyCollection());

	/// <summary>
	/// A lazy-loaded read-only collection of last names.
	/// </summary>
	private static readonly Lazy<ReadOnlyCollection<string>> _lastNames = new(Resources.LastNames.Split(Core.ControlChars.Comma, StringSplitOptions.TrimEntries).ToReadOnlyCollection());

	// Replace the existing declaration of _lock with the following:
	private static readonly Lock _lock = new();

	/// <summary>
	/// A cache for postal formats, keyed by country.
	/// </summary>
	private static readonly Dictionary<Country, string[]> _postalFormatsCache = [];

	/// <summary>
	/// Provides a thread-static instance of RandomNumberGenerator for generating cryptographically secure random numbers.
	/// </summary>
	[ThreadStatic]
	private static readonly RandomNumberGenerator _randomNumberGenerator;

	/// <summary>
	/// An object pool for reusing instances of StringBuilder, reducing allocations.
	/// </summary>
	private static readonly ObjectPool<StringBuilder> _stringBuilderPool = new DefaultObjectPoolProvider().CreateStringBuilderPool();

	/// <summary>
	/// Initializes static members of the <see cref="RandomData" /> class.
	/// </summary>
	static RandomData() => _randomNumberGenerator = RandomNumberGenerator.Create();

	/// <summary>
	/// Generates the first line of an address.
	/// </summary>
	/// <param name="addressLength">The total desired length of the address line.</param>
	/// <returns>A string representing the first line of an address.</returns>
	/// <remarks>
	/// This method combines a number, generated by <see cref="GenerateNumber(int)"/>, and a word, generated by <see cref="GenerateWord(int)"/>, to form an address line.
	/// The address number is controlled by <see cref="AddressNumberCount"/>, ensuring the generated address line meets the specified length requirements.
	/// </remarks>
	private static string GenerateAddressLineOne(int addressLength) => $"{GenerateNumber(AddressNumberCount)} {GenerateWord(addressLength - AddressNumberCount - 1)}";

	/// <summary>
	/// Generates the second line of an address.
	/// </summary>
	/// <param name="addressLength">The total desired length of the address line.</param>
	/// <returns>A string representing the second line of an address.</returns>
	/// <remarks>
	/// This method combines a word, generated by <see cref="GenerateWord(int)"/>, and a number, generated by <see cref="GenerateNumber(int)"/>, to form an address line.
	/// The address number is controlled by <see cref="AddressNumberCount"/>, ensuring the generated address line meets the specified length requirements.
	/// </remarks>
	private static string GenerateAddressLineTwo(int addressLength) => $"{GenerateWord(addressLength - AddressNumberCount - 1)} {GenerateNumber(AddressNumberCount)}";

	/// <summary>
	/// Generates an email address using the provided first and last names. If either is null or empty, defaults are used.
	/// </summary>
	/// <param name="firstName">The first name to use in the email address. Defaults to "FIRSTNAME" if null or empty.</param>
	/// <param name="lastName">The last name to use in the email address. Defaults to "LASTNAME" if null or empty.</param>
	/// <returns>A string representing the generated email address.</returns>
	/// <remarks>
	/// This method utilizes <see cref="StringExtensions.DefaultIfNullOrEmpty(string, string)"/> to provide default values for null or empty names,
	/// </remarks>
	private static string GenerateEmailAddressWithName(string firstName, string lastName) => $"{firstName.DefaultIfNullOrEmpty("FIRSTNAME")}.{lastName.DefaultIfNullOrEmpty("LASTNAME")}@{GenerateWord(5, 15, 'a', 'z')}.{GenerateDomainExtension()}";

	/// <summary>
	/// Generates a <see cref="PersonRecord"/> with random data.
	/// </summary>
	/// <param name="addressCount">The number of addresses to generate for the person. Default is 2.</param>
	/// <param name="addressLength">The length of each address line. Default is 25.</param>
	/// <param name="countyProvinceLength">The length of the county or province name. Default is 20.</param>
	/// <returns>A <see cref="PersonRecord"/> populated with random data.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GeneratePersonRecord), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	private static PersonRecord GeneratePersonRecord(int addressCount = 2, int addressLength = 25, int countyProvinceLength = 20)
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
			Addresses = GenerateAddressCollection<Address>(personData.Country, addressCount, addressLength, countyProvinceLength)
				.Select(address => address)
				.Where(address => address is not null)
				.ToCollection()!,
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
			Addresses = GenerateAddressCollection<Models.ValueTypes.Address>(personData.Country, addressCount, addressLength, countyProvinceLength)
				.Select(address => address)
				.ToCollection()!,
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

		if (!_postalFormatsCache.TryGetValue(country, out var postalFormats))
		{
			if (string.IsNullOrEmpty(country.PostalFormat))
			{
				return string.Empty;
			}

			postalFormats = country.PostalFormat.Split(Core.ControlChars.Comma);
			_postalFormatsCache[country] = postalFormats;
		}

		var format = postalFormats.PickRandom();
		var builder = _stringBuilderPool.Get().ClearSetCapacity(format.Length);

		try
		{
			foreach (var character in format.AsSpan())
			{
				_ = character switch
				{
					'N' => builder.Append(GenerateNumber(1)),
					'A' => builder.Append(GenerateCharacter('A', 'Z')),
					_ => builder.Append(character),
				};
			}

			_ = builder.Replace("CC", country.Iso2);

			if (city is not null && format.Contains("CITY", StringComparison.Ordinal))
			{
				_ = builder.Replace("CITY", city.Name);
			}

			return builder.ToString();
		}
		finally
		{
			_stringBuilderPool.Return(builder);
		}
	}

	/// <summary>
	/// Selects a random word from the provided collection of words.
	/// </summary>
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
	/// <remarks>
	/// This method uses <see cref="GenerateInteger(int, int)"/> to select a random index within the bounds of the <paramref name="words"/> collection.
	/// </remarks>
	private static string Of([NotNull] params ReadOnlyCollection<string> words) => words[GenerateInteger(0, words.Count - 1)];

	/// <summary>
	/// Creates a file with a specified length filled with random data.
	/// </summary>
	/// <param name="fileName">The name of the file to create. Cannot be null or empty.</param>
	/// <param name="fileLength">The length of the file in bytes. Defaults to <see cref="DefaultFileLength"/> if not specified.</param>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="fileName"/> is null.</exception>
	/// <exception cref="ArgumentException">Thrown when <paramref name="fileName"/> is empty.</exception>
	/// <remarks>
	/// This method uses <see cref="RandomNumberGenerator"/> for generating random data to fill the file.
	/// </remarks>
	internal static void CreateFile([NotNull] string fileName, int fileLength = DefaultFileLength)
	{
		const int bufferSize = 4096; // Use a buffer size of 4KB.
		var buffer = new byte[bufferSize];
		var iterations = fileLength / bufferSize;
		var remainingBytes = fileLength % bufferSize;

		using (var rng = RandomNumberGenerator.Create())
		{
			using (var fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None, bufferSize))
			{
				for (var index = 0; index < iterations; index++)
				{
					rng.GetBytes(buffer);
					fileStream.Write(buffer, 0, buffer.Length);
				}

				if (remainingBytes > 0)
				{
					buffer = new byte[remainingBytes];
					rng.GetBytes(buffer);
					fileStream.Write(buffer, 0, buffer.Length);
				}
			}
		}
	}

	/// <summary>
	/// Generates an address of the specified type: RefTypes.Address, ValueTypes.Address, or AddressRecord.
	/// </summary>
	/// <typeparam name="TAddress">The type of address to generate.</typeparam>
	/// <param name="country">The country for the address. If null, a random country is used.</param>
	/// <param name="addressLength">The length of each address line. Default is 25.</param>
	/// <param name="countyProvinceLength">The length of the county or province name. Default is 20.</param>
	/// <returns>An instance of the specified address type populated with random data.</returns>
	/// <exception cref="NotSupportedException">Thrown if the type is not supported.</exception>
	[Information(nameof(GenerateAddress), author: "David McCarter", createdOn: "6/4/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.New, OptimizationStatus = OptimizationStatus.None)]
	public static TAddress GenerateAddress<TAddress>(Country? country = null, int addressLength = 25, int countyProvinceLength = 20)
	{
		country ??= _countries.Value.PickRandom();
		addressLength = addressLength.ArgumentInRange(min: 5, max: 100);
		countyProvinceLength = countyProvinceLength.ArgumentInRange(min: 5, max: 50);

		var state = country?.States?.PickRandom();
		var city = state?.Cities?.PickRandom();

		var id = GenerateKey();
		var address1 = GenerateAddressLineOne(addressLength);
		var address2 = GenerateAddressLineTwo(addressLength);
		var cityName = city?.Name ?? string.Empty;
		var countryName = country?.Name ?? string.Empty;
		var countyProvince = GenerateWord(countyProvinceLength);
		var phone = GenerateNumber(country!.PhoneNumberLength);
		var postalCode = GeneratePostalCode(country, city);
		var stateName = state?.Name ?? string.Empty;

		if (typeof(TAddress) == typeof(Address))
		{
			return (TAddress)(object)new Address
			{
				Id = id,
				Address1 = address1,
				Address2 = address2,
				City = cityName,
				Country = countryName,
				CountyProvince = countyProvince,
				Phone = phone,
				PostalCode = postalCode,
				State = stateName
			};
		}
		else if (typeof(TAddress) == typeof(Models.ValueTypes.Address))
		{
			return (TAddress)(object)new Models.ValueTypes.Address
			{
				Id = id,
				Address1 = address1,
				Address2 = address2,
				City = cityName,
				Country = countryName,
				CountyProvince = countyProvince,
				Phone = phone,
				PostalCode = postalCode,
				State = stateName
			};
		}
		else if (typeof(TAddress) == typeof(AddressRecord))
		{
			return (TAddress)(object)new AddressRecord(id, address1, address2, cityName, stateName, countyProvince, countryName, postalCode, phone);
		}
		else
		{
			throw new NotSupportedException($"Type {typeof(TAddress).FullName} is not supported by GenerateAddress.");
		}
	}

	/// <summary>
	/// Generates a collection of addresses for a randomly selected country.
	/// </summary>
	/// <param name="count">The number of addresses to generate. Defaults to 2.</param>
	/// <param name="addressLength">The length of the address line. Defaults to 25.</param>
	/// <param name="countyProvinceLength">The length of the county or province. Defaults to 20.</param>
	/// <returns>A collection of addresses of the specified type for a random country.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GenerateAddressCollection), "David McCarter", "6/1/2025", Status = Status.New)]
	public static Collection<TAddress> GenerateAddressCollection<TAddress>(int count = 2, int addressLength = 25, int countyProvinceLength = 20) where TAddress : IAddress<TAddress>
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
	/// Generates a byte array of a specified size in kilobytes.
	/// </summary>
	/// <param name="sizeInKb">The size of the byte array to generate, in kilobytes.</param>
	/// <returns>A byte array filled with random bytes.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="sizeInKb"/> is negative.</exception>
	/// <remarks>
	/// This method uses <see cref="RandomNumberGenerator"/> to fill the byte array with cryptographically secure random bytes.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GenerateByteArray), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static byte[] GenerateByteArray(double sizeInKb)
	{
		sizeInKb = sizeInKb.ArgumentMeetsCondition(sizeInKb >= double.Epsilon, errorMessage: string.Format(CultureInfo.InvariantCulture, Resources.SizeMustBeEpsilon, double.Epsilon));

		var bytes = new byte[Convert.ToInt32(sizeInKb * 1024)];

		lock (_lock)
		{
			_randomNumberGenerator.GetBytes(bytes);
		}

		return bytes;
	}

	/// <summary>
	/// Generates a random character using the default minimum and maximum character constraints.
	/// </summary>
	/// <returns>A random character between <see cref="DefaultMinCharacter"/> and <see cref="DefaultMaxCharacter"/>.</returns>
	/// <example>Output: 82 'R'</example>
	[Information(nameof(GenerateCharacter), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
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
	/// <remarks>
	/// This method utilizes <see cref="GenerateInteger(int, int)"/> to generate a random integer within the specified range and then casts it to a character.
	/// </remarks>
	/// <example>Output: 65 'A'</example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GenerateCharacter), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static char GenerateCharacter(char minValue, char maxValue)
	{
		return (char)GenerateInteger(minValue, maxValue);
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
		return new() { X = GenerateInteger(), Y = GenerateInteger(), Z = GenerateInteger() };
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

		var coordinates = new List<T>(count);

		for (var coordinateIndex = 0; coordinateIndex < count; coordinateIndex++)
		{
			coordinates.Add(GenerateCoordinate<T>());
		}

		return coordinates.ToReadOnlyCollection();
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
	[Information(nameof(GenerateDomainExtension), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static string GenerateDomainExtension()
	{
		return Of(_domainExtensions.Value.ToReadOnlyCollection());
	}

	/// <summary>
	/// Generates a random email address for testing purposes.
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
	///   <item><description>A username generated with <see cref="GenerateWord(int, int, char, char)"/> (5-25 chars)</description></item>
	///   <item><description>The "@" symbol</description></item>
	///   <item><description>A domain name generated with <see cref="GenerateWord(int, int, char, char)"/> (5-15 chars)</description></item>
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
	/// <seealso cref="GenerateWord(int, int, char, char)"/>
	/// <seealso cref="GenerateDomainExtension"/>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GenerateEmailAddress), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string GenerateEmailAddress()
	{
		return string.Concat(GenerateWord(5, 25, 'a', 'z'), "@", GenerateWord(5, 15, 'a', 'z'), ".", GenerateDomainExtension());
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
	[Information(nameof(GenerateFirstName), "David McCarter", "3/11/2023", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static string? GenerateFirstName()
	{
		return _firstNames.Value.PickRandom();
	}

	/// <summary>
	/// Generates a random integer within a specified range.
	/// </summary>
	/// <param name="min">The inclusive lower bound of the random number returned. Default is <see cref="int.MinValue"/>.</param>
	/// <param name="max">The exclusive upper bound of the random number returned. Must be greater than or equal to <paramref name="min"/>. Default is <see cref="int.MaxValue"/>.</param>
	/// <returns>A 32-bit signed integer greater than or equal to <paramref name="min"/> and less than <paramref name="max"/>.</returns>
	/// <exception cref="ArgumentOutOfRangeException"><paramref name="min"/> is greater than <paramref name="max"/>.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GenerateInteger), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static int GenerateInteger(int min = int.MinValue, int max = int.MaxValue)
	{
		//Ensure maxLength is +1 of minLength so the _randomNumberGenerator does not cause an exception.
		max = max.EnsureMinimum(min + 1);

		return RandomNumberGenerator.GetInt32(min, max);
	}

	/// <summary>
	/// Generates a unique key using the <see cref="GenerateKey"/> method.
	/// </summary>
	/// <returns>A unique key as a string.</returns>
	/// <example>Output: f7f0af78003d4ab194b5a4024d02112a</example>
	[Information(nameof(GenerateKey), "David McCarter", "1/19/2019", BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
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
	[Information(nameof(GenerateLastName), "David McCarter", "3/11/2023", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static string? GenerateLastName()
	{
		return _lastNames.Value.PickRandom();
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

		var sb = _stringBuilderPool.Get().ClearSetCapacity(length);

		try
		{
			for (var numberIndex = 0; numberIndex < length; numberIndex++)
			{
				_ = sb.Append(RandomNumberGenerator.GetInt32(0, 10));
			}

			return sb.ToString().Trim();
		}
		finally
		{
			_stringBuilderPool.Return(sb);
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
	[Information(nameof(GeneratePerson), author: "David McCarter", createdOn: "6/4/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.New, OptimizationStatus = OptimizationStatus.None)]
	public static TPerson GeneratePerson<TPerson>(int addressCount = 2, int addressLength = 25, int countyProvinceLength = 20)
	{
		if (typeof(TPerson) == typeof(Person))
		{
			return (TPerson)(object)GeneratePersonRef(addressCount, addressLength, countyProvinceLength);
		}
		else if (typeof(TPerson) == typeof(Models.ValueTypes.Person))
		{
			return (TPerson)(object)GeneratePersonVal(addressCount, addressLength, countyProvinceLength);
		}
		else if (typeof(TPerson) == typeof(PersonRecord))
		{
			return (TPerson)(object)GeneratePersonRecord(addressCount, addressLength, countyProvinceLength);
		}
		else
		{
			throw new NotSupportedException($"Type {typeof(TPerson).FullName} is not supported by GeneratePerson.");
		}
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
			var firstName = _firstNames.Value.PickRandom() ?? string.Empty;
			var lastName = _lastNames.Value.PickRandom() ?? string.Empty;
			var personName = new PersonName(firstName, lastName);

			if (names.AddIfNotExists(personName) is false)
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
	/// <remarks>
	/// This method leverages <see cref="GeneratePersonRecord(int, int, int)"/> to create each <see cref="PersonRecord"/> in the collection.
	/// </remarks>
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

		return includeCountryCode ? $"{country.PhoneCode?.Split(Core.ControlChars.Comma).PickRandom()}-{GenerateNumber(country.PhoneNumberLength)}" : GenerateNumber(country.PhoneNumberLength);
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

		//Lookup Country
		var country = CountryRepository.GetCountry(countryName);

		return includeCountryCode
			? $"{(country?.PhoneCode ?? string.Empty).Split(Core.ControlChars.Comma).PickRandom()}-{GenerateNumber(country?.PhoneNumberLength ?? 10)}"
			: GenerateNumber(country?.PhoneNumberLength ?? 10);
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

		var fileName = $"{GenerateWord(fileNameLength, DefaultMinCharacterRandomFile, DefaultMaxCharacterRandomFile)}{Core.ControlChars.Dot}{extension}";

		return Path.Combine(Path.GetTempPath(), fileName);
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

		var fileName = $"{GenerateWord(fileNameLength, DefaultMinCharacterRandomFile, DefaultMaxCharacterRandomFile)}{Core.ControlChars.Dot}{extension}";

		return Path.Combine(path, fileName);
	}

	/// <summary>
	/// Generates random real location data including country, state, and city.
	/// </summary>
	/// <returns>A tuple containing a <see cref="Country"/>, <see cref="State"/>, and <see cref="City"/>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GenerateRandomLocationData), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static (Country country, State state, City city) GenerateRandomLocationData()
	{
		var country = _countries.Value.PickRandom();
		State? state = null;
		City? city = null;

		if (country!.States != null && country.States.HasItems())
		{
			state = country.States.PickRandom();

			if (state?.Cities != null && state.Cities.HasItems())
			{
				city = state.Cities.PickRandom();
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
	[Information(nameof(GenerateRelativeUrl), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string GenerateRelativeUrl()
	{
		var sb = _stringBuilderPool.Get().Clear();

		try
		{
			var length = GenerateInteger(1, 10);
			for (var lengthIndex = 0; lengthIndex < length; lengthIndex++)
			{
				_ = sb.Append(GenerateUrlFragment());
			}

			_ = sb.Append('/');

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb);
		}
	}

	/// <summary>
	/// Generates a temporary file with random content.
	/// </summary>
	/// <param name="fileLength">The length of the file in characters. Default is <see cref="DefaultFileLength"/>.</param>
	/// <returns>The path to the generated temporary file.</returns>
	/// <example>Output: C:\\Users\\user folder\\AppData\\Local\\Temp\\OFQCKBRAKQ.dotnettips.temp</example>
	[Information(nameof(GenerateTempFile), "David McCarter", "1/19/2019", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static string GenerateTempFile(int fileLength = DefaultFileLength)
	{
		fileLength = fileLength.ArgumentInRange(min: 1, defaultValue: DefaultFileLength);

		var fileName = GenerateRandomFileName();
		var fakeText = GenerateWord(fileLength);

		File.WriteAllText(fileName, fakeText);

		return fileName;
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
		return $"{GenerateUrlHostName()}{GenerateRelativeUrl()}";
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
		return $"/{GenerateWord(1, 25, 'a', 'z')}";
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
		return $"https://{GenerateUrlHostNameNoProtocol()}";
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
		return $"www.{GenerateWord(1, 25, 'a', 'z')}.{GenerateUrlHostNameNoSubDomain()}";
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
		length = length.ArgumentInRange(min: 1, defaultValue: 1);

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
		minLength = minLength.ArgumentInRange(min: 1, defaultValue: 1);
		maxLength = maxLength.ArgumentInRange(min: 1, defaultValue: 1);

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

		var sb = _stringBuilderPool.Get().ClearSetCapacity(length);

		try
		{
			for (var wordIndex = 0; wordIndex < length; wordIndex++)
			{
				_ = sb.Append(GenerateCharacter(minCharacter, maxCharacter));
			}

			return sb.ToString().Trim();
		}
		finally
		{
			_stringBuilderPool.Return(sb);
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

		var strings = new List<string>(count);

		for (var wordCount = 0; wordCount < count; wordCount++)
		{
			strings.Add(GenerateWord(minLength, maxLength));
		}

		return strings.ToReadOnlyCollection();
	}

	/// <summary>
	/// Provides an extensive string for testing purposes, with a length of 969 characters, including spaces.
	/// </summary>
	/// <value>
	/// The long test string loaded from <see cref="Resources.LongTestString"/>.
	/// </value>
	[Information(nameof(GenerateWords), "David McCarter", "1/19/2019", Status = Status.Available)]
	public static string LongTestString => Resources.LongTestString;

}
