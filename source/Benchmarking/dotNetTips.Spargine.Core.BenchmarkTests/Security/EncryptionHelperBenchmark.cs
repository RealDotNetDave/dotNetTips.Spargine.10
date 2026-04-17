// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 05-01-2025
//
// Last Modified By : David McCarter
// Last Modified On : 12-24-2025
// ***********************************************************************
// <copyright file="EncryptionHelperBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.Security;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.BenchmarkTests.Security;

[BenchmarkCategory(Categories.Encryption)]
public class EncryptionHelperBenchmark : Benchmark
{

	private const string Key = "!&@^@%@$@#!!!";

	private string _aesCypherText;
	private string _aesGcmEncryptText;
	private byte[] _aesIv;
	private byte[] _aesKey;
	private string _cypherText = string.Empty;

	[Benchmark(Description = nameof(EncryptionHelper.AesDecrypt))]
	[BenchmarkCategory(Categories.Encryption)]
	public void AesDecrypt()
	{
		var result = EncryptionHelper.AesEncrypt(this._aesCypherText, this._aesKey, this._aesIv);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EncryptionHelper.AesEncrypt))]
	[BenchmarkCategory(Categories.Encryption)]
	public void AesEncrypt()
	{
		var result = EncryptionHelper.AesEncrypt(this.LongTestString, this._aesKey, this._aesIv);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EncryptionHelper.AesGcmDecrypt))]
	[BenchmarkCategory(Categories.Encryption)]
	public void AesGcmDecrypt()
	{
		var result = EncryptionHelper.AesGcmDecrypt(this._aesGcmEncryptText, this._aesKey, this._aesIv);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EncryptionHelper.AesGcmEncrypt))]
	[BenchmarkCategory(Categories.Encryption)]
	public void AesGcmEncrypt()
	{
		var result = EncryptionHelper.AesGcmEncrypt(this.LongTestString, this._aesKey, this._aesIv);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EncryptionHelper.GenerateAesIV))]
	[BenchmarkCategory(Categories.Encryption)]
	public void GenerateAesIV()
	{
		var result = EncryptionHelper.GenerateAesIV();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EncryptionHelper.GenerateAesKey))]
	[BenchmarkCategory(Categories.Encryption)]
	public void GenerateAesKey()
	{
		var result = EncryptionHelper.GenerateAesKey();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EncryptionHelper.GenerateRandomKey))]
	[BenchmarkCategory(Categories.Strings)]
	public void GenerateRandomKey()
	{
		var result = EncryptionHelper.GenerateRandomKey();

		this.Consume(result);
	}

	public override void Setup()
	{
		base.Setup();

		this._cypherText = EncryptionHelper.SimpleSHA256Encrypt(this.LongTestString, Key);
		this._aesKey = EncryptionHelper.GenerateAesKey();
		this._aesIv = EncryptionHelper.GenerateAesIV();
		this._aesCypherText = EncryptionHelper.AesEncrypt(this.LongTestString, this._aesKey, this._aesIv);
		this._aesGcmEncryptText = EncryptionHelper.AesGcmEncrypt(this.LongTestString, this._aesKey, this._aesIv);
	}

	[Benchmark(Description = nameof(EncryptionHelper.SimpleSHA256Decrypt))]
	[BenchmarkCategory(Categories.Encryption)]
	public void SimpleSHA256Decrypt()
	{
		var result = EncryptionHelper.SimpleSHA256Decrypt(this._cypherText, Key);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EncryptionHelper.SimpleSHA256Encrypt))]
	[BenchmarkCategory(Categories.Encryption)]
	public void SimpleSHA256Encrypt()
	{
		var result = EncryptionHelper.SimpleSHA256Encrypt(this.LongTestString, Key);

		this.Consume(result);
	}
}
