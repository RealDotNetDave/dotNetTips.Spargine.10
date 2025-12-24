// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 05-01-2025
//
// Last Modified By : David McCarter
// Last Modified On : 12-23-2025
// ***********************************************************************
// <copyright file="LineSplitEntryTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class LineSplitEntryTests
{
	[TestMethod]
	public void LineSplitEntry_Constructor_ShouldInitializeProperties()
	{
		// Arrange
		var line = "This is a line".AsSpan();
		var separator = "\n".AsSpan();

		// Act
		var entry = new LineSplitEntry(line, separator);

		// Assert
		Assert.AreEqual(line.ToString(), entry.Line.ToString());
		Assert.AreEqual(separator.ToString(), entry.Separator.ToString());
	}

	[TestMethod]
	public void LineSplitEntry_Deconstruct_ShouldReturnLineAndSeparator()
	{
		// Arrange
		var line = "This is a line".AsSpan();
		var separator = "\n".AsSpan();
		var entry = new LineSplitEntry(line, separator);

		// Act
		entry.Deconstruct(out var deconstructedLine, out var deconstructedSeparator);

		// Assert
		Assert.AreEqual(line.ToString(), deconstructedLine.ToString());
		Assert.AreEqual(separator.ToString(), deconstructedSeparator.ToString());
	}

	[TestMethod]
	public void LineSplitEntry_ImplicitConversion_EmptyLine_ShouldReturnEmpty()
	{
		// Arrange
		var line = ReadOnlySpan<char>.Empty;
		var separator = "\n".AsSpan();
		var entry = new LineSplitEntry(line, separator);

		// Act
		ReadOnlySpan<char> result = entry;

		// Assert
		Assert.AreEqual(line.ToString(), result.ToString());
	}

	[TestMethod]
	public void LineSplitEntry_ImplicitConversion_EmptyLineAndSeparator_ShouldReturnEmpty()
	{
		// Arrange
		var line = ReadOnlySpan<char>.Empty;
		var separator = ReadOnlySpan<char>.Empty;
		var entry = new LineSplitEntry(line, separator);

		// Act
		ReadOnlySpan<char> result = entry;

		// Assert
		Assert.AreEqual(line.ToString(), result.ToString());
	}

	[TestMethod]
	public void LineSplitEntry_ImplicitConversion_EmptySeparator_ShouldReturnLine()
	{
		// Arrange
		var line = "This is a line".AsSpan();
		var separator = ReadOnlySpan<char>.Empty;
		var entry = new LineSplitEntry(line, separator);

		// Act
		ReadOnlySpan<char> result = entry;

		// Assert
		Assert.AreEqual(line.ToString(), result.ToString());
	}

	[TestMethod]
	public void LineSplitEntry_ImplicitConversion_ShouldReturnLine()
	{
		// Arrange
		var line = "This is a line".AsSpan();
		var separator = "\n".AsSpan();
		var entry = new LineSplitEntry(line, separator);

		// Act
		ReadOnlySpan<char> result = entry;

		// Assert
		Assert.AreEqual(line.ToString(), result.ToString());
	}

	[TestMethod]
	public void LineSplitEntry_ToReadOnlySpan_ShouldReturnLine()
	{
		// Arrange
		var line = "This is a line".AsSpan();
		var separator = "\n".AsSpan();
		var entry = new LineSplitEntry(line, separator);

		// Act
		var result = LineSplitEntry.ToReadOnlySpan(entry);

		// Assert
		Assert.AreEqual(line.ToString(), result.ToString());
	}


}
