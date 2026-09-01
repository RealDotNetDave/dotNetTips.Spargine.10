// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 05-01-2025
//
// Last Modified By : David McCarter
// Last Modified On : 12-23-2025
// ***********************************************************************
// <copyright file="HttpEventListenerTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Threading.Tasks;
using DotNetTips.Spargine.Core.Network;
using DotNetTips.Spargine.Extensions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)
namespace DotNetTips.Spargine.Core.Tests.Network;

[ExcludeFromCodeCoverage]
[TestClass]
public class HttpEventListenersTests : IDisposable
{

	private readonly HttpClient _httpClient = new();
	private readonly ILogger _logger = new NullLogger<HttpEventListenersTests>();

	public void Dispose()
	{
		this._httpClient.TryDispose();
	}

	[TestMethod]
	public async Task HttpEventListenerAsyncLocalTest()
	{
		try
		{
			var result = string.Empty;

			using (var listener = new HttpEventListenerAsyncLocal(this._logger))
			{
				result = await this._httpClient.GetStringAsync("https://dotnettips.com");
			}
		}
		catch
		{
			Assert.Fail();
		}
	}

	[TestMethod]
	public async Task HttpEventListenerTest()
	{
		try
		{
			var result = string.Empty;

			using (var listener = new HttpEventListener(this._logger))
			{
				result = await this._httpClient.GetStringAsync("https://dotnettips.com");
			}

			Trace.WriteLine(result);
		}
		catch
		{
			Assert.Fail();
		}
	}

	[TestMethod]
	public async Task HttpRequestsObserverTest()
	{
		try
		{
			var result = string.Empty;

			using (var observer = new HttpRequestsObserver(this._logger))
			{
				using (DiagnosticListener.AllListeners.Subscribe(observer))
				{
					result = await this._httpClient.GetStringAsync("https://dotnettips.com");
				}
			}
		}
		catch (Exception ex)
		{
			Trace.WriteLine(ex.Message);

			Assert.Fail();
		}
	}

}
