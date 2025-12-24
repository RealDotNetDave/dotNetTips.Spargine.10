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
using System.Collections.ObjectModel;
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
	public void DoesNotHaveItems_EmptyCollection_ReturnsTrue()
	{
		var emptyCollection = new ObservableCollection<int>();
		var result = emptyCollection.IsEmpty();
		Assert.IsTrue(result, "Expected result to be true for an empty collection.");
	}

	[TestMethod]
	public void DoesNotHaveItems_NonEmptyCollection_ReturnsFalse()
	{
		var nonEmptyCollection = new ObservableCollection<int> { 1, 2, 3 };
		var result = nonEmptyCollection.IsEmpty();
		Assert.IsFalse(result, "Expected result to be false for a non-empty collection.");
	}

	[TestMethod]
	public void DoesNotHaveItems_NullCollection_ReturnsFalse()
	{
		ObservableCollection<int> nullCollection = null;
		var result = nullCollection.IsEmpty();
		Assert.IsTrue(result);
	}

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
