// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 05-30-2021
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-02-2026
// ***********************************************************************
// <copyright file="KeyGenerator.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Generates unique keys using a GUID without dashes.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Provides static methods for generating unique, cryptographically random keys and identifiers.
/// </summary>
/// <remarks>
/// The <see cref="KeyGenerator"/> class offers various methods to create unique keys suitable for different scenarios
/// such as database primary keys, cache keys, distributed system identifiers, and sortable time-based keys.
/// All methods use GUIDs as the underlying randomness source, ensuring globally unique identifiers.
/// <para>
/// <strong>Key Features:</strong>
/// </para>
/// <list type="bullet">
/// <item><description>Generate standard GUID-based keys without dashes (32 hexadecimal characters)</description></item>
/// <item><description>Create sortable keys using GUID version 7 with timestamp ordering</description></item>
/// <item><description>Build custom composite keys from multiple string components</description></item>
/// <item><description>Support for prefixed keys for type identification or namespacing</description></item>
/// <item><description>Optional timestamp inclusion for time-aware key generation</description></item>
/// </list>
/// <para>
/// <strong>Performance Characteristics (.NET 10):</strong>
/// </para>
/// <list type="bullet">
/// <item><description>Uses <see cref="Guid.NewGuid()"/> for cryptographically strong random values</description></item>
/// <item><description>GUID version 7 (<see cref="Guid.CreateVersion7()"/>) provides monotonically increasing keys</description></item>
/// <item><description>All formatting uses <see cref="CultureInfo.InvariantCulture"/> for consistency</description></item>
/// <item><description>Custom keys leverage <see cref="FastStringBuilder"/> for efficient concatenation</description></item>
/// <item><description>Zero allocation for simple key generation methods</description></item>
/// </list>
/// <para>
/// <strong>Common Use Cases:</strong>
/// </para>
/// <list type="bullet">
/// <item><description>Database primary keys and unique identifiers</description></item>
/// <item><description>Distributed cache keys with guaranteed uniqueness</description></item>
/// <item><description>Message queue correlation IDs and trace identifiers</description></item>
/// <item><description>Time-sortable keys for ordered data structures</description></item>
/// <item><description>Composite keys combining entity type and unique identifier</description></item>
/// <item><description>Session tokens and temporary authentication keys</description></item>
/// </list>
/// <para>
/// <strong>GUID Format Notes:</strong>
/// </para>
/// <list type="bullet">
/// <item><description>Format "N" produces 32 lowercase hexadecimal characters without dashes</description></item>
/// <item><description>Example standard key: "f7f0af78003d4ab194b5a4024d02112a"</description></item>
/// <item><description>Example version 7 key: "018d9e7a3c8f7b3e9f2a1c4d6e8f0a2b" (time-ordered)</description></item>
/// <item><description>GUID version 7 keys sort chronologically when compared as strings</description></item>
/// </list>
/// </remarks>
/// <example>
/// Basic key generation:
/// <code>
/// // Generate simple unique key
/// string key = KeyGenerator.GenerateKey();
/// // Returns: "f7f0af78003d4ab194b5a4024d02112a"
/// 
/// // Generate key with prefix for entity identification
/// string userKey = KeyGenerator.GenerateKey("User");
/// // Returns: "User_a3b8c9d1e2f3g4h5i6j7k8l9m0n1o2p3"
/// </code>
/// 
/// Sortable keys for time-ordered collections:
/// <code>
/// // Generate time-ordered keys (GUID version 7)
/// string sortableKey1 = KeyGenerator.GenerateSortableKey();
/// Thread.Sleep(10);
/// string sortableKey2 = KeyGenerator.GenerateSortableKey();
/// 
/// // sortableKey2 > sortableKey1 (string comparison preserves time order)
/// bool isOrdered = string.Compare(sortableKey1, sortableKey2) &lt; 0;
/// // Returns: true
/// 
/// // With prefix for namespacing
/// string eventKey = KeyGenerator.GenerateSortableKey("Event");
/// // Returns: "Event_018d9e7a3c8f7b3e9f2a1c4d6e8f0a2b"
/// </code>
/// 
/// Custom composite keys:
/// <code>
/// // Create composite key with multiple components
/// string cacheKey = KeyGenerator.GenerateCustomKey(
///     separator: '_',
///     addTimeStamp: true,
///     "Product",
///     "Details",
///     "en-US"
/// );
/// // Returns: "Product_Details_en-US_1704123456789_a3b8c9d1e2f3g4h5i6j7k8l9m0n1o2p3"
/// 
/// // Without timestamp
/// string simpleKey = KeyGenerator.GenerateCustomKey(
///     separator: '-',
///     addTimeStamp: false,
///     "Order",
///     "2024",
///     "Q1"
/// );
/// // Returns: "Order-2024-Q1-f7f0af78003d4ab194b5a4024d02112a"
/// </code>
/// 
/// Database primary key generation:
/// <code>
/// public class Product
/// {
///     public string Id { get; set; } = KeyGenerator.GenerateKey("Product");
///     public string Name { get; set; }
/// }
/// 
/// var product = new Product { Name = "Widget" };
/// // product.Id = "Product_b2c3d4e5f6g7h8i9j0k1l2m3n4o5p6q7"
/// </code>
/// 
/// Time-ordered event logging:
/// <code>
/// public class EventLog
/// {
///     public string EventId { get; set; } = KeyGenerator.GenerateSortableKey("Event");
///     public DateTime Timestamp { get; set; } = DateTime.UtcNow;
///     public string Message { get; set; }
/// }
/// 
/// var events = new List&lt;EventLog&gt;
/// {
///     new() { Message = "First" },
///     new() { Message = "Second" },
///     new() { Message = "Third" }
/// };
/// 
/// // EventIds are naturally sortable by time
/// var sortedEvents = events.OrderBy(e => e.EventId).ToList();
/// </code>
/// 
/// Distributed cache key generation:
/// <code>
/// // Generate unique cache keys for different contexts
/// string userCacheKey = KeyGenerator.GenerateCustomKey(
///     separator: ':',
///     addTimeStamp: false,
///     "cache",
///     "user",
///     userId.ToString()
/// );
/// // Returns: "cache:user:12345:a3b8c9d1e2f3g4h5i6j7k8l9m0n1o2p3"
/// 
/// await cache.SetAsync(userCacheKey, userData);
/// </code>
/// </example>
/// <seealso cref="Guid"/>
/// <seealso cref="Guid.NewGuid()"/>
/// <seealso cref="Guid.CreateVersion7()"/>
/// <seealso cref="FastStringBuilder"/>
[Information(Status = Status.Available, Documentation = "https://bit.ly/SpargineKeyGenerator")]
public static class KeyGenerator
{

	/// <summary>
	/// Generates a composite custom key by joining multiple string components with a separator,
	/// optionally appending a Unix timestamp and always appending a GUID-based unique identifier.
	/// </summary>
	/// <param name="separator">
	/// The character used to separate components in the generated key.
	/// Defaults to <see cref="ControlChars.Dash"/> (<c>'-'</c>). Common alternatives include
	/// underscore (<c>'_'</c>), colon (<c>':'</c>), or slash (<c>'/'</c>).
	/// </param>
	/// <param name="addTimeStamp">
	/// If <c>true</c>, appends a Unix timestamp (milliseconds since epoch) as a component
	/// before the GUID; if <c>false</c>, the timestamp component is omitted. Defaults to <c>true</c>.
	/// </param>
	/// <param name="items">
	/// The string components that form the logical part of the key (for example, type, region, tenant, user).
	/// Must contain at least one non-empty item; validation is performed by <c>ArgumentItemsExists()</c>.
	/// </param>
	/// <returns>
	/// A custom key composed of the provided <paramref name="items"/>, the optional timestamp,
	/// and a 32-character GUID (format <c>"N"</c>), all separated by <paramref name="separator"/>.
	/// </returns>
	/// <remarks>
	/// The method pipeline is:
	/// <list type="number">
	/// <item><description>Validate and materialize <paramref name="items"/> into a list.</description></item>
	/// <item><description>Optionally append a timestamp converted to a hex string via <see cref="FastStringBuilder.BytesToString(in ReadOnlySpan{byte})"/>.</description></item>
	/// <item><description>Append a GUID-based key from <see cref="GenerateKey()"/>.</description></item>
	/// <item><description>Concatenate all parts using <see cref="FastStringBuilder.Concat(char, in bool, ReadOnlySpan{string})"/>.</description></item>
	/// </list>
	/// This produces human-readable, structured, and globally unique keys that are suitable for
	/// cache keys, routing keys, partition keys, and correlation identifiers.
	/// </remarks>
	/// <example>
	/// <code>
	/// // Default separator with timestamp
	/// string key = KeyGenerator.GenerateCustomKey(items: ["Product", "Details", "en-US"]);
	/// // "Product-Details-en-US-1704123456789-f7f0af78003d4ab194b5a4024d02112a"
	/// 
	/// // Custom separator without timestamp
	/// string cacheKey = KeyGenerator.GenerateCustomKey(
	///     separator: ':',
	///     addTimeStamp: false,
	///     "cache", "user", userId.ToString()
	/// );
	/// // "cache:user:12345:a3b8c9d1e2f3g4h5i6j7k8l9m0n1o2p3"
	/// </code>
	/// </example>
	/// <seealso cref="GenerateKey()"/>
	/// <seealso cref="GenerateKey(string)"/>
	/// <seealso cref="FastStringBuilder.Concat(char, in bool, ReadOnlySpan{string})"/>
	[return: NotNull]
	[Information(nameof(GenerateCustomKey), "David McCarter", "8/18/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static string GenerateCustomKey([ConstantExpected] char separator = ControlChars.Dash, bool addTimeStamp = true, params string[] items)
	{
		items = items.ArgumentItemsExists();

		// Pre-size: items + optional timestamp + generated key = items.Length + 1 or 2
		var capacity = items.Length + (addTimeStamp ? 2 : 1);
		var keyItems = new List<string>(capacity);
		keyItems.AddRange(items);

		if (addTimeStamp)
		{
			var timestamp = GenerateTimeStamp();
			keyItems.Add(FastStringBuilder.BytesToString(ref timestamp));
		}

		keyItems.Add(GenerateKey());

		return FastStringBuilder.Concat(delimiter: separator, addLineFeed: false, args: [.. keyItems]);
	}

	/// <summary>
	/// Generates a new globally unique key based on a GUID without dashes.
	/// </summary>
	/// <returns>
	/// A 32-character lowercase hexadecimal string representing a GUID in <c>"N"</c> format
	/// (no dashes). Example: <c>"f7f0af78003d4ab194b5a4024d02112a"</c>.
	/// </returns>
	/// <remarks>
	/// Uses <see cref="Guid.NewGuid()"/> as the underlying source of randomness and formats
	/// the value with <see cref="CultureInfo.InvariantCulture"/> to ensure culture-independent output.
	/// This method is suitable for general-purpose unique identifiers where sort order does not matter.
	/// For time-sortable keys, use <see cref="GenerateSortableKey()"/>.
	/// </remarks>
	/// <example>
	/// <code>
	/// // Simple unique key for general identification
	/// string key = KeyGenerator.GenerateKey();
	/// // Example: "f7f0af78003d4ab194b5a4024d02112a"
	/// 
	/// // Use as a primary key
	/// var entityId = KeyGenerator.GenerateKey();
	/// 
	/// // Use as a correlation ID in logging
	/// var correlationId = KeyGenerator.GenerateKey();
	/// logger.LogInformation("CorrelationId: {CorrelationId}", correlationId);
	/// </code>
	/// </example>
	/// <seealso cref="GenerateKey(string)"/>
	/// <seealso cref="GenerateSortableKey()"/>
	[return: NotNull]
	[Information(nameof(GenerateKey), "David McCarter", "5/30/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string GenerateKey()
	{
		return Guid.NewGuid().ToString("N", CultureInfo.InvariantCulture);
	}

	/// <summary>
	/// Generates a new globally unique key with the specified prefix, based on a GUID without dashes.
	/// </summary>
	/// <param name="prefix">
	/// The string to prepend to the generated GUID. Must not be <c>null</c>.
	/// Typically used to indicate the entity type or logical namespace (for example, "User", "Order", or "Product").
	/// </param>
	/// <returns>
	/// A unique identifier string in the format <c>{prefix}_{guid}</c>, where the GUID portion
	/// is a 32-character lowercase hexadecimal string (format <c>"N"</c>, no dashes).
	/// For example: <c>"User_f7f0af78003d4ab194b5a4024d02112a"</c>.
	/// </returns>
	/// <remarks>
	/// This method combines a caller-provided prefix with a randomly generated GUID to create
	/// self-describing identifiers that are both globally unique and easy to classify by type.
	/// <para>
	/// Input validation is performed via <c>prefix.ArgumentNotNull()</c>, which throws if
	/// <paramref name="prefix"/> is <c>null</c>. The GUID is formatted using
	/// <see cref="CultureInfo.InvariantCulture"/> to ensure culture-independent output.
	/// </para>
	/// For time-sortable identifiers, consider <see cref="GenerateSortableKey(string)"/>.
	/// </remarks>
	/// <example>
	/// <code>
	/// // Generate keys with semantic prefixes
	/// string userId = KeyGenerator.GenerateKey("User");
	/// // e.g. "User_f7f0af78003d4ab194b5a4024d02112a"
	/// 
	/// string orderId = KeyGenerator.GenerateKey("Order");
	/// // e.g. "Order_a3b8c9d1e2f3g4h5i6j7k8l9m0n1o2p3"
	/// 
	/// // Extract prefix and GUID later
	/// var parts = userId.Split('_');
	/// string entityType = parts[0]; // "User"
	/// string idPart = parts[1];     // GUID portion
	/// </code>
	/// </example>
	/// <exception cref="ArgumentNullException">
	/// Thrown when <paramref name="prefix"/> is <c>null</c>.
	/// </exception>
	/// <seealso cref="GenerateKey()"/>
	/// <seealso cref="GenerateSortableKey(string)"/>
	[return: NotNull]
	[Information(nameof(GenerateKey), "David McCarter", "5/30/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string GenerateKey([DisallowNull] string prefix)
	{
		prefix = prefix.ArgumentNotNull();

		return string.Create(prefix.Length + 33, prefix, static (span, p) =>
		{
			p.AsSpan().CopyTo(span);
			span[p.Length] = '_';
			_ = Guid.NewGuid().TryFormat(span[(p.Length + 1)..], out _, "N");
		});
	}

	/// <summary>
	/// Creates a sortable random key from a GUID using version 7 GUIDs.
	/// </summary>
	/// <returns>A sortable unique key as a string.</returns>
	/// <example>Example: 017f0af78003d4ab194b5a4024d02112a</example>
	[return: NotNull]
	[Information(nameof(GenerateSortableKey), "David McCarter", "5/7/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static string GenerateSortableKey()
	{
		return Guid.CreateVersion7().ToString("N", CultureInfo.InvariantCulture);
	}

	/// <summary>
	/// Creates a sortable random key from a GUID with a specified prefix using version 7 GUIDs.
	/// </summary>
	/// <param name="prefix">The prefix to prepend to the generated key.</param>
	/// <returns>A sortable unique key as a string with the specified prefix.</returns>
	/// <example>Example: DataRecord_017f0af78003d4ab194b5a4024d02112a</example>
	[return: NotNull]
	[Information(nameof(GenerateSortableKey), "David McCarter", "5/7/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static string GenerateSortableKey([DisallowNull] string prefix)
	{
		return $"{prefix.ArgumentNotNull()}_{Guid.CreateVersion7().ToString("N", CultureInfo.InvariantCulture)}";
	}

	/// <summary>
	/// Generates a timestamp representing the current UTC time in milliseconds since the Unix epoch (January 1, 1970).
	/// </summary>
	/// <returns>
	/// A byte array containing the timestamp as a 64-bit integer (milliseconds since Unix epoch).
	/// The array contains 8 bytes in little-endian format.
	/// </returns>
	/// <remarks>
	/// This private method is used internally by <see cref="GenerateCustomKey"/> to include
	/// timestamp components in composite keys. The Unix millisecond timestamp provides a 
	/// consistent, culture-independent time representation suitable for key generation.
	/// <para>
	/// <strong>Technical Details:</strong>
	/// </para>
	/// <list type="bullet">
	/// <item><description>Uses <see cref="DateTimeOffset.UtcNow"/> for current UTC time</description></item>
	/// <item><description>Converts to Unix milliseconds using <see cref="DateTimeOffset.ToUnixTimeMilliseconds()"/></description></item>
	/// <item><description>Returns 8-byte array via <see cref="BitConverter.GetBytes(long)"/></description></item>
	/// <item><description>Byte order depends on system endianness (typically little-endian)</description></item>
	/// </list>
	/// <para>
	/// <strong>Important Notes:</strong>
	/// </para>
	/// <list type="bullet">
	/// <item><description>Excluded from code coverage as it's a simple wrapper method</description></item>
	/// <item><description>Used for time-based key components, not for cryptographic purposes</description></item>
	/// <item><description>Millisecond precision (not nanoseconds)</description></item>
	/// </list>
	/// </remarks>
	/// <seealso cref="GenerateCustomKey"/>
	/// <seealso cref="DateTimeOffset.UtcNow"/>
	/// <seealso cref="DateTimeOffset.ToUnixTimeMilliseconds()"/>
	/// <seealso cref="BitConverter.GetBytes(long)"/>
	[ExcludeFromCodeCoverage]
	[Information(nameof(GenerateTimeStamp), Status = Status.Available)]
	private static byte[] GenerateTimeStamp()
	{
		return BitConverter.GetBytes(DateTimeOffset.UtcNow.ToUnixTimeMilliseconds());
	}
}
