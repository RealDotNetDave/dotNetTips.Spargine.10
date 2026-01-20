// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 05-30-2021
//
// Last Modified By : David McCarter
// Last Modified On : 01-20-2026
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
	/// optionally including a timestamp and always appending a unique GUID-based identifier.
	/// </summary>
	/// <param name="separator">
	/// The character used to separate components in the generated key. 
	/// Defaults to <see cref="ControlChars.Dash"/> ('-'). Common alternatives include underscore ('_'), 
	/// colon (':'), or dot ('.').
	/// </param>
	/// <param name="addTimeStamp">
	/// If <c>true</c>, includes a Unix timestamp (milliseconds since epoch) as a component before the unique GUID.
	/// If <c>false</c>, the timestamp is omitted. Defaults to <c>true</c>.
	/// </param>
	/// <param name="items">
	/// The string components to include in the key. Must contain at least one non-null item.
	/// Each item will be separated by <paramref name="separator"/>.
	/// </param>
	/// <returns>
	/// A custom key string composed of:
	/// <list type="number">
	/// <item><description>All provided <paramref name="items"/> joined by <paramref name="separator"/></description></item>
	/// <item><description>Optional Unix timestamp (if <paramref name="addTimeStamp"/> is <c>true</c>)</description></item>
	/// <item><description>A unique GUID without dashes (32 hexadecimal characters)</description></item>
	/// </list>
	/// All components are separated by the specified <paramref name="separator"/>.
	/// </returns>
	/// <exception cref="ArgumentException">
	/// Thrown when <paramref name="items"/> is <c>null</c>, empty, or contains no valid items.
	/// </exception>
	/// <remarks>
	/// This method is useful for creating hierarchical or namespaced keys where you need to combine
	/// multiple contextual identifiers (like entity type, user ID, or category) with a unique identifier.
	/// The optional timestamp component enables time-based key sorting and expiration scenarios.
	/// <para>
	/// <strong>Performance Characteristics (.NET 10):</strong>
	/// </para>
	/// <list type="bullet">
	/// <item><description>Allocates a single result string after building the composite key</description></item>
	/// <item><description>Timestamp generation uses <see cref="DateTimeOffset.UtcNow"/> for UTC consistency</description></item>
	/// <item><description>GUID generation uses <see cref="Guid.NewGuid()"/> for cryptographic randomness</description></item>
	/// <item><description>Time Complexity: O(n) where n = total length of all items</description></item>
	/// </list>
	/// <para>
	/// <strong>Key Structure:</strong>
	/// </para>
	/// <list type="bullet">
	/// <item><description>Format (with timestamp): <c>item1{sep}item2{sep}...{sep}timestamp{sep}guid</c></description></item>
	/// <item><description>Format (without timestamp): <c>item1{sep}item2{sep}...{sep}guid</c></description></item>
	/// <item><description>Timestamp: Unix milliseconds (e.g., "1704123456789")</description></item>
	/// <item><description>GUID: 32-character hexadecimal string without dashes</description></item>
	/// </list>
	/// <para>
	/// <strong>Common Use Cases:</strong>
	/// </para>
	/// <list type="bullet">
	/// <item><description>Multi-tenant cache keys: "tenant:user:resource:guid"</description></item>
	/// <item><description>Hierarchical database keys: "customer-order-item-guid"</description></item>
	/// <item><description>Message queue routing keys: "region.service.action.guid"</description></item>
	/// <item><description>Time-expiring tokens: "session-userid-timestamp-guid"</description></item>
	/// <item><description>Partitioned storage keys: "year/month/day/guid"</description></item>
	/// </list>
	/// <para>
	/// <strong>Important Notes:</strong>
	/// </para>
	/// <list type="bullet">
	/// <item><description>The GUID component is always included, ensuring global uniqueness</description></item>
	/// <item><description>Timestamps are in UTC milliseconds since Unix epoch (January 1, 1970)</description></item>
	/// <item><description>Items are not validated or sanitized; ensure they don't contain the separator character</description></item>
	/// <item><description>The method always uses <see cref="CultureInfo.InvariantCulture"/> for consistent formatting</description></item>
	/// </list>
	/// </remarks>
	/// <example>
	/// Basic composite key with default settings:
	/// <code>
	/// string key = KeyGenerator.GenerateCustomKey(
	///     items: new[] { "Product", "Electronics", "Laptop" }
	/// );
	/// // Returns: "Product-Electronics-Laptop-1704123456789-f7f0af78003d4ab194b5a4024d02112a"
	/// </code>
	/// 
	/// Custom separator without timestamp:
	/// <code>
	/// string key = KeyGenerator.GenerateCustomKey(
	///     separator: '_',
	///     addTimeStamp: false,
	///     "User", "Premium", "US"
	/// );
	/// // Returns: "User_Premium_US_a3b8c9d1e2f3g4h5i6j7k8l9m0n1o2p3"
	/// </code>
	/// 
	/// Cache key for multi-tenant application:
	/// <code>
	/// string tenantId = "tenant123";
	/// string userId = "user456";
	/// string resource = "dashboard";
	/// 
	/// string cacheKey = KeyGenerator.GenerateCustomKey(
	///     separator: ':',
	///     addTimeStamp: false,
	///     "cache", tenantId, userId, resource
	/// );
	/// // Returns: "cache:tenant123:user456:dashboard:b2c3d4e5f6g7h8i9j0k1l2m3n4o5p6q7"
	/// 
	/// await cache.SetAsync(cacheKey, data, TimeSpan.FromMinutes(30));
	/// </code>
	/// 
	/// Time-expiring session token:
	/// <code>
	/// string sessionKey = KeyGenerator.GenerateCustomKey(
	///     separator: '-',
	///     addTimeStamp: true,
	///     "session", userId, ipAddress
	/// );
	/// // Returns: "session-user123-192.168.1.1-1704123456789-c3d4e5f6g7h8i9j0k1l2m3n4o5p6q7r8"
	/// 
	/// // Parse timestamp later for expiration checks
	/// var parts = sessionKey.Split('-');
	/// var timestamp = long.Parse(parts[^2]);
	/// var createdAt = DateTimeOffset.FromUnixTimeMilliseconds(timestamp);
	/// </code>
	/// 
	/// Hierarchical storage path:
	/// <code>
	/// DateTime now = DateTime.UtcNow;
	/// string storageKey = KeyGenerator.GenerateCustomKey(
	///     separator: '/',
	///     addTimeStamp: false,
	///     "documents",
	///     now.Year.ToString(),
	///     now.Month.ToString("D2"),
	///     now.Day.ToString("D2")
	/// );
	/// // Returns: "documents/2024/01/15/d4e5f6g7h8i9j0k1l2m3n4o5p6q7r8s9"
	/// </code>
	/// 
	/// Message queue routing key:
	/// <code>
	/// string routingKey = KeyGenerator.GenerateCustomKey(
	///     separator: '.',
	///     addTimeStamp: true,
	///     "orders", "new", "priority-high"
	/// );
	/// // Returns: "orders.new.priority-high.1704123456789.e5f6g7h8i9j0k1l2m3n4o5p6q7r8s9t0"
	/// 
	/// await messageQueue.PublishAsync(routingKey, orderData);
	/// </code>
	/// 
	/// Database partition key:
	/// <code>
	/// string customerId = "CUST001";
	/// string region = "US-EAST";
	/// 
	/// string partitionKey = KeyGenerator.GenerateCustomKey(
	///     separator: '_',
	///     addTimeStamp: false,
	///     region, customerId
	/// );
	/// // Returns: "US-EAST_CUST001_f6g7h8i9j0k1l2m3n4o5p6q7r8s9t0u1"
	/// 
	/// var record = new DataRecord
	/// {
	///     PartitionKey = partitionKey,
	///     Data = customerData
	/// };
	/// </code>
	/// 
	/// API correlation ID:
	/// <code>
	/// string correlationId = KeyGenerator.GenerateCustomKey(
	///     separator: '-',
	///     addTimeStamp: true,
	///     "api", "v1", "payment"
	/// );
	/// // Returns: "api-v1-payment-1704123456789-g7h8i9j0k1l2m3n4o5p6q7r8s9t0u1v2"
	/// 
	/// httpContext.Response.Headers.Add("X-Correlation-Id", correlationId);
	/// logger.LogInformation("Processing payment with correlation ID: {CorrelationId}", correlationId);
	/// </code>
	/// </example>
	/// <seealso cref="GenerateKey()"/>
	/// <seealso cref="GenerateKey(string)"/>
	/// <seealso cref="DateTimeOffset.UtcNow"/>
	[return: NotNull]
	[Information(nameof(GenerateCustomKey), "David McCarter", "8/18/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static string GenerateCustomKey([ConstantExpected] char separator = ControlChars.Dash, bool addTimeStamp = true, params string[] items)
	{
		items = items.ArgumentItemsExists();

		var keyItems = items.ToList();

		if (addTimeStamp)
		{
			var timestamp = GenerateTimeStamp();
			keyItems.Add(FastStringBuilder.BytesToString(ref timestamp));
		}

		keyItems.Add(GenerateKey());

		return FastStringBuilder.Concat(delimiter: separator, addLineFeed: false, args: [.. keyItems]);
	}

	/// <summary>
	/// Generates a globally unique key as a 32-character hexadecimal string without dashes.
	/// </summary>
	/// <returns>
	/// A unique identifier string containing 32 lowercase hexadecimal characters (0-9, a-f) 
	/// derived from a randomly generated GUID.
	/// </returns>
	/// <remarks>
	/// This method creates a GUID using <see cref="Guid.NewGuid()"/> and formats it without dashes 
	/// using the "N" format specifier. The result is a compact, URL-safe identifier suitable for 
	/// use as database keys, cache keys, or any scenario requiring unique identifiers.
	/// <para>
	/// <strong>Performance Characteristics (.NET 10):</strong>
	/// </para>
	/// <list type="bullet">
	/// <item><description>Uses <see cref="Guid.NewGuid()"/> which generates cryptographically random values</description></item>
	/// <item><description>Format "N" produces lowercase hexadecimal without dashes or braces</description></item>
	/// <item><description>Uses <see cref="CultureInfo.InvariantCulture"/> for consistent formatting</description></item>
	/// <item><description>Time Complexity: O(1) - constant time operation</description></item>
	/// <item><description>Space Complexity: O(1) - single 32-character string allocation</description></item>
	/// <item><description>Thread-safe: Can be called concurrently from multiple threads</description></item>
	/// </list>
	/// <para>
	/// <strong>Key Characteristics:</strong>
	/// </para>
	/// <list type="bullet">
	/// <item><description>Length: Always exactly 32 characters</description></item>
	/// <item><description>Characters: Lowercase hexadecimal (0-9, a-f)</description></item>
	/// <item><description>Format: No dashes, no braces, no whitespace</description></item>
	/// <item><description>Uniqueness: Globally unique (collision probability ≈ 0)</description></item>
	/// <item><description>Randomness: Cryptographically strong random values</description></item>
	/// <item><description>Case: Always lowercase for consistency</description></item>
	/// </list>
	/// <para>
	/// <strong>Common Use Cases:</strong>
	/// </para>
	/// <list type="bullet">
	/// <item><description>Database primary keys for distributed systems</description></item>
	/// <item><description>Unique identifiers for entities without natural keys</description></item>
	/// <item><description>Cache keys for distributed caching systems</description></item>
	/// <item><description>Message correlation IDs in message queues</description></item>
	/// <item><description>Request tracking IDs in web applications</description></item>
	/// <item><description>Temporary file names or session identifiers</description></item>
	/// <item><description>URL-safe unique tokens</description></item>
	/// </list>
	/// <para>
	/// <strong>Comparison with Standard GUID Formats:</strong>
	/// </para>
	/// <list type="bullet">
	/// <item><description>Format "D" (default): "f7f0af78-003d-4ab1-94b5-a4024d02112a" (36 chars with dashes)</description></item>
	/// <item><description>Format "N" (this method): "f7f0af78003d4ab194b5a4024d02112a" (32 chars, no dashes)</description></item>
	/// <item><description>Format "B": "{f7f0af78-003d-4ab1-94b5-a4024d02112a}" (38 chars with braces)</description></item>
	/// <item><description>Format "P": "(f7f0af78-003d-4ab1-94b5-a4024d02112a)" (38 chars with parentheses)</description></item>
	/// </list>
	/// <para>
	/// <strong>Important Notes:</strong>
	/// </para>
	/// <list type="bullet">
	/// <item><description>Keys are NOT sortable by creation time (use <see cref="GenerateSortableKey()"/> for that)</description></item>
	/// <item><description>Keys are globally unique across all machines and time</description></item>
	/// <item><description>The method is thread-safe and can be called from async contexts</description></item>
	/// <item><description>Generated keys are suitable for indexing in databases</description></item>
	/// </list>
	/// </remarks>
	/// <example>
	/// Basic key generation:
	/// <code>
	/// string key = KeyGenerator.GenerateKey();
	/// // Returns: "f7f0af78003d4ab194b5a4024d02112a"
	/// 
	/// Console.WriteLine($"Generated key: {key}");
	/// Console.WriteLine($"Key length: {key.Length}"); // Always 32
	/// </code>
	/// 
	/// Using as database primary key:
	/// <code>
	/// public class Product
	/// {
	///     public string Id { get; set; } = KeyGenerator.GenerateKey();
	///     public string Name { get; set; } = "Default Product";
	///     public decimal Price { get; set; } = 0;
	/// }
	/// 
	/// var product = new Product
	/// {
	///     Name = "Laptop",
	///     Price = 999.99m
	/// };
	/// 
	/// await database.Products.AddAsync(product);
	/// // product.Id = "a3b8c9d1e2f3g4h5i6j7k8l9m0n1o2p3"
	/// </code>
	/// 
	/// Cache key generation:
	/// <code>
	/// string cacheKey = $"user_session_{KeyGenerator.GenerateKey()}";
	/// // Returns: "user_session_b2c3d4e5f6g7h8i9j0k1l2m3n4o5p6q7"
	/// 
	/// await cache.SetAsync(cacheKey, userData, TimeSpan.FromHours(1));
	/// </code>
	/// 
	/// Request correlation ID:
	/// <code>
	/// string correlationId = KeyGenerator.GenerateKey();
	/// 
	/// httpContext.Response.Headers.Add("X-Correlation-Id", correlationId);
	/// logger.LogInformation("Request {CorrelationId} started", correlationId);
	/// 
	/// // Later in the request pipeline
	/// logger.LogInformation("Request {CorrelationId} completed", correlationId);
	/// </code>
	/// 
	/// Temporary file name:
	/// <code>
	/// string tempFileName = $"{KeyGenerator.GenerateKey()}.tmp";
	/// string tempPath = Path.Combine(Path.GetTempPath(), tempFileName);
	/// 
	/// await File.WriteAllTextAsync(tempPath, data);
	/// // File: "c:\temp\c3d4e5f6g7h8i9j0k1l2m3n4o5p6q7r8.tmp"
	/// </code>
	/// 
	/// Message queue identifier:
	/// <code>
	/// var message = new Message
	/// {
	///     MessageId = KeyGenerator.GenerateKey(),
	///     Body = payload,
	///     Timestamp = DateTime.UtcNow
	/// };
	/// 
	/// await queue.SendAsync(message);
	/// </code>
	/// 
	/// Unique document identifier:
	/// <code>
	/// public class Document
	/// {
	///     public Document()
	///     {
	///         DocumentId = KeyGenerator.GenerateKey();
	///         CreatedAt = DateTime.UtcNow;
	///     }
	///     
	///     public string DocumentId { get; private set; }
	///     public DateTime CreatedAt { get; private set; }
	///     public string Content { get; set; }
	/// }
	/// </code>
	/// 
	/// Generating multiple unique keys:
	/// <code>
	/// // All keys are guaranteed to be unique
	/// var keys = Enumerable.Range(0, 1000)
	///     .Select(_ => KeyGenerator.GenerateKey())
	///     .ToList();
	/// 
	/// // Verify uniqueness
	/// bool allUnique = keys.Distinct().Count() == keys.Count;
	/// // Returns: true
	/// </code>
	/// </example>
	/// <seealso cref="GenerateKey(string)"/>
	/// <seealso cref="GenerateSortableKey()"/>
	/// <seealso cref="Guid.NewGuid()"/>
	/// <seealso cref="Guid.ToString(string)"/>
	[return: NotNull]
	[Information(nameof(GenerateKey), "David McCarter", "5/30/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Documentation = "https://bit.ly/SpargineJun2021", Status = Status.Available)]
	public static string GenerateKey() => Guid.NewGuid().ToString("N", CultureInfo.InvariantCulture);

	/// <summary>
	/// Generates a globally unique key with a specified prefix, formatted as "prefix_guid" without dashes.
	/// </summary>
	/// <param name="prefix">
	/// The string to prepend to the generated GUID. Must not be <c>null</c>.
	/// Common examples include entity type names (e.g., "User", "Order", "Product") or namespace identifiers.
	/// </param>
	/// <returns>
	/// A unique identifier string in the format "{prefix}_{guid}", where the GUID portion 
	/// is 32 lowercase hexadecimal characters without dashes, and the prefix and GUID 
	/// are separated by an underscore character.
	/// </returns>
	/// <exception cref="ArgumentNullException">
	/// Thrown when <paramref name="prefix"/> is <c>null</c>.
	/// </exception>
	/// <remarks>
	/// This method is particularly useful for creating self-documenting keys where the prefix 
	/// indicates the entity type or context. The underscore separator provides clear visual 
	/// distinction between the prefix and the unique identifier portion.
	/// <para>
	/// <strong>Performance Characteristics (.NET 10):</strong>
	/// </para>
	/// <list type="bullet">
	/// <item><description>Uses string interpolation for efficient concatenation</description></item>
	/// <item><description>GUID generation uses <see cref="Guid.NewGuid()"/> for cryptographic randomness</description></item>
	/// <item><description>Format "N" produces lowercase hexadecimal without dashes</description></item>
	/// <item><description>Uses <see cref="CultureInfo.InvariantCulture"/> for consistent formatting</description></item>
	/// <item><description>Time Complexity: O(1) - constant time operation</description></item>
	/// <item><description>Space Complexity: O(1) - single string allocation</description></item>
	/// </list>
	/// <para>
	/// <strong>Key Structure:</strong>
	/// </para>
	/// <list type="bullet">
	/// <item><description>Format: <c>{prefix}_{32-character-guid}</c></description></item>
	/// <item><description>Separator: Single underscore character ('_')</description></item>
	/// <item><description>Total length: prefix.Length + 1 + 32 characters</description></item>
	/// <item><description>GUID portion: Always 32 lowercase hexadecimal characters</description></item>
	/// <item><description>Example: "User_f7f0af78003d4ab194b5a4024d02112a"</description></item>
	/// </list>
	/// <para>
	/// <strong>Common Use Cases:</strong>
	/// </para>
	/// <list type="bullet">
	/// <item><description>Type-prefixed database primary keys: "Customer_guid", "Order_guid"</description></item>
	/// <item><description>Multi-entity caches with type identification: "Product_guid", "Category_guid"</description></item>
	/// <item><description>Namespaced identifiers: "TenantA_guid", "TenantB_guid"</description></item>
	/// <item><description>Environment-specific keys: "Dev_guid", "Prod_guid"</description></item>
	/// <item><description>Self-documenting audit trails and logs</description></item>
	/// <item><description>API resource identifiers: "api/users/User_guid"</description></item>
	/// </list>
	/// <para>
	/// <strong>Prefix Guidelines:</strong>
	/// </para>
	/// <list type="bullet">
	/// <item><description>Keep prefixes short and descriptive (e.g., "User", "Ord", "Prod")</description></item>
	/// <item><description>Use consistent naming conventions across your application</description></item>
	/// <item><description>Avoid special characters that might cause issues in URLs or databases</description></item>
	/// <item><description>Consider using PascalCase or lowercase for consistency</description></item>
	/// <item><description>Empty strings are allowed but defeat the purpose of type identification</description></item>
	/// </list>
	/// <para>
	/// <strong>Important Notes:</strong>
	/// </para>
	/// <list type="bullet">
	/// <item><description>The underscore separator is fixed and cannot be customized</description></item>
	/// <item><description>Prefix is not validated; ensure it doesn't contain underscore to avoid parsing ambiguity</description></item>
	/// <item><description>Keys are NOT time-sortable (use <see cref="GenerateSortableKey(string)"/> for that)</description></item>
	/// <item><description>The method is thread-safe and suitable for concurrent use</description></item>
	/// </list>
	/// </remarks>
	/// <example>
	/// Entity type identification:
	/// <code>
	/// string userId = KeyGenerator.GenerateKey("User");
	/// // Returns: "User_f7f0af78003d4ab194b5a4024d02112a"
	/// 
	/// string orderId = KeyGenerator.GenerateKey("Order");
	/// // Returns: "Order_a3b8c9d1e2f3g4h5i6j7k8l9m0n1o2p3"
	/// 
	/// string productId = KeyGenerator.GenerateKey("Product");
	/// // Returns: "Product_b2c3d4e5f6g7h8i9j0k1l2m3n4o5p6q7"
	/// </code>
	/// 
	/// Database entity with prefixed key:
	/// <code>
	/// public class Customer
	/// {
	///     public string CustomerId { get; set; } = KeyGenerator.GenerateKey("Customer");
	///     public string Name { get; set; }
	///     public string Email { get; set; }
	/// }
	/// 
	/// var customer = new Customer
	/// {
	///     Name = "John Doe",
	///     Email = "john@example.com"
	/// };
	/// 
	/// await database.Customers.AddAsync(customer);
	/// // customer.CustomerId = "Customer_c3d4e5f6g7h8i9j0k1l2m3n4o5p6q7r8"
	/// </code>
	/// 
	/// Multi-tenant application:
	/// <code>
	/// string tenantId = "TenantA";
	/// string resourceId = KeyGenerator.GenerateKey(tenantId);
	/// // Returns: "TenantA_d4e5f6g7h8i9j0k1l2m3n4o5p6q7r8s9"
	/// 
	/// // Store resource with tenant-specific key
	/// await storage.SaveAsync(resourceId, resourceData);
	/// </code>
	/// 
	/// Environment-specific keys:
	/// <code>
	/// string environment = Configuration["Environment"]; // "Development"
	/// string cacheKey = KeyGenerator.GenerateKey(environment);
	/// // Returns: "Development_e5f6g7h8i9j0k1l2m3n4o5p6q7r8s9t0"
	/// 
	/// await cache.SetAsync(cacheKey, data);
	/// </code>
	/// 
	/// Type-safe entity creation:
	/// <code>
	/// public abstract class Entity
	/// {
	///     protected Entity(string prefix)
	///     {
	///         Id = KeyGenerator.GenerateKey(prefix);
	///         CreatedAt = DateTime.UtcNow;
	///     }
	///     
	///     public string Id { get; private set; }
	///     public DateTime CreatedAt { get; private set; }
	/// }
	/// 
	/// public class Invoice : Entity
	/// {
	///     public Invoice() : base("Invoice") { }
	///     public decimal Amount { get; set; }
	/// }
	/// 
	/// var invoice = new Invoice { Amount = 1500.00m };
	/// // invoice.Id = "Invoice_f6g7h8i9j0k1l2m3n4o5p6q7r8s9t0u1"
	/// </code>
	/// 
	/// Parsing prefix from key:
	/// <code>
	/// string key = KeyGenerator.GenerateKey("Order");
	/// // key = "Order_g7h8i9j0k1l2m3n4o5p6q7r8s9t0u1v2"
	/// 
	/// // Extract entity type from key
	/// string entityType = key.Split('_')[0];
	/// // Returns: "Order"
	/// 
	/// // Extract GUID portion
	/// string guid = key.Split('_')[1];
	/// // Returns: "g7h8i9j0k1l2m3n4o5p6q7r8s9t0u1v2"
	/// </code>
	/// 
	/// Repository pattern with typed keys:
	/// <code>
	/// public class Repository&lt;T&gt; where T : class
	/// {
	///     private readonly string _entityPrefix;
	///     
	///     public Repository()
	///     {
	///         _entityPrefix = typeof(T).Name;
	///     }
	///     
	///     public string GenerateId()
	///     {
	///         return KeyGenerator.GenerateKey(_entityPrefix);
	///     }
	/// }
	/// 
	/// var userRepo = new Repository&lt;User&gt;();
	/// string newUserId = userRepo.GenerateId();
	/// // Returns: "User_h8i9j0k1l2m3n4o5p6q7r8s9t0u1v2w3"
	/// </code>
	/// 
	/// API resource URLs:
	/// <code>
	/// string customerId = KeyGenerator.GenerateKey("Customer");
	/// string apiUrl = $"https://api.example.com/customers/{customerId}";
	/// // Returns: "https://api.example.com/customers/Customer_i9j0k1l2m3n4o5p6q7r8s9t0u1v2w3x4"
	/// 
	/// // The prefix in the URL makes it clear what resource type is being accessed
	/// </code>
	/// </example>
	/// <seealso cref="GenerateSortableKey(string)"/>
	/// <seealso cref="GenerateCustomKey(char, bool, string[])"/>
	[return: NotNull]
	[Information(nameof(GenerateKey), "David McCarter", "5/30/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Documentation = "https://bit.ly/SpargineJun2021", Status = Status.Available)]
	public static string GenerateKey([DisallowNull] string prefix)
	{
		return $"{prefix.ArgumentNotNull()}_{Guid.NewGuid().ToString("N", CultureInfo.InvariantCulture)}";
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
