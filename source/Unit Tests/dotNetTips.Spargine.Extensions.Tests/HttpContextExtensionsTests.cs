// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : Copilot Agent
// Created          : 04-06-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-06-2026
// ***********************************************************************
// <copyright file="HttpContextExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

#nullable enable

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class HttpContextExtensionsTests
{

	[TestMethod]
	public void GetRemoteIPAddress_ValidContextWithIPv4_ReturnsIPv4String()
	{
		// Arrange
		var context = new StubHttpContext(IPAddress.Loopback);

		// Act
		var result = context.GetRemoteIPAddress();

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(IPAddress.Loopback.ToString(), result);
	}

	[TestMethod]
	public void GetRemoteIPAddress_ValidContextWithIPv6_ReturnsIPv6String()
	{
		// Arrange
		var context = new StubHttpContext(IPAddress.IPv6Loopback);

		// Act
		var result = context.GetRemoteIPAddress();

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(IPAddress.IPv6Loopback.ToString(), result);
	}

	[TestMethod]
	public void GetRemoteIPAddress_NullContext_ThrowsArgumentNullException()
	{
		// Arrange
		HttpContext context = null!;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => context.GetRemoteIPAddress());
	}

	private sealed class StubConnectionInfo(IPAddress remoteIpAddress) : ConnectionInfo
	{
		public override string Id { get; set; } = string.Empty;
		public override IPAddress? RemoteIpAddress { get; set; } = remoteIpAddress;
		public override int RemotePort { get; set; }
		public override IPAddress? LocalIpAddress { get; set; }
		public override int LocalPort { get; set; }
		public override X509Certificate2? ClientCertificate { get; set; }

		public override Task<X509Certificate2?> GetClientCertificateAsync(CancellationToken cancellationToken = default)
			=> Task.FromResult(ClientCertificate);
	}

	private sealed class StubHttpContext(IPAddress remoteIpAddress) : HttpContext
	{
		private readonly StubConnectionInfo _connection = new(remoteIpAddress);

		public override IFeatureCollection Features => throw new NotImplementedException();
		public override HttpRequest Request => throw new NotImplementedException();
		public override HttpResponse Response => throw new NotImplementedException();
		public override ConnectionInfo Connection => _connection;
		public override WebSocketManager WebSockets => throw new NotImplementedException();
		[Obsolete]
		public override Microsoft.AspNetCore.Http.Authentication.AuthenticationManager Authentication => throw new NotImplementedException();
		public override ClaimsPrincipal User { get; set; } = new();
		public override IDictionary<object, object?> Items { get; set; } = new Dictionary<object, object?>();
		public override IServiceProvider RequestServices { get; set; } = null!;
		public override CancellationToken RequestAborted { get; set; }
		public override string TraceIdentifier { get; set; } = string.Empty;
		public override ISession Session { get; set; } = null!;

		public override void Abort() => throw new NotImplementedException();
	}

}
