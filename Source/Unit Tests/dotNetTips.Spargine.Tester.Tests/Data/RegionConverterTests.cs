// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tester.Tests
// Author           : Copilot Agent
// Created          : 04-27-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-27-2026
// ***********************************************************************
// <copyright file="RegionConverterTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Unit tests for the RegionConverter class.
// </summary>
// ***********************************************************************

using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using DotNetTips.Spargine.Tester.Data;
using DotNetTips.Spargine.Tester.Data.Converters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Tester.Tests.Data;

[ExcludeFromCodeCoverage]
[TestClass]
public class RegionConverterTests
{

	private static JsonSerializerOptions CreateOptions()
	{
		var options = new JsonSerializerOptions();
		options.Converters.Add(RegionConverter.Singleton);
		return options;
	}

	[TestMethod]
	public void Singleton_ReturnsSameInstance()
	{
		// Act
		var first = RegionConverter.Singleton;
		var second = RegionConverter.Singleton;

		// Assert
		Assert.AreSame(first, second);
	}

	[TestMethod]
	public void CanConvert_RegionType_ReturnsTrue()
	{
		// Act
		var result = RegionConverter.Singleton.CanConvert(typeof(Region));

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void CanConvert_StringType_ReturnsFalse()
	{
		// Act
		var result = RegionConverter.Singleton.CanConvert(typeof(string));

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void CanConvert_IntType_ReturnsFalse()
	{
		// Act
		var result = RegionConverter.Singleton.CanConvert(typeof(int));

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void Read_Africa_ReturnsRegionAfrica()
	{
		// Arrange
		var options = CreateOptions();

		// Act
		var result = JsonSerializer.Deserialize<Region>("\"Africa\"", options);

		// Assert
		Assert.AreEqual(Region.Africa, result);
	}

	[TestMethod]
	public void Read_Americas_ReturnsRegionAmericas()
	{
		// Arrange
		var options = CreateOptions();

		// Act
		var result = JsonSerializer.Deserialize<Region>("\"Americas\"", options);

		// Assert
		Assert.AreEqual(Region.Americas, result);
	}

	[TestMethod]
	public void Read_Asia_ReturnsRegionAsia()
	{
		// Arrange
		var options = CreateOptions();

		// Act
		var result = JsonSerializer.Deserialize<Region>("\"Asia\"", options);

		// Assert
		Assert.AreEqual(Region.Asia, result);
	}

	[TestMethod]
	public void Read_Europe_ReturnsRegionEurope()
	{
		// Arrange
		var options = CreateOptions();

		// Act
		var result = JsonSerializer.Deserialize<Region>("\"Europe\"", options);

		// Assert
		Assert.AreEqual(Region.Europe, result);
	}

	[TestMethod]
	public void Read_Oceania_ReturnsRegionOceania()
	{
		// Arrange
		var options = CreateOptions();

		// Act
		var result = JsonSerializer.Deserialize<Region>("\"Oceania\"", options);

		// Assert
		Assert.AreEqual(Region.Oceania, result);
	}

	[TestMethod]
	public void Read_Polar_ReturnsRegionPolar()
	{
		// Arrange
		var options = CreateOptions();

		// Act
		var result = JsonSerializer.Deserialize<Region>("\"Polar\"", options);

		// Assert
		Assert.AreEqual(Region.Polar, result);
	}

	[TestMethod]
	public void Read_UnknownString_ReturnsRegionEmpty()
	{
		// Arrange
		var options = CreateOptions();

		// Act
		var result = JsonSerializer.Deserialize<Region>("\"UnknownRegion\"", options);

		// Assert
		Assert.AreEqual(Region.Empty, result);
	}

	[TestMethod]
	public void Read_EmptyString_ReturnsRegionEmpty()
	{
		// Arrange
		var options = CreateOptions();

		// Act
		var result = JsonSerializer.Deserialize<Region>("\"\"", options);

		// Assert
		Assert.AreEqual(Region.Empty, result);
	}

	[TestMethod]
	public void RoundTrip_Africa_PreservesValue()
	{
		// Arrange
		var options = CreateOptions();
		var original = Region.Africa;

		// Act
		var json = JsonSerializer.Serialize(original, options);
		var result = JsonSerializer.Deserialize<Region>(json, options);

		// Assert
		Assert.AreEqual(original, result);
	}

	[TestMethod]
	public void RoundTrip_Americas_PreservesValue()
	{
		// Arrange
		var options = CreateOptions();
		var original = Region.Americas;

		// Act
		var json = JsonSerializer.Serialize(original, options);
		var result = JsonSerializer.Deserialize<Region>(json, options);

		// Assert
		Assert.AreEqual(original, result);
	}

	[TestMethod]
	public void RoundTrip_Asia_PreservesValue()
	{
		// Arrange
		var options = CreateOptions();
		var original = Region.Asia;

		// Act
		var json = JsonSerializer.Serialize(original, options);
		var result = JsonSerializer.Deserialize<Region>(json, options);

		// Assert
		Assert.AreEqual(original, result);
	}

	[TestMethod]
	public void RoundTrip_Europe_PreservesValue()
	{
		// Arrange
		var options = CreateOptions();
		var original = Region.Europe;

		// Act
		var json = JsonSerializer.Serialize(original, options);
		var result = JsonSerializer.Deserialize<Region>(json, options);

		// Assert
		Assert.AreEqual(original, result);
	}

	[TestMethod]
	public void RoundTrip_Oceania_PreservesValue()
	{
		// Arrange
		var options = CreateOptions();
		var original = Region.Oceania;

		// Act
		var json = JsonSerializer.Serialize(original, options);
		var result = JsonSerializer.Deserialize<Region>(json, options);

		// Assert
		Assert.AreEqual(original, result);
	}

	[TestMethod]
	public void RoundTrip_Polar_PreservesValue()
	{
		// Arrange
		var options = CreateOptions();
		var original = Region.Polar;

		// Act
		var json = JsonSerializer.Serialize(original, options);
		var result = JsonSerializer.Deserialize<Region>(json, options);

		// Assert
		Assert.AreEqual(original, result);
	}

	[TestMethod]
	public void RoundTrip_Empty_ProducesEmptyJsonString()
	{
		// Arrange
		var options = CreateOptions();

		// Act
		var json = JsonSerializer.Serialize(Region.Empty, options);

		// Assert
		Assert.AreEqual("\"\"", json);
	}

}
