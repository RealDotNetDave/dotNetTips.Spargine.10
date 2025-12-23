// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 11-14-2025
// ***********************************************************************
// <copyright file="DirectoryInfoExtensionsTests.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using DotNetTips.Spargine.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class DirectoryInfoExtensionsTests
{

	[TestMethod]
	public void DirectoryInfoSizeTest01()
	{
		var directory = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));

		var result = directory.GetSize();

		Assert.IsTrue(result > 0);

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => DirectoryInfoExtensions.GetSize(null));
	}

	[TestMethod]
	public void DirectoryInfoSizeTest02()
	{
		var directory = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));

		var result = directory.GetSize(ControlChars.WildcardAllFiles);

		Assert.IsTrue(result > 0);

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => directory.GetSize(null) == 0);
	}

	[TestMethod]
	public void DirectoryInfoSizeTest03()
	{
		var directory = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));

		var result = directory.GetSize(searchPattern: ControlChars.WildcardAllFiles, searchOption: SearchOption.AllDirectories);

		Assert.IsTrue(result > 0);

		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => directory.GetSize("*.txt", (SearchOption)100) ==
			0);
	}

}
