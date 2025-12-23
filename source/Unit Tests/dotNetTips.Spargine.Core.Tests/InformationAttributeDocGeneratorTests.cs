// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 11-16-2024
//
// Last Modified By : David McCarter
// Last Modified On : 01-18-2025
// ***********************************************************************
// <copyright file="InformationAttributeDocGeneratorTests.cs" company="DotNetTips.Spargine.Core.Tests">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Reflection;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class InformationAttributeDocGeneratorTests
{

	[TestMethod]
	public void GenerateMarkdownDocumentForAssembly_ValidAssembly_Benchmark_ToFile()
	{
		// Arrange
		var assembly = Assembly.LoadFile(Path.Combine(App.ProcessPath, "DotNetTips.Spargine.10.dll"));

		// Act
		var result = InformationAttributeDocGenerator.GenerateMarkdownDocumentForAssembly(assembly, @"C:\dotNetTips.com");

		// Assert
		Assert.IsFalse(string.IsNullOrEmpty(result));
	}

	[TestMethod]
	public void GenerateMarkdownDocumentForAssembly_ValidAssembly_Core_ToFile()
	{
		// Arrange
		var assembly = Assembly.GetAssembly(typeof(App));

		// Act
		var result = InformationAttributeDocGenerator.GenerateMarkdownDocumentForAssembly(assembly, @"C:\dotNetTips.com");

		// Assert
		Assert.IsFalse(string.IsNullOrEmpty(result));
	}

	[TestMethod]
	public void GenerateMarkdownDocumentForAssembly_ValidAssembly_Extensions_ToFile()
	{
		// Arrange
		var assembly = Assembly.GetAssembly(typeof(ListExtensions));

		// Act
		var result = InformationAttributeDocGenerator.GenerateMarkdownDocumentForAssembly(assembly, @"C:\dotNetTips.com");

		// Assert
		Assert.IsFalse(string.IsNullOrEmpty(result));
	}

	[TestMethod]
	public void GenerateMarkdownDocumentForAssembly_ValidAssembly_ReturnsDocumentation()
	{
		// Arrange
		var assembly = Assembly.GetAssembly(typeof(InformationAttribute));

		// Act
		var result = InformationAttributeDocGenerator.GenerateMarkdownDocumentForAssembly(assembly);

		// Assert
		Assert.IsFalse(string.IsNullOrEmpty(result));
	}

	[TestMethod]
	public void GenerateMarkdownDocumentForAssembly_ValidAssembly_Tester_ToFile()
	{
		// Arrange
		var assembly = Assembly.GetAssembly(typeof(RandomData));

		// Act
		var result = InformationAttributeDocGenerator.GenerateMarkdownDocumentForAssembly(assembly, @"C:\dotNetTips.com");

		// Assert
		Assert.IsFalse(string.IsNullOrEmpty(result));
	}

	[TestMethod]
	public void GenerateMarkdownDocumentForAssembly_ValidAssembly_ToFile()
	{
		// Arrange
		var assembly = Assembly.GetAssembly(typeof(TypeHelper));

		// Act
		var result = InformationAttributeDocGenerator.GenerateMarkdownDocumentForAssembly(assembly, @"C:\dotNetTips.com");

		// Assert
		Assert.IsFalse(string.IsNullOrEmpty(result));
	}
}
