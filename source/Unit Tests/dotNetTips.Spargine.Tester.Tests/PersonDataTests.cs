// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tester.Tests
// Author           : David McCarter
// Created          : 01-28-2025
//
// Last Modified By : David McCarter
// Last Modified On : 09-01-2025
// ***********************************************************************
// <copyright file="PersonDataTests.cs" company="DotNetTips.Spargine.Tester.Tests">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Tester.Data.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Tester.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class PersonDataTests
{

	[TestMethod]
	public void PersonData_Constructor_NullCellPhone_ThrowsArgumentNullException()
	{
		// Arrange
		var bornOn = DateTimeOffset.Now;
		var country = new Country { Name = "USA" };
		var email = "test@example.com";
		var firstName = "John";
		var lastName = "Doe";
		var phone = "0987654321";

		// Act
		Assert.ThrowsExactly<ArgumentNullException>(() => new PersonData(bornOn, null, country, email, firstName, lastName, phone));
	}

	[TestMethod]
	public void PersonData_Constructor_NullCountry_ThrowsArgumentNullException()
	{
		// Arrange
		var bornOn = DateTimeOffset.Now;
		var cellPhone = "1234567890";
		var email = "test@example.com";
		var firstName = "John";
		var lastName = "Doe";
		var phone = "0987654321";

		// Act
		Assert.ThrowsExactly<ArgumentNullException>(() => new PersonData(bornOn, cellPhone, null, email, firstName, lastName, phone));
	}

	[TestMethod]
	public void PersonData_Constructor_NullEmail_ThrowsArgumentNullException()
	{
		// Arrange
		var bornOn = DateTimeOffset.Now;
		var cellPhone = "1234567890";
		var country = new Country { Name = "USA" };
		var firstName = "John";
		var lastName = "Doe";
		var phone = "0987654321";

		// Act
		Assert.ThrowsExactly<ArgumentNullException>(() => new PersonData(bornOn, cellPhone, country, null, firstName, lastName, phone));
	}

	[TestMethod]
	public void PersonData_Constructor_NullFirstName_ThrowsArgumentNullException()
	{
		// Arrange
		var bornOn = DateTimeOffset.Now;
		var cellPhone = "1234567890";
		var country = new Country { Name = "USA" };
		var email = "test@example.com";
		var lastName = "Doe";
		var phone = "0987654321";

		// Act
		Assert.ThrowsExactly<ArgumentNullException>(() => new PersonData(bornOn, cellPhone, country, email, null, lastName, phone));
	}

	[TestMethod]
	public void PersonData_Constructor_NullLastName_ThrowsArgumentNullException()
	{
		// Arrange
		var bornOn = DateTimeOffset.Now;
		var cellPhone = "1234567890";
		var country = new Country { Name = "USA" };
		var email = "test@example.com";
		var firstName = "John";
		var phone = "0987654321";

		// Act
		Assert.ThrowsExactly<ArgumentNullException>(() => new PersonData(bornOn, cellPhone, country, email, firstName, null, phone));
	}

	[TestMethod]
	public void PersonData_Constructor_NullPhone_ThrowsArgumentNullException()
	{
		// Arrange
		var bornOn = DateTimeOffset.Now;
		var cellPhone = "1234567890";
		var country = new Country { Name = "USA" };
		var email = "test@example.com";
		var firstName = "John";
		var lastName = "Doe";

		// Act
		Assert.ThrowsExactly<ArgumentNullException>(() => new PersonData(bornOn, cellPhone, country, email, firstName, lastName, null));
	}
	[TestMethod]
	public void PersonData_Constructor_ValidParameters_CreatesInstance()
	{
		// Arrange
		var bornOn = DateTimeOffset.Now;
		var cellPhone = "1234567890";
		var country = new Country { Name = "USA" };
		var email = "test@example.com";
		var firstName = "John";
		var lastName = "Doe";
		var phone = "0987654321";

		// Act
		var personData = new PersonData(bornOn, cellPhone, country, email, firstName, lastName, phone);

		// Assert
		Assert.IsNotNull(personData);
		Assert.AreEqual(bornOn, personData.BornOn);
		Assert.AreEqual(cellPhone, personData.CellPhone);
		Assert.AreEqual(country, personData.Country);
		Assert.AreEqual(email, personData.Email);
		Assert.AreEqual(firstName, personData.FirstName);
		Assert.AreEqual(lastName, personData.LastName);
		Assert.AreEqual(phone, personData.Phone);
	}
}
