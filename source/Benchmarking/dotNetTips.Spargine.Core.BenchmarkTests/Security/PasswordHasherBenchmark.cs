// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 09-26-2025
//
// Last Modified By : David McCarter
// Last Modified On : 09-26-2025
// ***********************************************************************
// <copyright file="PasswordHasherBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.Security;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.BenchmarkTests.Security;

public class PasswordHasherBenchmark : Benchmark
{
	private const string Password = "l#VkasX2L![][lP![&J}ll]&R}v]BKvADGa(gDmq]f]636ocaos?,%.Kfnb60uKx";

	[Benchmark(Description = nameof(PasswordHasher.HashPassword) + ": Argon2")]
	[BenchmarkCategory(Categories.New)]
	public string HashPasswordArgon2()
	{
		return PasswordHasher.HashPassword(Password, HashAlgorithmType.Argon2);
	}

	[Benchmark(Description = nameof(PasswordHasher.HashPassword) + ": PBKDF2")]
	[BenchmarkCategory(Categories.New)]
	public string HashPasswordPBKDF2()
	{
		return PasswordHasher.HashPassword(Password, HashAlgorithmType.PBKDF2);
	}

	[Benchmark(Description = nameof(PasswordHasher.HashPassword) + ": SHA256")]
	[BenchmarkCategory(Categories.New)]
	public string HashPasswordSHA256()
	{
		return PasswordHasher.HashPassword(Password, HashAlgorithmType.SHA256);
	}

	[Benchmark(Description = nameof(PasswordHasher.HashPassword) + ": SHA3256")]
	[BenchmarkCategory(Categories.New)]
	public string HashPasswordSHA3256()
	{
		return PasswordHasher.HashPassword(Password, HashAlgorithmType.SHA3256);
	}

	[Benchmark(Description = nameof(PasswordHasher.HashPassword) + ": SHA3384")]
	[BenchmarkCategory(Categories.New)]
	public string HashPasswordSHA3384()
	{
		return PasswordHasher.HashPassword(Password, HashAlgorithmType.SHA3384);
	}

	[Benchmark(Description = nameof(PasswordHasher.HashPassword) + ": SHA3512")]
	[BenchmarkCategory(Categories.New)]
	public string HashPasswordSHA3512()
	{
		return PasswordHasher.HashPassword(Password, HashAlgorithmType.SHA3512);
	}

	[Benchmark(Description = nameof(PasswordHasher.HashPassword) + ": Shake128")]
	[BenchmarkCategory(Categories.New)]
	public string HashPasswordShake128()
	{
		return PasswordHasher.HashPassword(Password, HashAlgorithmType.Shake128);
	}

	[Benchmark(Description = nameof(PasswordHasher.HashPassword) + ": Shake256")]
	[BenchmarkCategory(Categories.New)]
	public string HashPasswordShake256()
	{
		return PasswordHasher.HashPassword(Password, HashAlgorithmType.Shake256);
	}
}
