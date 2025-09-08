using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using DotNetTips.Spargine.Core;

namespace DotNetTips.Spargine.Core.Security;

public static class BarcodeGenerator
{
	private const string ALG = "alg";
	private const string ALG_H256 = "H256";
	private const int DefaultMacLenBytes = 10; // compact & robust
	private const string EXP = "e";
	private const string ISS = "iss";
	private const string KID = "kid";
	private const string PID = "pid";
	private const string SIG = "sig";
	private const string TID = "tid";
	private const string V = "v";

	private static byte[] ComputeHmacTruncated(string payload, byte[] key, int macLenBytes)
	{
		using var hmac = new HMACSHA256(key);
		var full = hmac.ComputeHash(Encoding.UTF8.GetBytes(payload));

		if (macLenBytes >= full.Length)
		{
			return full;
		}

		var sig = new byte[macLenBytes];
		Buffer.BlockCopy(full, 0, sig, 0, macLenBytes);

		return sig;
	}

	public static string BuildHmacBarcode(string ticketId, string performanceId, DateTimeOffset expiresUtc, string issuer, byte[] key, string kid, int macLenBytes = DefaultMacLenBytes)
	{
		ticketId = ticketId.ArgumentNotNullOrEmpty();
		performanceId = performanceId.ArgumentNotNullOrEmpty();
		issuer = issuer.ArgumentNotNullOrEmpty();
		kid = kid.ArgumentNotNullOrEmpty();
		key = [.. key.ArgumentCountInRange(min: 16, max: 64, paramName: nameof(key))];
		macLenBytes = macLenBytes.ArgumentInRange(min: 1, max: 32, paramName: nameof(macLenBytes));

		var payload =
			$"{V}=1|{TID}={ticketId}|{PID}={performanceId}|{EXP}={expiresUtc.ToUnixTimeSeconds()}|{ISS}={issuer}|{ALG}={ALG_H256}|{KID}={kid}";

		var sigBytes = ComputeHmacTruncated(payload, key, macLenBytes);
		var sigText = Crockford32.Encode(sigBytes); // uppercase, no padding
		return $"{payload}|{SIG}={sigText}";
	}


	public static bool ValidateHmacBarcode(string barcode, IReadOnlyDictionary<string, byte[]> keysByKid, out Dictionary<string, string> fields, int macLenBytes = DefaultMacLenBytes, TimeSpan? maxSkew = null, TimeSpan? pastExpiryGrace = null)
	{
		fields = new(StringComparer.OrdinalIgnoreCase);

		if (barcode.CheckIsNotNullOrEmpty() != true)
		{
			return false;
		}

		if (keysByKid.CheckIsNotNull() != true)
		{
			return false;
		}

		if (keysByKid.Count == 0)
		{
			return false;
		}


		if (macLenBytes.CheckIsInRange(1, 32) == false)
		{
			return false;
		}

		// Split at last "|sig="
		var sigIdx = barcode.LastIndexOf("|" + SIG + "=", StringComparison.Ordinal);

		if (sigIdx < 0)
		{
			return false;
		}

		var payload = barcode[..sigIdx];
		var sigPart = barcode[(sigIdx + SIG.Length + 2)..]; // skip "|sig="

		// Parse k=v pairs
		foreach (var part in payload.Split('|'))
		{
			var kv = part.Split('=', 2);
			if (kv.Length == 2)
			{
				fields[kv[0]] = kv[1];
			}
		}

		// Basic fields
		if (!fields.TryGetValue(V, out var v) || v != "1")
		{
			return false;
		}

		if (!fields.TryGetValue(ALG, out var alg) || !alg.Equals(ALG_H256, StringComparison.OrdinalIgnoreCase))
		{
			return false;
		}

		// Decode signature
		byte[] providedSig;
		try
		{
			providedSig = Crockford32.Decode(sigPart);
		}
		catch
		{
			return false;
		}

		if (providedSig.Length is 0 or > 32)
		{
			return false;
		}

		// Optional expiry check
		if (fields.TryGetValue(EXP, out var eStr) && long.TryParse(eStr, out var epoch))
		{
			var now = DateTimeOffset.UtcNow + (maxSkew ?? TimeSpan.Zero);
			var expires = DateTimeOffset.FromUnixTimeSeconds(epoch);
			if (expires + (pastExpiryGrace ?? TimeSpan.Zero) < now)
			{
				return false;
			}
		}

		// Key selection (by kid if present, else try all)
		IEnumerable<byte[]> candidates;
		if (fields.TryGetValue(KID, out var kid) && keysByKid.TryGetValue(kid, out var key))
		{
			candidates = new[] { key };
		}
		else
		{
			candidates = keysByKid.Values;
		}

		foreach (var k in candidates)
		{
			var expected = ComputeHmacTruncated(payload, k, macLenBytes);
			var n = Math.Min(expected.Length, providedSig.Length);
			if (n == 0)
			{
				continue;
			}

			if (CryptographicOperations.FixedTimeEquals(expected.AsSpan(0, n), providedSig.AsSpan(0, n)))
			{
				return true;
			}
		}
		return false;
	}
}

internal static class Crockford32
{
	// Alphabet: 0..9 A..Z without I, L, O, U
	private const string Alphabet = "0123456789ABCDEFGHJKMNPQRSTVWXYZ";

	private static readonly sbyte[] Map = BuildMap();

	private static sbyte[] BuildMap()
	{
		var map = Enumerable.Repeat<sbyte>(-1, 128).ToArray();
		for (var i = 0; i < Alphabet.Length; i++)
		{
			map[Alphabet[i]] = (sbyte)i;
		}
		// Ambiguity aliases
		map['I'] = map['1'] = map['L'] = map['1'];
		map['O'] = map['0'] = map['0'];
		// Lowercase support
		for (var c = 'a'; c <= 'z'; c++)
		{
			var up = char.ToUpperInvariant(c);
			if (up < 128 && map[up] >= 0)
			{
				map[c] = map[up];
			}
		}
		return map;
	}

	public static byte[] Decode(string text)
	{
		if (string.IsNullOrWhiteSpace(text))
		{
			return [];
		}

		// Normalize: uppercase, strip hyphens/spaces, map I/L->1 and O->0
		Span<char> norm = stackalloc char[text.Length];
		var n = 0;
		foreach (var ch in text)
		{
			if (ch is '-' or ' ')
			{
				continue;
			}

			var c = char.ToUpperInvariant(ch);
			if (c is 'I' or 'L')
			{
				c = '1';
			}
			else if (c == 'O')
			{
				c = '0';
			}

			norm[n++] = c;
		}

		int buffer = 0, bitsLeft = 0;
		var bytes = new List<byte>((int)Math.Floor(n * 5 / 8.0));
		for (var i = 0; i < n; i++)
		{
			var c = norm[i];
			var v = (c < 128) ? Map[c] : -1;
			if (v < 0)
			{
				throw new FormatException($"Invalid Base32 character '{c}'.");
			}

			buffer = (buffer << 5) | v;
			bitsLeft += 5;
			if (bitsLeft >= 8)
			{
				bytes.Add((byte)((buffer >> (bitsLeft - 8)) & 0xFF));
				bitsLeft -= 8;
			}
		}
		return [.. bytes];
	}

	public static string Encode(ReadOnlySpan<byte> data)
	{
		if (data.Length == 0)
		{
			return string.Empty;
		}

		var sb = new StringBuilder((int)Math.Ceiling(data.Length * 8 / 5.0));
		int buffer = 0, bitsLeft = 0;
		foreach (var b in data)
		{
			buffer = (buffer << 8) | b;
			bitsLeft += 8;
			while (bitsLeft >= 5)
			{
				var index = (buffer >> (bitsLeft - 5)) & 31;
				_ = sb.Append(Alphabet[index]);
				bitsLeft -= 5;
			}
		}
		if (bitsLeft > 0)
		{
			var index = (buffer << (5 - bitsLeft)) & 31;
			_ = sb.Append(Alphabet[index]);
		}
		return sb.ToString();
	}
}

// ----------- Demo (remove in production if you like) -----------
internal static class Program
{
	private const string Kid = "2025-08a";

	// Example 32-byte key (DEV ONLY!). In prod, load from your secret store.
	private static readonly byte[] DevKey = Convert.FromBase64String("3LHykMQCAZPQTWGNVqwm+9UZQLk32hmnR0gVLC9Nhfw=");

	private static readonly IReadOnlyDictionary<string, byte[]> KeyRing = new Dictionary<string, byte[]>
	{
		[Kid] = DevKey
	};

	private static void Main()
	{
		var tid = "01J9E8W3S1S9P8WQKD3B3CP9T7";              // ULID/Guid/etc.
		var pid = "01J9E8W6D4SQFK6E9RWQ2Z6B2D";              // ULID/Guid/etc.
		var exp = DateTimeOffset.UtcNow.AddHours(8);
		var issuer = "CTIX";

		// Build code
		var code = BarcodeGenerator.BuildHmacBarcode(tid, pid, exp, issuer, DevKey, Kid);
		Console.WriteLine("BARCODE:\n" + code + "\n");

		// Validate
		var ok = BarcodeGenerator.ValidateHmacBarcode(
			code,
			keysByKid: KeyRing,
			out var fields,
			pastExpiryGrace: TimeSpan.FromMinutes(30),
			maxSkew: TimeSpan.FromMinutes(2));

		Console.WriteLine("VALID: " + ok);
		foreach (var kv in fields)
		{
			Console.WriteLine($"{kv.Key} = {kv.Value}");
		}
	}
}
