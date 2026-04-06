// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : Copilot Agent
// Created          : 04-06-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-06-2026
// ***********************************************************************
// <copyright file="WebClientExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

#pragma warning disable SYSLIB0014 // WebClient is obsolete

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class WebClientExtensionsTests
{

	[DataContract]
	private sealed class JsonTestData
	{

		[DataMember]
		public string Name { get; set; }

		[DataMember]
		public int Value { get; set; }

	}

	private static int GetAvailablePort()
	{
		using (var listener = new TcpListener(IPAddress.Loopback, 0))
		{
			listener.Start();
			var port = ((IPEndPoint)listener.LocalEndpoint).Port;
			listener.Stop();

			return port;
		}
	}

	[TestMethod]
	public void ConvertFrom_EmptyResponse_ReturnsNull()
	{
		// Arrange
		var port = GetAvailablePort();
		var prefix = $"http://localhost:{port}/empty/";

		using (var listener = new HttpListener())
		{
			listener.Prefixes.Add(prefix);
			listener.Start();

			var serverTask = Task.Run(() =>
			{
				var context = listener.GetContext();
				var response = context.Response;
				response.ContentLength64 = 0;
				response.OutputStream.Close();
			});

			using (var client = new WebClient())
			{
				var url = new Uri(prefix);

				// Act
				var result = client.ConvertFrom<JsonTestData>(url);

				// Assert
				Assert.IsNull(result);
			}

			serverTask.Wait(TimeSpan.FromSeconds(5));
			listener.Stop();
		}
	}

	[TestMethod]
	public void ConvertFrom_NullClient_ThrowsArgumentNullException()
	{
		// Arrange
		WebClient client = null;
		var url = new Uri("http://localhost");

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => client.ConvertFrom<JsonTestData>(url));
	}

	[TestMethod]
	public void ConvertFrom_NullUrl_ThrowsArgumentNullException()
	{
		// Arrange & Act & Assert
		using (var client = new WebClient())
		{
			Assert.ThrowsExactly<ArgumentNullException>(() => client.ConvertFrom<JsonTestData>(null));
		}
	}

	[TestMethod]
	public void ConvertFrom_ValidJsonResponse_ReturnsDeserializedObject()
	{
		// Arrange
		var port = GetAvailablePort();
		var prefix = $"http://localhost:{port}/valid/";
		var expectedValue = RandomData.GenerateInteger(1, 1000);
		var json = $"{{\"Name\":\"TestItem\",\"Value\":{expectedValue}}}";

		using (var listener = new HttpListener())
		{
			listener.Prefixes.Add(prefix);
			listener.Start();

			var serverTask = Task.Run(() =>
			{
				var context = listener.GetContext();
				var response = context.Response;
				var buffer = Encoding.UTF8.GetBytes(json);
				response.ContentLength64 = buffer.Length;
				response.OutputStream.Write(buffer, 0, buffer.Length);
				response.OutputStream.Close();
			});

			using (var client = new WebClient())
			{
				var url = new Uri(prefix);

				// Act
				var result = client.ConvertFrom<JsonTestData>(url);

				// Assert
				Assert.IsNotNull(result);
				Assert.AreEqual("TestItem", result.Name);
				Assert.AreEqual(expectedValue, result.Value);
			}

			serverTask.Wait(TimeSpan.FromSeconds(5));
			listener.Stop();
		}
	}

}
