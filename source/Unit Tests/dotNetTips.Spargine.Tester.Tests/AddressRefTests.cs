// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tester.Tests
// Author           : David McCarter
// Created          : 01-29-2025
//
// Last Modified By : David McCarter
// Last Modified On : 06-30-2025
// ***********************************************************************
// <copyright file="AddressRefTests.cs" company="DotNetTips.Spargine.Tester.Tests">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Tester.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class AddressRefTests
{
	[TestMethod]
	public void Clone()
	{
		var address = RandomData.GenerateAddress<Address>();

		// Specify the type argument explicitly to resolve CS0411  
		var clonedAddresses = address.FastClone<Address>();

		Assert.IsNotNull(clonedAddresses);
	}
	[TestMethod]
	public void CompareTo_DifferentId_ReturnsNonZero()
	{
		// Arrange
		var address1 = RandomData.GenerateAddress<Address>();
		var address2 = RandomData.GenerateAddress<Address>();

		// Act
		var result = address1.CompareTo(address2);

		// Assert
		Assert.AreNotEqual(0, result, "Expected CompareTo to return a non-zero value for addresses with different Ids.");
	}

	[TestMethod]
	public void CompareTo_NullAddress_ReturnsPositive()
	{
		// Arrange
		var address = RandomData.GenerateAddress<Address>();
		// Act

		var result = address.CompareTo(null);

		// Assert
		Assert.IsTrue(result > 0, "Expected CompareTo to return a positive value when comparing with null.");
	}
}
