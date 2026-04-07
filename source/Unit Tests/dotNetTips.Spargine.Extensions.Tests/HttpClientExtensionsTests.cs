// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 04-06-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-06-2026
// ***********************************************************************
// <copyright file="HttpClientExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class HttpClientExtensionsTests
{

	private sealed class MockHttpMessageHandler(HttpStatusCode statusCode, string content) : HttpMessageHandler
	{

		protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();

			var response = new HttpResponseMessage(statusCode)
			{
				Content = new StringContent(content),
			};

			return Task.FromResult(response);
		}

	}

	private sealed class TestPayload
	{

		public string Name { get; set; }

		public int Value { get; set; }

	}

	[TestMethod]
	public async Task GetAndDeserializeAsync_NullClient_ThrowsArgumentNullException()
	{
		// Arrange
		HttpClient client = null;
		var url = new Uri("https://example.com/api/test");
		var options = new JsonSerializerOptions();

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
		{
			await client.GetAndDeserializeAsync<TestPayload>(url, options);
		});
	}

	[TestMethod]
	public async Task GetAndDeserializeAsync_NullUrl_ThrowsArgumentNullException()
	{
		// Arrange
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.OK, "{}"))
		{
			BaseAddress = new Uri("https://example.com"),
		};

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
		{
			await client.GetAndDeserializeAsync<TestPayload>(null, new JsonSerializerOptions());
		});
	}

	[TestMethod]
	public async Task GetAndDeserializeAsync_NullOptions_ThrowsArgumentNullException()
	{
		// Arrange
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.OK, "{}"))
		{
			BaseAddress = new Uri("https://example.com"),
		};
		var url = new Uri("https://example.com/api/test");

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
		{
			await client.GetAndDeserializeAsync<TestPayload>(url, null);
		});
	}

	[TestMethod]
	public async Task GetAndDeserializeAsync_ValidRequest_ReturnsDeserializedObject()
	{
		// Arrange
		var expectedName = RandomData.GenerateWord(5, 10);
		var expectedValue = RandomData.GenerateInteger(1, 1000);
		var payload = new TestPayload { Name = expectedName, Value = expectedValue };
		var json = JsonSerializer.Serialize(payload);

		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.OK, json))
		{
			BaseAddress = new Uri("https://example.com"),
		};
		var url = new Uri("https://example.com/api/test");
		var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

		// Act
		var result = await client.GetAndDeserializeAsync<TestPayload>(url, options);

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(expectedName, result.Name);
		Assert.AreEqual(expectedValue, result.Value);
	}

	[TestMethod]
	public async Task GetAndDeserializeAsync_NonSuccessStatusCode_ThrowsHttpRequestException()
	{
		// Arrange
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.NotFound, "Not Found"))
		{
			BaseAddress = new Uri("https://example.com"),
		};
		var url = new Uri("https://example.com/api/test");
		var options = new JsonSerializerOptions();

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<HttpRequestException>(async () =>
		{
			await client.GetAndDeserializeAsync<TestPayload>(url, options);
		});
	}

	[TestMethod]
	public async Task GetAndDeserializeAsync_CancellationRequested_ThrowsTaskCanceledException()
	{
		// Arrange
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.OK, "{}"))
		{
			BaseAddress = new Uri("https://example.com"),
		};
		var url = new Uri("https://example.com/api/test");
		var options = new JsonSerializerOptions();
		using var cts = new CancellationTokenSource();
		cts.Cancel();

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<TaskCanceledException>(async () =>
		{
			await client.GetAndDeserializeAsync<TestPayload>(url, options, cts.Token);
		});
	}

}
