// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tests
// Author           : David McCarter
// Created          : 06-24-2024
//
// Last Modified By : David McCarter
// Last Modified On : 11-14-2025
// ***********************************************************************
// <copyright file="HttpClientHelperTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using DotNetTips.Spargine.Net.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)
namespace DotNetTips.Spargine.Tests.Net.Http;

[ExcludeFromCodeCoverage]
[TestClass]
public class HttpClientHelperTests
{

	[TestMethod]
	public async Task GetHttpResponseAsync_InvalidUrl_ThrowsHttpRequestException()
	{
		// Arrange
		var url = new Uri("https://thisurldoesnotexist123456789.com");

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<HttpRequestException>(async () =>
		{
			await HttpClientHelper.GetHttpResponseAsync(url);
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
			await HttpClientHelper.GetHttpResponseAsync(url);
		});
	}


	[TestMethod]
	public async Task GetHttpResponseAsync_ValidUrl_ReturnsSuccessStatusCode()
	{
		// Arrange
		var url = new Uri("https://httpbin.org/get");

		// Act
		HttpResponseMessage response;
		try
		{
			response = await HttpClientHelper.GetHttpResponseAsync(url);
		}
		catch (HttpRequestException)
		{
			Assert.Inconclusive("Network request failed. This test requires network access.");
			return;
		}

		// Assert
		Assert.IsNotNull(response);
		Assert.IsTrue(response.IsSuccessStatusCode);
	}


	[TestMethod]
	public async Task GetStreamAsync_NullUrl_ThrowsArgumentNullException()
	{
		// Arrange
		Uri url = null;

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
		{
			await HttpClientHelper.GetStreamAsync(url);
		});
	}

	[TestMethod]
	public async Task GetStreamAsync_ValidUrl_ReturnsStream()
	{
		// Arrange
		var url = new Uri("https://httpbin.org/stream/1");

		// Act
		Stream stream;
		try
		{
			stream = await HttpClientHelper.GetStreamAsync(url);
		}
		catch (HttpRequestException)
		{
			Assert.Inconclusive("Network request failed. This test requires network access.");
			return;
		}

		// Assert
		Assert.IsNotNull(stream);
		Assert.IsTrue(stream.CanRead);
	}

}
