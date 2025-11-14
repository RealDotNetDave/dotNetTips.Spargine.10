// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 01-10-2025
//
// Last Modified By : David McCarter
// Last Modified On : 09-01-2025
// ***********************************************************************
// <copyright file="CountryDataTests.cs" company="DotNetTips.Spargine.Core.Tests">
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

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

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
		Assert.IsTrue(countries.Count > 0);
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

		Assert.IsTrue(countries.Count == 250);
	}

	[TestMethod]
	public void GetCountriesTest()
	{
		var countries = CountryRepository.GetCountries();

		Assert.IsNotNull(countries);

		Assert.IsTrue(countries.Count == 250);
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
		Assert.ThrowsExactly<ArgumentNullException>(() => CountryRepository.GetCountry((string)null!));
		Assert.ThrowsExactly<ArgumentNullException>(() => CountryRepository.GetCountry(string.Empty));
	}


	[TestMethod]
	public void GetCountryByNameTest()
	{
		var country = CountryRepository.GetCountry(CountryName.UnitedStates);

		Assert.IsNotNull(country);
	}
}
