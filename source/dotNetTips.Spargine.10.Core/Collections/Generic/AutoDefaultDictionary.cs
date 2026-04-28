// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 01-03-2025
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-28-2026
// ***********************************************************************
// <copyright file="AutoDefaultDictionary.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// The AutoDefaultDictionary class simplifies handling of missing keys
// in dictionaries by providing a default value or a custom function to
// generate values dynamically. This can be particularly useful in
// applications where missing data should be handled gracefully without
// throwing exceptions.
// Original Code by: Simon Painter.
// </summary>
// ***********************************************************************

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace DotNetTips.Spargine.Core.Collections.Generic;

/// <summary>
/// Represents a dictionary that returns a default value when a key is not found.
/// </summary>
/// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
/// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
[Serializable]
[Information("Original Code by: Simon Painter. Improvement suggested by: James Curran.", Status = Status.Available, Documentation = "https://bit.ly/SpargineAutoDefaultDictionary")]
public sealed class AutoDefaultDictionary<TKey, TValue> : Dictionary<TKey, TValue>, ISerializable, IReadOnlyDictionary<TKey, TValue>
	where TKey : notnull
	where TValue : notnull
{
	/// <summary>
	/// The default value to return when a key is not found in the dictionary.
	/// </summary>
	private readonly TValue _defaultValue;

	/// <summary>
	/// The function to call when a key is not found in the dictionary.
	/// </summary>
	private readonly Func<TKey, TValue>? _onMissingKey;

	/// <summary>
	/// Initializes a new instance of the <see cref="AutoDefaultDictionary{TKey, TValue}"/> class with the default value for <typeparamref name="TValue"/>.
	/// </summary>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public AutoDefaultDictionary()
	{
		this._defaultValue = default!;
		this._onMissingKey = _ => default!;
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="AutoDefaultDictionary{TKey, TValue}"/> class with the specified default value for <typeparamref name="TValue"/>.
	/// </summary>
	/// <param name="defaultValue">The default value to return when a key is not found in the dictionary.</param>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public AutoDefaultDictionary(TValue defaultValue)
	{
		this._defaultValue = defaultValue ?? throw new ArgumentNullException(nameof(defaultValue));
		this._onMissingKey = _ => defaultValue;
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="AutoDefaultDictionary{TKey, TValue}"/> class with the specified comparer.
	/// </summary>
	/// <param name="comparer">The comparer to use when comparing c</param>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public AutoDefaultDictionary(in IEqualityComparer<TKey> comparer) : base(comparer)
	{
		this._defaultValue = default!;
		this._onMissingKey = _ => default!;
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="AutoDefaultDictionary{TKey, TValue}"/> class with the specified function to handle missing keys.
	/// </summary>
	/// <param name="onMissingKey">The function to call when a key is not found in the dictionary.</param>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public AutoDefaultDictionary(in Func<TKey, TValue> onMissingKey)
	{
		this._onMissingKey = onMissingKey ?? throw new ArgumentNullException(nameof(onMissingKey));
		this._defaultValue = default!;
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="AutoDefaultDictionary{TKey, TValue}"/> class with the specified dictionary and default value.
	/// </summary>
	/// <param name="dictionary">The dictionary to initialize with.</param>
	/// <param name="defaultValue">The default value to return when a key is not found in the dictionary.</param>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public AutoDefaultDictionary(in IDictionary<TKey, TValue> dictionary, in TValue defaultValue) : base(dictionary)
	{
		this._defaultValue = defaultValue ?? throw new ArgumentNullException(nameof(defaultValue));

	}

	/// <summary>
	/// Initializes a new instance of the <see cref="AutoDefaultDictionary{TKey, TValue}"/> class with the specified dictionary and function to handle missing keys.
	/// </summary>
	/// <param name="dictionary">The dictionary to initialize with.</param>
	/// <param name="onMissingKey">The function to call when a key is not found in the dictionary.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="onMissingKey"/> is null.</exception>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public AutoDefaultDictionary(in IDictionary<TKey, TValue> dictionary, in Func<TKey, TValue> onMissingKey) : base(dictionary)
	{
		this._onMissingKey = onMissingKey ?? throw new ArgumentNullException(nameof(onMissingKey));
		this._defaultValue = default!;
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="AutoDefaultDictionary{TKey, TValue}"/> class with the specified key-value pair collection and default value.
	/// </summary>
	/// <param name="keyValuePairs">The key-value pairs to initialize with.</param>
	/// <param name="defaultValue">The default value to return when a key is not found in the dictionary.</param>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public AutoDefaultDictionary(in IEnumerable<KeyValuePair<TKey, TValue>> keyValuePairs, in TValue defaultValue) : base(keyValuePairs.ToDictionary(kvp => kvp.Key, kvp => kvp.Value)) => this._defaultValue = defaultValue ?? throw new ArgumentNullException(nameof(defaultValue));

	/// <summary>
	/// Initializes a new instance of the <see cref="AutoDefaultDictionary{TKey, TValue}"/> class with the specified key-value pairs and a function to handle missing keys.
	/// </summary>
	/// <param name="keyValuePairs">The key-value pairs to initialize the dictionary with.</param>
	/// <param name="onMissingKey">The function to call when a key is not found in the dictionary.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="onMissingKey"/> is null.</exception>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public AutoDefaultDictionary(in IEnumerable<KeyValuePair<TKey, TValue>> keyValuePairs, in Func<TKey, TValue> onMissingKey)
		: base(keyValuePairs.ToDictionary(kvp => kvp.Key, kvp => kvp.Value))
	{
		this._onMissingKey = onMissingKey ?? throw new ArgumentNullException(nameof(onMissingKey));
		this._defaultValue = default!;
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="AutoDefaultDictionary{TKey, TValue}"/> class with the specified default value and comparer.
	/// </summary>
	/// <param name="defaultValue">The default value to return when a key is not found in the dictionary.</param>
	/// <param name="comparer">The comparer to use when comparing keys.</param>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public AutoDefaultDictionary(in TValue defaultValue, in IEqualityComparer<TKey> comparer) : base(comparer)
	{
		this._defaultValue = defaultValue ?? throw new ArgumentNullException(nameof(defaultValue));

	}

	/// <summary>
	/// Initializes a new instance of the <see cref="AutoDefaultDictionary{TKey, TValue}"/> class with the specified function to handle missing keys and comparer.
	/// </summary>
	/// <param name="onMissingKey">The function to call when a key is not found in the dictionary.</param>
	/// <param name="comparer">The comparer to use when comparing keys.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="onMissingKey"/> is null.</exception>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public AutoDefaultDictionary(in Func<TKey, TValue> onMissingKey, in IEqualityComparer<TKey> comparer) : base(comparer)
	{
		this._onMissingKey = onMissingKey ?? throw new ArgumentNullException(nameof(onMissingKey));
		this._defaultValue = default!;
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="AutoDefaultDictionary{TKey, TValue}"/> class with the specified default value and initial capacity.
	/// </summary>
	/// <param name="defaultValue">The default value to return when a key is not found.</param>
	/// <param name="capacity">The initial number of elements that the dictionary can contain.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="defaultValue"/> is null.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="capacity"/> is less than 0.</exception>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public AutoDefaultDictionary(TValue defaultValue, int capacity) : base(capacity)
	{
		this._defaultValue = defaultValue ?? throw new ArgumentNullException(nameof(defaultValue));
		this._onMissingKey = _ => defaultValue;
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="AutoDefaultDictionary{TKey, TValue}"/> class with the specified factory function and initial capacity.
	/// </summary>
	/// <param name="onMissingKey">The function to call when a key is not found.</param>
	/// <param name="capacity">The initial number of elements that the dictionary can contain.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="onMissingKey"/> is null.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="capacity"/> is less than 0.</exception>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public AutoDefaultDictionary(in Func<TKey, TValue> onMissingKey, int capacity) : base(capacity)
	{
		this._onMissingKey = onMissingKey ?? throw new ArgumentNullException(nameof(onMissingKey));
		this._defaultValue = default!;
	}

	/// <summary>
	/// Gets the default value returned when a key is not found in the dictionary.
	/// Returns <c>default(TValue)</c> if a factory function is configured instead of a static default value.
	/// </summary>
	/// <value>The default value for missing keys.</value>
	[Pure]
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public TValue DefaultValue
	{
		get => this._defaultValue;
	}

	/// <summary>
	/// Gets the factory function used to generate values for missing keys, or <c>null</c> if a static default value is used.
	/// </summary>
	/// <value>The factory function, or <c>null</c> if using a static default value.</value>
	[Pure]
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public Func<TKey, TValue>? OnMissingKeyFactory
	{
		get => this._onMissingKey;
	}

	/// <summary>
	/// Gets or sets the value associated with the specified key. If the key does not exist, the default value is returned and added to the dictionary.
	/// </summary>
	/// <param name="key">The key of the value to get or set.</param>
	/// <returns>The value associated with the specified key, or the default value if the key does not exist.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="key"/> is null.</exception>
	[Pure]
	[Information(OptimizationStatus = OptimizationStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public new TValue this[TKey key]
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			if (!this.TryGetValue(key, out var value))
			{
				value = this._onMissingKey != null ? this._onMissingKey(key) : this._defaultValue;
				this.Add(key, value);
			}

			return value;
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set
		{
			base[key] = value;
		}
	}

	/// <summary>
	/// Adds a key/value pair to the dictionary if the key does not exist, or updates the value if the key exists.
	/// </summary>
	/// <param name="key">The key to add or update.</param>
	/// <param name="addValue">The value to add if the key does not exist.</param>
	/// <param name="updateValueFactory">The function to generate a new value for an existing key.</param>
	/// <returns>The new value for the key.</returns>
	/// <exception cref="ArgumentNullException">Thrown if any parameter is null.</exception>
	[Information(UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public TValue AddOrUpdate([DisallowNull] TKey key, [DisallowNull] TValue addValue, [DisallowNull] Func<TKey, TValue, TValue> updateValueFactory)
	{
		key = key.ArgumentNotNull();
		addValue = addValue.ArgumentNotNull();
		updateValueFactory = updateValueFactory.ArgumentNotNull();

		if (this.TryGetValue(key, out var existingValue))
		{
			var newValue = updateValueFactory(key, existingValue);
			this[key] = newValue;
			return newValue;
		}

		this.Add(key, addValue);

		return addValue;
	}

	/// <summary>
	/// Removes all keys and values from the dictionary while retaining the default value behavior.
	/// </summary>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public new void Clear()
	{
		base.Clear();
	}

	/// <summary>
	/// Determines whether the dictionary contains a specific value using the specified comparer.
	/// </summary>
	/// <param name="value">The value to locate in the dictionary.</param>
	/// <param name="comparer">The comparer to use when comparing values.</param>
	/// <returns><c>true</c> if the dictionary contains an element with the specified value; otherwise, <c>false</c>.</returns>
	[Pure]
	[Information(UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public bool ContainsValue([DisallowNull] TValue value, [AllowNull] IEqualityComparer<TValue>? comparer = null)
	{
		value = value.ArgumentNotNull();

		// Fast path: Use base implementation for default comparer
		if (comparer is null || comparer.Equals(EqualityComparer<TValue>.Default))
		{
			return base.ContainsValue(value);
		}

		// Custom comparer path
		return this.Values.Any(v => comparer.Equals(v, value));
	}

	/// <summary>
	/// Gets the value associated with the specified key. If the key does not exist, 
	/// adds the specified value to the dictionary and returns it.
	/// </summary>
	/// <param name="key">The key of the value to get or add.</param>
	/// <param name="value">The value to add if the key does not exist.</param>
	/// <returns>The value associated with the specified key.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="key"/> or <paramref name="value"/> is null.</exception>
	[Pure]
	[Information(UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public TValue GetOrAdd([DisallowNull] TKey key, [DisallowNull] TValue value)
	{
		key = key.ArgumentNotNull();
		value = value.ArgumentNotNull();

		if (!this.TryGetValue(key, out var existingValue))
		{
			this.Add(key, value);
			return value;
		}

		return existingValue;
	}

	/// <summary>
	/// Gets the value associated with the specified key. If the key does not exist, 
	/// uses the factory function to create a value, adds it to the dictionary, and returns it.
	/// </summary>
	/// <param name="key">The key of the value to get or add.</param>
	/// <param name="valueFactory">The function to create a value if the key does not exist.</param>
	/// <returns>The value associated with the specified key.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="key"/> or <paramref name="valueFactory"/> is null.</exception>
	[Pure]
	[Information(UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public TValue GetOrAdd([DisallowNull] TKey key, [DisallowNull] Func<TKey, TValue> valueFactory)
	{
		key = key.ArgumentNotNull();
		valueFactory = valueFactory.ArgumentNotNull();

		if (!this.TryGetValue(key, out var value))
		{
			value = valueFactory(key);
			this.Add(key, value);
		}

		return value;
	}

	/// <summary>
	/// Gets the value associated with the specified key, or the configured default value if the key does not exist.
	/// Unlike the indexer, this method does NOT add the default value to the dictionary.
	/// </summary>
	/// <param name="key">The key of the value to get.</param>
	/// <returns>The value associated with the key, or the default value if the key does not exist.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="key"/> is null.</exception>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public TValue GetValueOrDefault([DisallowNull] TKey key)
	{
		key = key.ArgumentNotNull();

		if (!this.TryGetValue(key, out var value))
		{
			value = this._onMissingKey != null ? this._onMissingKey(key) : this._defaultValue;
		}

		return value;
	}

	/// <summary>
	/// Creates an immutable snapshot of the dictionary.
	/// </summary>
	/// <returns>An <see cref="ImmutableDictionary{TKey, TValue}"/> containing all current key-value pairs.</returns>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public ImmutableDictionary<TKey, TValue> ToImmutableDictionary()
	{
		return ImmutableDictionary.CreateRange(this);
	}

	/// <summary>
	/// Creates a read-only wrapper around this dictionary.
	/// </summary>
	/// <returns>A <see cref="ReadOnlyDictionary{TKey, TValue}"/> that wraps this dictionary.</returns>
	[Pure]
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public ReadOnlyDictionary<TKey, TValue> ToReadOnlyDictionary()
	{
		return new ReadOnlyDictionary<TKey, TValue>(this);
	}

	/// <summary>
	/// Attempts to add the specified key and value to the dictionary.
	/// </summary>
	/// <param name="key">The key of the element to add.</param>
	/// <param name="value">The value of the element to add.</param>
	/// <returns><c>true</c> if the key/value pair was added; <c>false</c> if the key already exists.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="key"/> or <paramref name="value"/> is null.</exception>
	[Information(UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public new bool TryAdd([DisallowNull] TKey key, [DisallowNull] TValue value)
	{
		key = key.ArgumentNotNull();
		value = value.ArgumentNotNull();

		if (this.ContainsKey(key))
		{
			return false;
		}

		this.Add(key, value);
		return true;
	}

	/// <summary>
	/// Updates the value associated with the specified key if it equals the comparison value.
	/// </summary>
	/// <param name="key">The key whose value should be updated.</param>
	/// <param name="newValue">The new value to set.</param>
	/// <param name="comparisonValue">The value to compare with the existing value.</param>
	/// <returns><c>true</c> if the value was updated; <c>false</c> if the key doesn't exist or the comparison failed.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="key"/>, <paramref name="newValue"/>, or <paramref name="comparisonValue"/> is null.</exception>
	[Information(UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public bool TryUpdate([DisallowNull] TKey key, [DisallowNull] TValue newValue, [DisallowNull] TValue comparisonValue)
	{
		key = key.ArgumentNotNull();
		newValue = newValue.ArgumentNotNull();
		comparisonValue = comparisonValue.ArgumentNotNull();

		if (this.TryGetValue(key, out var existingValue) && EqualityComparer<TValue>.Default.Equals(existingValue, comparisonValue))
		{
			this[key] = newValue;
			return true;
		}

		return false;
	}
}
