// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 05-01-2025
//
// Last Modified By : David McCarter
// Last Modified On : 12-24-2025
// ***********************************************************************
// <copyright file="AutoDefaultDictionaryTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using DotNetTips.Spargine.Core.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Tests.Collections.Generic;

[ExcludeFromCodeCoverage]
[TestClass]
public class AutoDefaultDictionaryTests
{


	[TestMethod]
	public void ConstructorWithComparer_ShouldInitializeWithDefaultValue()
	{
		// Arrange
		var comparer = EqualityComparer<int>.Default;
		var dictionary = new AutoDefaultDictionary<int, string>(comparer);

		// Act
		var value = dictionary[1];

		// Assert
		Assert.IsNull(value);
	}

	[TestMethod]
	public void ConstructorWithDefaultValue_ShouldInitializeWithSpecifiedDefaultValue()
	{
		// Arrange
		var defaultValue = "default";
		var dictionary = new AutoDefaultDictionary<int, string>(defaultValue);

		// Act
		var value = dictionary[1];

		// Assert
		Assert.AreEqual(defaultValue, value);
	}

	[TestMethod]
	public void ConstructorWithDefaultValueAndComparer_ShouldInitializeWithSpecifiedDefaultValue()
	{
		// Arrange
		var defaultValue = "default";
		var comparer = EqualityComparer<int>.Default;
		var dictionary = new AutoDefaultDictionary<int, string>(defaultValue, comparer);

		// Act
		var value = dictionary[1];

		// Assert
		Assert.AreEqual(defaultValue, value);
	}

	[TestMethod]
	public void ConstructorWithDictionaryAndDefaultValue_EmptyDictionary_ShouldInitializeWithDefaultValue()
	{
		// Arrange
		var initialDictionary = new Dictionary<int, string>();
		var defaultValue = "default";

		// Act
		var dictionary = new AutoDefaultDictionary<int, string>(initialDictionary, defaultValue);
		var value = dictionary[1];

		// Assert
		Assert.AreEqual(0, initialDictionary.Count);
		Assert.AreEqual(defaultValue, value);
		Assert.AreEqual(1, dictionary.Count);
	}

	[TestMethod]
	public void ConstructorWithDictionaryAndDefaultValue_NullDefaultValue_ShouldThrowArgumentNullException()
	{
		// Arrange
		var initialDictionary = new Dictionary<int, string> { { 1, "one" } };

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => new AutoDefaultDictionary<int, string>(initialDictionary, (string)null!));
	}

	[TestMethod]
	public void ConstructorWithDictionaryAndDefaultValue_ShouldAddDefaultValueOnlyOnAccess()
	{
		// Arrange
		var initialDictionary = new Dictionary<int, string> { { 1, "one" } };
		var defaultValue = "default";
		var dictionary = new AutoDefaultDictionary<int, string>(initialDictionary, defaultValue);

		// Act
		var initialCount = dictionary.Count;
		var missingValue = dictionary[99];
		var afterAccessCount = dictionary.Count;

		// Assert
		Assert.AreEqual(1, initialCount);
		Assert.AreEqual(defaultValue, missingValue);
		Assert.AreEqual(2, afterAccessCount);
	}

	[TestMethod]
	public void ConstructorWithDictionaryAndDefaultValue_ShouldInitializeWithProvidedValues()
	{
		// Arrange
		var initialDictionary = new Dictionary<int, string> { { 1, "one" }, { 2, "two" } };
		var defaultValue = "default";

		// Act
		var dictionary = new AutoDefaultDictionary<int, string>(initialDictionary, defaultValue);

		// Assert
		Assert.AreEqual(2, dictionary.Count);
		Assert.AreEqual("one", dictionary[1]);
		Assert.AreEqual("two", dictionary[2]);
	}

	[TestMethod]
	public void ConstructorWithDictionaryAndDefaultValue_ShouldPreserveExistingValues()
	{
		// Arrange
		var initialDictionary = new Dictionary<int, string> { { 1, "one" }, { 2, "two" }, { 3, "three" } };
		var defaultValue = "default";
		var dictionary = new AutoDefaultDictionary<int, string>(initialDictionary, defaultValue);

		// Act & Assert
		Assert.AreEqual("one", dictionary[1]);
		Assert.AreEqual("two", dictionary[2]);
		Assert.AreEqual("three", dictionary[3]);
		Assert.AreEqual(3, dictionary.Count);
	}

	[TestMethod]
	public void ConstructorWithDictionaryAndDefaultValue_ShouldReturnDefaultValueForMissingKey()
	{
		// Arrange
		var initialDictionary = new Dictionary<int, string> { { 1, "one" } };
		var defaultValue = "default";
		var dictionary = new AutoDefaultDictionary<int, string>(initialDictionary, defaultValue);

		// Act
		var value = dictionary[99];

		// Assert
		Assert.AreEqual(defaultValue, value);
		Assert.AreEqual(2, dictionary.Count);
		Assert.IsTrue(dictionary.ContainsKey(99));
	}

	[TestMethod]
	public void ConstructorWithDictionaryAndOnMissingKey_ShouldInitializeWithFunction()
	{
		// Arrange
		var initialDictionary = new Dictionary<int, string> { { 1, "one" } };
		Func<int, string> onMissingKey = key => $"Missing: {key}";
		var dictionary = new AutoDefaultDictionary<int, string>(initialDictionary, onMissingKey);

		// Act
		var value1 = dictionary[1];
		var value2 = dictionary[2];

		// Assert
		Assert.AreEqual("one", value1);
		Assert.AreEqual("Missing: 2", value2);
	}

	[TestMethod]
	public void ConstructorWithKeyValuePairs_ShouldInitializeWithSpecifiedDefaultValue()
	{
		// Arrange
		var keyValuePairs = new List<KeyValuePair<int, string>>
	{
		new KeyValuePair<int, string>(1, "one"),
		new KeyValuePair<int, string>(2, "two")
	};
		var defaultValue = "default";
		var dictionary = new AutoDefaultDictionary<int, string>(keyValuePairs, defaultValue);

		// Act
		var value1 = dictionary[1];
		var value2 = dictionary[2];
		var value3 = dictionary[3];

		// Assert
		Assert.AreEqual("one", value1);
		Assert.AreEqual("two", value2);
		Assert.AreEqual(defaultValue, value3);
	}

	[TestMethod]
	public void ConstructorWithKeyValuePairsAndOnMissingKey_ShouldInitializeWithFunction()
	{
		// Arrange
		var keyValuePairs = new List<KeyValuePair<int, string>>
	{
		new KeyValuePair<int, string>(1, "one"),
		new KeyValuePair<int, string>(2, "two")
	};
		Func<int, string> onMissingKey = key => $"Missing: {key}";
		var dictionary = new AutoDefaultDictionary<int, string>(keyValuePairs, onMissingKey);

		// Act
		var value1 = dictionary[1];
		var value2 = dictionary[2];
		var value3 = dictionary[3];

		// Assert
		Assert.AreEqual("one", value1);
		Assert.AreEqual("two", value2);
		Assert.AreEqual("Missing: 3", value3);
	}

	[TestMethod]
	public void ConstructorWithOnMissingKey_ShouldInitializeWithFunction()
	{
		// Arrange
		Func<int, string> onMissingKey = key => $"Missing: {key}";
		var dictionary = new AutoDefaultDictionary<int, string>(onMissingKey);

		// Act
		var value = dictionary[1];

		// Assert
		Assert.AreEqual("Missing: 1", value);
	}

	[TestMethod]
	public void ConstructorWithOnMissingKeyAndComparer_ShouldInitializeWithFunction()
	{
		// Arrange
		Func<int, string> onMissingKey = key => $"Missing: {key}";
		var comparer = EqualityComparer<int>.Default;
		var dictionary = new AutoDefaultDictionary<int, string>(onMissingKey, comparer);

		// Act
		var value = dictionary[1];

		// Assert
		Assert.AreEqual("Missing: 1", value);
	}

	[TestMethod]
	public void DefaultConstructor_ShouldInitializeWithDefaultValue()
	{
		// Arrange
		var dictionary = new AutoDefaultDictionary<int, string>();

		// Act
		var value = dictionary[1];

		// Assert
		Assert.IsNull(value);
	}

	[TestMethod]
	public void IndexerGet_ShouldReturnDefaultValueWhenKeyDoesNotExist()
	{
		// Arrange
		var defaultValue = "default";
		var dictionary = new AutoDefaultDictionary<int, string>(defaultValue);

		// Act
		var value = dictionary[1];

		// Assert
		Assert.AreEqual(defaultValue, value);
	}

	[TestMethod]
	public void IndexerGet_ShouldReturnExistingValue()
	{
		// Arrange
		var dictionary = new AutoDefaultDictionary<int, string>();
		dictionary[1] = "value";

		// Act
		var value = dictionary[1];

		// Assert
		Assert.AreEqual("value", value);
	}

	[TestMethod]
	public void IndexerSet_ShouldSetValue()
	{
		// Arrange
		var dictionary = new AutoDefaultDictionary<int, string>();

		// Act
		dictionary[1] = "value";
		var value = dictionary[1];

		// Assert
		Assert.AreEqual("value", value);
	}
}
