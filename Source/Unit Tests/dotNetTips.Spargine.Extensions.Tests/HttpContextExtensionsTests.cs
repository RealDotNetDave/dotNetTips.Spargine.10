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
using System.IO;
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
	public void GetAbsoluteUri_FullUri_ReturnsCompleteAbsoluteUri()
	{
		// Arrange
		var headers = new HeaderDictionary();
		var context = new StubHttpContext(headers, scheme: "https", host: new HostString("example.com:8443"), pathBase: new PathString("/api"), path: new PathString("/users"), queryString: new QueryString("?page=1"));

		// Act
		var result = context.GetAbsoluteUri();

		// Assert
		Assert.AreEqual(new Uri("https://example.com:8443/api/users?page=1"), result);
	}

	[TestMethod]
	public void GetAbsoluteUri_MinimalUri_ReturnsSchemeAndHost()
	{
		// Arrange
		var headers = new HeaderDictionary();
		var context = new StubHttpContext(headers, scheme: "http", host: new HostString("localhost"));

		// Act
		var result = context.GetAbsoluteUri();

		// Assert
		Assert.AreEqual(new Uri("http://localhost/"), result);
	}

	[TestMethod]
	public void GetAbsoluteUri_NoQueryString_ReturnsUriWithoutQuery()
	{
		// Arrange
		var headers = new HeaderDictionary();
		var context = new StubHttpContext(headers, scheme: "https", host: new HostString("example.com"), path: new PathString("/items"));

		// Act
		var result = context.GetAbsoluteUri();

		// Assert
		Assert.AreEqual(new Uri("https://example.com/items"), result);
	}

	[TestMethod]
	public void GetAbsoluteUri_NullContext_ThrowsArgumentNullException()
	{
		// Arrange
		HttpContext context = null!;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => context.GetAbsoluteUri());
	}

	[TestMethod]
	public void GetBearerToken_BasicScheme_ReturnsNull()
	{
		// Arrange
		var headers = new HeaderDictionary { ["Authorization"] = "Basic dXNlcjpwYXNz" };
		var context = new StubHttpContext(headers);

		// Act
		var result = context.GetBearerToken();

		// Assert
		Assert.IsNull(result);
	}

	[TestMethod]
	public void GetBearerToken_BearerWithWhitespace_ReturnsTrimmedToken()
	{
		// Arrange
		var headers = new HeaderDictionary { ["Authorization"] = "Bearer   spaced_token  " };
		var context = new StubHttpContext(headers);

		// Act
		var result = context.GetBearerToken();

		// Assert
		Assert.AreEqual("spaced_token", result);
	}

	[TestMethod]
	public void GetBearerToken_CaseInsensitiveBearer_ReturnsToken()
	{
		// Arrange
		var headers = new HeaderDictionary { ["Authorization"] = "BEARER mytoken" };
		var context = new StubHttpContext(headers);

		// Act
		var result = context.GetBearerToken();

		// Assert
		Assert.AreEqual("mytoken", result);
	}

	[TestMethod]
	public void GetBearerToken_NoAuthorizationHeader_ReturnsNull()
	{
		// Arrange
		var headers = new HeaderDictionary();
		var context = new StubHttpContext(headers);

		// Act
		var result = context.GetBearerToken();

		// Assert
		Assert.IsNull(result);
	}

	[TestMethod]
	public void GetBearerToken_NullContext_ThrowsArgumentNullException()
	{
		// Arrange
		HttpContext context = null!;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => context.GetBearerToken());
	}

	[TestMethod]
	public void GetBearerToken_ValidBearerHeader_ReturnsToken()
	{
		// Arrange
		var headers = new HeaderDictionary { ["Authorization"] = "Bearer abc123xyz" };
		var context = new StubHttpContext(headers);

		// Act
		var result = context.GetBearerToken();

		// Assert
		Assert.AreEqual("abc123xyz", result);
	}

	[TestMethod]
	public void GetRemoteIPAddress_NullContext_ThrowsArgumentNullException()
	{
		// Arrange
		HttpContext context = null!;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => context.GetRemoteIPAddress());
	}

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
	public void GetRequestHeaderValue_EmptyHeaderName_ThrowsArgumentException()
	{
		// Arrange
		var headers = new HeaderDictionary();
		var context = new StubHttpContext(headers);

		// Act & Assert
		Assert.ThrowsExactly<ArgumentException>(() => context.GetRequestHeaderValue(string.Empty));
	}

	[TestMethod]
	public void GetRequestHeaderValue_ExistingHeader_ReturnsValue()
	{
		// Arrange
		var headers = new HeaderDictionary { ["X-Request-ID"] = "req-12345" };
		var context = new StubHttpContext(headers);

		// Act
		var result = context.GetRequestHeaderValue("X-Request-ID");

		// Assert
		Assert.AreEqual("req-12345", result);
	}

	[TestMethod]
	public void GetRequestHeaderValue_MissingHeader_ReturnsNull()
	{
		// Arrange
		var headers = new HeaderDictionary();
		var context = new StubHttpContext(headers);

		// Act
		var result = context.GetRequestHeaderValue("X-Missing");

		// Assert
		Assert.IsNull(result);
	}

	[TestMethod]
	public void GetRequestHeaderValue_NullContext_ThrowsArgumentNullException()
	{
		// Arrange
		HttpContext context = null!;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => context.GetRequestHeaderValue("X-Custom"));
	}

	[TestMethod]
	public void GetRequestHeaderValue_NullHeaderName_ThrowsArgumentNullException()
	{
		// Arrange
		var headers = new HeaderDictionary();
		var context = new StubHttpContext(headers);

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => context.GetRequestHeaderValue(null!));
	}

	[TestMethod]
	public void GetRequestHeaderValue_UserAgentHeader_ReturnsValue()
	{
		// Arrange
		var headers = new HeaderDictionary { ["User-Agent"] = "TestAgent/1.0" };
		var context = new StubHttpContext(headers);

		// Act
		var result = context.GetRequestHeaderValue("User-Agent");

		// Assert
		Assert.AreEqual("TestAgent/1.0", result);
	}

	[TestMethod]
	public void GetRequestHeaderValue_WhitespaceHeaderName_ThrowsArgumentException()
	{
		// Arrange
		var headers = new HeaderDictionary();
		var context = new StubHttpContext(headers);

		// Act & Assert
		Assert.ThrowsExactly<ArgumentException>(() => context.GetRequestHeaderValue("   "));
	}

	[TestMethod]
	public void GetUserClaim_EmptyClaimType_ThrowsArgumentException()
	{
		// Arrange
		var headers = new HeaderDictionary();
		var context = new StubHttpContext(headers);

		// Act & Assert
		Assert.ThrowsExactly<ArgumentException>(() => context.GetUserClaim(string.Empty));
	}

	[TestMethod]
	public void GetUserClaim_ExistingClaim_ReturnsClaimValue()
	{
		// Arrange
		var headers = new HeaderDictionary();
		var context = new StubHttpContext(headers);
		var identity = new ClaimsIdentity([new Claim(ClaimTypes.NameIdentifier, "user-42")], "TestAuth");
		context.User = new ClaimsPrincipal(identity);

		// Act
		var result = context.GetUserClaim(ClaimTypes.NameIdentifier);

		// Assert
		Assert.AreEqual("user-42", result);
	}

	[TestMethod]
	public void GetUserClaim_MissingClaim_ReturnsNull()
	{
		// Arrange
		var headers = new HeaderDictionary();
		var context = new StubHttpContext(headers);
		var identity = new ClaimsIdentity([new Claim(ClaimTypes.Name, "alice")], "TestAuth");
		context.User = new ClaimsPrincipal(identity);

		// Act
		var result = context.GetUserClaim(ClaimTypes.Email);

		// Assert
		Assert.IsNull(result);
	}

	[TestMethod]
	public void GetUserClaim_NoClaims_ReturnsNull()
	{
		// Arrange
		var headers = new HeaderDictionary();
		var context = new StubHttpContext(headers);

		// Act
		var result = context.GetUserClaim(ClaimTypes.NameIdentifier);

		// Assert
		Assert.IsNull(result);
	}

	[TestMethod]
	public void GetUserClaim_NullClaimType_ThrowsArgumentNullException()
	{
		// Arrange
		var headers = new HeaderDictionary();
		var context = new StubHttpContext(headers);

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => context.GetUserClaim(null!));
	}

	[TestMethod]
	public void GetUserClaim_NullContext_ThrowsArgumentNullException()
	{
		// Arrange
		HttpContext context = null!;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => context.GetUserClaim(ClaimTypes.NameIdentifier));
	}

	[TestMethod]
	public void IsAuthenticated_AuthenticatedUser_ReturnsTrue()
	{
		// Arrange
		var headers = new HeaderDictionary();
		var context = new StubHttpContext(headers);
		var identity = new ClaimsIdentity([new Claim(ClaimTypes.Name, "alice")], "TestAuth");
		context.User = new ClaimsPrincipal(identity);

		// Act
		var result = context.IsAuthenticated();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsAuthenticated_NullContext_ThrowsArgumentNullException()
	{
		// Arrange
		HttpContext context = null!;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => context.IsAuthenticated());
	}

	[TestMethod]
	public void IsAuthenticated_NullIdentity_ReturnsFalse()
	{
		// Arrange
		var headers = new HeaderDictionary();
		var context = new StubHttpContext(headers);
		context.User = new ClaimsPrincipal();

		// Act
		var result = context.IsAuthenticated();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsAuthenticated_UnauthenticatedUser_ReturnsFalse()
	{
		// Arrange
		var headers = new HeaderDictionary();
		var context = new StubHttpContext(headers);

		// Act
		var result = context.IsAuthenticated();

		// Assert
		Assert.IsFalse(result);
	}

	private sealed class StubConnectionInfo(IPAddress remoteIpAddress) : ConnectionInfo
	{
		public override X509Certificate2? ClientCertificate { get; set; }
		public override string Id { get; set; } = string.Empty;
		public override IPAddress? LocalIpAddress { get; set; }
		public override int LocalPort { get; set; }
		public override IPAddress? RemoteIpAddress { get; set; } = remoteIpAddress;
		public override int RemotePort { get; set; }

		public override Task<X509Certificate2?> GetClientCertificateAsync(CancellationToken cancellationToken = default)
			=> Task.FromResult(this.ClientCertificate);
	}

	private sealed class StubHttpContext : HttpContext
	{
		private readonly StubConnectionInfo _connection;
		private readonly StubHttpRequest _request;

		public StubHttpContext(IPAddress remoteIpAddress)
		{
			this._connection = new StubConnectionInfo(remoteIpAddress);
			this._request = new StubHttpRequest(this);
		}

		public StubHttpContext(IHeaderDictionary headers, string scheme = "https", HostString host = default, PathString pathBase = default, PathString path = default, QueryString queryString = default)
		{
			this._connection = new StubConnectionInfo(IPAddress.Loopback);
			this._request = new StubHttpRequest(this, headers)
			{
				Scheme = scheme,
				Host = host,
				PathBase = pathBase,
				Path = path,
				QueryString = queryString,
			};
		}

		public override ConnectionInfo Connection => this._connection;
		public override IFeatureCollection Features => throw new NotImplementedException();
		public override IDictionary<object, object?> Items { get; set; } = new Dictionary<object, object?>();
		public override HttpRequest Request => this._request;
		public override CancellationToken RequestAborted { get; set; }
		public override IServiceProvider RequestServices { get; set; } = null!;
		public override HttpResponse Response => throw new NotImplementedException();
		public override ISession Session { get; set; } = null!;
		public override string TraceIdentifier { get; set; } = string.Empty;
		public override ClaimsPrincipal User { get; set; } = new();
		public override WebSocketManager WebSockets => throw new NotImplementedException();

		public override void Abort() => throw new NotImplementedException();
	}

	private sealed class StubHttpRequest : HttpRequest
	{
		private readonly HttpContext _httpContext;

		public StubHttpRequest(HttpContext httpContext, IHeaderDictionary? headers = null)
		{
			this._httpContext = httpContext;
			this.Headers = headers ?? new HeaderDictionary();
		}

		public override Stream Body { get; set; } = Stream.Null;
		public override long? ContentLength { get; set; }
		public override string? ContentType { get; set; }
		public override IRequestCookieCollection Cookies { get; set; } = null!;
		public override IFormCollection Form { get; set; } = null!;
		public override bool HasFormContentType => false;
		public override IHeaderDictionary Headers { get; }
		public override HostString Host { get; set; } = new("localhost");
		public override HttpContext HttpContext => this._httpContext;
		public override bool IsHttps { get; set; } = true;
		public override string Method { get; set; } = "GET";
		public override PathString Path { get; set; } = new("/");
		public override PathString PathBase { get; set; } = PathString.Empty;
		public override string Protocol { get; set; } = "HTTP/2";
		public override IQueryCollection Query { get; set; } = null!;
		public override QueryString QueryString { get; set; } = QueryString.Empty;
		public override string Scheme { get; set; } = "https";

		public override Task<IFormCollection> ReadFormAsync(CancellationToken cancellationToken = default) => throw new NotImplementedException();
	}

}
