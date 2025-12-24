// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 05-09-2025
//
// Last Modified By : David McCarter
// Last Modified On : 12-17-2025
// ***********************************************************************
// <copyright file="DiagnosticEntry.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Diagnostics;

/// <summary>
/// Represents a single diagnostic message entry with timestamp and elapsed time tracking.
/// </summary>
/// <param name="timestamp">
/// The UTC timestamp when the diagnostic entry was recorded. Cannot be <c>null</c>.
/// </param>
/// <param name="message">
/// The diagnostic message content. Cannot be <c>null</c> or empty.
/// Whitespace is automatically trimmed from the beginning and end of the message.
/// </param>
/// <param name="elapsed">
/// The elapsed time when the diagnostic entry was recorded. Cannot be <c>null</c>.
/// </param>
/// <remarks>
/// This is a <see langword="readonly"/> <see langword="struct"/> that uses a primary constructor to initialize its properties.
/// All three parameters are required and captured as immutable properties.
/// <para>
/// <strong>Primary Constructor Behavior:</strong>
/// The primary constructor parameters are captured and exposed as read-only auto-properties (<see cref="Timestamp"/>, 
/// <see cref="Message"/>, and <see cref="Elapsed"/>). The <paramref name="message"/> parameter is validated and trimmed 
/// during property initialization.
/// </para>
/// <para>
/// <strong>Immutability:</strong>
/// This struct is immutable. All properties are read-only and set only during construction.
/// The <see langword="readonly"/> modifier ensures that no instance members can modify the struct's state.
/// </para>
/// <para>
/// <strong>Value Type Semantics:</strong>
/// As a struct, <see cref="DiagnosticEntry"/> is a value type and is typically allocated on the stack.
/// Instances are compared by value, and the struct implements <see cref="IEquatable{T}"/> for efficient equality comparisons.
/// </para>
/// </remarks>
/// <example>
/// Example usage:
/// <code>
/// // Create a diagnostic entry
/// var entry = new DiagnosticEntry(
///     DateTimeOffset.UtcNow,
///     "Operation completed successfully",
///     TimeSpan.FromMilliseconds(125.5)
/// );
/// 
/// // Access properties
/// Console.WriteLine(entry.Timestamp);  // UTC timestamp
/// Console.WriteLine(entry.Message);    // Trimmed message
/// Console.WriteLine(entry.Elapsed);    // TimeSpan
/// 
/// // String representation
/// Console.WriteLine(entry.ToString());
/// // Output: "2025-05-08 14:30:45Z - Operation completed successfully (125.5 ms)"
/// 
/// // Equality comparison
/// var entry2 = new DiagnosticEntry(entry.Timestamp, entry.Message, entry.Elapsed);
/// bool areEqual = entry == entry2;  // true
/// </code>
/// </example>
/// <exception cref="ArgumentNullException">
/// Thrown when <paramref name="message"/> is <c>null</c>.
/// </exception>
/// <seealso cref="IEquatable{T}"/>
[Information("DiagnosticEntry", "David McCarter", "05/08/2025", Status = Status.New)]
[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
public readonly struct DiagnosticEntry([NotNull] DateTimeOffset timestamp, [NotNull] string message, [NotNull] TimeSpan elapsed) : IEquatable<DiagnosticEntry>
{

	/// <summary>
	/// Determines whether two <see cref="DiagnosticEntry"/> instances are not equal.
	/// </summary>
	/// <param name="left">The first <see cref="DiagnosticEntry"/> to compare.</param>
	/// <param name="right">The second <see cref="DiagnosticEntry"/> to compare.</param>
	/// <returns>
	/// <c>true</c> if the two <see cref="DiagnosticEntry"/> instances are not equal; otherwise, <c>false</c>.
	/// </returns>
	public static bool operator !=(DiagnosticEntry left, DiagnosticEntry right) => !(left == right);

	/// <summary>
	/// Determines whether two <see cref="DiagnosticEntry"/> instances are equal.
	/// </summary>
	/// <param name="left">The first <see cref="DiagnosticEntry"/> to compare.</param>
	/// <param name="right">The second <see cref="DiagnosticEntry"/> to compare.</param>
	/// <returns>
	/// <c>true</c> if the two <see cref="DiagnosticEntry"/> instances are equal; otherwise, <c>false</c>.
	/// </returns>
	public static bool operator ==(DiagnosticEntry left, DiagnosticEntry right) => left.Equals(right);

	private string GetDebuggerDisplay() => this.ToString();

	/// <summary>
	/// Determines whether the specified object is equal to the current <see cref="DiagnosticEntry"/>.
	/// </summary>
	/// <param name="obj">The object to compare with the current <see cref="DiagnosticEntry"/>.</param>
	/// <returns>
	/// <c>true</c> if the specified object is equal to the current <see cref="DiagnosticEntry"/>; otherwise, <c>false</c>.
	/// </returns>
	[Information(nameof(Equals), UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public override bool Equals(object? obj) => obj is DiagnosticEntry other && this.Equals(other);

	/// <summary>
	/// Determines whether the specified <see cref="DiagnosticEntry"/> is equal to the current <see cref="DiagnosticEntry"/>.
	/// </summary>
	/// <param name="other">The <see cref="DiagnosticEntry"/> to compare with the current instance.</param>
	/// <returns>
	/// <c>true</c> if the specified <see cref="DiagnosticEntry"/> is equal to the current instance; otherwise, <c>false</c>.
	/// </returns>
	[Information(nameof(Equals), UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public bool Equals(DiagnosticEntry other) => this.Timestamp == other.Timestamp && string.Equals(this.Message, other.Message, StringComparison.Ordinal) && this.Elapsed == other.Elapsed;

	/// <summary>
	/// Returns a hash code for the current <see cref="DiagnosticEntry"/>.
	/// </summary>
	/// <returns>
	/// A hash code for the current <see cref="DiagnosticEntry"/>.
	/// </returns>
	[Information(nameof(GetHashCode), UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public override int GetHashCode() => HashCode.Combine(this.Timestamp, this.Message, this.Elapsed);

	/// <summary>
	/// Returns a string representation of the diagnostic entry.
	/// </summary>
	/// <returns>A string representation of the diagnostic entry.</returns>
	[Information(nameof(ToString), UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public override string ToString() => $"{this.Timestamp:u} - {this.Message} ({this.Elapsed.TotalMilliseconds} ms)";

	/// <summary>
	/// Gets the elapsed time when the diagnostic entry was recorded.
	/// </summary>
	[Information(nameof(Elapsed), UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public TimeSpan Elapsed { get; } = elapsed;

	/// <summary>
	/// Gets the content of the diagnostic message.
	/// </summary>
	/// <value>
	/// The trimmed diagnostic message content. Leading and trailing whitespace is automatically removed.
	/// </value>
	/// <remarks>
	/// This property is initialized from the primary constructor parameter <c>message</c>.
	/// <para>
	/// <strong>Validation and Transformation:</strong>
	/// The property initializer performs two operations:
	/// <list type="number">
	/// <item><description>Validates that the <c>message</c> parameter is not <c>null</c></description></item>
	/// <item><description>Trims leading and trailing whitespace using <see cref="string.Trim()"/></description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Null Handling:</strong>
	/// Uses the null-coalescing operator (<c>??</c>) combined with a throw expression to ensure
	/// non-null assignment. If <c>message</c> is <c>null</c>, an <see cref="ArgumentNullException"/> is thrown
	/// immediately during construction, preventing invalid instances from being created.
	/// </para>
	/// <para>
	/// <strong>Immutability:</strong>
	/// This property is read-only and can only be set during struct initialization.
	/// Once a <see cref="DiagnosticEntry"/> is created, the message cannot be changed.
	/// </para>
	/// </remarks>
	/// <example>
	/// Example initialization scenarios:
	/// <code>
	/// // Valid - message with whitespace is trimmed
	/// var entry1 = new DiagnosticEntry(
	///     DateTimeOffset.UtcNow,
	///     "  Operation completed  ",  // Stored as "Operation completed"
	///     TimeSpan.FromSeconds(1)
	/// );
	/// 
	/// // Valid - message without whitespace remains unchanged
	/// var entry2 = new DiagnosticEntry(
	///     DateTimeOffset.UtcNow,
	///     "Error occurred",  // Stored as "Error occurred"
	///     TimeSpan.FromSeconds(2)
	/// );
	/// 
	/// // Invalid - throws ArgumentNullException
	/// try
	/// {
	///     var entry3 = new DiagnosticEntry(
	///         DateTimeOffset.UtcNow,
	///         null,  // Throws ArgumentNullException
	///         TimeSpan.FromSeconds(3)
	///     );
	/// }
	/// catch (ArgumentNullException ex)
	/// {
	///     Console.WriteLine(ex.Message);  // "Message cannot be null. (Parameter 'message')"
	/// }
	/// </code>
	/// </example>
	/// <exception cref="ArgumentNullException">
	/// Thrown during construction when the <c>message</c> parameter is <c>null</c>.
	/// </exception>
	/// <seealso cref="string.Trim()"/>
	[Information(nameof(Message), UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public string Message { get; } = message?.Trim() ?? throw new ArgumentNullException(nameof(message), "Message cannot be null.");

	/// <summary>
	/// Gets the UTC timestamp when the diagnostic entry was recorded.
	/// </summary>
	/// <value>
	/// A <see cref="DateTimeOffset"/> representing the UTC time when this diagnostic entry was created.
	/// </value>
	/// <remarks>
	/// This property is initialized from the primary constructor parameter <c>timestamp</c>.
	/// <para>
	/// <strong>UTC Time:</strong>
	/// The timestamp should represent Coordinated Universal Time (UTC) to ensure consistency across time zones.
	/// While the property accepts any <see cref="DateTimeOffset"/> value, it is recommended to use
	/// <see cref="DateTimeOffset.UtcNow"/> when creating diagnostic entries.
	/// </para>
	/// <para>
	/// <strong>Immutability:</strong>
	/// This property is read-only and can only be set during struct initialization.
	/// Once a <see cref="DiagnosticEntry"/> is created, the timestamp cannot be changed.
	/// </para>
	/// <para>
	/// <strong>Equality Comparison:</strong>
	/// The timestamp is used in equality comparisons via <see cref="Equals(DiagnosticEntry)"/> and
	/// <see cref="GetHashCode"/>. Two <see cref="DiagnosticEntry"/> instances are considered equal
	/// only if their timestamps, messages, and elapsed times are all equal.
	/// </para>
	/// </remarks>
	/// <example>
	/// Example usage:
	/// <code>
	/// // Create entry with UTC timestamp
	/// var entry = new DiagnosticEntry(
	///     DateTimeOffset.UtcNow,
	///     "Process started",
	///     TimeSpan.Zero
	/// );
	/// 
	/// // Access the timestamp
	/// Console.WriteLine($"Recorded at: {entry.Timestamp:u}");
	/// // Output: "Recorded at: 2025-05-08 14:30:45Z"
	/// 
	/// // Compare timestamps
	/// var entry2 = new DiagnosticEntry(
	///     entry.Timestamp.AddSeconds(1),
	///     "Process completed",
	///     TimeSpan.FromSeconds(1)
	/// );
	/// 
	/// bool sameTime = entry.Timestamp == entry2.Timestamp;  // false
	/// </code>
	/// </example>
	/// <seealso cref="DateTimeOffset"/>
	/// <seealso cref="DateTimeOffset.UtcNow"/>
	[Information(nameof(Timestamp), UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public DateTimeOffset Timestamp { get; } = timestamp;
}
