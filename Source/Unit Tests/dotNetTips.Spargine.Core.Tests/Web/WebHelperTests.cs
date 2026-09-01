// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 02-07-2021
//
// Last Modified By : David McCarter
// Last Modified On : 04-14-2026
// ***********************************************************************
// <copyright file="WebHelperTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using DotNetTips.Spargine.Core.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Tests.Web;

[ExcludeFromCodeCoverage]
[TestClass]
public class WebHelperTests
{

	[TestMethod]
	public void DownloadStringAsyncTest()
	{
		var result = WebHelper.DownloadStringAsync(new Uri(@"https://dotnettips.com"), clientId: "UNITTEST1").GetAwaiter().GetResult();

		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void DownloadStringTest()
	{
		var result = WebHelper.DownloadStringAsync(new Uri(@"https://www.google.com/"), clientId: "UNITTEST2").GetAwaiter().GetResult();

		Assert.IsTrue(string.IsNullOrEmpty(result) is false);
	}

	[TestMethod]
	public void DownloadStringAsyncNullAddressThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			WebHelper.DownloadStringAsync(null).GetAwaiter().GetResult());
	}

	[TestMethod]
	public void DownloadStringAsyncWithCancellationThrowsOperationCanceledException()
	{
		using var cts = new CancellationTokenSource();
		cts.Cancel();

		Assert.ThrowsExactly<TaskCanceledException>(() =>
			WebHelper.DownloadStringAsync(new Uri("https://www.google.com/"), cancellationToken: cts.Token).GetAwaiter().GetResult());
	}

	[TestMethod]
	public void HttpHeaderNamesReturnsNonEmptyCollection()
	{
		var result = WebHelper.HttpHeaderNames();

		Assert.IsNotNull(result);
		Assert.IsTrue(result.Count > 0);
	}

	[TestMethod]
	public void HttpHeaderNamesContainsExpectedHeaders()
	{
		var result = WebHelper.HttpHeaderNames();

		Assert.IsTrue(result.Contains(nameof(HttpRequestHeader.Accept)));
		Assert.IsTrue(result.Contains(nameof(HttpRequestHeader.ContentType)));
		Assert.IsTrue(result.Contains(nameof(HttpRequestHeader.Host)));
		Assert.IsTrue(result.Contains(nameof(HttpRequestHeader.Authorization)));
		Assert.IsTrue(result.Contains(nameof(HttpRequestHeader.UserAgent)));
	}

	[TestMethod]
	public void HttpHeaderNamesReturnsReadOnlyCollection()
	{
		var result = WebHelper.HttpHeaderNames();

		Assert.IsInstanceOfType<ReadOnlyCollection<string>>(result);
	}

	[TestMethod]
	public void HttpHeaderNamesReturnsConsistentResults()
	{
		var result1 = WebHelper.HttpHeaderNames();
		var result2 = WebHelper.HttpHeaderNames();

		Assert.AreEqual(result1.Count, result2.Count);

		for (var i = 0; i < result1.Count; i++)
		{
			Assert.AreEqual(result1[i], result2[i]);
		}
	}

	[TestMethod]
	public void IsLocalUri_WithLocalAbsoluteUri_ReturnsTrue()
	{
		var request = new DefaultHttpContext().Request;
		request.Host = new HostString("localhost");

		var result = WebHelper.IsLocalUri("http://localhost/home", request);

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsLocalUri_WithLocalRelativeUri_ReturnsTrue()
	{
		var request = new DefaultHttpContext().Request;
		// Assuming the request host is set to a default or specific value in the actual test environment setup.

		var result = WebHelper.IsLocalUri("/home", request);

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsLocalUri_WithNonLocalAbsoluteUri_ReturnsFalse()
	{
		var request = new DefaultHttpContext().Request;
		request.Host = new HostString("localhost");

		var result = WebHelper.IsLocalUri("http://www.example.com/home", request);

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsLocalUri_WithNonLocalRelativeUri_ReturnsFalse()
	{
		var request = new DefaultHttpContext().Request;
		// Assuming the request host is set to a default or specific value in the actual test environment setup.

		var result = WebHelper.IsLocalUri("http://www.example.com/home", request);

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsLocalUri_WithNullPath_ThrowsArgumentNullException()
	{
		// Arrange
		var request = new DefaultHttpContext().Request;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => WebHelper.IsLocalUri(null, request));
	}

	[TestMethod]
	public void IsLocalUri_WithNullRequest_ThrowsArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => WebHelper.IsLocalUri("/home", null));
	}

	[TestMethod]
	public void IsLocalUriWithEmptyPathThrowsArgumentNullException()
	{
		var request = new DefaultHttpContext().Request;

		Assert.ThrowsExactly<ArgumentNullException>(() => WebHelper.IsLocalUri(string.Empty, request));
	}

	[TestMethod]
	public void IsLocalUriWithHttpsLocalAbsoluteUriReturnsTrue()
	{
		var request = new DefaultHttpContext().Request;
		request.Host = new HostString("localhost");

		var result = WebHelper.IsLocalUri("https://localhost/secure", request);

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsLocalUriWithHttpsNonLocalAbsoluteUriReturnsFalse()
	{
		var request = new DefaultHttpContext().Request;
		request.Host = new HostString("localhost");

		var result = WebHelper.IsLocalUri("https://www.example.com/secure", request);

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsLocalUriWithHttpPrefixNotAbsoluteReturnsFalse()
	{
		var request = new DefaultHttpContext().Request;

		// A path that starts with "http://" but is not a valid absolute URI
		var result = WebHelper.IsLocalUri("http://", request);

		Assert.IsFalse(result);
	}

}
