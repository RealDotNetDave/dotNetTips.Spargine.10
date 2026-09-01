// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 05-01-2025
//
// Last Modified By : David McCarter
// Last Modified On : 04-02-2026
// ***********************************************************************
// <copyright file="InformationAttributeDocGeneratorTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
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
		GetDocPath("DotNetTips.Spargine.Benchmark.10.dll", out var filePath, out var outputPath);

		if (filePath.IsNullOrEmpty())
		{
			return;
		}

		var assembly = Assembly.LoadFile(filePath);

		// Act
		var result = InformationAttributeDocGenerator.GenerateMarkdownDocumentForAssembly(assembly, outputPath);

		// Assert
		Assert.IsFalse(string.IsNullOrEmpty(result));
	}

	[TestMethod]
	public void GenerateMarkdownDocumentForAssembly_ValidAssembly_Core_ToFile()
	{

		GetDocPath("DotNetTips.Spargine.10.Core.dll", out var _, out var outputPath);

		var assembly = Assembly.GetAssembly(typeof(App));

		// Act
		var result = InformationAttributeDocGenerator.GenerateMarkdownDocumentForAssembly(assembly, outputPath);

		// Assert
		Assert.IsFalse(string.IsNullOrEmpty(result));
	}

	[TestMethod]
	public void GenerateMarkdownDocumentForAssembly_ValidAssembly_Extensions_ToFile()
	{
		GetDocPath("DotNetTips.Spargine.10.Extensions.dll", out var _, out var outputPath);

		var assembly = Assembly.GetAssembly(typeof(ListExtensions));


		// Act
		var result = InformationAttributeDocGenerator.GenerateMarkdownDocumentForAssembly(assembly, outputPath);

		// Assert
		Assert.IsFalse(string.IsNullOrEmpty(result));
	}

	[TestMethod]
	public void GenerateMarkdownDocumentForAssembly_ValidAssembly_Spargine_ToFile()
	{
		GetDocPath("DotNetTips.Spargine.10.dll", out var filePath, out var outputPath);

		var assembly = Assembly.LoadFile(filePath);

		// Act
		var result = InformationAttributeDocGenerator.GenerateMarkdownDocumentForAssembly(assembly, outputPath);

		// Assert
		Assert.IsFalse(string.IsNullOrEmpty(result));
	}


	[TestMethod]
	public void GenerateMarkdownDocumentForAssembly_ValidAssembly_Tester_ToFile()
	{
		GetDocPath("DotNetTips.Spargine.10.Tester.dll", out var _, out var outputPath);

		var assembly = Assembly.GetAssembly(typeof(RandomData));

		// Act
		var result = InformationAttributeDocGenerator.GenerateMarkdownDocumentForAssembly(assembly, outputPath);

		// Assert
		Assert.IsFalse(string.IsNullOrEmpty(result));
	}
	private static string GetBaseOutputPathFromAssembly()
	{
		// Get the directory where the current assembly is located
		var assemblyLocation = Assembly.GetExecutingAssembly().Location;
		var assemblyDirectory = Path.GetDirectoryName(assemblyLocation);

		// Navigate up to find the base output directory
		// For your case: AppBin\net10.0 -> AppBin
		var baseOutputPath = Directory.GetParent(assemblyDirectory)?.FullName;

		return baseOutputPath ?? assemblyDirectory;
	}

	private static void GetDocPath(string file, out string filePath, out string outputPath)
	{
		var path = GetBaseOutputPathFromAssembly();
		filePath = Directory.GetFiles(path, file, SearchOption.AllDirectories).FirstOrDefault();

		if (filePath.IsNullOrEmpty())
		{
			outputPath = string.Empty;
			return;
		}

		var baseOutputPath = new DirectoryInfo(filePath).Parent.Parent.Parent.ToString();

		outputPath = Path.Combine(baseOutputPath, "docs", "Library Information");
	}
}
