// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 04-06-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-13-2026
// ***********************************************************************
// <copyright file="HttpClientExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
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
	public async Task DeleteAndDeserializeAsyncCancellationRequestedThrowsInvalidOperationException()
	{
		// Arrange
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.OK, "{}"))
		{
			BaseAddress = new Uri("https://example.com"),
		};
		var url = new Uri("https://example.com/api/test/1");
		var options = new JsonSerializerOptions();
		using var cts = new CancellationTokenSource();
		cts.Cancel();

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<InvalidOperationException>(async () =>
		{
			await client.DeleteAndDeserializeAsync<TestPayload>(url, options, cts.Token);
		});
	}

	[TestMethod]
	public async Task DeleteAndDeserializeAsyncInternalServerErrorThrowsInvalidOperationException()
	{
		// Arrange
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.InternalServerError, string.Empty))
		{
			BaseAddress = new Uri("https://example.com"),
		};
		var url = new Uri("https://example.com/api/test/1");
		var options = new JsonSerializerOptions();

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<InvalidOperationException>(async () =>
		{
			await client.DeleteAndDeserializeAsync<TestPayload>(url, options);
		});
	}

	[TestMethod]
	public async Task DeleteAndDeserializeAsyncNotFoundThrowsInvalidOperationException()
	{
		// Arrange
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.NotFound, string.Empty))
		{
			BaseAddress = new Uri("https://example.com"),
		};
		var url = new Uri("https://example.com/api/test/1");
		var options = new JsonSerializerOptions();

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<InvalidOperationException>(async () =>
		{
			await client.DeleteAndDeserializeAsync<TestPayload>(url, options);
		});
	}

	// ──────────────────────────────────────────────
	// DeleteAndDeserializeAsync
	// ──────────────────────────────────────────────

	[TestMethod]
	public async Task DeleteAndDeserializeAsyncNullClientThrowsArgumentNullException()
	{
		// Arrange
		HttpClient client = null;
		var url = new Uri("https://example.com/api/test/1");
		var options = new JsonSerializerOptions();

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
		{
			await client.DeleteAndDeserializeAsync<TestPayload>(url, options);
		});
	}

	[TestMethod]
	public async Task DeleteAndDeserializeAsyncNullOptionsThrowsArgumentNullException()
	{
		// Arrange
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.OK, "{}"))
		{
			BaseAddress = new Uri("https://example.com"),
		};
		var url = new Uri("https://example.com/api/test/1");

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
		{
			await client.DeleteAndDeserializeAsync<TestPayload>(url, null);
		});
	}

	[TestMethod]
	public async Task DeleteAndDeserializeAsyncNullUrlThrowsArgumentNullException()
	{
		// Arrange
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.OK, "{}"))
		{
			BaseAddress = new Uri("https://example.com"),
		};
		var options = new JsonSerializerOptions();

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
		{
			await client.DeleteAndDeserializeAsync<TestPayload>(null, options);
		});
	}

	[TestMethod]
	public async Task DeleteAndDeserializeAsyncValidResponseReturnsDeserializedObject()
	{
		// Arrange
		var expectedResponse = new TestPayload { Name = "Deleted", Value = 1 };
		var json = JsonSerializer.Serialize(expectedResponse);
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.OK, json))
		{
			BaseAddress = new Uri("https://example.com"),
		};
		var url = new Uri("https://example.com/api/test/1");
		var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

		// Act
		var result = await client.DeleteAndDeserializeAsync<TestPayload>(url, options);

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(expectedResponse.Name, result.Name);
		Assert.AreEqual(expectedResponse.Value, result.Value);
	}

	[TestMethod]
	public async Task DownloadToStreamAsyncCancellationRequestedThrowsInvalidOperationException()
	{
		// Arrange
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.OK, "data"))
		{
			BaseAddress = new Uri("https://example.com"),
		};
		var url = new Uri("https://example.com/api/file");
		using var destination = new MemoryStream();
		using var cts = new CancellationTokenSource();
		cts.Cancel();

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<InvalidOperationException>(async () =>
		{
			await client.DownloadToStreamAsync(url, destination, cts.Token);
		});
	}

	[TestMethod]
	public async Task DownloadToStreamAsyncInternalServerErrorThrowsInvalidOperationException()
	{
		// Arrange
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.InternalServerError, string.Empty))
		{
			BaseAddress = new Uri("https://example.com"),
		};
		var url = new Uri("https://example.com/api/file");
		using var destination = new MemoryStream();

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<InvalidOperationException>(async () =>
		{
			await client.DownloadToStreamAsync(url, destination);
		});
	}

	[TestMethod]
	public async Task DownloadToStreamAsyncNonWritableStreamThrowsArgumentException()
	{
		// Arrange
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.OK, "data"))
		{
			BaseAddress = new Uri("https://example.com"),
		};
		var url = new Uri("https://example.com/api/file");
		using var readOnlyStream = new MemoryStream(new byte[] { 1, 2, 3 }, writable: false);

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentException>(async () =>
		{
			await client.DownloadToStreamAsync(url, readOnlyStream);
		});
	}

	[TestMethod]
	public async Task DownloadToStreamAsyncNotFoundThrowsInvalidOperationException()
	{
		// Arrange
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.NotFound, string.Empty))
		{
			BaseAddress = new Uri("https://example.com"),
		};
		var url = new Uri("https://example.com/api/file");
		using var destination = new MemoryStream();

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<InvalidOperationException>(async () =>
		{
			await client.DownloadToStreamAsync(url, destination);
		});
	}

	// ──────────────────────────────────────────────
	// DownloadToStreamAsync
	// ──────────────────────────────────────────────

	[TestMethod]
	public async Task DownloadToStreamAsyncNullClientThrowsArgumentNullException()
	{
		// Arrange
		HttpClient client = null;
		var url = new Uri("https://example.com/api/file");
		using var destination = new MemoryStream();

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
		{
			await client.DownloadToStreamAsync(url, destination);
		});
	}

	[TestMethod]
	public async Task DownloadToStreamAsyncNullDestinationThrowsArgumentNullException()
	{
		// Arrange
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.OK, "data"))
		{
			BaseAddress = new Uri("https://example.com"),
		};
		var url = new Uri("https://example.com/api/file");

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
		{
			await client.DownloadToStreamAsync(url, null);
		});
	}

	[TestMethod]
	public async Task DownloadToStreamAsyncNullUrlThrowsArgumentNullException()
	{
		// Arrange
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.OK, "data"))
		{
			BaseAddress = new Uri("https://example.com"),
		};
		using var destination = new MemoryStream();

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
		{
			await client.DownloadToStreamAsync(null, destination);
		});
	}

	[TestMethod]
	public async Task DownloadToStreamAsyncValidResponseCopiesContentToDestination()
	{
		// Arrange
		var expectedContent = "file content for download test";
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.OK, expectedContent))
		{
			BaseAddress = new Uri("https://example.com"),
		};
		var url = new Uri("https://example.com/api/file");
		using var destination = new MemoryStream();

		// Act
		await client.DownloadToStreamAsync(url, destination);

		// Assert
		destination.Position = 0;
		using var reader = new StreamReader(destination);
		var content = await reader.ReadToEndAsync();
		Assert.AreEqual(expectedContent, content);
	}

	[TestMethod]
	public async Task GetAndDeserializeAsyncCancellationRequestedThrowsTaskCanceledException()
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
	public async Task GetAndDeserializeAsyncNonSuccessStatusCodeThrowsHttpRequestException()
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

	// ──────────────────────────────────────────────
	// GetAndDeserializeAsync
	// ──────────────────────────────────────────────

	[TestMethod]
	public async Task GetAndDeserializeAsyncNullClientThrowsArgumentNullException()
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
	public async Task GetAndDeserializeAsyncNullOptionsThrowsArgumentNullException()
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
	public async Task GetAndDeserializeAsyncNullUrlThrowsArgumentNullException()
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
	public async Task GetAndDeserializeAsyncValidResponseReturnsDeserializedObject()
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
	public async Task GetAndDeserializeFromStreamAsyncCancellationRequestedThrowsInvalidOperationException()
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
	public async Task GetAndDeserializeFromStreamAsyncInternalServerErrorThrowsInvalidOperationException()
	{
		// Arrange
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.InternalServerError, string.Empty))
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
	public async Task GetAndDeserializeFromStreamAsyncNotFoundThrowsInvalidOperationException()
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

	// ──────────────────────────────────────────────
	// GetAndDeserializeFromStreamAsync
	// ──────────────────────────────────────────────

	[TestMethod]
	public async Task GetAndDeserializeFromStreamAsyncNullClientThrowsArgumentNullException()
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
	public async Task GetAndDeserializeFromStreamAsyncNullOptionsThrowsArgumentNullException()
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
	public async Task GetAndDeserializeFromStreamAsyncNullUrlThrowsArgumentNullException()
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
	public async Task GetAndDeserializeFromStreamAsyncValidResponseReturnsDeserializedObject()
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
	public async Task GetStreamAsyncCancellationRequestedThrowsInvalidOperationException()
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
	public async Task GetStreamAsyncInternalServerErrorThrowsInvalidOperationException()
	{
		// Arrange
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.InternalServerError, string.Empty))
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
	public async Task GetStreamAsyncNotFoundThrowsInvalidOperationException()
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

	// ──────────────────────────────────────────────
	// GetStreamAsync
	// ──────────────────────────────────────────────

	[TestMethod]
	public async Task GetStreamAsyncNullClientThrowsArgumentNullException()
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
	public async Task GetStreamAsyncNullUrlThrowsArgumentNullException()
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
	public async Task GetStreamAsyncValidResponseReturnsStream()
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

		using var reader = new StreamReader(stream);
		var content = await reader.ReadToEndAsync();
		Assert.AreEqual(expectedContent, content);
	}

	[TestMethod]
	public async Task HeadAsyncCancellationRequestedThrowsInvalidOperationException()
	{
		// Arrange
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.OK, string.Empty))
		{
			BaseAddress = new Uri("https://example.com"),
		};
		var url = new Uri("https://example.com/api/test");
		using var cts = new CancellationTokenSource();
		cts.Cancel();

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<InvalidOperationException>(async () =>
		{
			await client.HeadersAsync(url, cts.Token);
		});
	}

	[TestMethod]
	public async Task HeadAsyncNotFoundThrowsInvalidOperationException()
	{
		// Arrange
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.NotFound, string.Empty))
		{
			BaseAddress = new Uri("https://example.com"),
		};
		var url = new Uri("https://example.com/api/test");

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<InvalidOperationException>(async () =>
		{
			await client.HeadersAsync(url);
		});
	}

	[TestMethod]
	public async Task HeadersAsyncInternalServerErrorThrowsInvalidOperationException()
	{
		// Arrange
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.InternalServerError, string.Empty))
		{
			BaseAddress = new Uri("https://example.com"),
		};
		var url = new Uri("https://example.com/api/test");

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<InvalidOperationException>(async () =>
		{
			await client.HeadersAsync(url);
		});
	}

	// ──────────────────────────────────────────────
	// HeadersAsync
	// ──────────────────────────────────────────────

	[TestMethod]
	public async Task HeadAsyncNullClientThrowsArgumentNullException()
	{
		// Arrange
		HttpClient client = null;
		var url = new Uri("https://example.com/api/test");

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
		{
			await client.HeadersAsync(url);
		});
	}

	[TestMethod]
	public async Task HeadAsyncNullUrlThrowsArgumentNullException()
	{
		// Arrange
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.OK, string.Empty))
		{
			BaseAddress = new Uri("https://example.com"),
		};

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
		{
			await client.HeadersAsync(null);
		});
	}

	[TestMethod]
	public async Task HeadAsyncValidResponseReturnsHeaders()
	{
		// Arrange
		using var client = new HttpClient(new MockHttpMessageHandlerWithHeaders(HttpStatusCode.OK))
		{
			BaseAddress = new Uri("https://example.com"),
		};
		var url = new Uri("https://example.com/api/test");

		// Act
		var headers = await client.HeadersAsync(url);

		// Assert
		Assert.IsNotNull(headers);
		Assert.IsTrue(headers.Contains("X-Custom-Header"));

		var headerValues = headers.GetValues("X-Custom-Header");
		Assert.IsTrue(headerValues.Any());
	}

	[TestMethod]
	public async Task PatchAndDeserializeAsyncCancellationRequestedThrowsInvalidOperationException()
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
	public async Task PatchAndDeserializeAsyncNotFoundThrowsInvalidOperationException()
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
	public async Task PatchAndDeserializeAsyncInternalServerErrorThrowsInvalidOperationException()
	{
		// Arrange
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.InternalServerError, string.Empty))
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

	// ──────────────────────────────────────────────
	// PatchAndDeserializeAsync
	// ──────────────────────────────────────────────

	[TestMethod]
	public async Task PatchAndDeserializeAsyncNullClientThrowsArgumentNullException()
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
	public async Task PatchAndDeserializeAsyncNullOptionsThrowsArgumentNullException()
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
	public async Task PatchAndDeserializeAsyncNullRequestThrowsArgumentNullException()
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
	public async Task PatchAndDeserializeAsyncNullUrlThrowsArgumentNullException()
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
	public async Task PatchAndDeserializeAsyncValidResponseReturnsDeserializedObject()
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
	public async Task PostAndDeserializeAsyncCancellationRequestedThrowsInvalidOperationException()
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
	public async Task PostAndDeserializeAsyncNotFoundThrowsInvalidOperationException()
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
	public async Task PostAndDeserializeAsyncInternalServerErrorThrowsInvalidOperationException()
	{
		// Arrange
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.InternalServerError, string.Empty))
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

	// ──────────────────────────────────────────────
	// PostAndDeserializeAsync
	// ──────────────────────────────────────────────

	[TestMethod]
	public async Task PostAndDeserializeAsyncNullClientThrowsArgumentNullException()
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
	public async Task PostAndDeserializeAsyncNullOptionsThrowsArgumentNullException()
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
	public async Task PostAndDeserializeAsyncNullRequestThrowsArgumentNullException()
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
	public async Task PostAndDeserializeAsyncNullUrlThrowsArgumentNullException()
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
	public async Task PostAndDeserializeAsyncValidResponseReturnsDeserializedObject()
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
	public async Task PostAndEnsureSuccessAsyncCancellationRequestedThrowsInvalidOperationException()
	{
		// Arrange
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.OK, string.Empty))
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
			await client.PostAndEnsureSuccessAsync(url, requestBody, options, cts.Token);
		});
	}

	[TestMethod]
	public async Task PostAndEnsureSuccessAsyncNotFoundThrowsInvalidOperationException()
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
			await client.PostAndEnsureSuccessAsync(url, requestBody, options);
		});
	}

	[TestMethod]
	public async Task PostAndEnsureSuccessAsyncInternalServerErrorThrowsInvalidOperationException()
	{
		// Arrange
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.InternalServerError, string.Empty))
		{
			BaseAddress = new Uri("https://example.com"),
		};
		var url = new Uri("https://example.com/api/test");
		var requestBody = new TestPayload { Name = "Test", Value = 1 };
		var options = new JsonSerializerOptions();

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<InvalidOperationException>(async () =>
		{
			await client.PostAndEnsureSuccessAsync(url, requestBody, options);
		});
	}

	// ──────────────────────────────────────────────
	// PostAndEnsureSuccessAsync
	// ──────────────────────────────────────────────

	[TestMethod]
	public async Task PostAndEnsureSuccessAsyncNullClientThrowsArgumentNullException()
	{
		// Arrange
		HttpClient client = null;
		var url = new Uri("https://example.com/api/test");
		var requestBody = new TestPayload { Name = "Test", Value = 1 };
		var options = new JsonSerializerOptions();

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
		{
			await client.PostAndEnsureSuccessAsync(url, requestBody, options);
		});
	}

	[TestMethod]
	public async Task PostAndEnsureSuccessAsyncNullOptionsThrowsArgumentNullException()
	{
		// Arrange
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.OK, string.Empty))
		{
			BaseAddress = new Uri("https://example.com"),
		};
		var url = new Uri("https://example.com/api/test");
		var requestBody = new TestPayload { Name = "Test", Value = 1 };

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
		{
			await client.PostAndEnsureSuccessAsync(url, requestBody, null);
		});
	}

	[TestMethod]
	public async Task PostAndEnsureSuccessAsyncNullRequestThrowsArgumentNullException()
	{
		// Arrange
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.OK, string.Empty))
		{
			BaseAddress = new Uri("https://example.com"),
		};
		var url = new Uri("https://example.com/api/test");
		var options = new JsonSerializerOptions();

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
		{
			await client.PostAndEnsureSuccessAsync<TestPayload>(url, null, options);
		});
	}

	[TestMethod]
	public async Task PostAndEnsureSuccessAsyncNullUrlThrowsArgumentNullException()
	{
		// Arrange
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.OK, string.Empty))
		{
			BaseAddress = new Uri("https://example.com"),
		};
		var requestBody = new TestPayload { Name = "Test", Value = 1 };
		var options = new JsonSerializerOptions();

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
		{
			await client.PostAndEnsureSuccessAsync(null, requestBody, options);
		});
	}

	[TestMethod]
	public async Task PostAndEnsureSuccessAsyncValidResponseReturnsStatusCode()
	{
		// Arrange
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.Created, string.Empty))
		{
			BaseAddress = new Uri("https://example.com"),
		};
		var url = new Uri("https://example.com/api/test");
		var requestBody = new TestPayload { Name = "New", Value = 42 };
		var options = new JsonSerializerOptions();

		// Act
		var statusCode = await client.PostAndEnsureSuccessAsync(url, requestBody, options);

		// Assert
		Assert.AreEqual(HttpStatusCode.Created, statusCode);
	}

	[TestMethod]
	public async Task PutAndDeserializeAsyncCancellationRequestedThrowsInvalidOperationException()
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

	[TestMethod]
	public async Task PutAndDeserializeAsyncNotFoundThrowsInvalidOperationException()
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
	public async Task PutAndDeserializeAsyncInternalServerErrorThrowsInvalidOperationException()
	{
		// Arrange
		using var client = new HttpClient(new MockHttpMessageHandler(HttpStatusCode.InternalServerError, string.Empty))
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

	// ──────────────────────────────────────────────
	// PutAndDeserializeAsync
	// ──────────────────────────────────────────────

	[TestMethod]
	public async Task PutAndDeserializeAsyncNullClientThrowsArgumentNullException()
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
	public async Task PutAndDeserializeAsyncNullOptionsThrowsArgumentNullException()
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
	public async Task PutAndDeserializeAsyncNullRequestThrowsArgumentNullException()
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
	public async Task PutAndDeserializeAsyncNullUrlThrowsArgumentNullException()
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
	public async Task PutAndDeserializeAsyncValidResponseReturnsDeserializedObject()
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

	// ──────────────────────────────────────────────
	// Helper types
	// ──────────────────────────────────────────────

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

	private sealed class MockHttpMessageHandlerWithHeaders(HttpStatusCode statusCode) : HttpMessageHandler
	{

		protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();

			var response = new HttpResponseMessage(statusCode)
			{
				Content = new StringContent(string.Empty),
			};
			response.Headers.Add("X-Custom-Header", "test-value");

			return Task.FromResult(response);
		}

	}

	private sealed class TestPayload
	{

		public string Name { get; set; }

		public int Value { get; set; }

	}

}
