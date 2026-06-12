// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tests
// Author           : Copilot Agent
// Created          : 06-12-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 06-12-2026
// ***********************************************************************
// <copyright file="HttpClientOptionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Net.Http;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)
namespace DotNetTips.Spargine.Tests.Net.Http;

[ExcludeFromCodeCoverage]
[TestClass]
public class HttpClientOptionsTests
{

	[TestMethod]
	public void HttpClientOptions_Default_AllowAutoRedirectIsTrue()
	{
		// Act
		var options = new HttpClientOptions();

		// Assert
		Assert.IsTrue(options.AllowAutoRedirect);
	}

	[TestMethod]
	public void HttpClientOptions_Default_KeepAlivePingPolicyIsWithActiveRequests()
	{
		// Act
		var options = new HttpClientOptions();

		// Assert
		Assert.AreEqual(HttpKeepAlivePingPolicy.WithActiveRequests, options.KeepAlivePingPolicy);
	}

	[TestMethod]
	public void HttpClientOptions_Default_KeepAlivePingTimeoutIs30Seconds()
	{
		// Act
		var options = new HttpClientOptions();

		// Assert
		Assert.AreEqual(TimeSpan.FromSeconds(30), options.KeepAlivePingTimeout);
	}

	[TestMethod]
	public void HttpClientOptions_Default_MaxAutomaticRedirectionsIs3()
	{
		// Act
		var options = new HttpClientOptions();

		// Assert
		Assert.AreEqual(3, options.MaxAutomaticRedirections);
	}

	[TestMethod]
	public void HttpClientOptions_Default_MaxConnectionsPerServerIs20()
	{
		// Act
		var options = new HttpClientOptions();

		// Assert
		Assert.AreEqual(20, options.MaxConnectionsPerServer);
	}

	[TestMethod]
	public void HttpClientOptions_Default_PooledConnectionIdleTimeoutIs5Minutes()
	{
		// Act
		var options = new HttpClientOptions();

		// Assert
		Assert.AreEqual(TimeSpan.FromMinutes(5), options.PooledConnectionIdleTimeout);
	}

	[TestMethod]
	public void HttpClientOptions_Default_PooledConnectionLifetimeIs10Minutes()
	{
		// Act
		var options = new HttpClientOptions();

		// Assert
		Assert.AreEqual(TimeSpan.FromMinutes(10), options.PooledConnectionLifetime);
	}

	[TestMethod]
	public void HttpClientOptions_Default_TimeoutIs30Seconds()
	{
		// Act
		var options = new HttpClientOptions();

		// Assert
		Assert.AreEqual(TimeSpan.FromSeconds(30), options.Timeout);
	}

	[TestMethod]
	public void HttpClientOptions_Default_UseCookiesIsFalse()
	{
		// Act
		var options = new HttpClientOptions();

		// Assert
		Assert.IsFalse(options.UseCookies);
	}

	[TestMethod]
	public void HttpClientOptions_Default_UseProxyIsFalse()
	{
		// Act
		var options = new HttpClientOptions();

		// Assert
		Assert.IsFalse(options.UseProxy);
	}

	[TestMethod]
	public void HttpClientOptions_Default_UserAgentIsOptimizedHttpClient()
	{
		// Act
		var options = new HttpClientOptions();

		// Assert
		Assert.AreEqual("OptimizedHttpClient/1.0", options.UserAgent);
	}

	[TestMethod]
	public void HttpClientOptions_WithExpression_NewInstanceHasUpdatedTimeout()
	{
		// Arrange
		var original = new HttpClientOptions();

		// Act
		var modified = original with { Timeout = TimeSpan.FromMinutes(1) };

		// Assert
		Assert.AreEqual(TimeSpan.FromMinutes(1), modified.Timeout);
	}

	[TestMethod]
	public void HttpClientOptions_WithExpression_OriginalTimeoutIsUnchanged()
	{
		// Arrange
		var original = new HttpClientOptions();

		// Act
		_ = original with { Timeout = TimeSpan.FromMinutes(1) };

		// Assert
		Assert.AreEqual(TimeSpan.FromSeconds(30), original.Timeout);
	}

}
