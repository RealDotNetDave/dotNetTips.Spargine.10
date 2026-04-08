// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tester.Tests
// Author           : David McCarter
// Created          : 05-01-2025
//
// Last Modified By : David McCarter
// Last Modified On : 04-08-2026
// ***********************************************************************
// <copyright file="RandomDataTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Buffers;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading.Tasks;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Core.Serialization;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Data;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using DotNetTips.Spargine.Tester.Models.RefTypes.SerializerContexts;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Tester.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class RandomDataTests
{
	private const int AddressCount = 5;

	private const int Count = 256;

	private const string FileExtension = "dotnettips.com";

	private const int FileLength = 1500;

	private List<Person> _people;

	public RandomDataTests()
	{
		this._people = RandomData.GeneratePersonRefCollection(Count).Shuffle().ToList();
	}

	[TestMethod]
	public void AddToPersonCollectionTest()
	{
		try
		{
			var people = RandomData.GeneratePersonRefCollection(Count);

			var newPeople = new List<Person>();

			for (var personCount = 0; personCount < people.Count; personCount++)
			{
				_ = newPeople.AddIfNotExists(people[personCount]);
			}

			Assert.AreEqual(Count, newPeople.FastCount());
		}
		catch (Exception ex)
		{
			Debug.WriteLine(ex.Message);
			Assert.Fail();
		}
	}

	[TestMethod]
	public void ClonePersonProperTest()
	{
		var person = RandomData.GeneratePerson<Person>();

		try
		{
			var personClone = person.FastClone<Person>();

			Assert.IsNotNull(personClone);
		}
		catch (Exception ex)
		{
			Debug.WriteLine(ex.Message);
			Assert.Fail();
		}
	}

	[TestMethod]
	public void ConvertPersonValToRefTest()
	{
		var personVal = RandomData.GeneratePerson<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>();

		var personRef = Person.ToPerson(personVal);

		Assert.IsNotNull(personRef);
	}

	[TestMethod]
	public void Deserialize_JsonJsonSerializerContext_PersonProper_Ref_Test()
	{
		var json = RandomData.GeneratePerson<Person>().ToJson();

		var normalResult = JsonSerializer.Deserialize<Person>(json);

		Assert.IsNotNull(normalResult);

		var result = JsonSerializer.Deserialize(json, PersonRefJsonSerializerContext.Default.Person);

		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void Deserialize_JsonSerializerContext_Person_Collection_Test()
	{
		var json = RandomData.GeneratePersonRefCollection(Count).ToJson();

		var result = JsonSerializer.Deserialize(json, PersonRefJsonSerializerContext.Default.PersonList);

		Assert.IsNotNull(result);
		Assert.AreEqual(Count, result.Count);
	}

	[TestMethod]
	public void Deserialize_JsonSerializerContext_PersonRecord_Collection_Test()
	{
		var json = RandomData.GeneratePersonRecordCollection(Count).ToJson();

		var result = JsonSerializer.Deserialize(json, PersonRecordJsonSerializerContext.Default.PersonList);

		Assert.IsNotNull(result);
		Assert.AreEqual(Count, result.Count);
	}

	[TestMethod]
	public void Deserialize_JsonSerializerContext_PersonVal_Collection_Test()
	{
		var json = RandomData.GeneratePersonRefCollection(Count).ToJson();

		var result = JsonSerializer.Deserialize(json, PersonRefJsonSerializerContext.Default.PersonList);

		Assert.IsNotNull(result);
		Assert.AreEqual(Count, result.Count);
	}

	// Tests for RandomData.GenerateAddress<TAddress>
	[TestMethod]
	public void GenerateAddress_ReturnsAddress_ForRefType()
	{
		var address = RandomData.GenerateAddress<Address>();

		Assert.IsNotNull(address);
		Assert.IsFalse(string.IsNullOrEmpty(address.Id));
		Assert.IsFalse(string.IsNullOrEmpty(address.Address1));
		Assert.IsFalse(string.IsNullOrEmpty(address.Address2));
		Assert.IsFalse(string.IsNullOrEmpty(address.Country));
		Assert.IsFalse(string.IsNullOrEmpty(address.CountyProvince));
		Assert.IsFalse(string.IsNullOrEmpty(address.Phone));
	}

	[TestMethod]
	public void GenerateAddress_ReturnsAddress_ForValueType()
	{
		var address = RandomData.GenerateAddress<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>();
		Assert.IsNotNull(address);
		Assert.IsFalse(string.IsNullOrEmpty(address.Id));
		Assert.IsFalse(string.IsNullOrEmpty(address.Address1));
		Assert.IsFalse(string.IsNullOrEmpty(address.Address2));
		Assert.IsFalse(string.IsNullOrEmpty(address.Country));
		Assert.IsFalse(string.IsNullOrEmpty(address.CountyProvince));
		Assert.IsFalse(string.IsNullOrEmpty(address.Phone));
	}

	[TestMethod]
	public void GenerateAddress_ReturnsAddressRecord()
	{
		var address = RandomData.GenerateAddress<AddressRecord>();
		Assert.IsNotNull(address);
		Assert.IsFalse(string.IsNullOrEmpty(address.Id));
		Assert.IsFalse(string.IsNullOrEmpty(address.Address1));
		Assert.IsFalse(string.IsNullOrEmpty(address.Address2));
		Assert.IsFalse(string.IsNullOrEmpty(address.Country));
		Assert.IsFalse(string.IsNullOrEmpty(address.CountyProvince));
		Assert.IsFalse(string.IsNullOrEmpty(address.Phone));
	}

	[TestMethod]
	public void GenerateAddress_UnsupportedType_ThrowsException()
	{
		Assert.ThrowsExactly<NotSupportedException>(() => RandomData.GenerateAddress<string>());
	}

	[TestMethod]
	public void GenerateAddress_WithExplicitParameters_ReturnsValidAddress()
	{
		var country = RandomData.GenerateRandomLocationData().country;
		int addressLength = 50;
		int countyProvinceLength = 30;

		var address = RandomData.GenerateAddress<Address>(country, addressLength, countyProvinceLength);
		Assert.IsNotNull(address);
		Assert.IsLessThanOrEqualTo(addressLength, address.Address1.Length);
		Assert.IsLessThanOrEqualTo(addressLength, address.Address2.Length);
		Assert.IsLessThanOrEqualTo(countyProvinceLength, address.CountyProvince.Length);
	}

	[TestMethod]
	public void GenerateAddressCollection_DefaultParameters_ReturnsAddresses()
	{
		// Arrange
		var country = RandomData.GenerateRandomLocationData().country;

		// Act
		var result = RandomData.GenerateAddressCollection<Address>(country);

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(2, result.Count);
	}

	[TestMethod]
	public void GenerateAddressCollection_Generic_ReturnsAddresses_ForAddressRecord()
	{
		var addresses = RandomData.GenerateAddressCollection<AddressRecord>(Count);

		Assert.IsNotNull(addresses);
		Assert.AreEqual(Count, addresses.Count);
	}

	[TestMethod]
	public void GenerateAddressCollection_Generic_ReturnsAddresses_ForRefType()
	{
		var addresses = RandomData.GenerateAddressCollection<Address>(Count);
		Assert.IsNotNull(addresses);
		Assert.AreEqual(Count, addresses.Count);
	}

	[TestMethod]
	public void GenerateAddressCollection_Generic_ReturnsAddresses_ForValueType()
	{
		var addresses = RandomData.GenerateAddressCollection<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>(Count);

		Assert.IsNotNull(addresses);
		Assert.AreEqual(Count, addresses.Count);
	}

	[TestMethod]
	public void GenerateAddressCollection_GenericOverload_DefaultParameters_ReturnsAddresses()
	{
		var addresses = RandomData.GenerateAddressCollection<Address>();

		Assert.IsNotNull(addresses);
		Assert.AreEqual(2, addresses.Count);
	}

	[TestMethod]
	public void GenerateAddressCollection_InvalidCountry_ThrowsException()
	{
		// Act
		Assert.ThrowsExactly<ArgumentNullException>(() => RandomData.GenerateAddressCollection<Address>(null));
	}

	[TestMethod]
	public void GenerateAddressCollection_SpecifiedParameters_ReturnsAddresses()
	{
		// Arrange
		var country = RandomData.GenerateRandomLocationData().country;
		int count = 5;
		int addressLength = 50;
		int countyProvinceLength = 30;

		// Act
		var result = RandomData.GenerateAddressCollection<Address>(country, count, addressLength, countyProvinceLength);

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(count, result.Count);
	}

	[TestMethod]
	public void GenerateAddressCollectionTest()
	{
		var addresses = RandomData.GenerateAddressCollection<Address>(
			RandomData.GenerateRandomLocationData().country,
			AddressCount,
			100,
			50);

		Assert.IsNotNull(addresses);

		Assert.AreEqual(AddressCount, addresses.Count);
	}

	[TestMethod]
	public void GenerateByteArray_InvalidCount_UsesDefaultValue()
	{
		var result = RandomData.GenerateByteArray(0);

		Assert.IsNotNull(result);
		Assert.AreEqual(1, result.Length);
	}

	[TestMethod]
	public void GenerateByteArray_LargeCount_ReturnsCorrectLength()
	{
		const int count = 4096;

		var result = RandomData.GenerateByteArray(count);

		Assert.IsNotNull(result);
		Assert.AreEqual(count, result.Length);
	}

	[TestMethod]
	public void GenerateByteArrayTest()
	{
		var byteArray = RandomData.GenerateByteArray(1);

		Assert.IsNotEmpty(byteArray);

		Assert.IsGreaterThan(0, byteArray.First());
	}

	[TestMethod]
	public void GenerateCharacter_CustomRange_ReturnsCharInRange()
	{
		var character = RandomData.GenerateCharacter('A', 'Z');

		Assert.IsTrue(character >= 'A' && character <= 'Z');
	}

	[TestMethod]
	public void GenerateCharacter_DefaultRange_ReturnsValidChar()
	{
		var character = RandomData.GenerateCharacter();

		Assert.IsTrue(character >= RandomData.DefaultMinCharacter && character <= RandomData.DefaultMaxCharacter);
	}

	[TestMethod]
	public void GenerateCharacterTest()
	{
		var character = RandomData.GenerateCharacter();

		Assert.IsNotNull(character);
	}

	[TestMethod]
	public void GenerateCharacterTestWithMinMaxCharTest()
	{
		var character = RandomData.GenerateCharacter('A', 'C');

		Assert.IsNotNull(character);
	}

	[TestMethod]
	public void GenerateCoordinateCollection_AllCoordinatesHaveValues()
	{
		// Arrange
		const int count = 5;

		// Act
		var result = RandomData.GenerateCoordinateCollection<Coordinate>(count);

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(count, result.Count);

		foreach (var coordinate in result)
		{
			Assert.IsNotNull(coordinate);
			// Verify coordinates have been assigned (they should be non-default values in most cases)
			Assert.IsNotNull(coordinate.ToString());
		}
	}


	[TestMethod]
	public void GenerateCoordinateCollection_DefaultCount_ReturnsTwoCoordinates()
	{
		// Act
		var result = RandomData.GenerateCoordinateCollection<Coordinate>();

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(2, result.Count);
	}

	[TestMethod]
	public void GenerateCoordinateCollection_InvalidCount_UsesDefaultValue()
	{
		// Arrange & Act
		var result = RandomData.GenerateCoordinateCollection<Coordinate>(0);

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(2, result.Count);
	}

	[TestMethod]
	public void GenerateCoordinateCollection_LargeCount_ReturnsAllCoordinates()
	{
		// Arrange
		const int count = 1000;

		// Act
		var result = RandomData.GenerateCoordinateCollection<Coordinate>(count);

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(count, result.Count);
	}

	[TestMethod]
	public void GenerateCoordinateCollection_NegativeCount_UsesDefaultValue()
	{
		var result = RandomData.GenerateCoordinateCollection<Coordinate>(-1);

		Assert.IsNotNull(result);
		Assert.AreEqual(2, result.Count);
	}

	[TestMethod]
	public void GenerateCoordinateCollection_ReturnsReadOnlyCollection()
	{
		// Arrange & Act
		var result = RandomData.GenerateCoordinateCollection<Coordinate>(5);

		// Assert
		Assert.IsNotNull(result);
		Assert.IsInstanceOfType<ReadOnlyCollection<Coordinate>>(result);
	}

	[TestMethod]
	public void GenerateCoordinateCollection_SpecifiedCount_ReturnsCorrectNumber()
	{
		// Arrange
		const int count = 10;

		// Act
		var result = RandomData.GenerateCoordinateCollection<Coordinate>(count);

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(count, result.Count);
	}

	[TestMethod]
	public void GenerateCoordinateTest()
	{
		var coordinate = RandomData.GenerateCoordinate<Coordinate>();

		Assert.IsNotNull(coordinate);

		Assert.IsNotNull(coordinate.ToString());
	}

	[TestMethod]
	public void GenerateCreditCards_DefaultCount_ReturnsTwoCards()
	{
		var result = RandomData.GenerateCreditCards();

		Assert.IsNotNull(result);
		Assert.AreEqual(2, result.Count);
	}

	[TestMethod]
	public void GenerateCreditCardsTest()
	{
		var result = RandomData.GenerateCreditCards(100);

		Assert.IsNotNull(result);
		Assert.AreEqual(100, result.Count);
	}

	[TestMethod]
	public void GenerateCreditCardTest()
	{
		var result = RandomData.GenerateCreditCard();

		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void GenerateDecimal_ZeroDecimalPlaces_ReturnsWholeNumber()
	{
		var decimalValue = RandomData.GenerateDecimal(0, 100, 0);

		Assert.IsGreaterThanOrEqualTo(0, decimalValue);
		Assert.IsLessThanOrEqualTo(100, decimalValue);
		Assert.AreEqual(Math.Floor(decimalValue), decimalValue);
	}

	[TestMethod]
	public void GenerateDecimalTest()
	{
		var decimalValue = RandomData.GenerateDecimal(0, 100, 2);

		Assert.IsGreaterThanOrEqualTo(0, decimalValue);
		Assert.IsLessThanOrEqualTo(100, decimalValue);
	}

	[TestMethod]
	public void GenerateDomainExtension_ReturnsNonEmptyString()
	{
		var extension = RandomData.GenerateDomainExtension();

		Assert.IsNotNull(extension);
		Assert.IsFalse(string.IsNullOrWhiteSpace(extension));
	}

	[TestMethod]
	public void GenerateDomainExtensionTest()
	{
		var stringValue = RandomData.GenerateDomainExtension();

		Assert.IsNotNull(stringValue);
	}

	[TestMethod]
	public void GenerateEmailAddress_ContainsAtSymbol()
	{
		var email = RandomData.GenerateEmailAddress();

		Assert.IsNotNull(email);
		Assert.IsTrue(email.Contains('@'));
		Assert.IsTrue(email.Contains('.'));
	}

	[TestMethod]
	public void GenerateEmailAddressTest()
	{
		var stringValue = RandomData.GenerateEmailAddress();

		Assert.IsNotNull(stringValue);
	}

	[TestMethod]
	public void GenerateFile_DefaultFileLength_CreatesFile()
	{
		var fileName = RandomData.GenerateFile(RandomData.GenerateRandomFileName());

		Assert.IsNotNull(fileName);

		var testFile = new FileInfo(fileName);

		Assert.IsTrue(testFile.Exists);

		testFile.Delete();
	}

	[TestMethod]
	public void GenerateFiles_DefaultParameters_ReturnsFiles()
	{
		// Act
		var result = RandomData.GenerateFiles();

		// Assert
		Assert.IsNotNull(result);
		Assert.IsNotNull(result.Path);
		Assert.AreEqual(2, result.Files.Count);

		// Clean up
		this.DeleteFiles(result.Files);
	}

	[TestMethod]
	public void GenerateFiles_SpecifiedParameters_ReturnsFiles()
	{
		// Arrange
		int count = 5;
		int fileLength = 1024;
		string fileExtension = "test";

		// Act
		var result = RandomData.GenerateFiles(count, fileLength, fileExtension);

		// Assert
		Assert.IsNotNull(result);
		Assert.IsNotNull(result.Path);
		Assert.AreEqual(count, result.Files.Count);

		// Clean up
		this.DeleteFiles(result.Files);
	}

	[TestMethod]
	public void GenerateFiles_WithPath_ReturnsFiles()
	{
		// Arrange
		string path = Path.GetTempPath();
		int count = 5;
		int fileLength = 1024;

		// Act
		var result = RandomData.GenerateFiles(path, count, fileLength);

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(count, result.Count);

		// Clean up
		this.DeleteFiles(result);
	}

	[TestMethod]
	public void GenerateFilesTest()
	{
		var files = RandomData.GenerateFiles(Count, FileLength);

		Assert.IsNotNull(files);

		Assert.IsNotNull(files.Path);

		Assert.AreEqual(Count, files.Files.Count);

		this.DeleteFiles(files.Files);
	}

	[TestMethod]
	public void GenerateFilesWithExtTest()
	{
		var files = RandomData.GenerateFiles(count: Count, fileLength: FileLength, fileExtension: "test");

		Assert.IsNotNull(files);

		Assert.IsNotNull(files.Path);

		Assert.AreEqual(Count, files.Files.Count);

		this.DeleteFiles(files.Files);
	}


	[TestMethod]
	public void GenerateFilesWithPathTest()
	{
		var files = RandomData.GenerateFiles(
			Environment.GetFolderPath(
				Environment.SpecialFolder.ApplicationData,
				Environment.SpecialFolderOption.DoNotVerify),
			Count,
			FileLength);

		Assert.IsNotNull(files);

		Assert.AreEqual(Count, files.Count);

		this.DeleteFiles(files);
	}

	[TestMethod]
	public void GenerateFileTest()
	{
		var fileName = RandomData.GenerateFile(RandomData.GenerateRandomFileName(), fileLength: FileLength);

		Assert.IsNotNull(fileName);

		var testFile = new FileInfo(fileName);

		Assert.IsTrue(testFile.Exists);

		Assert.AreEqual(testFile.Length, FileLength);

		testFile.Delete();
	}

	[TestMethod]
	public void GenerateFirstName_ReturnsNonNullNonEmptyName()
	{
		var firstName = RandomData.GenerateFirstName();

		Assert.IsNotNull(firstName);
		Assert.IsFalse(string.IsNullOrWhiteSpace(firstName));
	}

	[TestMethod]
	public void GenerateGenerateUrlHostNameTest()
	{
		var stringValue = RandomData.GenerateUrlHostName();

		Assert.IsNotNull(stringValue);
	}

	[TestMethod]
	public void GenerateInteger_DefaultParameters_ReturnsValue()
	{
		var intValue = RandomData.GenerateInteger();

		Assert.IsNotNull(intValue);
	}

	[TestMethod]
	public void GenerateIntegerTest()
	{
		var intValue = RandomData.GenerateInteger(0, 1000);

		Assert.IsGreaterThanOrEqualTo(0, intValue);
		Assert.IsLessThanOrEqualTo(1000, intValue);
	}

	[TestMethod]
	public void GenerateKey_ReturnsUniqueKeys()
	{
		var key1 = RandomData.GenerateKey();
		var key2 = RandomData.GenerateKey();

		Assert.IsNotNull(key1);
		Assert.IsNotNull(key2);
		Assert.AreNotEqual(key1, key2);
	}

	[TestMethod]
	public void GenerateKeyTest()
	{
		var stringValue = RandomData.GenerateKey();

		Assert.IsNotNull(stringValue);
	}

	[TestMethod]
	public void GenerateLastName_ReturnsNonNullNonEmptyName()
	{
		var lastName = RandomData.GenerateLastName();

		Assert.IsNotNull(lastName);
		Assert.IsFalse(string.IsNullOrWhiteSpace(lastName));
	}

	[TestMethod]
	public void GenerateNamesTest()
	{
		for (var count = 0; count < Count; count++)
		{
			var firstName = RandomData.GenerateFirstName();
			var lastName = RandomData.GenerateLastName();

			Assert.IsNotNull(firstName);
			Assert.IsNotNull(lastName);
			Assert.IsFalse(string.IsNullOrWhiteSpace(firstName));
			Assert.IsFalse(string.IsNullOrWhiteSpace(lastName));
		}
	}

	[TestMethod]
	public void GenerateNonZeroByteArray_ComparedToGenerateByteArray_ExcludesZeros()
	{
		// Arrange
		const int count = 1000;

		// Act
		var nonZeroArray = RandomData.GenerateNonZeroByteArray(count);
		var normalArray = RandomData.GenerateByteArray(count);

		// Assert
		Assert.AreEqual(normalArray.Length, nonZeroArray.Length);
		Assert.IsTrue(nonZeroArray.All(b => b != 0), "Non-zero array should contain no zero bytes");
	}

	[TestMethod]
	public void GenerateNonZeroByteArray_CryptographicRandomness_HasGoodDistribution()
	{
		// Arrange
		const int count = 10000;
		var distribution = new int[256];

		// Act
		var result = RandomData.GenerateNonZeroByteArray(count);

		// Assert
		foreach (var byteValue in result)
		{
			distribution[byteValue]++;
		}

		Assert.AreEqual(0, distribution[0], "Zero byte should never be generated");

		var uniqueValues = distribution.Count(d => d > 0);
		Assert.IsGreaterThanOrEqualTo(127, uniqueValues, $"Expected at least 127 unique non-zero values, got {uniqueValues}");
	}

	[TestMethod]
	public void GenerateNonZeroByteArray_InvalidCount_UsesDefaultValue()
	{
		// Arrange & Act
		var result = RandomData.GenerateNonZeroByteArray(0);

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(1, result.Length);
		Assert.AreNotEqual(0, result[0]);
	}

	[TestMethod]
	public void GenerateNonZeroByteArray_LargeCount_ReturnsNonZeroBytes()
	{
		// Arrange
		const int count = 4096;

		// Act
		var result = RandomData.GenerateNonZeroByteArray(count);

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(count, result.Length);

		var zeroCount = result.Count(b => b == 0);
		Assert.AreEqual(0, zeroCount, $"Found {zeroCount} zero bytes, expected 0");
	}

	[TestMethod]
	public void GenerateNonZeroByteArray_MinimumCount_ReturnsOneNonZeroByte()
	{
		// Arrange & Act
		var result = RandomData.GenerateNonZeroByteArray(1);

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(1, result.Length);
		Assert.AreNotEqual(0, result[0], "Generated byte should not be zero");
	}

	[TestMethod]
	public void GenerateNonZeroByteArray_MultipleCalls_GeneratesDifferentValues()
	{
		// Arrange
		const int count = 100;

		// Act
		var result1 = RandomData.GenerateNonZeroByteArray(count);
		var result2 = RandomData.GenerateNonZeroByteArray(count);

		// Assert
		Assert.IsNotNull(result1);
		Assert.IsNotNull(result2);
		Assert.IsFalse(result1.SequenceEqual(result2), "Two consecutive calls should produce different byte arrays");
	}

	[TestMethod]
	public void GenerateNonZeroByteArray_ParallelExecution_ThreadSafe()
	{
		// Arrange
		const int iterations = 100;
		const int count = 256;
		var results = new ConcurrentBag<byte[]>();

		// Act
		Parallel.For(0, iterations, _ =>
		{
			var result = RandomData.GenerateNonZeroByteArray(count);
			results.Add(result);
		});

		// Assert
		Assert.AreEqual(iterations, results.Count);

		foreach (var result in results)
		{
			Assert.AreEqual(count, result.Length);
			Assert.IsTrue(result.All(b => b != 0), "All bytes should be non-zero");
		}
	}

	[TestMethod]
	public void GenerateNonZeroByteArray_StandardCount_ReturnsNonZeroBytes()
	{
		// Arrange
		const int count = 256;

		// Act
		var result = RandomData.GenerateNonZeroByteArray(count);

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(count, result.Length);

		foreach (var byteValue in result)
		{
			Assert.AreNotEqual(0, byteValue, $"Byte value {byteValue} should not be zero");
		}
	}

	[TestMethod]
	public void GenerateNonZeroByteArray_VariousSizes_AllValid()
	{
		// Arrange
		int[] testSizes = [1, 10, 100, 256, 512, 1024, 2048];

		// Act & Assert
		foreach (var size in testSizes)
		{
			var result = RandomData.GenerateNonZeroByteArray(size);

			Assert.IsNotNull(result, $"Result should not be null for size {size}");
			Assert.AreEqual(size, result.Length, $"Array length should be {size}");
			Assert.IsTrue(result.All(b => b != 0), $"All bytes should be non-zero for size {size}");
		}
	}

	[TestMethod]
	public void GenerateNumber_DefaultLength_ReturnsSingleDigit()
	{
		var stringValue = RandomData.GenerateNumber();

		Assert.IsNotNull(stringValue);
		Assert.AreEqual(1, stringValue.Length);
	}

	[TestMethod]
	public void GenerateNumberTest()
	{
		var stringValue = RandomData.GenerateNumber(15);

		Assert.IsNotNull(stringValue);

		Assert.AreEqual(15, stringValue.Length);
	}

	[TestMethod]
	public void GeneratePerson_UnsupportedType_ThrowsException()
	{
		Assert.ThrowsExactly<NotSupportedException>(() => RandomData.GeneratePerson<string>());
	}

	[TestMethod]
	public void GeneratePersonNames_DefaultParameters_ReturnsPersonNames()
	{
		// Act
		var result = RandomData.GeneratePersonNames();

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(2, result.Count);
	}

	[TestMethod]
	public void GeneratePersonNames_InvalidCount_UsesDefaultValue()
	{
		var result = RandomData.GeneratePersonNames(0);

		Assert.IsNotNull(result);
		Assert.AreEqual(2, result.Count);
	}

	[TestMethod]
	public void GeneratePersonNames_SpecifiedParameters_ReturnsPersonNames()
	{
		// Arrange
		int count = 5;

		// Act
		var result = RandomData.GeneratePersonNames(count);

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(count, result.Count);
	}

	[TestMethod]
	public void GeneratePersonNamesTest()
	{
		var personNames = RandomData.GeneratePersonNames(Count);

		Assert.IsNotNull(personNames);

		Assert.AreEqual(Count, personNames.Count);
	}

	[TestMethod]
	public void GeneratePersonRecordCollection_DefaultCount_ReturnsTwoRecords()
	{
		var people = RandomData.GeneratePersonRecordCollection();

		Assert.IsNotNull(people);
		Assert.AreEqual(2, people.Count);
	}

	[TestMethod]
	public void GeneratePersonRecordCollectionTest()
	{
		var people = RandomData.GeneratePersonRecordCollection(AddressCount);

		Assert.IsNotNull(people);

		Assert.AreEqual(AddressCount, people.Count);

		JsonSerialization.SerializeToFile(
			people,
			new FileInfo(Path.Combine(App.ExecutingFolder(), "PeopleRecord.json")));
	}

	[TestMethod]
	public void GeneratePersonRecordTest()
	{
		var person = RandomData.GeneratePerson<PersonRecord>(addressCount: AddressCount);

		Assert.IsNotNull(person);
		Assert.IsNotNull(person.Addresses);
		Assert.IsNotNull(person.AddressesSerialization);
		Assert.IsNotNull(person.BornOn);
		Assert.IsNotNull(person.CellPhone);
		Assert.IsNotNull(person.Email);
		Assert.IsNotNull(person.FirstName);
		Assert.IsNotNull(person.Id);
		Assert.IsNotNull(person.LastName);
		Assert.IsNotNull(person.Phone);

		Assert.AreEqual(AddressCount, person.Addresses.Count);

		JsonSerialization.SerializeToFile(
			person,
			new FileInfo(Path.Combine(App.ExecutingFolder(), "PersonRecord.json")));
	}

	[TestMethod]
	public void GeneratePersonRefCollection_DefaultCount_ReturnsTwoPeople()
	{
		var people = RandomData.GeneratePersonRefCollection();

		Assert.IsNotNull(people);
		Assert.AreEqual(2, people.Count);
	}

	[TestMethod]
	public void GeneratePersonRefCollectionTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count);

		Assert.IsNotNull(people);

		Assert.AreEqual(Count, people.Count);

		JsonSerialization.SerializeToFile(people, new FileInfo(Path.Combine(App.ExecutingFolder(), "PeopleRef.json")));
	}

	[TestMethod]
	public void GeneratePersonRefTest()
	{
		var person = RandomData.GeneratePerson<Person>(addressCount: AddressCount);

		Assert.IsNotNull(person);
		Assert.IsNotNull(person.Addresses);
		Assert.IsNotNull(person.AddressesSerialization);
		Assert.IsNotNull(person.BornOn);
		Assert.IsNotNull(person.CellPhone);
		Assert.IsNotNull(person.Email);
		Assert.IsNotNull(person.FirstName);
		Assert.IsNotNull(person.Id);
		Assert.IsNotNull(person.LastName);
		Assert.IsNotNull(person.Phone);
		Assert.AreEqual(AddressCount, person.Addresses.Count);

		JsonSerialization.SerializeToFile(person, new FileInfo(Path.Combine(App.ExecutingFolder(), "PersonRef.json")));
	}

	[TestMethod]
	public void GeneratePersonValCollection_DefaultCount_ReturnsTwoPeople()
	{
		var people = RandomData.GeneratePersonValCollection();

		Assert.IsNotNull(people);
		Assert.AreEqual(2, people.Count);
	}

	[TestMethod]
	public void GeneratePersonValCollectionTest()
	{
		var people = RandomData.GeneratePersonValCollection(Count);

		Assert.AreEqual(Count, people.Count);

		Assert.AreEqual(Count, people.ToDictionary(item => item.Id).Count);

		JsonSerialization.SerializeToFile(people, new FileInfo(Path.Combine(App.ExecutingFolder(), "PeopleVal.json")));
	}

	[TestMethod]
	public void GeneratePersonValTest()
	{
		var person = RandomData.GeneratePerson<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>(addressCount: AddressCount);

		Assert.IsNotNull(person);
		Assert.IsNotNull(person.Addresses);
		Assert.IsNotNull(person.AddressesSerialization);
		Assert.IsNotNull(person.BornOn);
		Assert.IsNotNull(person.CellPhone);
		Assert.IsNotNull(person.Email);
		Assert.IsNotNull(person.FirstName);
		Assert.IsNotNull(person.Id);
		Assert.IsNotNull(person.LastName);
		Assert.IsNotNull(person.Phone);
		Assert.AreEqual(5, person.Addresses.Count);

		Assert.AreEqual(AddressCount, person.Addresses.Count);

		JsonSerialization.SerializeToFile(person, new FileInfo(Path.Combine(App.ExecutingFolder(), "PersonVal.json")));
	}

	[TestMethod]
	public void GeneratePhoneNumber_Country_Test_Random()
	{
		// Explicitly specify the namespace for the FastShuffle method to resolve ambiguity
		var country = CountryRepository.GetCountries().Shuffle().FirstOrDefault();

		var stringValue = RandomData.GeneratePhoneNumber(country!, true);

		Assert.IsNotNull(stringValue);
	}

	[TestMethod]
	public void GeneratePhoneNumber_Country_WithoutCountryCode()
	{
		var country = CountryRepository.GetCountries().Shuffle().FirstOrDefault();

		var phoneNumber = RandomData.GeneratePhoneNumber(country!, false);

		Assert.IsNotNull(phoneNumber);
		Assert.IsFalse(string.IsNullOrWhiteSpace(phoneNumber));
	}

	[TestMethod]
	public void GeneratePhoneNumber_CountryName_Test_USA()
	{
		var stringValue = RandomData.GeneratePhoneNumber(CountryName.Taiwan, true);

		Assert.IsNotNull(stringValue);
	}

	[TestMethod]
	public void GeneratePhoneNumber_CountryName_WithoutCountryCode()
	{
		var phoneNumber = RandomData.GeneratePhoneNumber(CountryName.UnitedStates, false);

		Assert.IsNotNull(phoneNumber);
		Assert.IsFalse(string.IsNullOrWhiteSpace(phoneNumber));
	}

	[TestMethod]
	public void GenerateRandomFileName_DefaultParameters_ReturnsValidPath()
	{
		var fileName = RandomData.GenerateRandomFileName();

		Assert.IsNotNull(fileName);
		Assert.IsTrue(fileName.Contains(Path.GetTempPath().TrimEnd(Path.DirectorySeparatorChar)));
	}

	[TestMethod]
	public void GenerateRandomFileNameAllParamsTest()
	{
		var stringValue = RandomData.GenerateRandomFileName(
			Environment.GetFolderPath(
				Environment.SpecialFolder.ApplicationData,
				Environment.SpecialFolderOption.DoNotVerify),
			fileNameLength: 10,
			extension: FileExtension);

		Assert.IsNotNull(stringValue);

		Assert.AreEqual(10 + FileExtension.Length + 1, new FileInfo(stringValue).Name.Length);

		Assert.EndsWith(FileExtension, stringValue);
	}

	[TestMethod]
	public void GenerateRandomFileNameTest()
	{
		var stringValue = RandomData.GenerateRandomFileName();

		Assert.IsNotNull(stringValue);
	}

	[TestMethod]
	public void GenerateRandomFileNameWithExtTest()
	{
		var stringValue = RandomData.GenerateRandomFileName(fileNameLength: 10, extension: FileExtension);

		Assert.IsNotNull(stringValue);

		Assert.AreEqual(10 + FileExtension.Length + 1, new FileInfo(stringValue).Name.Length);

		Assert.EndsWith(FileExtension, stringValue);
	}

	[TestMethod]
	public void GenerateRandomFileNameWithPathTest()
	{
		var stringValue = RandomData.GenerateRandomFileName(
			Environment.GetFolderPath(
				Environment.SpecialFolder.ApplicationData,
				Environment.SpecialFolderOption.DoNotVerify));

		Assert.IsNotNull(stringValue);
	}

	[TestMethod]
	public void GenerateRandomLocationData_ReturnsValidCountry()
	{
		var result = RandomData.GenerateRandomLocationData();

		Assert.IsNotNull(result.country);
		Assert.IsFalse(string.IsNullOrEmpty(result.country.Name));
	}

	[TestMethod]
	public void GenerateRandomLocationDataTest()
	{
		var result = RandomData.GenerateRandomLocationData();

		Assert.IsNotNull(result);

		Assert.IsNotNull(result.country);
	}

	[TestMethod]
	public void GenerateRandomPersonData_ReturnsValidFields()
	{
		var personData = RandomData.GenerateRandomPersonData();

		Assert.IsNotNull(personData);
		Assert.IsNotNull(personData.FirstName);
		Assert.IsNotNull(personData.LastName);
		Assert.IsNotNull(personData.Email);
		Assert.IsNotNull(personData.Phone);
		Assert.IsNotNull(personData.CellPhone);
		Assert.IsNotNull(personData.Country);
		Assert.IsTrue(personData.BornOn < DateTimeOffset.Now);
	}

	[TestMethod]
	public void GenerateRandomPersonDataTest()
	{
		var result = RandomData.GenerateRandomPersonData();

		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void GenerateRandomPersonNameTest()
	{
		var result = RandomData.GenerateRandomPersonName();

		Assert.IsNotNull(result);

		Assert.IsNotNull(result.firstName);

		Assert.IsNotNull(result.lastName);
	}

	[TestMethod]
	public void GenerateRelativeUrl_StartsWithSlash()
	{
		var url = RandomData.GenerateRelativeUrl();

		Assert.IsNotNull(url);
		Assert.IsTrue(url.StartsWith('/'));
		Assert.IsTrue(url.EndsWith('/'));
	}

	[TestMethod]
	public void GenerateRelativeUrlTest()
	{
		var stringValue = RandomData.GenerateRelativeUrl();

		Assert.IsNotNull(stringValue);
	}

	[TestMethod]
	public void GenerateTempFile_DefaultLength_ReturnsFile()
	{
		var filePath = RandomData.GenerateTempFile();

		Assert.IsNotNull(filePath);

		var tempFile = new FileInfo(filePath);

		Assert.IsTrue(tempFile.Exists);

		tempFile.Delete();
	}

	[TestMethod]
	public void GenerateTempFileTest()
	{
		var stringValue = RandomData.GenerateTempFile(FileLength);

		Assert.IsNotNull(stringValue);

		var tempFile = new FileInfo(stringValue);

		Assert.IsTrue(tempFile.Exists);

		Assert.AreEqual(FileLength, tempFile.Length);

		tempFile.Delete();
	}

	[TestMethod]
	public void GenerateUrl_StartsWithHttps()
	{
		var url = RandomData.GenerateUrl();

		Assert.IsNotNull(url);
		Assert.IsTrue(url.StartsWith("https://"));
	}

	[TestMethod]
	public void GenerateUrlFragment_StartsWithSlash()
	{
		var fragment = RandomData.GenerateUrlFragment();

		Assert.IsNotNull(fragment);
		Assert.IsTrue(fragment.StartsWith('/'));
	}

	[TestMethod]
	public void GenerateUrlFragmentTest()
	{
		var stringValue = RandomData.GenerateUrlFragment();

		Assert.IsNotNull(stringValue);
	}

	[TestMethod]
	public void GenerateUrlHostName_StartsWithHttps()
	{
		var hostName = RandomData.GenerateUrlHostName();

		Assert.IsNotNull(hostName);
		Assert.IsTrue(hostName.StartsWith("https://"));
	}

	[TestMethod]
	public void GenerateUrlHostNameNoProtocol_StartsWithWww()
	{
		var hostName = RandomData.GenerateUrlHostNameNoProtocol();

		Assert.IsNotNull(hostName);
		Assert.IsTrue(hostName.StartsWith("www."));
	}

	[TestMethod]
	public void GenerateUrlHostNameNoProtocolTest()
	{
		var stringValue = RandomData.GenerateUrlHostNameNoProtocol();

		Assert.IsNotNull(stringValue);
	}

	[TestMethod]
	public void GenerateUrlHostNameNoSubDomain_ReturnsNonEmptyString()
	{
		var hostName = RandomData.GenerateUrlHostNameNoSubDomain();

		Assert.IsNotNull(hostName);
		Assert.IsFalse(string.IsNullOrWhiteSpace(hostName));
	}

	[TestMethod]
	public void GenerateUrlHostNameNoSubDomainTest()
	{
		var stringValue = RandomData.GenerateUrlHostNameNoSubDomain();

		Assert.IsNotNull(stringValue);
	}

	[TestMethod]
	public void GenerateUrlTest()
	{
		var stringValue = RandomData.GenerateUrl();

		Assert.IsNotNull(stringValue);
	}

	[TestMethod]
	public void GenerateValPersonTest()
	{
		var person = RandomData.GeneratePerson<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>();

		Assert.IsNotNull(person);

		Assert.IsNotNull(person.Addresses);

		Assert.IsTrue(person.BornOn > DateTimeOffset.Parse("1/1/1800"));

		Assert.IsNotNull(person.CellPhone);

		Assert.IsNotNull(person.Email);

		Assert.IsNotNull(person.FirstName);

		Assert.IsNotNull(person.Phone);

		Assert.IsNotNull(person.Id);

		Assert.IsNotNull(person.LastName);

		Assert.IsNotNull(person.ToString());
	}

	[TestMethod]
	public void GenerateWord_DefaultParameters_ReturnsWord()
	{
		var word = RandomData.GenerateWord(length: 1);

		Assert.IsNotNull(word);
		Assert.IsGreaterThanOrEqualTo(1, word.Length);
	}

	[TestMethod]
	public void GenerateWordLengthWithCharactersTest()
	{
		var stringValue = RandomData.GenerateWord(length: 10, minCharacter: 'A', maxCharacter: 'Z');

		Assert.IsNotNull(stringValue);

		Assert.AreEqual(10, stringValue.Length);
	}

	[TestMethod]
	public void GenerateWordMinMaxLengthTest()
	{
		var stringValue = RandomData.GenerateWord(minLength: 10, maxLength: 25);

		Assert.IsNotNull(stringValue);

		Assert.IsGreaterThanOrEqualTo(10, stringValue.Length);

		Assert.IsLessThanOrEqualTo(25, stringValue.Length);
	}

	[TestMethod]
	public void GenerateWordMinMaxLengthWithCharactersTest()
	{
		var stringValue = RandomData.GenerateWord(minLength: 5, maxLength: 25, minCharacter: 'A', maxCharacter: 'Z');

		Assert.IsNotNull(stringValue);

		Assert.IsGreaterThanOrEqualTo(5, stringValue.Length);

		Assert.IsLessThanOrEqualTo(25, stringValue.Length);
	}

	[TestMethod]
	public void GenerateWords_DefaultParameters_ReturnsWords()
	{
		var words = RandomData.GenerateWords();

		Assert.IsNotNull(words);
		Assert.AreEqual(1, words.Count);
	}

	[TestMethod]
	public void GenerateWordsTest()
	{
		const int WordCount = 25;

		var words = RandomData.GenerateWords(WordCount, 10, 25);

		Assert.AreEqual(WordCount, words.Count);
	}

	[TestMethod]
	public void GenerateWordTest()
	{
		var stringValue = RandomData.GenerateWord(25);

		Assert.IsNotNull(stringValue);

		Assert.AreEqual(25, stringValue.Length);
	}

	[TestMethod]
	public void LongTestString_IsNotNullOrEmpty()
	{
		var longTestString = RandomData.LongTestString;

		Assert.IsNotNull(longTestString);
		Assert.IsFalse(string.IsNullOrEmpty(longTestString));
		Assert.IsGreaterThan(0, longTestString.Length);
	}

	[TestMethod]
	public void PersonRecord_Serialization_Test()
	{
		var person = RandomData.GeneratePerson<PersonRecord>();

		var result = JsonSerializer.Serialize(person);

		Assert.AreEqual(false, string.IsNullOrEmpty(result));

		person = JsonSerializer.Deserialize<PersonRecord>(result);

		Assert.IsNotNull(person);
	}

	[TestMethod]
	public void PersonRef_Serialization_Test()
	{
		var person = RandomData.GeneratePerson<Person>();

		var result = JsonSerializer.Serialize(person);

		Assert.AreEqual(false, string.IsNullOrEmpty(result));

		person = JsonSerializer.Deserialize<Person>(result);

		Assert.IsNotNull(person);
	}

	[TestMethod]
	public void PersonVal_Serialization_Test()
	{
		var person = RandomData.GeneratePerson<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>();

		var result = JsonSerializer.Serialize(person);

		Assert.AreEqual(false, string.IsNullOrEmpty(result));

		person = JsonSerializer.Deserialize<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>(result);

		Assert.IsNotNull(person);
	}

	[TestMethod]
	public void PersonValCollectionOrderByTest()
	{
		var people = RandomData.GeneratePersonValCollection(10000);

		var list = people.OrderBy(p => p.LastName).ThenByDescending(p => p.FirstName).Count();
	}

	[TestMethod]
	public void ReadOnlySequenceCollectionTest()
	{
		try
		{
			var people = new ReadOnlySequence<Person>(
				RandomData.GeneratePersonRefCollection(Count).ToArray());

			var newPeople = new List<Person>();

			foreach (var person in people)
			{
				if (MemoryMarshal.TryGetArray(person, out var segment))
				{
					foreach (var item in segment)
					{
						newPeople.Add(item);
					}
				}
			}

			Assert.AreEqual(Count, newPeople.FastCount());
		}
		catch (Exception ex)
		{
			Debug.WriteLine(ex.Message);
			Assert.Fail();
		}
	}

	[TestMethod]
	public void RecordToStringTest()
	{
		var stringValue1 = RandomData.GeneratePerson<PersonRecord>().ToString();

		Assert.IsNotNull(stringValue1);

		var stringValue2 = RandomData.GeneratePerson<PersonRecord>().PropertiesToString();

		Assert.IsNotNull(stringValue2);
	}

	[TestMethod]
	public void TestReusingCollection()
	{
		var collection = this._people;

		collection.Sort();

		Assert.AreEqual(collection.First().Email, this._people.First().Email);
	}

	[TestMethod]
	public void UpdatePersonRecordTest()
	{
		var person1 = RandomData.GeneratePerson<PersonRecord>();

		Assert.IsNotNull(person1);

		// Update Postal code
		var person2 = person1 with { CellPhone = "(858) 123-1234" };

		Assert.IsNotNull(person2);

		Debug.WriteLine(person2.ToString());

		Debug.WriteLine(person2.PropertiesToString());
	}

	private void DeleteFiles(IEnumerable<string> files)
	{
		if (files.IsEmpty())
		{
			return;
		}

		_ = Parallel.ForEach(
			source: files,
			body: (fileName) =>
			{
				try
				{
					File.Delete(fileName);
				}
				catch (Exception ex) when (ex is ArgumentException ||
					ex is ArgumentNullException ||
					ex is System.IO.DirectoryNotFoundException ||
					ex is IOException ||
					ex is NotSupportedException ||
					ex is PathTooLongException ||
					ex is UnauthorizedAccessException)
				{
					Trace.WriteLine(ex.GetAllMessages());
				}
			});
	}
}
