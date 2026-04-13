// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 04-06-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-07-2026
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
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class HttpClientExtensionsTests
{

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
	public async Task GetAndDeserializeFromStreamAsync_CancellationRequested_ThrowsInvalidOperationException()
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
		_ = await Assert.ThrowsExactlyAsync<InvalidOperationException>(async () =>
		{
			await client.GetAndDeserializeFromStreamAsync<TestPayload>(url, options, cts.Token);
		});
	}

	[TestMethod]
	public async Task GetAndDeserializeFromStreamAsync_NotFound_ThrowsInvalidOperationException()
	{
		// Arrange
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.NotFound, string.Empty))
		{
			BaseAddress = new Uri("https://example.com"),
		};
		var url = new Uri("https://example.com/api/test");
		var options = new JsonSerializerOptions();

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<InvalidOperationException>(async () =>
		{
			await client.GetAndDeserializeFromStreamAsync<TestPayload>(url, options);
		});
	}

	[TestMethod]
	public async Task GetAndDeserializeFromStreamAsync_NullClient_ThrowsArgumentNullException()
	{
		// Arrange
		HttpClient client = null;
		var url = new Uri("https://example.com/api/test");
		var options = new JsonSerializerOptions();

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
		{
			await client.GetAndDeserializeFromStreamAsync<TestPayload>(url, options);
		});
	}

	[TestMethod]
	public async Task GetAndDeserializeFromStreamAsync_NullOptions_ThrowsArgumentNullException()
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
			await client.GetAndDeserializeFromStreamAsync<TestPayload>(url, null);
		});
	}

	[TestMethod]
	public async Task GetAndDeserializeFromStreamAsync_NullUrl_ThrowsArgumentNullException()
	{
		// Arrange
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.OK, "{}"))
		{
			BaseAddress = new Uri("https://example.com"),
		};

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
		{
			await client.GetAndDeserializeFromStreamAsync<TestPayload>(null, new JsonSerializerOptions());
		});
	}

	[TestMethod]
	public async Task GetAndDeserializeFromStreamAsync_ValidResponse_ReturnsDeserializedObject()
	{
		// Arrange
		var expectedPayload = new TestPayload { Name = "StreamTest", Value = 42 };
		var json = JsonSerializer.Serialize(expectedPayload);
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.OK, json))
		{
			BaseAddress = new Uri("https://example.com"),
		};
		var url = new Uri("https://example.com/api/test");
		var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

		// Act
		var result = await client.GetAndDeserializeFromStreamAsync<TestPayload>(url, options);

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(expectedPayload.Name, result.Name);
		Assert.AreEqual(expectedPayload.Value, result.Value);
	}

	[TestMethod]
	public async Task PatchAndDeserializeAsync_NotFound_ThrowsInvalidOperationException()
	{
		// Arrange
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.NotFound, string.Empty))
		{
			BaseAddress = new Uri("https://example.com"),
		};
		var url = new Uri("https://example.com/api/test/1");
		var requestBody = new TestPayload { Name = "Test", Value = 1 };
		var options = new JsonSerializerOptions();

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<InvalidOperationException>(async () =>
		{
			await client.PatchAndDeserializeAsync<TestPayload, TestPayload>(url, requestBody, options);
		});
	}

	[TestMethod]
	public async Task PatchAndDeserializeAsync_NullClient_ThrowsArgumentNullException()
	{
		// Arrange
		HttpClient client = null;
		var url = new Uri("https://example.com/api/test/1");
		var requestBody = new TestPayload { Name = "Test", Value = 1 };
		var options = new JsonSerializerOptions();

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
		{
			await client.PatchAndDeserializeAsync<TestPayload, TestPayload>(url, requestBody, options);
		});
	}

	[TestMethod]
	public async Task PatchAndDeserializeAsync_NullOptions_ThrowsArgumentNullException()
	{
		// Arrange
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.OK, "{}"))
		{
			BaseAddress = new Uri("https://example.com"),
		};
		var url = new Uri("https://example.com/api/test/1");
		var requestBody = new TestPayload { Name = "Test", Value = 1 };

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
		{
			await client.PatchAndDeserializeAsync<TestPayload, TestPayload>(url, requestBody, null);
		});
	}

	[TestMethod]
	public async Task PatchAndDeserializeAsync_NullRequest_ThrowsArgumentNullException()
	{
		// Arrange
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.OK, "{}"))
		{
			BaseAddress = new Uri("https://example.com"),
		};
		var url = new Uri("https://example.com/api/test/1");
		var options = new JsonSerializerOptions();

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
		{
			await client.PatchAndDeserializeAsync<TestPayload, TestPayload>(url, null, options);
		});
	}

	[TestMethod]
	public async Task PatchAndDeserializeAsync_NullUrl_ThrowsArgumentNullException()
	{
		// Arrange
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.OK, "{}"))
		{
			BaseAddress = new Uri("https://example.com"),
		};
		var requestBody = new TestPayload { Name = "Test", Value = 1 };
		var options = new JsonSerializerOptions();

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
		{
			await client.PatchAndDeserializeAsync<TestPayload, TestPayload>(null, requestBody, options);
		});
	}

	[TestMethod]
	public async Task PatchAndDeserializeAsync_ValidResponse_ReturnsDeserializedObject()
	{
		// Arrange
		var expectedResponse = new TestPayload { Name = "Patched", Value = 50 };
		var json = JsonSerializer.Serialize(expectedResponse);
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.OK, json))
		{
			BaseAddress = new Uri("https://example.com"),
		};
		var url = new Uri("https://example.com/api/test/1");
		var requestBody = new TestPayload { Name = "Patched", Value = 50 };
		var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

		// Act
		var result = await client.PatchAndDeserializeAsync<TestPayload, TestPayload>(url, requestBody, options);

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(expectedResponse.Name, result.Name);
		Assert.AreEqual(expectedResponse.Value, result.Value);
	}

	[TestMethod]
	public async Task PostAndDeserializeAsync_CancellationRequested_ThrowsInvalidOperationException()
	{
		// Arrange
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.OK, "{}"))
		{
			BaseAddress = new Uri("https://example.com"),
		};
		var url = new Uri("https://example.com/api/test");
		var requestBody = new TestPayload { Name = "Test", Value = 1 };
		var options = new JsonSerializerOptions();
		using var cts = new CancellationTokenSource();
		cts.Cancel();

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<InvalidOperationException>(async () =>
		{
			await client.PostAndDeserializeAsync<TestPayload, TestPayload>(url, requestBody, options, cts.Token);
		});
	}

	[TestMethod]
	public async Task PostAndDeserializeAsync_NotFound_ThrowsInvalidOperationException()
	{
		// Arrange
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.NotFound, string.Empty))
		{
			BaseAddress = new Uri("https://example.com"),
		};
		var url = new Uri("https://example.com/api/test");
		var requestBody = new TestPayload { Name = "Test", Value = 1 };
		var options = new JsonSerializerOptions();

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<InvalidOperationException>(async () =>
		{
			await client.PostAndDeserializeAsync<TestPayload, TestPayload>(url, requestBody, options);
		});
	}

	[TestMethod]
	public async Task PostAndDeserializeAsync_NullClient_ThrowsArgumentNullException()
	{
		// Arrange
		HttpClient client = null;
		var url = new Uri("https://example.com/api/test");
		var requestBody = new TestPayload { Name = "Test", Value = 1 };
		var options = new JsonSerializerOptions();

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
		{
			await client.PostAndDeserializeAsync<TestPayload, TestPayload>(url, requestBody, options);
		});
	}

	[TestMethod]
	public async Task PostAndDeserializeAsync_NullOptions_ThrowsArgumentNullException()
	{
		// Arrange
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.OK, "{}"))
		{
			BaseAddress = new Uri("https://example.com"),
		};
		var url = new Uri("https://example.com/api/test");
		var requestBody = new TestPayload { Name = "Test", Value = 1 };

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
		{
			await client.PostAndDeserializeAsync<TestPayload, TestPayload>(url, requestBody, null);
		});
	}

	[TestMethod]
	public async Task PostAndDeserializeAsync_NullRequest_ThrowsArgumentNullException()
	{
		// Arrange
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.OK, "{}"))
		{
			BaseAddress = new Uri("https://example.com"),
		};
		var url = new Uri("https://example.com/api/test");
		var options = new JsonSerializerOptions();

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
		{
			await client.PostAndDeserializeAsync<TestPayload, TestPayload>(url, null, options);
		});
	}

	[TestMethod]
	public async Task PostAndDeserializeAsync_NullUrl_ThrowsArgumentNullException()
	{
		// Arrange
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.OK, "{}"))
		{
			BaseAddress = new Uri("https://example.com"),
		};
		var requestBody = new TestPayload { Name = "Test", Value = 1 };
		var options = new JsonSerializerOptions();

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
		{
			await client.PostAndDeserializeAsync<TestPayload, TestPayload>(null, requestBody, options);
		});
	}

	[TestMethod]
	public async Task PostAndDeserializeAsync_ValidResponse_ReturnsDeserializedObject()
	{
		// Arrange
		var expectedResponse = new TestPayload { Name = "Created", Value = 1 };
		var json = JsonSerializer.Serialize(expectedResponse);
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.OK, json))
		{
			BaseAddress = new Uri("https://example.com"),
		};
		var url = new Uri("https://example.com/api/test");
		var requestBody = new TestPayload { Name = "New", Value = 0 };
		var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

		// Act
		var result = await client.PostAndDeserializeAsync<TestPayload, TestPayload>(url, requestBody, options);

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(expectedResponse.Name, result.Name);
		Assert.AreEqual(expectedResponse.Value, result.Value);
	}

	[TestMethod]
	public async Task PutAndDeserializeAsync_NotFound_ThrowsInvalidOperationException()
	{
		// Arrange
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.NotFound, string.Empty))
		{
			BaseAddress = new Uri("https://example.com"),
		};
		var url = new Uri("https://example.com/api/test/1");
		var requestBody = new TestPayload { Name = "Test", Value = 1 };
		var options = new JsonSerializerOptions();

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<InvalidOperationException>(async () =>
		{
			await client.PutAndDeserializeAsync<TestPayload, TestPayload>(url, requestBody, options);
		});
	}

	[TestMethod]
	public async Task PutAndDeserializeAsync_NullClient_ThrowsArgumentNullException()
	{
		// Arrange
		HttpClient client = null;
		var url = new Uri("https://example.com/api/test/1");
		var requestBody = new TestPayload { Name = "Test", Value = 1 };
		var options = new JsonSerializerOptions();

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
		{
			await client.PutAndDeserializeAsync<TestPayload, TestPayload>(url, requestBody, options);
		});
	}

	[TestMethod]
	public async Task PutAndDeserializeAsync_NullOptions_ThrowsArgumentNullException()
	{
		// Arrange
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.OK, "{}"))
		{
			BaseAddress = new Uri("https://example.com"),
		};
		var url = new Uri("https://example.com/api/test/1");
		var requestBody = new TestPayload { Name = "Test", Value = 1 };

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
		{
			await client.PutAndDeserializeAsync<TestPayload, TestPayload>(url, requestBody, null);
		});
	}

	[TestMethod]
	public async Task PutAndDeserializeAsync_NullRequest_ThrowsArgumentNullException()
	{
		// Arrange
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.OK, "{}"))
		{
			BaseAddress = new Uri("https://example.com"),
		};
		var url = new Uri("https://example.com/api/test/1");
		var options = new JsonSerializerOptions();

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
		{
			await client.PutAndDeserializeAsync<TestPayload, TestPayload>(url, null, options);
		});
	}

	[TestMethod]
	public async Task PutAndDeserializeAsync_NullUrl_ThrowsArgumentNullException()
	{
		// Arrange
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.OK, "{}"))
		{
			BaseAddress = new Uri("https://example.com"),
		};
		var requestBody = new TestPayload { Name = "Test", Value = 1 };
		var options = new JsonSerializerOptions();

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
		{
			await client.PutAndDeserializeAsync<TestPayload, TestPayload>(null, requestBody, options);
		});
	}

	[TestMethod]
	public async Task PutAndDeserializeAsync_ValidResponse_ReturnsDeserializedObject()
	{
		// Arrange
		var expectedResponse = new TestPayload { Name = "Updated", Value = 99 };
		var json = JsonSerializer.Serialize(expectedResponse);
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.OK, json))
		{
			BaseAddress = new Uri("https://example.com"),
		};
		var url = new Uri("https://example.com/api/test/1");
		var requestBody = new TestPayload { Name = "Updated", Value = 99 };
		var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

		// Act
		var result = await client.PutAndDeserializeAsync<TestPayload, TestPayload>(url, requestBody, options);

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(expectedResponse.Name, result.Name);
		Assert.AreEqual(expectedResponse.Value, result.Value);
	}

	[TestMethod]
	public async Task GetAndDeserializeAsync_ValidResponse_ReturnsDeserializedObject()
	{
		// Arrange
		var expectedPayload = new TestPayload { Name = "Test", Value = 42 };
		var json = JsonSerializer.Serialize(expectedPayload);
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
		Assert.AreEqual(expectedPayload.Name, result.Name);
		Assert.AreEqual(expectedPayload.Value, result.Value);
	}

	[TestMethod]
	public async Task GetStreamAsync_CancellationRequested_ThrowsInvalidOperationException()
	{
		// Arrange
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.OK, "stream content"))
		{
			BaseAddress = new Uri("https://example.com"),
		};
		var url = new Uri("https://example.com/api/stream");
		using var cts = new CancellationTokenSource();
		cts.Cancel();

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<InvalidOperationException>(async () =>
		{
			await HttpClientExtensions.GetStreamAsync(client, url, cts.Token);
		});
	}

	[TestMethod]
	public async Task GetStreamAsync_NotFound_ThrowsInvalidOperationException()
	{
		// Arrange
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.NotFound, string.Empty))
		{
			BaseAddress = new Uri("https://example.com"),
		};
		var url = new Uri("https://example.com/api/stream");

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<InvalidOperationException>(async () =>
		{
			await HttpClientExtensions.GetStreamAsync(client, url);
		});
	}

	[TestMethod]
	public async Task GetStreamAsync_NullClient_ThrowsArgumentNullException()
	{
		// Arrange
		HttpClient client = null;
		var url = new Uri("https://example.com/api/stream");

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
		{
			await HttpClientExtensions.GetStreamAsync(client, url);
		});
	}

	[TestMethod]
	public async Task GetStreamAsync_NullUrl_ThrowsArgumentNullException()
	{
		// Arrange
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.OK, "stream content"))
		{
			BaseAddress = new Uri("https://example.com"),
		};

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
		{
			await HttpClientExtensions.GetStreamAsync(client, null);
		});
	}

	[TestMethod]
	public async Task GetStreamAsync_ValidResponse_ReturnsStream()
	{
		// Arrange
		var expectedContent = "stream content data";
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.OK, expectedContent))
		{
			BaseAddress = new Uri("https://example.com"),
		};
		var url = new Uri("https://example.com/api/stream");

		// Act
		using var stream = await HttpClientExtensions.GetStreamAsync(client, url);

		// Assert
		Assert.IsNotNull(stream);
		Assert.IsTrue(stream.CanRead);

		using var reader = new System.IO.StreamReader(stream);
		var content = await reader.ReadToEndAsync();
		Assert.AreEqual(expectedContent, content);
	}

	[TestMethod]
	public async Task PatchAndDeserializeAsync_CancellationRequested_ThrowsInvalidOperationException()
	{
		// Arrange
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.OK, "{}"))
		{
			BaseAddress = new Uri("https://example.com"),
		};
		var url = new Uri("https://example.com/api/test/1");
		var requestBody = new TestPayload { Name = "Test", Value = 1 };
		var options = new JsonSerializerOptions();
		using var cts = new CancellationTokenSource();
		cts.Cancel();

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<InvalidOperationException>(async () =>
		{
			await client.PatchAndDeserializeAsync<TestPayload, TestPayload>(url, requestBody, options, cts.Token);
		});
	}

	[TestMethod]
	public async Task PutAndDeserializeAsync_CancellationRequested_ThrowsInvalidOperationException()
	{
		// Arrange
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.OK, "{}"))
		{
			BaseAddress = new Uri("https://example.com"),
		};
		var url = new Uri("https://example.com/api/test/1");
		var requestBody = new TestPayload { Name = "Test", Value = 1 };
		var options = new JsonSerializerOptions();
		using var cts = new CancellationTokenSource();
		cts.Cancel();

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<InvalidOperationException>(async () =>
		{
			await client.PutAndDeserializeAsync<TestPayload, TestPayload>(url, requestBody, options, cts.Token);
		});
	}

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

}
