// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tester.Tests
// Author           : David McCarter
// Created          : 01-28-2025
//
// Last Modified By : David McCarter
// Last Modified On : 08-13-2025
// ***********************************************************************
// <copyright file="PersonNameTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Tester.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class PersonNameTests
{
	[TestMethod]
	public void PersonName_Constructor_Default_CreatesInstance()
	{
		// Act
		var personName = new PersonName();

		// Assert
		Assert.IsNotNull(personName);
		Assert.AreEqual(string.Empty, personName.FirstName);
		Assert.AreEqual(string.Empty, personName.LastName);
	}

	[TestMethod]
	public void PersonName_Constructor_NullFirstName_ThrowsArgumentNullException()
	{
		// Arrange
		var lastName = "Doe";

		// Act
		Assert.ThrowsExactly<ArgumentNullException>(() => new PersonName(null, lastName));
	}

	[TestMethod]
	public void PersonName_Constructor_NullLastName_ThrowsArgumentNullException()
	{
		// Arrange
		var firstName = "John";

		// Act
		Assert.ThrowsExactly<ArgumentNullException>(() => new PersonName(firstName, null));
	}

	[TestMethod]
	public void PersonName_Constructor_ValidParameters_CreatesInstance()
	{
		// Arrange
		var firstName = "John";
		var lastName = "Doe";

		// Act
		var personName = new PersonName(firstName, lastName);

		// Assert
		Assert.IsNotNull(personName);
		Assert.AreEqual(firstName, personName.FirstName);
		Assert.AreEqual(lastName, personName.LastName);
	}
}
