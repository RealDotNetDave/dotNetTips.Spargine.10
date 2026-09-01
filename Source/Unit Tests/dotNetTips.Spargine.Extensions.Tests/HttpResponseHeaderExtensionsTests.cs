// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : Copilot Agent
// Created          : 04-06-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-13-2026
// ***********************************************************************
// <copyright file="HttpResponseHeaderExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class HttpResponseHeaderExtensionsTests
{

	[TestMethod]
	public void AddRequestId_CalledTwice_AddsTwoDistinctIds()
	{
		// Arrange
		using var response = new HttpResponseMessage(HttpStatusCode.OK);
		var headers = response.Headers;

		// Act
		var id1 = headers.AddRequestId();
		var id2 = headers.AddRequestId();

		// Assert
		Assert.AreNotEqual(id1, id2);
	}

	// =====================================================
	// AddRequestId tests
	// =====================================================

	[TestMethod]
	public void AddRequestId_NullResponseHeaders_ThrowsArgumentNullException()
	{
		// Arrange
		HttpResponseHeaders headers = null;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => headers.AddRequestId());
	}

	[TestMethod]
	public void AddRequestId_ValidResponseHeaders_ReturnsNonEmptyIdAndAddsHeader()
	{
		// Arrange
		using var response = new HttpResponseMessage(HttpStatusCode.OK);
		var headers = response.Headers;

		// Act
		var id = headers.AddRequestId();

		// Assert
		Assert.IsNotNull(id);
		Assert.IsTrue(id.Length > 0);
		Assert.IsTrue(headers.Contains("X-Request-UUID"));
	}

	[TestMethod]
	public void GetETagValue_NoETag_ReturnsNull()
	{
		// Arrange
		using var response = new HttpResponseMessage(HttpStatusCode.OK);

		// Act
		var result = response.Headers.GetETagValue();

		// Assert
		Assert.IsNull(result);
	}

	// =====================================================
	// GetETagValue tests
	// =====================================================

	[TestMethod]
	public void GetETagValue_NullHeaders_ThrowsArgumentNullException()
	{
		// Arrange
		HttpResponseHeaders headers = null;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => headers.GetETagValue());
	}

	[TestMethod]
	public void GetETagValue_WeakETag_ReturnsTagValue()
	{
		// Arrange
		using var response = new HttpResponseMessage(HttpStatusCode.OK);
		response.Headers.ETag = new EntityTagHeaderValue("\"weak-tag\"", isWeak: true);

		// Act
		var result = response.Headers.GetETagValue();

		// Assert
		Assert.AreEqual("\"weak-tag\"", result);
	}

	[TestMethod]
	public void GetETagValue_WithETag_ReturnsTagValue()
	{
		// Arrange
		using var response = new HttpResponseMessage(HttpStatusCode.OK);
		response.Headers.ETag = new EntityTagHeaderValue("\"abc123\"");

		// Act
		var result = response.Headers.GetETagValue();

		// Assert
		Assert.AreEqual("\"abc123\"", result);
	}

	[TestMethod]
	public void GetHeaderValue_EmptyHeaderName_ThrowsArgumentException()
	{
		// Arrange
		using var response = new HttpResponseMessage(HttpStatusCode.OK);

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentException>(() => response.Headers.GetHeaderValue("   "));
	}

	[TestMethod]
	public void GetHeaderValue_ExistingHeader_ReturnsFirstValue()
	{
		// Arrange
		using var response = new HttpResponseMessage(HttpStatusCode.OK);
		response.Headers.Add("X-Custom", "value-one");

		// Act
		var result = response.Headers.GetHeaderValue("X-Custom");

		// Assert
		Assert.AreEqual("value-one", result);
	}

	[TestMethod]
	public void GetHeaderValue_MissingHeader_ReturnsNull()
	{
		// Arrange
		using var response = new HttpResponseMessage(HttpStatusCode.OK);

		// Act
		var result = response.Headers.GetHeaderValue("X-Missing");

		// Assert
		Assert.IsNull(result);
	}

	[TestMethod]
	public void GetHeaderValue_MultipleValues_ReturnsFirst()
	{
		// Arrange
		using var response = new HttpResponseMessage(HttpStatusCode.OK);
		response.Headers.Add("X-Multi", new[] { "first", "second" });

		// Act
		var result = response.Headers.GetHeaderValue("X-Multi");

		// Assert
		Assert.AreEqual("first", result);
	}

	[TestMethod]
	public void GetHeaderValue_NullHeaderName_ThrowsArgumentNullException()
	{
		// Arrange
		using var response = new HttpResponseMessage(HttpStatusCode.OK);

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => response.Headers.GetHeaderValue(null));
	}

	// =====================================================
	// GetHeaderValue tests
	// =====================================================

	[TestMethod]
	public void GetHeaderValue_NullHeaders_ThrowsArgumentNullException()
	{
		// Arrange
		HttpResponseHeaders headers = null;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => headers.GetHeaderValue("X-Custom"));
	}

	[TestMethod]
	public void GetName_AcceptRanges_ReturnsAcceptRanges()
	{
		// Arrange
		var header = HttpResponseHeader.AcceptRanges;

		// Act
		var result = header.GetName();

		// Assert
		Assert.AreEqual("Accept-Ranges", result);
	}

	[TestMethod]
	public void GetName_Age_ReturnsAge()
	{
		// Arrange
		var header = HttpResponseHeader.Age;

		// Act
		var result = header.GetName();

		// Assert
		Assert.AreEqual("Age", result);
	}

	[TestMethod]
	public void GetName_Allow_ReturnsAllow()
	{
		// Arrange
		var header = HttpResponseHeader.Allow;

		// Act
		var result = header.GetName();

		// Assert
		Assert.AreEqual("Allow", result);
	}

	[TestMethod]
	public void GetName_CacheControl_ReturnsCacheControl()
	{
		// Arrange
		var header = HttpResponseHeader.CacheControl;

		// Act
		var result = header.GetName();

		// Assert
		Assert.AreEqual("Cache-Control", result);
	}

	[TestMethod]
	public void GetName_Connection_ReturnsConnection()
	{
		// Arrange
		var header = HttpResponseHeader.Connection;

		// Act
		var result = header.GetName();

		// Assert
		Assert.AreEqual("Connection", result);
	}

	[TestMethod]
	public void GetName_ContentEncoding_ReturnsContentEncoding()
	{
		// Arrange
		var header = HttpResponseHeader.ContentEncoding;

		// Act
		var result = header.GetName();

		// Assert
		Assert.AreEqual("Content-Encoding", result);
	}

	[TestMethod]
	public void GetName_ContentLanguage_ReturnsContentLanguage()
	{
		// Arrange
		var header = HttpResponseHeader.ContentLanguage;

		// Act
		var result = header.GetName();

		// Assert
		Assert.AreEqual("Content-Language", result);
	}

	[TestMethod]
	public void GetName_ContentLength_ReturnsContentLength()
	{
		// Arrange
		var header = HttpResponseHeader.ContentLength;

		// Act
		var result = header.GetName();

		// Assert
		Assert.AreEqual("Content-Length", result);
	}

	[TestMethod]
	public void GetName_ContentLocation_ReturnsContentLocation()
	{
		// Arrange
		var header = HttpResponseHeader.ContentLocation;

		// Act
		var result = header.GetName();

		// Assert
		Assert.AreEqual("Content-Location", result);
	}

	[TestMethod]
	public void GetName_ContentMd5_ReturnsContentMD5()
	{
		// Arrange
		var header = HttpResponseHeader.ContentMd5;

		// Act
		var result = header.GetName();

		// Assert
		Assert.AreEqual("Content-MD5", result);
	}

	[TestMethod]
	public void GetName_ContentRange_ReturnsContentRange()
	{
		// Arrange
		var header = HttpResponseHeader.ContentRange;

		// Act
		var result = header.GetName();

		// Assert
		Assert.AreEqual("Content-Range", result);
	}

	[TestMethod]
	public void GetName_ContentType_ReturnsContentType()
	{
		// Arrange
		var header = HttpResponseHeader.ContentType;

		// Act
		var result = header.GetName();

		// Assert
		Assert.AreEqual("Content-Type", result);
	}

	[TestMethod]
	public void GetName_Date_ReturnsDate()
	{
		// Arrange
		var header = HttpResponseHeader.Date;

		// Act
		var result = header.GetName();

		// Assert
		Assert.AreEqual("Date", result);
	}

	[TestMethod]
	public void GetName_ETag_ReturnsETag()
	{
		// Arrange
		var header = HttpResponseHeader.ETag;

		// Act
		var result = header.GetName();

		// Assert
		Assert.AreEqual("ETag", result);
	}

	[TestMethod]
	public void GetName_Expires_ReturnsExpires()
	{
		// Arrange
		var header = HttpResponseHeader.Expires;

		// Act
		var result = header.GetName();

		// Assert
		Assert.AreEqual("Expires", result);
	}

	[TestMethod]
	public void GetName_InvalidEnumValue_ThrowsArgumentOutOfRangeException()
	{
		// Arrange
		var header = (HttpResponseHeader)999;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => header.GetName());
	}

	[TestMethod]
	public void GetName_KeepAlive_ReturnsKeepAlive()
	{
		// Arrange
		var header = HttpResponseHeader.KeepAlive;

		// Act
		var result = header.GetName();

		// Assert
		Assert.AreEqual("Keep-Alive", result);
	}

	[TestMethod]
	public void GetName_LastModified_ReturnsLastModified()
	{
		// Arrange
		var header = HttpResponseHeader.LastModified;

		// Act
		var result = header.GetName();

		// Assert
		Assert.AreEqual("Last-Modified", result);
	}

	[TestMethod]
	public void GetName_Location_ReturnsLocation()
	{
		// Arrange
		var header = HttpResponseHeader.Location;

		// Act
		var result = header.GetName();

		// Assert
		Assert.AreEqual("Location", result);
	}

	[TestMethod]
	public void GetName_Pragma_ReturnsPragma()
	{
		// Arrange
		var header = HttpResponseHeader.Pragma;

		// Act
		var result = header.GetName();

		// Assert
		Assert.AreEqual("Pragma", result);
	}

	[TestMethod]
	public void GetName_ProxyAuthenticate_ReturnsProxyAuthenticate()
	{
		// Arrange
		var header = HttpResponseHeader.ProxyAuthenticate;

		// Act
		var result = header.GetName();

		// Assert
		Assert.AreEqual("Proxy-Authenticate", result);
	}

	[TestMethod]
	public void GetName_RetryAfter_ReturnsRetryAfter()
	{
		// Arrange
		var header = HttpResponseHeader.RetryAfter;

		// Act
		var result = header.GetName();

		// Assert
		Assert.AreEqual("Retry-After", result);
	}

	[TestMethod]
	public void GetName_Server_ReturnsServer()
	{
		// Arrange
		var header = HttpResponseHeader.Server;

		// Act
		var result = header.GetName();

		// Assert
		Assert.AreEqual("Server", result);
	}

	[TestMethod]
	public void GetName_SetCookie_ReturnsSetCookie()
	{
		// Arrange
		var header = HttpResponseHeader.SetCookie;

		// Act
		var result = header.GetName();

		// Assert
		Assert.AreEqual("Set-Cookie", result);
	}

	[TestMethod]
	public void GetName_Trailer_ReturnsTrailer()
	{
		// Arrange
		var header = HttpResponseHeader.Trailer;

		// Act
		var result = header.GetName();

		// Assert
		Assert.AreEqual("Trailer", result);
	}

	[TestMethod]
	public void GetName_TransferEncoding_ReturnsTransferEncoding()
	{
		// Arrange
		var header = HttpResponseHeader.TransferEncoding;

		// Act
		var result = header.GetName();

		// Assert
		Assert.AreEqual("Transfer-Encoding", result);
	}

	[TestMethod]
	public void GetName_Upgrade_ReturnsUpgrade()
	{
		// Arrange
		var header = HttpResponseHeader.Upgrade;

		// Act
		var result = header.GetName();

		// Assert
		Assert.AreEqual("Upgrade", result);
	}

	[TestMethod]
	public void GetName_Vary_ReturnsVary()
	{
		// Arrange
		var header = HttpResponseHeader.Vary;

		// Act
		var result = header.GetName();

		// Assert
		Assert.AreEqual("Vary", result);
	}

	[TestMethod]
	public void GetName_Via_ReturnsVia()
	{
		// Arrange
		var header = HttpResponseHeader.Via;

		// Act
		var result = header.GetName();

		// Assert
		Assert.AreEqual("Via", result);
	}

	[TestMethod]
	public void GetName_Warning_ReturnsWarning()
	{
		// Arrange
		var header = HttpResponseHeader.Warning;

		// Act
		var result = header.GetName();

		// Assert
		Assert.AreEqual("Warning", result);
	}

	[TestMethod]
	public void GetName_WwwAuthenticate_ReturnsWWWAuthenticate()
	{
		// Arrange
		var header = HttpResponseHeader.WwwAuthenticate;

		// Act
		var result = header.GetName();

		// Assert
		Assert.AreEqual("WWW-Authenticate", result);
	}

	[TestMethod]
	public void GetRequestId_HeadersWithMultipleRequestIdValues_ReturnsFirstValue()
	{
		// Arrange
		var firstId = RandomData.GenerateKey();
		var secondId = RandomData.GenerateKey();
		using var response = new HttpResponseMessage(HttpStatusCode.OK);
		response.Headers.Add("X-Request-UUID", new[] { firstId, secondId });
		var headers = response.Headers;

		// Act
		var result = headers.GetRequestId();

		// Assert
		Assert.AreEqual(firstId, result);
	}

	[TestMethod]
	public void GetRequestId_HeadersWithoutRequestId_ReturnsEmptyString()
	{
		// Arrange
		using var response = new HttpResponseMessage(HttpStatusCode.OK);
		var headers = response.Headers;

		// Act
		var result = headers.GetRequestId();

		// Assert
		Assert.AreEqual(string.Empty, result);
	}

	[TestMethod]
	public void GetRequestId_HeadersWithRequestId_ReturnsRequestIdValue()
	{
		// Arrange
		var expectedId = RandomData.GenerateKey();
		using var response = new HttpResponseMessage(HttpStatusCode.OK);
		response.Headers.Add("X-Request-UUID", expectedId);
		var headers = response.Headers;

		// Act
		var result = headers.GetRequestId();

		// Assert
		Assert.AreEqual(expectedId, result);
	}

	[TestMethod]
	public void GetRequestId_NullHeaders_ThrowsArgumentNullException()
	{
		// Arrange
		HttpResponseHeaders headers = null;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => headers.GetRequestId());
	}

	[TestMethod]
	public void HasHeader_EmptyHeaderName_ThrowsArgumentException()
	{
		// Arrange
		using var response = new HttpResponseMessage(HttpStatusCode.OK);

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentException>(() => response.Headers.HasHeader("  "));
	}

	[TestMethod]
	public void HasHeader_ExistingHeader_ReturnsTrue()
	{
		// Arrange
		using var response = new HttpResponseMessage(HttpStatusCode.OK);
		response.Headers.Add("X-Present", "value");

		// Act
		var result = response.Headers.HasHeader("X-Present");

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void HasHeader_MissingHeader_ReturnsFalse()
	{
		// Arrange
		using var response = new HttpResponseMessage(HttpStatusCode.OK);

		// Act
		var result = response.Headers.HasHeader("X-Absent");

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void HasHeader_NullHeaderName_ThrowsArgumentNullException()
	{
		// Arrange
		using var response = new HttpResponseMessage(HttpStatusCode.OK);

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => response.Headers.HasHeader(null));
	}

	// =====================================================
	// HasHeader tests
	// =====================================================

	[TestMethod]
	public void HasHeader_NullHeaders_ThrowsArgumentNullException()
	{
		// Arrange
		HttpResponseHeaders headers = null;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => headers.HasHeader("X-Custom"));
	}

	[TestMethod]
	public void TryGetRetryAfterDelay_DeltaSeconds_ReturnsTrueWithDelay()
	{
		// Arrange
		using var response = new HttpResponseMessage(HttpStatusCode.ServiceUnavailable);
		response.Headers.RetryAfter = new RetryConditionHeaderValue(TimeSpan.FromSeconds(120));

		// Act
		var result = response.Headers.TryGetRetryAfterDelay(out var delay);

		// Assert
		Assert.IsTrue(result);
		Assert.AreEqual(TimeSpan.FromSeconds(120), delay);
	}

	[TestMethod]
	public void TryGetRetryAfterDelay_FutureDate_ReturnsTrueWithPositiveDelay()
	{
		// Arrange
		using var response = new HttpResponseMessage(HttpStatusCode.ServiceUnavailable);
		var futureDate = DateTimeOffset.UtcNow.AddMinutes(5);
		response.Headers.RetryAfter = new RetryConditionHeaderValue(futureDate);

		// Act
		var result = response.Headers.TryGetRetryAfterDelay(out var delay);

		// Assert
		Assert.IsTrue(result);
		Assert.IsTrue(delay > TimeSpan.Zero);
	}

	[TestMethod]
	public void TryGetRetryAfterDelay_NoRetryAfter_ReturnsFalse()
	{
		// Arrange
		using var response = new HttpResponseMessage(HttpStatusCode.OK);

		// Act
		var result = response.Headers.TryGetRetryAfterDelay(out var delay);

		// Assert
		Assert.IsFalse(result);
		Assert.AreEqual(TimeSpan.Zero, delay);
	}

	// =====================================================
	// TryGetRetryAfterDelay tests
	// =====================================================

	[TestMethod]
	public void TryGetRetryAfterDelay_NullHeaders_ThrowsArgumentNullException()
	{
		// Arrange
		HttpResponseHeaders headers = null;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => headers.TryGetRetryAfterDelay(out _));
	}

	[TestMethod]
	public void TryGetRetryAfterDelay_PastDate_ReturnsTrueWithZeroDelay()
	{
		// Arrange
		using var response = new HttpResponseMessage(HttpStatusCode.ServiceUnavailable);
		var pastDate = DateTimeOffset.UtcNow.AddMinutes(-5);
		response.Headers.RetryAfter = new RetryConditionHeaderValue(pastDate);

		// Act
		var result = response.Headers.TryGetRetryAfterDelay(out var delay);

		// Assert
		Assert.IsTrue(result);
		Assert.AreEqual(TimeSpan.Zero, delay);
	}

}
