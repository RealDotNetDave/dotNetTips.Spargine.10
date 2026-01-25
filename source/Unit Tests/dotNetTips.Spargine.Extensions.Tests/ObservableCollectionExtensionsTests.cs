// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 10-13-2024
// ***********************************************************************
// <copyright file="ObservableCollectionExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class ObservableCollectionExtensionsTests
{

	private readonly int _count = 2500;


	[TestMethod]
	public void ToObservableCollectionTest()
	{
		var people = RandomData.GeneratePersonRefCollection(this._count).ToList();

		//Test 
		Assert.IsTrue(people.ToObservableCollection().IsNotEmpty());
	}

	[TestMethod]
	public void ToReadOnlyObservableCollectionTest()
	{
		var people = RandomData.GeneratePersonRefCollection(this._count).ToList();

		//Test 
		Assert.IsTrue(people.ToReadOnlyObservableCollection().IsNotEmpty());
	}

}
