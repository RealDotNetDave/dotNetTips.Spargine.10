// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 05-01-2025
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-06-2026
// ***********************************************************************
// <copyright file="StreamExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using DotNetTips.Spargine.Tester;
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

	[TestMethod]
	public void FlushClose_StreamWithData_FlushesAndClosesStream()
	{
		// Arrange
		var data = RandomData.GenerateByteArray(256);
		var stream = new MemoryStream();
		stream.Write(data);

		// Act
		stream.FlushClose();

		// Assert
		_ = Assert.ThrowsExactly<ObjectDisposedException>(() => stream.WriteByte(0));
	}
}
