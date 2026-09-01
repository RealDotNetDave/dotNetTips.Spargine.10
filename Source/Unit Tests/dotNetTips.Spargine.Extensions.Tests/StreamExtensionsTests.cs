// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 05-01-2025
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-08-2026
// ***********************************************************************
// <copyright file="StreamExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Tester;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class StreamExtensionsTests
{
	[TestMethod]
	public async Task CopyToAsyncPooled_CustomBuffer_CopiesAllBytes_ReturnsLength()
	{
		var data = RandomData.GenerateByteArray(1024);
		await using var source = new MemoryStream(data);
		await using var destination = new MemoryStream();

		var copied = await source.CopyToAsyncPooled(destination, 128);

		Assert.AreEqual(data.Length, copied);
		CollectionAssert.AreEqual(data, destination.ToArray());
	}

	[TestMethod]
	public async Task CopyToAsyncPooled_DefaultBuffer_CopiesAllBytes_ReturnsLength()
	{
		var data = RandomData.GenerateByteArray(512);
		await using var source = new MemoryStream(data);
		await using var destination = new MemoryStream();

		var copied = await source.CopyToAsyncPooled(destination);

		Assert.AreEqual(data.Length, copied);
		CollectionAssert.AreEqual(data, destination.ToArray());
	}

	[TestMethod]
	public async Task CopyToAsyncPooled_InvalidBufferSize_ThrowsArgumentOutOfRangeException()
	{
		await using var source = new MemoryStream(RandomData.GenerateByteArray(64));
		await using var destination = new MemoryStream();

		_ = await Assert.ThrowsExactlyAsync<ArgumentOutOfRangeException>(async () =>
		{
			_ = await source.CopyToAsyncPooled(destination, 0);
		});
	}

	[TestMethod]
	public void FlushClose_StreamIsNotNull_FlushesAndClosesStream()
	{
		var stream = new MemoryStream();

		stream.FlushClose();

		_ = Assert.ThrowsExactly<ObjectDisposedException>(() => stream.WriteByte(0));
	}

	[TestMethod]
	public void FlushClose_StreamIsNull_DoesNothing()
	{
		Stream stream = null;

		stream.FlushClose();
	}

	[TestMethod]
	public void FlushClose_StreamWithData_FlushesAndClosesStream()
	{
		var data = RandomData.GenerateByteArray(256);
		var stream = new MemoryStream();
		stream.Write(data);

		stream.FlushClose();

		_ = Assert.ThrowsExactly<ObjectDisposedException>(() => stream.WriteByte(0));
	}

	[TestMethod]
	public async Task ReadExactlyAsync_NullStream_ThrowsArgumentNullException()
	{
		var buffer = new byte[8];

		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
		{
			_ = await StreamExtensions.ReadExactlyAsync(null, buffer);
		});
	}

	[TestMethod]
	public async Task ReadExactlyAsync_SourceTooShort_ThrowsEndOfStreamException()
	{
		await using var stream = new MemoryStream(RandomData.GenerateByteArray(4));
		var buffer = new byte[8];

		_ = await Assert.ThrowsExactlyAsync<EndOfStreamException>(async () =>
		{
			_ = await StreamExtensions.ReadExactlyAsync(stream, buffer);
		});
	}

	[TestMethod]
	public async Task ReadExactlyAsync_ValidSource_FillsBuffer_ReturnsLength()
	{
		var data = RandomData.GenerateByteArray(32);
		await using var stream = new MemoryStream(data);
		var buffer = new byte[32];

		var bytesRead = await StreamExtensions.ReadExactlyAsync(stream, buffer);

		Assert.AreEqual(buffer.Length, bytesRead);
		CollectionAssert.AreEqual(data, buffer);
	}

	[TestMethod]
	public async Task WriteAllAsync_NullStream_ThrowsArgumentNullException()
	{
		var data = RandomData.GenerateByteArray(8);

		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
		{
			_ = await StreamExtensions.WriteAllAsync(null, data);
		});
	}

	[TestMethod]
	public async Task WriteAllAsync_ValidDestination_WritesAllBytes_ReturnsLength()
	{
		var data = RandomData.GenerateByteArray(128);
		await using var destination = new MemoryStream();

		var bytesWritten = await destination.WriteAllAsync(data);

		Assert.AreEqual(data.Length, bytesWritten);
		CollectionAssert.AreEqual(data, destination.ToArray());
	}
}
