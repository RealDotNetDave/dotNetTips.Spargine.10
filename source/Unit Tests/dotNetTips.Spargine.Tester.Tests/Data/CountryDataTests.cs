// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 01-10-2025
//
// Last Modified By : David McCarter
// Last Modified On : 04-01-2026
// ***********************************************************************
// <copyright file="CountryDataTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Core.Serialization;
using DotNetTips.Spargine.Tester.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Tester.Tests.Data;

[ExcludeFromCodeCoverage]
[TestClass]
public class CountryDataTests
{
	[TestMethod]
	public void GetCountries_ReturnsAllCountries()
	{
		var countries = CountryRepository.GetCountries();
		Assert.IsNotNull(countries);
		Assert.IsNotEmpty(countries);
	}

	[TestMethod]
	public void GetCountriesPhoneInfoTest()
	{
		var countries = CountryRepository.GetCountries();
		var data = countries.Select(p => new { p.Id, p.Iso2, p.Iso3, p.Name, p.PhoneCode, p.PhoneNumberLength, p.PostalFormat, p.PostalRegex });
		var result = data.ToList();

		var file = new FileInfo(Path.Combine(App.ProcessPath, "CountryPhonePostalInfo.json"));

		JsonSerializerOptions options = new JsonSerializerOptions { NumberHandling = JsonNumberHandling.Strict, PropertyNameCaseInsensitive = true, PropertyNamingPolicy = JsonNamingPolicy.CamelCase };

		JsonSerialization.SerializeToFile(data, file, options);

		Assert.AreEqual(250, countries.Count);
	}

	[TestMethod]
	public void GetCountriesTest()
	{
		var countries = CountryRepository.GetCountries();

		Assert.IsNotNull(countries);

		Assert.AreEqual(250, countries.Count);
	}

	[TestMethod]
	public void GetCountry_ByEnum_ReturnsCountry()
	{
		var country = CountryRepository.GetCountry(CountryName.UnitedStates);
		Assert.IsNotNull(country);
		Assert.AreEqual("United States", country.Name);
	}

	[TestMethod]
	public void GetCountry_ByIso2_ReturnsCountry()
	{
		var country = CountryRepository.GetCountry("US");
		Assert.IsNotNull(country);
		Assert.AreEqual("United States", country.Name);
	}

	[TestMethod]
	public void GetCountry_ByIso3_ReturnsCountry()
	{
		var country = CountryRepository.GetCountry("USA");
		Assert.IsNotNull(country);
		Assert.AreEqual("United States", country.Name);
	}

	[TestMethod]
	public void GetCountry_ByName_ReturnsCountry()
	{
		var country = CountryRepository.GetCountry("United States");
		Assert.IsNotNull(country);
		Assert.AreEqual("United States", country.Name);
	}

	[TestMethod]
	public void GetCountry_InvalidIso_ReturnsNull()
	{
		var country = CountryRepository.GetCountry("ZZ");
		Assert.IsNull(country);
	}

	[TestMethod]
	public void GetCountry_InvalidName_ReturnsNull()
	{
		var country = CountryRepository.GetCountry("NotACountry");
		Assert.IsNull(country);
	}

	[TestMethod]
	public void GetCountry_NullOrEmpty_ThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => CountryRepository.GetCountry(null! as string));
		Assert.ThrowsExactly<ArgumentNullException>(() => CountryRepository.GetCountry(string.Empty));
	}


	[TestMethod]
	public void GetCountryByNameTest()
	{
		var country = CountryRepository.GetCountry(CountryName.UnitedStates);

		Assert.IsNotNull(country);
	}
}
