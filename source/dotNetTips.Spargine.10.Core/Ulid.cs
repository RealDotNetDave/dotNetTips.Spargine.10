// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 08-03-2024
//
// Last Modified By : David McCarter
// Last Modified On : 12-24-2025
// ***********************************************************************
// <copyright file="Ulid.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// The `UlidGenerator` class can be used to generate unique identifiers
// that are lexicographically sortable, making them useful for
// databases and other systems that benefit from ordered unique identifiers.
// </summary>
// ***********************************************************************

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using DotNetTips.Spargine.Core;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Represents a Universally Unique Lexicographically Sortable Identifier (ULID).
/// </summary>
[Information(Status = Status.New)]
public readonly struct Ulid : IEquatable<Ulid>, IComparable<Ulid>
{
	/// <summary>
	/// The characters used for Base32 encoding.
	/// </summary>
	private static readonly char[] Base32Chars = "0123456789ABCDEFGHJKMNPQRSTVWXYZ".ToCharArray();

	/// <summary>
	/// A dictionary mapping Base32 characters to their integer values for decoding.
	/// </summary>
	private static readonly Dictionary<char, int> Base32CharToValue = Base32Chars
	.Select((c, i) => new { c, i })
	.ToDictionary(x => x.c, x => x.i);

	/// <summary>
	/// The string representation of the ULID.
	/// </summary>
	private readonly string _ulid;

	/// <summary>
	/// The length of the random component in the ULID.
	/// </summary>
	private const int RandomLength = 16;

	/// <summary>
	/// The length of the timestamp component in the ULID.
	/// </summary>
	private const int TimestampLength = 10;

	/// <summary>
	/// The total length of the ULID.
	/// </summary>
	private const int UlidLength = 26;

	/// <summary>
	/// Initializes a new instance of the <see cref="Ulid"/> struct.
	/// </summary>
	/// <param name="value">The string representation of the ULID.</param>
	/// <exception cref="ArgumentException">Thrown if the value is not a valid ULID.</exception>
	[Information(nameof(Ulid), UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public Ulid([DisallowNull] string value)
	{
		if (string.IsNullOrWhiteSpace(value) || value.Length != UlidLength)
		{
			ExceptionThrower.ThrowArgumentException($"Invalid ULID. A ULID must be exactly {UlidLength} characters long.", nameof(value));
		}

		this._ulid = value;
	}

	/// <summary>
	/// Determines whether two <see cref="Ulid"/> instances are not equal.
	/// </summary>
	/// <param name="left">The first <see cref="Ulid"/> instance.</param>
	/// <param name="right">The second <see cref="Ulid"/> instance.</param>
	/// <returns><c>true</c> if the ULIDs are not equal; otherwise, <c>false</c>.</returns>
	[Information("!=", UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public static bool operator !=(Ulid left, Ulid right) => !left.Equals(right);

	/// <summary>
	/// Determines whether one <see cref="Ulid"/> is less than another.
	/// </summary>
	/// <param name="left">The first <see cref="Ulid"/> instance.</param>
	/// <param name="right">The second <see cref="Ulid"/> instance.</param>
	/// <returns><c>true</c> if <paramref name="left"/> is less than <paramref name="right"/>; otherwise, <c>false</c>.</returns>
	[Information("<", UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public static bool operator <(Ulid left, Ulid right) => left.CompareTo(right) < 0;

	/// <summary>
	/// Determines whether one <see cref="Ulid"/> is less than or equal to another.
	/// </summary>
	/// <param name="left">The first <see cref="Ulid"/> instance.</param>
	/// <param name="right">The second <see cref="Ulid"/> instance.</param>
	/// <returns><c>true</c> if <paramref name="left"/> is less than or equal to <paramref name="right"/>; otherwise, <c>false</c>.</returns>
	[Information("<=", UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public static bool operator <=(Ulid left, Ulid right) => left.CompareTo(right) <= 0;

	/// <summary>
	/// Determines whether two <see cref="Ulid"/> instances are equal.
	/// </summary>
	/// <param name="left">The first <see cref="Ulid"/> instance.</param>
	/// <param name="right">The second <see cref="Ulid"/> instance.</param>
	/// <returns><c>true</c> if the ULIDs are equal; otherwise, <c>false</c>.</returns>
	[Information("==", UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public static bool operator ==(Ulid left, Ulid right) => left.Equals(right);

	/// <summary>
	/// Determines whether one <see cref="Ulid"/> is greater than another.
	/// </summary>
	/// <param name="left">The first <see cref="Ulid"/> instance.</param>
	/// <param name="right">The second <see cref="Ulid"/> instance.</param>
	/// <returns><c>true</c> if <paramref name="left"/> is greater than <paramref name="right"/>; otherwise, <c>false</c>.</returns>
	[Information(">", UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public static bool operator >(Ulid left, Ulid right) => left.CompareTo(right) > 0;

	/// <summary>
	/// Determines whether one <see cref="Ulid"/> is greater than or equal to another.
	/// </summary>
	/// <param name="left">The first <see cref="Ulid"/> instance.</param>
	/// <param name="right">The second <see cref="Ulid"/> instance.</param>
	/// <returns><c>true</c> if <paramref name="left"/> is greater than or equal to <paramref name="right"/>; otherwise, <c>false</c>.</returns>
	[Information(">=", UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public static bool operator >=(Ulid left, Ulid right) => left.CompareTo(right) >= 0;

	/// <summary>
	/// Encodes a byte span into a Base32 encoded character span using Crockford's Base32 alphabet.
	/// </summary>
	/// <remarks>
	/// This method converts a sequence of bytes into a Base32 encoded string representation.
	/// Base32 encoding is used to ensure that the ULID is represented in a compact and human-readable format.
	/// The implementation uses bit manipulation for optimal performance.
	/// </remarks>
	/// <param name="bytes">The byte span to encode.</param>
	/// <param name="chars">The character span to store the encoded characters.</param>
	/// <param name="charIndex">The starting index in the character span where encoding begins.</param>
	/// <param name="length">The number of characters to encode.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(EncodeBase32), OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
	private static void EncodeBase32(ReadOnlySpan<byte> bytes, Span<char> chars, int charIndex, int length)
	{
		const int Mask = 0x1F;
		var byteIndex = 0;
		var bitIndex = 0;

		for (var index = 0; index < length; index++)
		{
			int value;

			if (bitIndex > 3)
			{
				// Need to read from two bytes
				var currentByte = bytes[byteIndex];
				var nextByte = byteIndex + 1 < bytes.Length ? bytes[byteIndex + 1] : 0;
				var dualByte = (currentByte << 8) | nextByte;
				value = (dualByte >> (16 - bitIndex - 5)) & Mask;
				byteIndex++;
				bitIndex = (bitIndex + 5) & 7; // Equivalent to (bitIndex + 5) % 8
			}
			else
			{
				// Can read from single byte
				value = (bytes[byteIndex] >> (3 - bitIndex)) & Mask;
				bitIndex += 5;

				if (bitIndex >= 8)
				{
					bitIndex -= 8;
					byteIndex++;
				}
			}

			chars[charIndex + index] = Base32Chars[value];
		}
	}


	/// <summary>
	/// Generates a random byte array for the ULID.
	/// </summary>
	/// <remarks>
	/// This method generates a 10-byte array filled with cryptographically secure random values.
	/// The random bytes are used as part of the ULID's unique identifier.
	/// </remarks>
	/// <returns>A byte array containing 10 random bytes.</returns>
	[Information(nameof(GenerateRandomBytes), Status = Status.New)]
	private static byte[] GenerateRandomBytes()
	{
		var randomBytes = new byte[10];
		RandomNumberGenerator.Fill(randomBytes);
		return randomBytes;
	}

	/// <summary>
	/// Gets the current timestamp in milliseconds since the Unix epoch.
	/// </summary>
	/// <remarks>
	/// The timestamp is represented as a byte array and is used as the time component of the ULID.
	/// This ensures that ULIDs are lexicographically sortable based on their creation time.
	/// </remarks>
	/// <returns>A byte array representing the current timestamp in milliseconds since the Unix epoch.</returns>
	[Information(nameof(GenerateTimeStamp), Status = Status.New)]
	private static byte[] GenerateTimeStamp() => BitConverter.GetBytes(DateTimeOffset.UtcNow.ToUnixTimeMilliseconds());

	/// <summary>
	/// Compares this instance to another <see cref="Ulid"/> instance.
	/// </summary>
	/// <param name="other">The other <see cref="Ulid"/> instance to compare to.</param>
	/// <returns>An integer indicating the relative order of the ULIDs.</returns>
	[Information(nameof(CompareTo), UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public int CompareTo(Ulid other) => string.Compare(this._ulid, other._ulid, StringComparison.Ordinal);

	/// <summary>
	/// Determines whether this instance is equal to another <see cref="Ulid"/> instance.
	/// </summary>
	/// <param name="other">The other <see cref="Ulid"/> instance to compare to.</param>
	/// <returns><c>true</c> if the ULIDs are equal; otherwise, <c>false</c>.</returns>
	[Information(nameof(Equals), UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public bool Equals(Ulid other) => string.Equals(this._ulid, other._ulid, StringComparison.Ordinal);

	/// <summary>
	/// Determines whether this instance is equal to another object.
	/// </summary>
	/// <param name="obj">The object to compare to.</param>
	/// <returns><c>true</c> if the object is a <see cref="Ulid"/> and is equal to this instance; otherwise, <c>false</c>.</returns>
	[Information(nameof(Equals), UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public override bool Equals(object? obj) => obj is Ulid other && this.Equals(other);

	/// <summary>
	/// Gets the hash code for this instance.
	/// </summary>
	/// <returns>The hash code for this instance.</returns>
	[Information(nameof(GetHashCode), UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public override int GetHashCode() => this._ulid.GetHashCode(StringComparison.Ordinal);

	/// <summary>
	/// Extracts the timestamp from the ULID.
	/// </summary>
	/// <returns>The timestamp as a <see cref="DateTimeOffset"/>.</returns>
	[Information(nameof(GetTimeStamp), BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, Status = Status.New)]
	public DateTimeOffset GetTimeStamp()
	{
		var timestampChars = this._ulid.AsSpan(0, TimestampLength);
		var timestampBytes = new byte[6]; // 48 bits for the timestamp

		var bitIndex = 0;
		var byteIndex = 0;

		foreach (var c in timestampChars)
		{
			if (!Base32CharToValue.TryGetValue(c, out var value))
			{
				ExceptionThrower.ThrowArgumentException($"Invalid character '{c}' in ULID.", nameof(Ulid));
			}

			for (var i = 4; i >= 0; i--)
			{
				if (bitIndex == 8)
				{
					bitIndex = 0;
					byteIndex++;
				}

				if (byteIndex < timestampBytes.Length)
				{
					timestampBytes[byteIndex] |= (byte)((byte)((value >> i) & 1) << (7 - bitIndex));
					bitIndex++;
				}
			}
		}

		var padded = new byte[8];
		Buffer.BlockCopy(timestampBytes, 0, padded, 0, 6); // Copy to beginning, not offset 2
		var timestampMilliseconds = BitConverter.ToInt64(padded, 0);
		return DateTimeOffset.FromUnixTimeMilliseconds(timestampMilliseconds);
	}

	/// <summary>
	/// Generates a new ULID (Universally Unique Lexicographically Sortable Identifier).
	/// </summary>
	/// <returns>A new <see cref="Ulid"/> instance with timestamp and random components.</returns>
	/// <remarks>
	/// <para>
	/// This method generates a ULID that consists of:
	/// </para>
	/// <list type="bullet">
	/// <item><description>48-bit timestamp (milliseconds since Unix epoch) - 10 characters</description></item>
	/// <item><description>80-bit cryptographically secure random data - 16 characters</description></item>
	/// </list>
	/// <para>
	/// The implementation uses stack allocation to avoid heap allocations, providing optimal performance
	/// for high-frequency ULID generation scenarios.
	/// </para>
	/// </remarks>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(NewUlid), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
	public static Ulid NewUlid()
	{
		// Allocate all required memory on the stack to avoid heap allocations
		Span<char> ulidChars = stackalloc char[UlidLength];
		Span<byte> timestampBytes = stackalloc byte[8];
		Span<byte> randomBytes = stackalloc byte[10];

		// Generate timestamp (48 bits = 6 bytes) - use unchecked for performance
		var timestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();

		// Write timestamp directly using unsafe code for maximum performance
		unsafe
		{
			fixed (byte* pTimestamp = timestampBytes)
			{
				*(long*)pTimestamp = timestamp;
			}
		}

		// Encode timestamp component (10 characters) - only encode the 6 bytes we need
		EncodeBase32(timestampBytes[..6], ulidChars, 0, TimestampLength);

		// Generate cryptographically secure random bytes (80 bits = 10 bytes)
		RandomNumberGenerator.Fill(randomBytes);

		// Encode random component (16 characters)
		EncodeBase32(randomBytes, ulidChars, TimestampLength, RandomLength);

		// Create and return the ULID - use string constructor that accepts ReadOnlySpan<char>
		return new Ulid(new string(ulidChars));
	}

	/// <summary>
	/// Parses a string into a <see cref="Ulid"/> instance.
	/// </summary>
	/// <param name="value">The string representation of the ULID.</param>
	/// <returns>A <see cref="Ulid"/> instance.</returns>
	/// <exception cref="ArgumentException">Thrown if the value is not a valid ULID.</exception>
	[return: NotNull]
	[Information(nameof(Parse), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.New)]
	public static Ulid Parse(string value) => new(value);

	/// <summary>
	/// Gets the string representation of the ULID.
	/// </summary>
	/// <returns>The string representation of the ULID.</returns>
	[return: NotNull]
	[Information(nameof(ToString), UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public override string ToString() => this._ulid;

	/// <summary>
	/// Tries to parse a string into a <see cref="Ulid"/> instance.
	/// </summary>
	/// <param name="value">The string representation of the ULID.</param>
	/// <param name="ulid">The resulting <see cref="Ulid"/> instance, if successful.</param>
	/// <returns><c>true</c> if parsing was successful; otherwise, <c>false</c>.</returns>
	[Information(nameof(TryParse), UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public static bool TryParse(string value, out Ulid ulid)
	{
		if (!string.IsNullOrWhiteSpace(value) && value.Length == UlidLength)
		{
			ulid = new Ulid(value);
			return true;
		}

		ulid = default;
		return false;
	}
}
