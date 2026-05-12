// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 04-06-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-12-2026
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
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
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
	public void GetAbsoluteUri_NoQueryString_ReturnsUriWithoutQuery()
	{
		// Arrange
		var request = new StubHttpRequest
		{
			Scheme = "http",
			Host = new HostString("localhost:5000"),
			Path = new PathString("/health"),
		};

		// Act
		var result = request.GetAbsoluteUri();

		// Assert
		Assert.AreEqual("http://localhost:5000/health", result.ToString());
	}

	// =====================================================
	// GetAbsoluteUri tests
	// =====================================================

	[TestMethod]
	public void GetAbsoluteUri_NullRequest_ThrowsArgumentNullException()
	{
		// Arrange
		HttpRequest request = null;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => request.GetAbsoluteUri());
	}

	[TestMethod]
	public void GetAbsoluteUri_ValidRequest_ReturnsFullUri()
	{
		// Arrange
		var request = new StubHttpRequest
		{
			Scheme = "https",
			Host = new HostString("example.com"),
			PathBase = new PathString("/api"),
			Path = new PathString("/users"),
			QueryString = new QueryString("?page=1"),
		};

		// Act
		var result = request.GetAbsoluteUri();

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual("https://example.com/api/users?page=1", result.ToString());
	}

	[TestMethod]
	public void GetBearerToken_CaseInsensitiveBearer_ReturnsToken()
	{
		// Arrange
		var request = new StubHttpRequest();
		request.Headers["Authorization"] = "bearer my-token";

		// Act
		var result = request.GetBearerToken();

		// Assert
		Assert.AreEqual("my-token", result);
	}

	[TestMethod]
	public void GetBearerToken_NoAuthorizationHeader_ReturnsNull()
	{
		// Arrange
		var request = new StubHttpRequest();

		// Act
		var result = request.GetBearerToken();

		// Assert
		Assert.IsNull(result);
	}

	[TestMethod]
	public void GetBearerToken_NonBearerScheme_ReturnsNull()
	{
		// Arrange
		var request = new StubHttpRequest();
		request.Headers["Authorization"] = "Basic dXNlcjpwYXNz";

		// Act
		var result = request.GetBearerToken();

		// Assert
		Assert.IsNull(result);
	}

	// =====================================================
	// GetBearerToken tests
	// =====================================================

	[TestMethod]
	public void GetBearerToken_NullRequest_ThrowsArgumentNullException()
	{
		// Arrange
		HttpRequest request = null;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => request.GetBearerToken());
	}

	[TestMethod]
	public void GetBearerToken_ValidBearerToken_ReturnsToken()
	{
		// Arrange
		var request = new StubHttpRequest();
		request.Headers["Authorization"] = "Bearer my-test-token-123";

		// Act
		var result = request.GetBearerToken();

		// Assert
		Assert.AreEqual("my-test-token-123", result);
	}

	[TestMethod]
	public void GetHeaderValue_EmptyHeaderName_ThrowsArgumentException()
	{
		// Arrange
		var request = new StubHttpRequest();

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentException>(() => request.GetHeaderValue("   "));
	}

	[TestMethod]
	public void GetHeaderValue_ExistingHeader_ReturnsValue()
	{
		// Arrange
		var request = new StubHttpRequest();
		request.Headers["X-Custom"] = "custom-value";

		// Act
		var result = request.GetHeaderValue("X-Custom");

		// Assert
		Assert.AreEqual("custom-value", result);
	}

	[TestMethod]
	public void GetHeaderValue_MissingHeader_ReturnsNull()
	{
		// Arrange
		var request = new StubHttpRequest();

		// Act
		var result = request.GetHeaderValue("X-Missing");

		// Assert
		Assert.IsNull(result);
	}

	[TestMethod]
	public void GetHeaderValue_NullHeaderName_ThrowsArgumentNullException()
	{
		// Arrange
		var request = new StubHttpRequest();

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => request.GetHeaderValue(null));
	}

	// =====================================================
	// GetHeaderValue tests
	// =====================================================

	[TestMethod]
	public void GetHeaderValue_NullRequest_ThrowsArgumentNullException()
	{
		// Arrange
		HttpRequest request = null;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => request.GetHeaderValue("X-Test"));
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
	public void HasJsonContentType_JsonContentType_ReturnsTrue()
	{
		// Arrange
		var request = new StubHttpRequest { ContentType = "application/json" };

		// Act
		var result = request.HasJsonContentType();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void HasJsonContentType_JsonWithCharset_ReturnsTrue()
	{
		// Arrange
		var request = new StubHttpRequest { ContentType = "application/json; charset=utf-8" };

		// Act
		var result = request.HasJsonContentType();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void HasJsonContentType_NullContentType_ReturnsFalse()
	{
		// Arrange
		var request = new StubHttpRequest { ContentType = null };

		// Act
		var result = request.HasJsonContentType();

		// Assert
		Assert.IsFalse(result);
	}

	// =====================================================
	// HasJsonContentType tests
	// =====================================================

	[TestMethod]
	public void HasJsonContentType_NullRequest_ThrowsArgumentNullException()
	{
		// Arrange
		HttpRequest request = null;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => request.HasJsonContentType());
	}

	[TestMethod]
	public void HasJsonContentType_TextPlain_ReturnsFalse()
	{
		// Arrange
		var request = new StubHttpRequest { ContentType = "text/plain" };

		// Act
		var result = request.HasJsonContentType();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsContentType_CaseInsensitiveMatch_ReturnsTrue()
	{
		// Arrange
		var request = new StubHttpRequest { ContentType = "Application/JSON" };

		// Act
		var result = request.IsContentType("application/json");

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsContentType_EmptyContentType_ThrowsArgumentException()
	{
		// Arrange
		var request = new StubHttpRequest();

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentException>(() => request.IsContentType("  "));
	}

	[TestMethod]
	public void IsContentType_MatchingContentType_ReturnsTrue()
	{
		// Arrange
		var request = new StubHttpRequest { ContentType = "text/html; charset=utf-8" };

		// Act
		var result = request.IsContentType("text/html");

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsContentType_NonMatchingContentType_ReturnsFalse()
	{
		// Arrange
		var request = new StubHttpRequest { ContentType = "text/plain" };

		// Act
		var result = request.IsContentType("application/json");

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsContentType_NullContentType_ThrowsArgumentNullException()
	{
		// Arrange
		var request = new StubHttpRequest();

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => request.IsContentType(null));
	}

	// =====================================================
	// IsContentType tests
	// =====================================================

	[TestMethod]
	public void IsContentType_NullRequest_ThrowsArgumentNullException()
	{
		// Arrange
		HttpRequest request = null;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => request.IsContentType("text/plain"));
	}

	[TestMethod]
	public void IsContentType_NullRequestContentType_ReturnsFalse()
	{
		// Arrange
		var request = new StubHttpRequest { ContentType = null };

		// Act
		var result = request.IsContentType("text/plain");

		// Assert
		Assert.IsFalse(result);
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
	public void TryGetBodyGeneric_ValidBody_ReturnsFalseForInvalidJson()
	{
		// Arrange - raw binary bytes are not valid JSON; TryGetBody<T> catches JsonException and returns false
		var content = RandomData.GenerateByteArray(16);
		var request = CreateRequestWithBody(content);

		// Act
		var result = request.TryGetBody<string>(out var value);

		// Assert
		Assert.IsFalse(result);
		Assert.IsNull(value);
	}

	[TestMethod]
	public void TryGetBodyTypeInfo_BodyAtEnd_ReturnsFalse()
	{
		// Arrange - stream has content but position is at end, so CopyTo yields empty bytes
		var content = RandomData.GenerateByteArray(16);
		var stream = new MemoryStream(content);
		stream.Position = stream.Length;
		var request = new StubHttpRequest { Body = stream, ContentLength = content.Length };

		// Act
		var result = request.TryGetBody(RequestPayloadJsonContext.Default.RequestPayload, out var value);

		// Assert
		Assert.IsFalse(result);
		Assert.IsNull(value);
	}

	[TestMethod]
	public void TryGetBodyTypeInfo_EmptyBody_ThrowsArgumentException()
	{
		// Arrange
		var request = CreateRequestWithBody([]);

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentException>(() =>
			request.TryGetBody(RequestPayloadJsonContext.Default.RequestPayload, out _));
	}

	[TestMethod]
	public void TryGetBodyTypeInfo_InvalidJson_ReturnsFalse()
	{
		// Arrange - raw binary is not valid JSON
		var content = RandomData.GenerateByteArray(16);
		var request = CreateRequestWithBody(content);

		// Act
		var result = request.TryGetBody(RequestPayloadJsonContext.Default.RequestPayload, out var value);

		// Assert
		Assert.IsFalse(result);
		Assert.IsNull(value);
	}

	// =====================================================
	// TryGetBody<T>(JsonTypeInfo) tests
	// =====================================================

	[TestMethod]
	public void TryGetBodyTypeInfo_NullRequest_ThrowsArgumentNullException()
	{
		// Arrange
		HttpRequest request = null;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() =>
			request.TryGetBody(RequestPayloadJsonContext.Default.RequestPayload, out _));
	}

	[TestMethod]
	public void TryGetBodyTypeInfo_NullTypeInfo_ThrowsArgumentNullException()
	{
		// Arrange
		var request = CreateRequestWithBody(Encoding.UTF8.GetBytes("{}"));

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() =>
			request.TryGetBody((JsonTypeInfo<RequestPayload>)null, out _));
	}

	[TestMethod]
	public void TryGetBodyTypeInfo_ValidJson_ReturnsTrueWithValue()
	{
		// Arrange
		var payload = new RequestPayload { Name = "Alice", Value = 42 };
		var json = JsonSerializer.Serialize(payload, RequestPayloadJsonContext.Default.RequestPayload);
		var request = CreateRequestWithBody(Encoding.UTF8.GetBytes(json));

		// Act
		var result = request.TryGetBody(RequestPayloadJsonContext.Default.RequestPayload, out var value);

		// Assert
		Assert.IsTrue(result);
		Assert.IsNotNull(value);
		Assert.AreEqual(payload.Name, value.Name);
		Assert.AreEqual(payload.Value, value.Value);
	}

	private static StubHttpRequest CreateRequestWithBody(byte[] content)
	{
		var stream = new MemoryStream(content);

		return new StubHttpRequest { Body = stream, ContentLength = content.Length };
	}

	private sealed class StubHttpRequest : HttpRequest
	{

		private readonly HeaderDictionary _headers = new();

		public override Stream Body { get; set; }

		public override long? ContentLength { get; set; }

		public override string ContentType { get; set; }

		public override IRequestCookieCollection Cookies { get; set; }

		public override IFormCollection Form { get; set; }

		public override bool HasFormContentType => false;

		public override IHeaderDictionary Headers => this._headers;

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

[ExcludeFromCodeCoverage]
internal sealed class RequestPayload
{

	public string Name { get; set; }

	public int Value { get; set; }

}

[JsonSerializable(typeof(RequestPayload))]
internal sealed partial class RequestPayloadJsonContext : JsonSerializerContext { }
