// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tests
// Author           : David McCarter
// Created          : 06-24-2024
//
// Last Modified By : David McCarter
// Last Modified On : 11-14-2025
// ***********************************************************************
// <copyright file="SocketsHelperTests.cs" company="McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using DotNetTips.Spargine.Net.Sockets;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )
namespace DotNetTips.Spargine.Tests.Net.Sockets;

[ExcludeFromCodeCoverage]
[TestClass]
public class SocketsHelperTests
{

	[TestMethod]
	public async Task ConnectTcpAsync_NullContext_ThrowsArgumentNullException()
	{
		// Arrange
		SocketsHttpConnectionContext context = null;
		var cancellationToken = new CancellationToken(false);

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
		{
			await SocketsHelper.ConnectTcpAsync(context, cancellationToken);
		});
	}

}
