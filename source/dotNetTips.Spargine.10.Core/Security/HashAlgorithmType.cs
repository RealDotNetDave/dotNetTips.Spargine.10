//`![](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )


namespace DotNetTips.Spargine.Core.Security;

/// <summary>
/// Enum representing supported hashing algorithms.
/// </summary>
public enum HashAlgorithmType
{
	/// <summary>
	/// PBKDF2 hashing algorithm.
	/// </summary>
	PBKDF2,

	/// <summary>
	/// SHA256 hashing algorithm.
	/// </summary>
	SHA256,

	/// <summary>
	/// SHA3-256 hashing algorithm.
	/// </summary>
	SHA3256,

	/// <summary>
	/// SHA3-384 hashing algorithm.
	/// </summary>
	SHA3384,

	/// <summary>
	/// SHA3-512 hashing algorithm.
	/// </summary>
	SHA3512,

	/// <summary>
	/// SHAKE128 hashing algorithm.
	/// </summary>
	Shake128,

	/// <summary>
	/// SHAKE256 hashing algorithm.
	/// </summary>
	Shake256,

	/// <summary>
	/// Argon2 hashing algorithm.
	/// </summary>
	Argon2
}
