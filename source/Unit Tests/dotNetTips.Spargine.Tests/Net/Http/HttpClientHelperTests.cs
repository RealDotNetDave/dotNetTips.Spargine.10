// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tests
// Author           : David McCarter
// Created          : 06-24-2024
//
// Last Modified By : Copilot Agent
// Last Modified On : 06-12-2026
// ***********************************************************************
// <copyright file="HttpClientHelperTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Net.Http;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)
namespace DotNetTips.Spargine.Tests.Net.Http;

[ExcludeFromCodeCoverage]
[TestClass]
public class HttpClientHelperTests
{

	[TestMethod]
	public void CreateOptimizedHttpClient_CustomTimeout_SetsTimeoutOnClient()
	{
		// Arrange
		var options = new HttpClientOptions { Timeout = TimeSpan.FromMinutes(2) };

		// Act
		using var client = HttpClientHelper.CreateOptimizedHttpClient(options);

		// Assert
		Assert.AreEqual(TimeSpan.FromMinutes(2), client.Timeout);
	}

	[TestMethod]
	public void CreateOptimizedHttpClient_CustomUserAgent_SetsUserAgentHeader()
	{
		// Arrange
		var options = new HttpClientOptions { UserAgent = "MyApp/3.0" };

		// Act
		using var client = HttpClientHelper.CreateOptimizedHttpClient(options);

		// Assert
		Assert.Contains("MyApp/3.0", client.DefaultRequestHeaders.UserAgent.ToString());
	}

	[TestMethod]
	public void CreateOptimizedHttpClient_NoOptions_HasDefaultTimeout()
	{
		// Act
		using var client = HttpClientHelper.CreateOptimizedHttpClient();

		// Assert
		Assert.AreEqual(TimeSpan.FromSeconds(30), client.Timeout);
	}

	[TestMethod]
	public void CreateOptimizedHttpClient_NoOptions_ReturnsNotNull()
	{
		// Act
		using var client = HttpClientHelper.CreateOptimizedHttpClient();

		// Assert
		Assert.IsNotNull(client);
	}

	[TestMethod]
	public void CreateOptimizedHttpClient_NoOptions_SetsDefaultUserAgentHeader()
	{
		// Act
		using var client = HttpClientHelper.CreateOptimizedHttpClient();

		// Assert
		Assert.Contains("OptimizedHttpClient/1.0", client.DefaultRequestHeaders.UserAgent.ToString());
	}

	[TestMethod]
	public void CreateOptimizedHttpClient_NoOptions_SetsDeflateAcceptEncoding()
	{
		// Act
		using var client = HttpClientHelper.CreateOptimizedHttpClient();

		// Assert
		Assert.Contains("deflate", client.DefaultRequestHeaders.AcceptEncoding.ToString());
	}

	[TestMethod]
	public void CreateOptimizedHttpClient_NoOptions_SetsGzipAcceptEncoding()
	{
		// Act
		using var client = HttpClientHelper.CreateOptimizedHttpClient();

		// Assert
		Assert.Contains("gzip", client.DefaultRequestHeaders.AcceptEncoding.ToString());
	}

	[TestMethod]
	public void CreateOptimizedHttpClient_NullOptions_UsesDefaultTimeout()
	{
		// Act
		using var client = HttpClientHelper.CreateOptimizedHttpClient(null);

		// Assert
		Assert.AreEqual(TimeSpan.FromSeconds(30), client.Timeout);
	}

	[TestMethod]
	public async Task GetHttpResponseAsync_InvalidUrl_ThrowsHttpRequestException()
	{
		// Arrange
		var url = new Uri("https://thisurldoesnotexist123456789.com");

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<HttpRequestException>(async () =>
		{
#pragma warning disable CS0618 // Type or member is obsolete
			await HttpClientHelper.GetHttpResponseAsync(url);
#pragma warning restore CS0618 // Type or member is obsolete
		});
	}

	[TestMethod]
	public async Task GetHttpResponseAsync_NullUrl_ThrowsArgumentNullException()
	{
		// Arrange
		Uri url = null;

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
		{
#pragma warning disable CS0618 // Type or member is obsolete
			await HttpClientHelper.GetHttpResponseAsync(url);
#pragma warning restore CS0618 // Type or member is obsolete
		});
	}


	[TestMethod]
	public async Task GetStreamAsync_NullUrl_ThrowsArgumentNullException()
	{
		// Arrange
		Uri url = null;

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
		{
#pragma warning disable CS0618 // Type or member is obsolete
			await HttpClientHelper.GetStreamAsync(url);
#pragma warning restore CS0618 // Type or member is obsolete
		});
	}

	[TestMethod]
	public async Task GetStreamAsync_ValidUrl_ReturnsStream()
	{
		// Arrange
		var url = new Uri("https://httpbin.org/stream/1");

		// Act
#pragma warning disable CS0618 // Type or member is obsolete
		var stream = await HttpClientHelper.GetStreamAsync(url);
#pragma warning restore CS0618 // Type or member is obsolete

		// Assert
		Assert.IsNotNull(stream);
		Assert.IsTrue(stream.CanRead);
	}

}
