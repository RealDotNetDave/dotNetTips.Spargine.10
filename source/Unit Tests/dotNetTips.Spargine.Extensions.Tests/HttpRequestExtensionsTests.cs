// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 04-06-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-06-2026
// ***********************************************************************
// <copyright file="HttpRequestExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using DotNetTips.Spargine.Tester;
using Microsoft.AspNetCore.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class HttpRequestExtensionsTests
{

	[TestMethod]
	public void AddRequestId_CalledTwice_AddsTwoDistinctIds()
	{
		// Arrange
		using var message = new HttpRequestMessage();
		var headers = message.Headers;

		// Act
		var id1 = headers.AddRequestId();
		var id2 = headers.AddRequestId();

		// Assert
		Assert.AreNotEqual(id1, id2);
	}

	[TestMethod]
	public void AddRequestId_NullHeaders_ThrowsArgumentNullException()
	{
		// Arrange
		HttpRequestHeaders headers = null;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => headers.AddRequestId());
	}

	[TestMethod]
	public void AddRequestId_ValidHeaders_ReturnsNonEmptyIdAndAddsHeader()
	{
		// Arrange
		using var message = new HttpRequestMessage();
		var headers = message.Headers;

		// Act
		var id = headers.AddRequestId();

		// Assert
		Assert.IsNotNull(id);
		Assert.IsTrue(id.Length > 0);
		Assert.IsTrue(headers.Contains("X-Request-UUID"));
	}

	[TestMethod]
	public async Task GetRawBodyBytesAsync_EmptyBody_ReturnsEmptyArray()
	{
		// Arrange
		var request = CreateRequestWithBody([]);

		// Act
		var result = await request.GetRawBodyBytesAsync();

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(0, result.Length);
	}

	[TestMethod]
	public async Task GetRawBodyBytesAsync_NullRequest_ThrowsArgumentNullException()
	{
		// Arrange
		HttpRequest request = null;

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
		{
			await request.GetRawBodyBytesAsync();
		});
	}

	[TestMethod]
	public async Task GetRawBodyBytesAsync_ValidRequest_ReturnsByteArray()
	{
		// Arrange
		var expectedBytes = RandomData.GenerateByteArray(64);
		var request = CreateRequestWithBody(expectedBytes);

		// Act
		var result = await request.GetRawBodyBytesAsync();

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(expectedBytes.Length, result.Length);
		CollectionAssert.AreEqual(expectedBytes, result);
	}

	[TestMethod]
	public async Task GetRawBodyStringAsync_NullEncoding_ThrowsArgumentNullException()
	{
		// Arrange
		var request = CreateRequestWithBody(Encoding.UTF8.GetBytes("test"));

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
		{
			await request.GetRawBodyStringAsync(null);
		});
	}

	[TestMethod]
	public async Task GetRawBodyStringAsync_NullRequest_ThrowsArgumentNullException()
	{
		// Arrange
		HttpRequest request = null;

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
		{
			_ = await request.GetRawBodyStringAsync(Encoding.UTF8);
		});
	}

	[TestMethod]
	public async Task GetRawBodyStringAsync_UTF32Encoding_ReturnsCorrectString()
	{
		// Arrange
		var expectedText = RandomData.GenerateWord(5, 20);
		var request = CreateRequestWithBody(Encoding.UTF32.GetBytes(expectedText));

		// Act
		var result = await request.GetRawBodyStringAsync(Encoding.UTF32);

		// Assert
		Assert.AreEqual(expectedText, result);
	}

	[TestMethod]
	public async Task GetRawBodyStringAsync_ValidRequest_ReturnsString()
	{
		// Arrange
		var expectedText = RandomData.GenerateWord(10, 50);
		var request = CreateRequestWithBody(Encoding.UTF8.GetBytes(expectedText));

		// Act
		var result = await request.GetRawBodyStringAsync(Encoding.UTF8);

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(expectedText, result);
	}

	[TestMethod]
	public void TryGetBody_EmptyBody_ThrowsArgumentException()
	{
		// Arrange
		var request = CreateRequestWithBody([]);

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentException>(() => request.TryGetBody(out _));
	}

	[TestMethod]
	public void TryGetBody_NullBody_ThrowsArgumentException()
	{
		// Arrange
		var request = new StubHttpRequest { Body = null };

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentException>(() => request.TryGetBody(out _));
	}

	[TestMethod]
	public void TryGetBody_NullRequest_ThrowsArgumentNullException()
	{
		// Arrange
		HttpRequest request = null;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => request.TryGetBody(out _));
	}

	[TestMethod]
	public void TryGetBody_ValidBody_ReturnsTrueWithBytes()
	{
		// Arrange
		var expectedBytes = RandomData.GenerateByteArray(32);
		var request = CreateRequestWithBody(expectedBytes);

		// Act
		var result = request.TryGetBody(out var value);

		// Assert
		Assert.IsTrue(result);
		Assert.IsNotNull(value);
		CollectionAssert.AreEqual(expectedBytes, value);
	}

	[TestMethod]
	public void TryGetBodyGeneric_BodyAtEnd_ReturnsFalse()
	{
		// Arrange - Create a stream with content but position at the end,
		// so Body.Length > 0 passes the check but CopyTo copies nothing.
		var content = RandomData.GenerateByteArray(16);
		var stream = new MemoryStream(content);
		stream.Position = stream.Length;

		var request = new StubHttpRequest { Body = stream, ContentLength = content.Length };

		// Act
		var result = request.TryGetBody<string>(out var value);

		// Assert
		Assert.IsFalse(result);
		Assert.IsNull(value);
	}

	[TestMethod]
	public void TryGetBodyGeneric_EmptyBody_ThrowsArgumentException()
	{
		// Arrange
		var request = CreateRequestWithBody([]);

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentException>(() => request.TryGetBody<string>(out _));
	}

	[TestMethod]
	public void TryGetBodyGeneric_NullRequest_ThrowsArgumentNullException()
	{
		// Arrange
		HttpRequest request = null;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => request.TryGetBody<string>(out _));
	}

	[TestMethod]
	public void TryGetBodyGeneric_ValidBody_ThrowsJsonException()
	{
		// Arrange - BitConverter.ToString produces hex like "48-65-6C-6C-6F" which is not valid JSON
		var content = RandomData.GenerateByteArray(16);
		var request = CreateRequestWithBody(content);

		// Act & Assert
		_ = Assert.ThrowsExactly<JsonException>(() => request.TryGetBody<string>(out _));
	}

	private static StubHttpRequest CreateRequestWithBody(byte[] content)
	{
		var stream = new MemoryStream(content);

		return new StubHttpRequest { Body = stream, ContentLength = content.Length };
	}

	private sealed class StubHttpRequest : HttpRequest
	{

		public override Stream Body { get; set; }

		public override long? ContentLength { get; set; }

		public override string ContentType { get; set; }

		public override IRequestCookieCollection Cookies { get; set; }

		public override IFormCollection Form { get; set; }

		public override bool HasFormContentType => false;

		public override IHeaderDictionary Headers => null;

		public override HostString Host { get; set; }

		public override HttpContext HttpContext => null;

		public override bool IsHttps { get; set; }

		public override string Method { get; set; }

		public override PathString Path { get; set; }

		public override PathString PathBase { get; set; }

		public override string Protocol { get; set; }

		public override IQueryCollection Query { get; set; }

		public override QueryString QueryString { get; set; }

		public override string Scheme { get; set; }

		public override Task<IFormCollection> ReadFormAsync(CancellationToken cancellationToken = default) => throw new NotImplementedException();

	}

}
