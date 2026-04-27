// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tester.Tests
// Author           : Copilot Agent
// Created          : 04-27-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-27-2026
// ***********************************************************************
// <copyright file="CountryTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Unit tests for the Country data model class, covering property defaults,
// property assignment, lazy-initialized collection properties, and JSON
// serialization round-trips.
// </summary>
// ***********************************************************************

using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using DotNetTips.Spargine.Tester.Data;
using DotNetTips.Spargine.Tester.Data.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Tester.Tests.Data.Models;

[ExcludeFromCodeCoverage]
[TestClass]
public class CountryTests
{
	[TestMethod]
	public void Capital_DefaultValue_IsUnknown()
	{
		var country = new Country();

		Assert.AreEqual("UNKNOWN", country.Capital);
	}

	[TestMethod]
	public void Capital_SetValue_ReturnsAssignedValue()
	{
		var country = new Country { Capital = "Washington" };

		Assert.AreEqual("Washington", country.Capital);
	}

	[TestMethod]
	public void Country_FromRepository_HasExpectedUsProperties()
	{
		var country = CountryRepository.GetCountry(CountryName.UnitedStates);

		Assert.IsNotNull(country);
		Assert.AreEqual("United States", country.Name);
		Assert.AreEqual("US", country.Iso2);
		Assert.AreEqual("USA", country.Iso3);
		Assert.AreEqual("Washington", country.Capital);
		Assert.AreEqual("USD", country.Currency);
		Assert.AreEqual(Region.Americas, country.Region);
		Assert.IsNotNull(country.States);
		Assert.IsTrue(country.States.Count > 0);
		Assert.IsNotNull(country.Timezones);
		Assert.IsTrue(country.Timezones.Count > 0);
	}

	[TestMethod]
	public void Country_JsonRoundTrip_PreservesAllProperties()
	{
		var original = new Country
		{
			Id = 233,
			Name = "United States",
			Iso2 = "US",
			Iso3 = "USA",
			Capital = "Washington",
			Currency = "USD",
			CurrencyName = "United States Dollar",
			CurrencySymbol = "$",
			PhoneCode = "+1",
			PhoneNumberLength = 10,
			Tld = ".us",
			Region = Region.Americas,
			Subregion = "Northern America",
			NumericCode = "840",
			Latitude = "38.00",
			Longitude = "-97.00",
		};

		var json = JsonSerializer.Serialize(original);
		var deserialized = JsonSerializer.Deserialize<Country>(json);

		Assert.IsNotNull(deserialized);
		Assert.AreEqual(original.Id, deserialized.Id);
		Assert.AreEqual(original.Name, deserialized.Name);
		Assert.AreEqual(original.Iso2, deserialized.Iso2);
		Assert.AreEqual(original.Iso3, deserialized.Iso3);
		Assert.AreEqual(original.Capital, deserialized.Capital);
		Assert.AreEqual(original.Currency, deserialized.Currency);
		Assert.AreEqual(original.CurrencyName, deserialized.CurrencyName);
		Assert.AreEqual(original.CurrencySymbol, deserialized.CurrencySymbol);
		Assert.AreEqual(original.PhoneCode, deserialized.PhoneCode);
		Assert.AreEqual(original.PhoneNumberLength, deserialized.PhoneNumberLength);
		Assert.AreEqual(original.Tld, deserialized.Tld);
		Assert.AreEqual(original.Region, deserialized.Region);
		Assert.AreEqual(original.Subregion, deserialized.Subregion);
		Assert.AreEqual(original.NumericCode, deserialized.NumericCode);
		Assert.AreEqual(original.Latitude, deserialized.Latitude);
		Assert.AreEqual(original.Longitude, deserialized.Longitude);
	}

	[TestMethod]
	public void Currency_SetValue_ReturnsAssignedValue()
	{
		var country = new Country { Currency = "USD" };

		Assert.AreEqual("USD", country.Currency);
	}

	[TestMethod]
	public void CurrencyName_SetValue_ReturnsAssignedValue()
	{
		var country = new Country { CurrencyName = "United States Dollar" };

		Assert.AreEqual("United States Dollar", country.CurrencyName);
	}

	[TestMethod]
	public void CurrencySymbol_SetValue_ReturnsAssignedValue()
	{
		var country = new Country { CurrencySymbol = "$" };

		Assert.AreEqual("$", country.CurrencySymbol);
	}

	[TestMethod]
	public void Emoji_SetValue_ReturnsAssignedValue()
	{
		var country = new Country { Emoji = "🇺🇸" };

		Assert.AreEqual("🇺🇸", country.Emoji);
	}

	[TestMethod]
	public void EmojiU_SetValue_ReturnsAssignedValue()
	{
		var country = new Country { EmojiU = "U+1F1FA U+1F1F8" };

		Assert.AreEqual("U+1F1FA U+1F1F8", country.EmojiU);
	}

	[TestMethod]
	public void Id_DefaultValue_IsZero()
	{
		var country = new Country();

		Assert.AreEqual(0L, country.Id);
	}

	[TestMethod]
	public void Id_SetValue_ReturnsAssignedValue()
	{
		var country = new Country { Id = 233 };

		Assert.AreEqual(233L, country.Id);
	}

	[TestMethod]
	public void Iso2_SetValue_ReturnsAssignedValue()
	{
		var country = new Country { Iso2 = "US" };

		Assert.AreEqual("US", country.Iso2);
	}

	[TestMethod]
	public void Iso3_SetValue_ReturnsAssignedValue()
	{
		var country = new Country { Iso3 = "USA" };

		Assert.AreEqual("USA", country.Iso3);
	}

	[TestMethod]
	public void Latitude_SetValue_ReturnsAssignedValue()
	{
		var country = new Country { Latitude = "38.00" };

		Assert.AreEqual("38.00", country.Latitude);
	}

	[TestMethod]
	public void Longitude_SetValue_ReturnsAssignedValue()
	{
		var country = new Country { Longitude = "-97.00" };

		Assert.AreEqual("-97.00", country.Longitude);
	}

	[TestMethod]
	public void Name_SetValue_ReturnsAssignedValue()
	{
		var country = new Country { Name = "United States" };

		Assert.AreEqual("United States", country.Name);
	}

	[TestMethod]
	public void Native_SetValue_ReturnsAssignedValue()
	{
		var country = new Country { Native = "United States" };

		Assert.AreEqual("United States", country.Native);
	}

	[TestMethod]
	public void NumericCode_SetValue_ReturnsAssignedValue()
	{
		var country = new Country { NumericCode = "840" };

		Assert.AreEqual("840", country.NumericCode);
	}

	[TestMethod]
	public void PhoneCode_SetValue_ReturnsAssignedValue()
	{
		var country = new Country { PhoneCode = "+1" };

		Assert.AreEqual("+1", country.PhoneCode);
	}

	[TestMethod]
	public void PhoneNumberLength_DefaultValue_IsTen()
	{
		var country = new Country();

		Assert.AreEqual(10, country.PhoneNumberLength);
	}

	[TestMethod]
	public void PhoneNumberLength_SetValue_ReturnsAssignedValue()
	{
		var country = new Country { PhoneNumberLength = 11 };

		Assert.AreEqual(11, country.PhoneNumberLength);
	}

	[TestMethod]
	public void PostalFormat_SetValue_ReturnsAssignedValue()
	{
		var country = new Country { PostalFormat = "#####" };

		Assert.AreEqual("#####", country.PostalFormat);
	}

	[TestMethod]
	public void PostalRegex_SetValue_ReturnsAssignedValue()
	{
		var country = new Country { PostalRegex = @"\d{5}" };

		Assert.AreEqual(@"\d{5}", country.PostalRegex);
	}

	[TestMethod]
	public void Region_SetValue_ReturnsAssignedValue()
	{
		var country = new Country { Region = Region.Americas };

		Assert.AreEqual(Region.Americas, country.Region);
	}

	[TestMethod]
	public void States_AddItem_ReflectedInProperty()
	{
		var country = new Country();
		country.States.Add(new State { Name = "California" });

		Assert.AreEqual(1, country.States.Count);
	}

	[TestMethod]
	public void States_DefaultValue_ReturnsEmptyCollection()
	{
		var country = new Country();

		Assert.IsNotNull(country.States);
		Assert.AreEqual(0, country.States.Count);
	}

	[TestMethod]
	public void States_SetValue_ReturnsAssignedCollection()
	{
		var states = new Collection<State> { new State { Name = "Virginia" } };
		var country = new Country { States = states };

		Assert.AreSame(states, country.States);
		Assert.AreEqual(1, country.States.Count);
	}

	[TestMethod]
	public void Subregion_SetValue_ReturnsAssignedValue()
	{
		var country = new Country { Subregion = "Northern America" };

		Assert.AreEqual("Northern America", country.Subregion);
	}

	[TestMethod]
	public void Timezones_AddItem_ReflectedInProperty()
	{
		var country = new Country();
		country.Timezones.Add(new Timezone { Abbreviation = "PST" });

		Assert.AreEqual(1, country.Timezones.Count);
	}

	[TestMethod]
	public void Timezones_DefaultValue_ReturnsEmptyCollection()
	{
		var country = new Country();

		Assert.IsNotNull(country.Timezones);
		Assert.AreEqual(0, country.Timezones.Count);
	}

	[TestMethod]
	public void Timezones_SetValue_ReturnsAssignedCollection()
	{
		var timezones = new Collection<Timezone> { new Timezone { Abbreviation = "EST" } };
		var country = new Country { Timezones = timezones };

		Assert.AreSame(timezones, country.Timezones);
		Assert.AreEqual(1, country.Timezones.Count);
	}

	[TestMethod]
	public void Tld_SetValue_ReturnsAssignedValue()
	{
		var country = new Country { Tld = ".us" };

		Assert.AreEqual(".us", country.Tld);
	}

	[TestMethod]
	public void Translations_SetValue_ReturnsAssignedValue()
	{
		var translations = new Translations { De = "Vereinigte Staaten" };
		var country = new Country { Translations = translations };

		Assert.IsNotNull(country.Translations);
		Assert.AreEqual("Vereinigte Staaten", country.Translations.De);
	}
}
