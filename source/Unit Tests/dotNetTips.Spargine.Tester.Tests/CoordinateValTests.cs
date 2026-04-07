// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tester.Tests
// Author           : David McCarter
// Created          : 01-28-2025
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-07-2026
// ***********************************************************************
// <copyright file="CoordinateValTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Models.ValueTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Tester.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class CoordinateValTests
{
	[TestMethod]
	public void Coordinate_CompareTo_DifferentValues_ReturnsNonZero()
	{
		// Arrange
		var coordinate1 = RandomData.GenerateCoordinate<Coordinate>();
		var coordinate2 = new Coordinate(coordinate1.X + 1, coordinate1.Y + 1, coordinate1.Z + 1);

		// Act
		var result = coordinate1.CompareTo(coordinate2);

		// Assert
		Assert.AreNotEqual(0, result);
	}

	[TestMethod]
	public void Coordinate_CompareTo_DifferentValues_ShouldReturnExpectedResults()
	{
		// Arrange
		var coord1 = new Coordinate(1, 2, 3);
		var coord2 = new Coordinate(1, 3, 3);
		var coord3 = new Coordinate(2, 2, 3);
		var coord4 = new Coordinate(1, 2, 4);

		// Act & Assert
		Assert.IsLessThan(0, coord1.CompareTo(coord2));
		Assert.IsLessThan(0, coord1.CompareTo(coord3));
		Assert.IsLessThan(0, coord1.CompareTo(coord4));
		Assert.IsGreaterThan(0, coord2.CompareTo(coord1));
		Assert.IsGreaterThan(0, coord3.CompareTo(coord1));
		Assert.IsGreaterThan(0, coord4.CompareTo(coord1));
	}

	[TestMethod]
	public void Coordinate_CompareTo_InvalidObjectType_ShouldThrowArgumentInvalidException()
	{
		// Arrange
		var coord = RandomData.GenerateCoordinate<Coordinate>();
		var invalidObject = new object();

		// Act & Assert
		Assert.ThrowsExactly<ArgumentInvalidException>(() => coord.CompareTo(invalidObject));
	}

	[TestMethod]
	public void Coordinate_CompareTo_NullObject_ShouldThrowArgumentInvalidException()
	{
		// Arrange
		var coord = RandomData.GenerateCoordinate<Coordinate>();

		// Act & Assert
		Assert.ThrowsExactly<ArgumentInvalidException>(() => coord.CompareTo(null));
	}

	[TestMethod]
	public void Coordinate_CompareTo_SameValues_ReturnsZero()
	{
		// Arrange
		var coordinate1 = RandomData.GenerateCoordinate<Coordinate>();
		var coordinate2 = new Coordinate(coordinate1.X, coordinate1.Y, coordinate1.Z);

		// Act
		var result = coordinate1.CompareTo(coordinate2);

		// Assert
		Assert.AreEqual(0, result);
	}

	[TestMethod]
	public void Coordinate_CompareTo_ShouldReturnExpectedResults()
	{
		// Arrange
		var coord1 = new Coordinate(1, 2, 3);
		var coord2 = new Coordinate(1, 2, 3);
		var coord3 = new Coordinate(4, 5, 6);

		// Act & Assert
		Assert.AreEqual(0, coord1.CompareTo(coord2));
		Assert.IsLessThan(0, coord1.CompareTo(coord3));
		Assert.IsGreaterThan(0, coord3.CompareTo(coord1));
	}

	[TestMethod]
	public void Coordinate_CompareTo_ValidCoordinate_ShouldReturnExpectedResults()
	{
		// Arrange
		var coord1 = new Coordinate(1, 2, 3);
		var coord2 = new Coordinate(1, 2, 3);
		var coord3 = new Coordinate(4, 5, 6);

		// Act & Assert
		Assert.AreEqual(0, coord1.CompareTo(coord2));
		Assert.IsLessThan(0, coord1.CompareTo(coord3));
		Assert.IsGreaterThan(0, coord3.CompareTo(coord1));
	}

	[TestMethod]
	public void Coordinate_CompareTo_ValidObjectCoordinate_ReturnsExpectedResult()
	{
		// Arrange
		var coord1 = new Coordinate(1, 2, 3);
		object coord2 = new Coordinate(1, 2, 3);
		object coord3 = new Coordinate(4, 5, 6);

		// Act & Assert
		Assert.AreEqual(0, coord1.CompareTo(coord2));
		Assert.IsLessThan(0, coord1.CompareTo(coord3));
	}

	[TestMethod]
	public void Coordinate_ComparisonOperators_ShouldReturnExpectedResults()
	{
		// Arrange
		var coord1 = new Coordinate(1, 2, 3);
		var coord2 = new Coordinate(1, 2, 3);
		var coord3 = new Coordinate(4, 5, 6);

		// Act & Assert
		Assert.IsTrue(coord1 <= coord2);
		Assert.IsTrue(coord1 >= coord2);
		Assert.IsTrue(coord1 < coord3);
		Assert.IsTrue(coord3 > coord1);
		Assert.IsFalse(coord3 < coord1);
		Assert.IsFalse(coord1 > coord3);
		Assert.IsFalse(coord3 <= coord1);
		Assert.IsFalse(coord1 >= coord3);
	}

	[TestMethod]
	public void Coordinate_Constructor_DefaultStruct_ShouldHaveZeroValues()
	{
		// Arrange & Act
		var coordinate = default(Coordinate);

		// Assert
		Assert.AreEqual(0, coordinate.X);
		Assert.AreEqual(0, coordinate.Y);
		Assert.AreEqual(0, coordinate.Z);
	}

	[TestMethod]
	public void Coordinate_Constructor_DefaultZ_ShouldBeZero()
	{
		// Arrange & Act
		var coordinate = new Coordinate(10, 20);

		// Assert
		Assert.AreEqual(10, coordinate.X);
		Assert.AreEqual(20, coordinate.Y);
		Assert.AreEqual(0, coordinate.Z);
	}

	[TestMethod]
	public void Coordinate_Constructor_ShouldInitializeProperties()
	{
		// Arrange
		var x = 1;
		var y = 2;
		var z = 3;

		// Act
		var coordinate = new Coordinate(x, y, z);

		// Assert
		Assert.AreEqual(x, coordinate.X);
		Assert.AreEqual(y, coordinate.Y);
		Assert.AreEqual(z, coordinate.Z);
	}

	[TestMethod]
	public void Coordinate_Constructor_ValidParameters_CreatesInstance()
	{
		// Arrange
		var x = 1;
		var y = 2;
		var z = 3;

		// Act
		var coordinate = new Coordinate(x, y, z);

		// Assert
		Assert.IsNotNull(coordinate);
		Assert.AreEqual(x, coordinate.X);
		Assert.AreEqual(y, coordinate.Y);
		Assert.AreEqual(z, coordinate.Z);
	}

	[TestMethod]
	public void Coordinate_EqualityOperators_ShouldReturnExpectedResults()
	{
		// Arrange
		var coord1 = new Coordinate(1, 2, 3);
		var coord2 = new Coordinate(1, 2, 3);
		var coord3 = new Coordinate(4, 5, 6);

		// Act & Assert
		Assert.IsTrue(coord1 == coord2);
		Assert.IsFalse(coord1 == coord3);
		Assert.IsFalse(coord1 != coord2);
		Assert.IsTrue(coord1 != coord3);
	}

	[TestMethod]
	public void Coordinate_Equals_DifferentValues_ReturnsFalse()
	{
		// Arrange
		var coordinate1 = RandomData.GenerateCoordinate<Coordinate>();
		var coordinate2 = new Coordinate(coordinate1.X + 1, coordinate1.Y + 1, coordinate1.Z + 1);

		// Act
		var result = coordinate1.Equals(coordinate2);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void Coordinate_Equals_NullObject_ReturnsFalse()
	{
		// Arrange
		var coordinate = RandomData.GenerateCoordinate<Coordinate>();

		// Act
		var result = coordinate.Equals(null);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void Coordinate_Equals_ObjectDifferentType_ReturnsFalse()
	{
		// Arrange
		var coordinate = RandomData.GenerateCoordinate<Coordinate>();
		var differentType = new object();

		// Act
		var result = coordinate.Equals(differentType);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void Coordinate_Equals_ObjectSameValues_ReturnsTrue()
	{
		// Arrange
		var coordinate1 = RandomData.GenerateCoordinate<Coordinate>();
		object coordinate2 = new Coordinate(coordinate1.X, coordinate1.Y, coordinate1.Z);

		// Act
		var result = coordinate1.Equals(coordinate2);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void Coordinate_Equals_SameValues_ReturnsTrue()
	{
		// Arrange
		var coordinate1 = RandomData.GenerateCoordinate<Coordinate>();
		var coordinate2 = new Coordinate(coordinate1.X, coordinate1.Y, coordinate1.Z);

		// Act
		var result = coordinate1.Equals(coordinate2);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void Coordinate_Equals_ShouldReturnExpectedResults()
	{
		// Arrange
		var coord1 = new Coordinate(1, 2, 3);
		var coord2 = new Coordinate(1, 2, 3);
		var coord3 = new Coordinate(4, 5, 6);

		// Act & Assert
		Assert.IsTrue(coord1.Equals(coord2));
		Assert.IsFalse(coord1.Equals(coord3));
		Assert.IsFalse(coord1.Equals(null));
	}

	[TestMethod]
	public void Coordinate_GetHashCode_DifferentValues_ReturnsDifferentHashCode()
	{
		// Arrange
		var coordinate1 = new Coordinate(1, 2, 3);
		var coordinate2 = new Coordinate(4, 5, 6);

		// Act
		var hashCode1 = coordinate1.GetHashCode();
		var hashCode2 = coordinate2.GetHashCode();

		// Assert
		Assert.AreNotEqual(hashCode1, hashCode2);
	}

	[TestMethod]
	public void Coordinate_GetHashCode_SameValues_ReturnsSameHashCode()
	{
		// Arrange
		var coordinate1 = RandomData.GenerateCoordinate<Coordinate>();
		var coordinate2 = new Coordinate(coordinate1.X, coordinate1.Y, coordinate1.Z);

		// Act
		var hashCode1 = coordinate1.GetHashCode();
		var hashCode2 = coordinate2.GetHashCode();

		// Assert
		Assert.AreEqual(hashCode1, hashCode2);
	}

	[TestMethod]
	public void Coordinate_GetHashCode_ShouldReturnExpectedResults()
	{
		// Arrange
		var coord1 = new Coordinate(1, 2, 3);
		var coord2 = new Coordinate(1, 2, 3);
		var coord3 = new Coordinate(4, 5, 6);

		// Act & Assert
		Assert.AreEqual(coord1.GetHashCode(), coord2.GetHashCode());
		Assert.AreNotEqual(coord1.GetHashCode(), coord3.GetHashCode());
	}

	[TestMethod]
	public void Coordinate_OperatorEquals_SameValues_ReturnsTrue()
	{
		// Arrange
		var coordinate1 = RandomData.GenerateCoordinate<Coordinate>();
		var coordinate2 = new Coordinate(coordinate1.X, coordinate1.Y, coordinate1.Z);

		// Act
		var result = coordinate1 == coordinate2;

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void Coordinate_OperatorNotEquals_DifferentValues_ReturnsTrue()
	{
		// Arrange
		var coordinate1 = RandomData.GenerateCoordinate<Coordinate>();
		var coordinate2 = new Coordinate(coordinate1.X + 1, coordinate1.Y + 1, coordinate1.Z + 1);

		// Act
		var result = coordinate1 != coordinate2;

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void Coordinate_OperatorNotEquals_SameValues_ReturnsFalse()
	{
		// Arrange
		var coordinate1 = RandomData.GenerateCoordinate<Coordinate>();
		var coordinate2 = new Coordinate(coordinate1.X, coordinate1.Y, coordinate1.Z);

		// Act
		var result = coordinate1 != coordinate2;

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void Coordinate_Properties_SetAndGet()
	{
		// Arrange
		var coordinate = new Coordinate(0, 0, 0);

		// Act
		coordinate.X = 42;
		coordinate.Y = 84;
		coordinate.Z = 126;

		// Assert
		Assert.AreEqual(42, coordinate.X);
		Assert.AreEqual(84, coordinate.Y);
		Assert.AreEqual(126, coordinate.Z);
	}

	[TestMethod]
	public void Coordinate_ToString_ReturnsCorrectString()
	{
		// Arrange
		var coordinate = new Coordinate(1, 2, 3);
		var expectedString = coordinate.PropertiesToString(includeMemberName: false);

		// Act
		var result = coordinate.ToString();

		// Assert
		Assert.AreEqual(expectedString, result);
	}

	[TestMethod]
	public void Coordinate_ToString_ReturnsNonEmptyString()
	{
		// Arrange
		var coordinate = RandomData.GenerateCoordinate<Coordinate>();

		// Act
		var result = coordinate.ToString();

		// Assert
		Assert.IsNotNull(result);
		Assert.AreNotEqual(string.Empty, result);
	}

	[TestMethod]
	public void Coordinate_ToString_ShouldReturnExpectedResults()
	{
		// Arrange
		var coord = new Coordinate(1, 2, 3);
		var expectedString = "X:1, Y:2, Z:3";

		// Act
		var result = coord.ToString();

		// Assert
		Assert.AreEqual(expectedString, result);
	}
}
