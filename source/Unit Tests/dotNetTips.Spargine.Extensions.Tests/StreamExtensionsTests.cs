// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : david
// Created          : 10-09-2024
//
// Last Modified By : david
// Last Modified On : 11-14-2025
// ***********************************************************************
// <copyright file="StreamExtensionsTests.cs" company="DotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class StreamExtensionsTests
{
	[TestMethod]
	public void FlushClose_StreamIsNotNull_FlushesAndClosesStream()
	{
		// Arrange
		var stream = new MemoryStream();

		// Act
		stream.FlushClose();

		// Assert
		_ = Assert.ThrowsExactly<ObjectDisposedException>(() => stream.WriteByte(0));
	}

	[TestMethod]
	public void FlushClose_StreamIsNull_DoesNothing()
	{
		// Arrange
		Stream stream = null;

		// Act & Assert
		stream.FlushClose(); // Should not throw any exception
	}
}
