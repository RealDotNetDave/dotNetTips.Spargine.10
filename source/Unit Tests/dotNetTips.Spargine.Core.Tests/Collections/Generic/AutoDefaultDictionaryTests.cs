// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 05-01-2025
//
// Last Modified By : David McCarter
// Last Modified On : 04-01-2026
// ***********************************************************************
// <copyright file="AutoDefaultDictionaryTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Tests.Collections.Generic;

[ExcludeFromCodeCoverage]
[TestClass]
public class AutoDefaultDictionaryTests
{
	[TestMethod]
	public void AddOrUpdate_KeyDoesNotExist_ShouldAddNewValue()
	{
		// Arrange
		var dictionary = new AutoDefaultDictionary<int, string>("default");
		Func<int, string, string> updateValueFactory = (key, oldValue) => $"{oldValue}_updated";

		// Act
		var result = dictionary.AddOrUpdate(1, "newValue", updateValueFactory);

		// Assert
		Assert.AreEqual("newValue", result);
		Assert.AreEqual("newValue", dictionary[1]);
		Assert.HasCount(1, dictionary);
	}

	[TestMethod]
	public void AddOrUpdate_KeyExists_ShouldUpdateValue()
	{
		// Arrange
		var dictionary = new AutoDefaultDictionary<int, string>("default");
		dictionary[1] = "originalValue";
		Func<int, string, string> updateValueFactory = (key, oldValue) => $"{oldValue}_updated";

		// Act
		var result = dictionary.AddOrUpdate(1, "newValue", updateValueFactory);

		// Assert
		Assert.AreEqual("originalValue_updated", result);
		Assert.AreEqual("originalValue_updated", dictionary[1]);
		Assert.HasCount(1, dictionary);
	}

	[TestMethod]
	public void AddOrUpdate_NullAddValue_ShouldThrowArgumentNullException()
	{
		// Arrange
		var dictionary = new AutoDefaultDictionary<int, string>("default");
		Func<int, string, string> updateValueFactory = (key, oldValue) => $"{oldValue}_updated";

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => dictionary.AddOrUpdate(1, null!, updateValueFactory));
	}

	[TestMethod]
	public void AddOrUpdate_NullKey_ShouldThrowArgumentNullException()
	{
		// Arrange
		var dictionary = new AutoDefaultDictionary<string, string>("default");
		Func<string, string, string> updateValueFactory = (key, oldValue) => $"{oldValue}_updated";

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => dictionary.AddOrUpdate(null!, "value", updateValueFactory));
	}

	[TestMethod]
	public void AddOrUpdate_NullUpdateFactory_ShouldThrowArgumentNullException()
	{
		// Arrange
		var dictionary = new AutoDefaultDictionary<int, string>("default");

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => dictionary.AddOrUpdate(1, "value", null!));
	}

	[TestMethod]
	public void Clear_ShouldRemoveAllItemsButRetainDefaultBehavior()
	{
		// Arrange
		var dictionary = new AutoDefaultDictionary<int, string>("default");
		dictionary[1] = "one";
		dictionary[2] = "two";
		dictionary[3] = "three";

		// Act
		dictionary.Clear();

		// Assert
		Assert.IsEmpty(dictionary);
		var value = dictionary[4];
		Assert.AreEqual("default", value);
		Assert.HasCount(1, dictionary);
	}

	[TestMethod]
	public void ConstructorWithCapacity_NullDefaultValue_ShouldThrowArgumentNullException()
	{
		// Arrange & Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => new AutoDefaultDictionary<int, string>(null!, 100));
	}

	[TestMethod]
	public void ConstructorWithCapacity_NullFactory_ShouldThrowArgumentNullException()
	{
		// Arrange & Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => new AutoDefaultDictionary<int, string>((Func<int, string>)null!, 100));
	}

	[TestMethod]
	public void ConstructorWithCapacity_ShouldInitializeWithDefaultValue()
	{
		// Arrange
		var defaultValue = "default";
		var capacity = 100;

		// Act
		var dictionary = new AutoDefaultDictionary<int, string>(defaultValue, capacity);
		var value = dictionary[1];

		// Assert
		Assert.AreEqual(defaultValue, value);
		Assert.HasCount(1, dictionary);
	}

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
	public void ConstructorWithComparer_ShouldUseCaseInsensitiveComparer()
	{
		// Arrange
		var comparer = StringComparer.OrdinalIgnoreCase;
		var dictionary = new AutoDefaultDictionary<string, string>(comparer);
		dictionary["Key"] = "value1";

		// Act
		var value = dictionary["key"];

		// Assert - case-insensitive comparer means "key" and "Key" are the same key
		Assert.AreEqual("value1", value);
		Assert.HasCount(1, dictionary);
	}

	[TestMethod]
	public void ConstructorWithDefaultValue_NullDefaultValue_ShouldThrowArgumentNullException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => new AutoDefaultDictionary<int, string>(null!));
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
	public void ConstructorWithDefaultValueAndComparer_NullDefaultValue_ShouldThrowArgumentNullException()
	{
		// Arrange
		var comparer = EqualityComparer<int>.Default;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => new AutoDefaultDictionary<int, string>((string)null!, comparer));
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
		Assert.IsEmpty(initialDictionary);
		Assert.AreEqual(defaultValue, value);
		Assert.HasCount(1, dictionary);
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
		Assert.HasCount(2, dictionary);
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
		Assert.HasCount(3, dictionary);
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
		Assert.HasCount(2, dictionary);
		Assert.IsTrue(dictionary.ContainsKey(99));
	}

	[TestMethod]
	public void ConstructorWithDictionaryAndOnMissingKey_NullOnMissingKey_ShouldThrowArgumentNullException()
	{
		// Arrange
		var initialDictionary = new Dictionary<int, string> { { 1, "one" } };

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => new AutoDefaultDictionary<int, string>(initialDictionary, (Func<int, string>)null!));
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
	public void ConstructorWithFactoryAndCapacity_ShouldInitializeWithFactory()
	{
		// Arrange
		Func<int, string> onMissingKey = key => $"Generated_{key}";
		var capacity = 100;

		// Act
		var dictionary = new AutoDefaultDictionary<int, string>(onMissingKey, capacity);
		var value = dictionary[1];

		// Assert
		Assert.AreEqual("Generated_1", value);
		Assert.HasCount(1, dictionary);
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
	public void ConstructorWithKeyValuePairsAndDefaultValue_NullDefaultValue_ShouldThrowArgumentNullException()
	{
		// Arrange
		var keyValuePairs = new List<KeyValuePair<int, string>> { new KeyValuePair<int, string>(1, "one") };

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => new AutoDefaultDictionary<int, string>(keyValuePairs, (string)null!));
	}

	[TestMethod]
	public void ConstructorWithKeyValuePairsAndOnMissingKey_NullOnMissingKey_ShouldThrowArgumentNullException()
	{
		// Arrange
		var keyValuePairs = new List<KeyValuePair<int, string>> { new KeyValuePair<int, string>(1, "one") };

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => new AutoDefaultDictionary<int, string>(keyValuePairs, (Func<int, string>)null!));
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
	public void ConstructorWithOnMissingKey_NullOnMissingKey_ShouldThrowArgumentNullException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => new AutoDefaultDictionary<int, string>((Func<int, string>)null!));
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
	public void ConstructorWithOnMissingKeyAndComparer_NullOnMissingKey_ShouldThrowArgumentNullException()
	{
		// Arrange
		var comparer = EqualityComparer<int>.Default;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => new AutoDefaultDictionary<int, string>((Func<int, string>)null!, comparer));
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
	public void ContainsValue_NullValue_ShouldThrowArgumentNullException()
	{
		// Arrange
		var dictionary = new AutoDefaultDictionary<int, string>("default");

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => dictionary.ContainsValue(null!));
	}

	[TestMethod]
	public void ContainsValue_WithCustomComparer_ShouldReturnFalse()
	{
		// Arrange
		var dictionary = new AutoDefaultDictionary<int, string>("default");
		dictionary[1] = "VALUE1";
		var comparer = StringComparer.OrdinalIgnoreCase;

		// Act
		var result = dictionary.ContainsValue("nonexistent", comparer);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ContainsValue_WithCustomComparer_ShouldReturnTrue()
	{
		// Arrange
		var dictionary = new AutoDefaultDictionary<int, string>("default");
		dictionary[1] = "VALUE1";
		var comparer = StringComparer.OrdinalIgnoreCase;

		// Act
		var result = dictionary.ContainsValue("value1", comparer);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void ContainsValue_WithDefaultComparer_ShouldReturnFalse()
	{
		// Arrange
		var dictionary = new AutoDefaultDictionary<int, string>("default");
		dictionary[1] = "value1";

		// Act
		var result = dictionary.ContainsValue("value2");

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ContainsValue_WithDefaultComparer_ShouldReturnTrue()
	{
		// Arrange
		var dictionary = new AutoDefaultDictionary<int, string>("default");
		dictionary[1] = "value1";
		dictionary[2] = "value2";

		// Act
		var result = dictionary.ContainsValue("value1");

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void ContainsValue_WithExplicitDefaultComparer_ShouldReturnTrue()
	{
		// Arrange
		var dictionary = new AutoDefaultDictionary<int, string>("default");
		dictionary[1] = "value1";

		// Act
		var result = dictionary.ContainsValue("value1", EqualityComparer<string>.Default);

		// Assert
		Assert.IsTrue(result);
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
	public void DefaultValue_ShouldReturnConfiguredDefaultValue()
	{
		// Arrange
		var defaultValue = "myDefault";
		var dictionary = new AutoDefaultDictionary<int, string>(defaultValue);

		// Act
		var result = dictionary.DefaultValue;

		// Assert
		Assert.AreEqual(defaultValue, result);
	}

	[TestMethod]
	public void DefaultValue_WithFactoryFunction_ShouldReturnDefaultOfType()
	{
		// Arrange
		Func<int, string> onMissingKey = key => $"Generated_{key}";
		var dictionary = new AutoDefaultDictionary<int, string>(onMissingKey);

		// Act
		var result = dictionary.DefaultValue;

		// Assert
		Assert.IsNull(result); // Should be default(string)
	}

	[TestMethod]
	public void GetOrAdd_NullFactory_ShouldThrowArgumentNullException()
	{
		// Arrange
		var dictionary = new AutoDefaultDictionary<int, string>("default");

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => dictionary.GetOrAdd(1, (Func<int, string>)null!));
	}

	[TestMethod]
	public void GetOrAdd_NullKey_ShouldThrowArgumentNullException()
	{
		// Arrange
		var dictionary = new AutoDefaultDictionary<string, string>("default");

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => dictionary.GetOrAdd(null!, "value"));
	}

	[TestMethod]
	public void GetOrAdd_NullValue_ShouldThrowArgumentNullException()
	{
		// Arrange
		var dictionary = new AutoDefaultDictionary<int, string>("default");

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => dictionary.GetOrAdd(1, (string)null!));
	}

	[TestMethod]
	public void GetOrAdd_WithFactory_KeyDoesNotExist_ShouldAddAndReturnValue()
	{
		// Arrange
		var dictionary = new AutoDefaultDictionary<int, string>("default");
		Func<int, string> valueFactory = key => $"Generated_{key}";

		// Act
		var result = dictionary.GetOrAdd(1, valueFactory);

		// Assert
		Assert.AreEqual("Generated_1", result);
		Assert.AreEqual("Generated_1", dictionary[1]);
		Assert.HasCount(1, dictionary);
	}

	[TestMethod]
	public void GetOrAdd_WithFactory_KeyExists_ShouldReturnExistingValue()
	{
		// Arrange
		var dictionary = new AutoDefaultDictionary<int, string>("default");
		dictionary[1] = "existingValue";
		Func<int, string> valueFactory = key => $"Generated_{key}";

		// Act
		var result = dictionary.GetOrAdd(1, valueFactory);

		// Assert
		Assert.AreEqual("existingValue", result);
		Assert.HasCount(1, dictionary);
	}

	[TestMethod]
	public void GetOrAdd_WithFactory_NullKey_ShouldThrowArgumentNullException()
	{
		// Arrange
		var dictionary = new AutoDefaultDictionary<string, string>("default");
		Func<string, string> valueFactory = key => $"Generated_{key}";

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => dictionary.GetOrAdd(null!, valueFactory));
	}

	[TestMethod]
	public void GetOrAdd_WithValue_KeyDoesNotExist_ShouldAddAndReturnValue()
	{
		// Arrange
		var dictionary = new AutoDefaultDictionary<int, string>("default");

		// Act
		var result = dictionary.GetOrAdd(1, "newValue");

		// Assert
		Assert.AreEqual("newValue", result);
		Assert.AreEqual("newValue", dictionary[1]);
		Assert.HasCount(1, dictionary);
	}

	[TestMethod]
	public void GetOrAdd_WithValue_KeyExists_ShouldReturnExistingValue()
	{
		// Arrange
		var dictionary = new AutoDefaultDictionary<int, string>("default");
		dictionary[1] = "existingValue";

		// Act
		var result = dictionary.GetOrAdd(1, "newValue");

		// Assert
		Assert.AreEqual("existingValue", result);
		Assert.HasCount(1, dictionary);
	}

	[TestMethod]
	public void GetValueOrDefault_KeyDoesNotExist_ShouldReturnDefaultWithoutAdding()
	{
		// Arrange
		var dictionary = new AutoDefaultDictionary<int, string>("default");

		// Act
		var result = dictionary.GetValueOrDefault(1);

		// Assert
		Assert.AreEqual("default", result);
		Assert.IsEmpty(dictionary); // Verify key was NOT added
	}

	[TestMethod]
	public void GetValueOrDefault_KeyExists_ShouldReturnValue()
	{
		// Arrange
		var dictionary = new AutoDefaultDictionary<int, string>("default");
		dictionary[1] = "existingValue";

		// Act
		var result = dictionary.GetValueOrDefault(1);

		// Assert
		Assert.AreEqual("existingValue", result);
		Assert.HasCount(1, dictionary); // Verify no new key was added
	}

	[TestMethod]
	public void GetValueOrDefault_NullKey_ShouldThrowArgumentNullException()
	{
		// Arrange
		var dictionary = new AutoDefaultDictionary<string, string>("default");

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => dictionary.GetValueOrDefault(null!));
	}

	[TestMethod]
	public void GetValueOrDefault_WithFactoryFunction_ShouldReturnGeneratedValue()
	{
		// Arrange
		Func<int, string> onMissingKey = key => $"Missing_{key}";
		var dictionary = new AutoDefaultDictionary<int, string>(onMissingKey);

		// Act
		var result = dictionary.GetValueOrDefault(1);

		// Assert
		Assert.AreEqual("Missing_1", result);
		Assert.IsEmpty(dictionary); // Verify key was NOT added
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
	public void IndexerGet_WithOnMissingKeyNull_ShouldReturnDefaultValue()
	{
		// Arrange - use constructor that does NOT set _onMissingKey
		var initialDictionary = new Dictionary<int, string> { { 1, "one" } };
		var dictionary = new AutoDefaultDictionary<int, string>(initialDictionary, "fallback");

		// Act - access a missing key; _onMissingKey is null so _defaultValue is used
		var value = dictionary[99];

		// Assert
		Assert.AreEqual("fallback", value);
		Assert.IsTrue(dictionary.ContainsKey(99));
	}

	[TestMethod]
	public void IndexerSet_ShouldOverwriteExistingValue()
	{
		// Arrange
		var dictionary = new AutoDefaultDictionary<int, string>("default");
		dictionary[1] = "originalValue";

		// Act
		dictionary[1] = "newValue";

		// Assert
		Assert.AreEqual("newValue", dictionary[1]);
		Assert.HasCount(1, dictionary);
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

	[TestMethod]
	public void OnMissingKeyFactory_WithDefaultValue_ShouldReturnFactory()
	{
		// Arrange
		var dictionary = new AutoDefaultDictionary<int, string>("default");

		// Act
		var result = dictionary.OnMissingKeyFactory;

		// Assert
		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void OnMissingKeyFactory_WithDictionaryAndDefaultValueConstructor_ShouldReturnNull()
	{
		// Arrange
		var initialDictionary = new Dictionary<int, string> { { 1, "one" } };
		var dictionary = new AutoDefaultDictionary<int, string>(initialDictionary, "default");

		// Act
		var result = dictionary.OnMissingKeyFactory;

		// Assert
		Assert.IsNull(result);
	}

	[TestMethod]
	public void OnMissingKeyFactory_WithFactory_ShouldReturnFactory()
	{
		// Arrange
		Func<int, string> onMissingKey = key => $"Generated_{key}";
		var dictionary = new AutoDefaultDictionary<int, string>(onMissingKey);

		// Act
		var result = dictionary.OnMissingKeyFactory;

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual("Generated_5", result(5));
	}

	[TestMethod]
	public void ToImmutableDictionary_ShouldCreateImmutableSnapshot()
	{
		// Arrange
		var dictionary = new AutoDefaultDictionary<int, string>("default");
		dictionary[1] = "one";
		dictionary[2] = "two";

		// Act
		var immutable = dictionary.ToImmutableDictionary();

		// Assert
		Assert.HasCount(2, immutable);
		Assert.AreEqual("one", immutable[1]);
		Assert.AreEqual("two", immutable[2]);

		// Verify it's truly immutable by modifying the original
		dictionary[3] = "three";
		Assert.HasCount(2, immutable); // Immutable should not reflect changes
	}

	[TestMethod]
	public void ToReadOnlyDictionary_ShouldCreateReadOnlyWrapper()
	{
		// Arrange
		var dictionary = new AutoDefaultDictionary<int, string>("default");
		dictionary[1] = "one";
		dictionary[2] = "two";

		// Act
		var readOnly = dictionary.ToReadOnlyDictionary();

		// Assert
		Assert.HasCount(2, readOnly);
		Assert.AreEqual("one", readOnly[1]);
		Assert.AreEqual("two", readOnly[2]);

		// Verify modifications to original are reflected
		dictionary[3] = "three";
		Assert.HasCount(3, readOnly);
	}

	[TestMethod]
	public void TryAdd_KeyDoesNotExist_ShouldAddAndReturnTrue()
	{
		// Arrange
		var dictionary = new AutoDefaultDictionary<int, string>("default");

		// Act
		var result = dictionary.TryAdd(1, "value");

		// Assert
		Assert.IsTrue(result);
		Assert.AreEqual("value", dictionary[1]);
		Assert.HasCount(1, dictionary);
	}

	[TestMethod]
	public void TryAdd_KeyExists_ShouldNotAddAndReturnFalse()
	{
		// Arrange
		var dictionary = new AutoDefaultDictionary<int, string>("default");
		dictionary[1] = "existingValue";

		// Act
		var result = dictionary.TryAdd(1, "newValue");

		// Assert
		Assert.IsFalse(result);
		Assert.AreEqual("existingValue", dictionary[1]);
		Assert.HasCount(1, dictionary);
	}

	[TestMethod]
	public void TryAdd_NullKey_ShouldThrowArgumentNullException()
	{
		// Arrange
		var dictionary = new AutoDefaultDictionary<string, string>("default");

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => dictionary.TryAdd(null!, "value"));
	}

	[TestMethod]
	public void TryAdd_NullValue_ShouldThrowArgumentNullException()
	{
		// Arrange
		var dictionary = new AutoDefaultDictionary<int, string>("default");

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => dictionary.TryAdd(1, null!));
	}

	[TestMethod]
	public void TryUpdate_KeyDoesNotExist_ShouldReturnFalse()
	{
		// Arrange
		var dictionary = new AutoDefaultDictionary<int, string>("default");

		// Act
		var result = dictionary.TryUpdate(1, "newValue", "comparisonValue");

		// Assert
		Assert.IsFalse(result);
		Assert.IsEmpty(dictionary);
	}

	[TestMethod]
	public void TryUpdate_KeyExistsAndComparisonMatches_ShouldUpdateAndReturnTrue()
	{
		// Arrange
		var dictionary = new AutoDefaultDictionary<int, string>("default");
		dictionary[1] = "originalValue";

		// Act
		var result = dictionary.TryUpdate(1, "newValue", "originalValue");

		// Assert
		Assert.IsTrue(result);
		Assert.AreEqual("newValue", dictionary[1]);
	}

	[TestMethod]
	public void TryUpdate_KeyExistsButComparisonFails_ShouldNotUpdateAndReturnFalse()
	{
		// Arrange
		var dictionary = new AutoDefaultDictionary<int, string>("default");
		dictionary[1] = "originalValue";

		// Act
		var result = dictionary.TryUpdate(1, "newValue", "wrongValue");

		// Assert
		Assert.IsFalse(result);
		Assert.AreEqual("originalValue", dictionary[1]);
	}

	[TestMethod]
	public void TryUpdate_NullComparisonValue_ShouldThrowArgumentNullException()
	{
		// Arrange
		var dictionary = new AutoDefaultDictionary<int, string>("default");

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => dictionary.TryUpdate(1, "newValue", null!));
	}

	[TestMethod]
	public void TryUpdate_NullKey_ShouldThrowArgumentNullException()
	{
		// Arrange
		var dictionary = new AutoDefaultDictionary<string, string>("default");

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => dictionary.TryUpdate(null!, "newValue", "oldValue"));
	}

	[TestMethod]
	public void TryUpdate_NullNewValue_ShouldThrowArgumentNullException()
	{
		// Arrange
		var dictionary = new AutoDefaultDictionary<int, string>("default");

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => dictionary.TryUpdate(1, null!, "oldValue"));
	}
}
