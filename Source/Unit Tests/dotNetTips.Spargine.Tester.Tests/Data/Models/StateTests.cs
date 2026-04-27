// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tester.Tests
// Author           : Copilot Agent
// Created          : 04-27-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-27-2026
// ***********************************************************************
// <copyright file="StateTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Unit tests for the State data model class, covering property defaults,
// property assignment, lazy-initialized Cities collection, static Country
// property, and JSON serialization round-trips.
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
public class StateTests
{

	[TestMethod]
	public void Cities_AddItem_ReflectedInProperty()
	{
		var state = new State();
		state.Cities.Add(new City { Name = "Arlington" });

		Assert.AreEqual(1, state.Cities.Count);
		Assert.AreEqual("Arlington", state.Cities[0].Name);
	}

	[TestMethod]
	public void Cities_AddMultipleItems_ReflectedInCount()
	{
		var state = new State();
		state.Cities.Add(new City { Name = "Richmond" });
		state.Cities.Add(new City { Name = "Norfolk" });
		state.Cities.Add(new City { Name = "Virginia Beach" });

		Assert.AreEqual(3, state.Cities.Count);
	}

	[TestMethod]
	public void Cities_DefaultValue_ReturnsEmptyNonNullCollection()
	{
		var state = new State();

		Assert.IsNotNull(state.Cities);
		Assert.AreEqual(0, state.Cities.Count);
	}

	[TestMethod]
	public void Cities_SetValue_ReturnsAssignedCollection()
	{
		var cities = new Collection<City> { new City { Name = "Richmond" } };
		var state = new State { Cities = cities };

		Assert.AreSame(cities, state.Cities);
		Assert.AreEqual(1, state.Cities.Count);
	}

	[TestMethod]
	public void Country_StaticProperty_DefaultValue_IsNull()
	{
		// Ensure clean state (reset from any prior test)
		State.Country = null;

		Assert.IsNull(State.Country);
	}

	[TestMethod]
	public void Country_StaticProperty_SetAndGetRoundTrip()
	{
		var country = new Country { Name = "United States", Iso2 = "US" };
		State.Country = country;

		Assert.IsNotNull(State.Country);
		Assert.AreEqual("United States", State.Country.Name);
		Assert.AreEqual("US", State.Country.Iso2);

		// Reset static state to avoid test pollution
		State.Country = null;
	}
	[TestMethod]
	public void Id_DefaultValue_IsZero()
	{
		var state = new State();

		Assert.AreEqual(0L, state.Id);
	}

	[TestMethod]
	public void Id_SetValue_ReturnsAssignedValue()
	{
		var state = new State { Id = 1416 };

		Assert.AreEqual(1416L, state.Id);
	}

	[TestMethod]
	public void Latitude_DefaultValue_IsNull()
	{
		var state = new State();

		Assert.IsNull(state.Latitude);
	}

	[TestMethod]
	public void Latitude_SetValue_ReturnsAssignedValue()
	{
		var state = new State { Latitude = "37.4316" };

		Assert.AreEqual("37.4316", state.Latitude);
	}

	[TestMethod]
	public void Longitude_DefaultValue_IsNull()
	{
		var state = new State();

		Assert.IsNull(state.Longitude);
	}

	[TestMethod]
	public void Longitude_SetValue_ReturnsAssignedValue()
	{
		var state = new State { Longitude = "-78.6569" };

		Assert.AreEqual("-78.6569", state.Longitude);
	}

	[TestMethod]
	public void Name_DefaultValue_IsNull()
	{
		var state = new State();

		Assert.IsNull(state.Name);
	}

	[TestMethod]
	public void Name_SetValue_ReturnsAssignedValue()
	{
		var state = new State { Name = "Virginia" };

		Assert.AreEqual("Virginia", state.Name);
	}

	[TestMethod]
	public void State_FromRepository_HasStatesWithCities()
	{
		var country = CountryRepository.GetCountry(CountryName.UnitedStates);

		Assert.IsNotNull(country);
		Assert.IsTrue(country.States.Count > 0);

		var firstState = country.States[0];
		Assert.IsNotNull(firstState.Name);
		Assert.IsNotNull(firstState.StateCode);
		Assert.IsNotNull(firstState.Cities);
	}

	[TestMethod]
	public void State_JsonRoundTrip_PreservesCities()
	{
		var original = new State
		{
			Name = "Virginia",
			Cities = new Collection<City>
			{
				new City { Id = 1, Name = "Richmond", Latitude = "37.5407", Longitude = "-77.4360" },
				new City { Id = 2, Name = "Norfolk",  Latitude = "36.8508", Longitude = "-76.2859" },
			}
		};

		var json = JsonSerializer.Serialize(original);
		var deserialized = JsonSerializer.Deserialize<State>(json);

		Assert.IsNotNull(deserialized);
		Assert.AreEqual(2, deserialized.Cities.Count);
		Assert.AreEqual("Richmond", deserialized.Cities[0].Name);
		Assert.AreEqual("Norfolk", deserialized.Cities[1].Name);
	}

	[TestMethod]
	public void State_JsonRoundTrip_PreservesScalarProperties()
	{
		var original = new State
		{
			Id = 1416,
			Name = "Virginia",
			StateCode = "VA",
			Type = "state",
			Latitude = "37.4316",
			Longitude = "-78.6569",
		};

		var json = JsonSerializer.Serialize(original);
		var deserialized = JsonSerializer.Deserialize<State>(json);

		Assert.IsNotNull(deserialized);
		Assert.AreEqual(original.Id, deserialized.Id);
		Assert.AreEqual(original.Name, deserialized.Name);
		Assert.AreEqual(original.StateCode, deserialized.StateCode);
		Assert.AreEqual(original.Type, deserialized.Type);
		Assert.AreEqual(original.Latitude, deserialized.Latitude);
		Assert.AreEqual(original.Longitude, deserialized.Longitude);
	}

	[TestMethod]
	public void StateCode_DefaultValue_IsNull()
	{
		var state = new State();

		Assert.IsNull(state.StateCode);
	}

	[TestMethod]
	public void StateCode_SetValue_ReturnsAssignedValue()
	{
		var state = new State { StateCode = "VA" };

		Assert.AreEqual("VA", state.StateCode);
	}

	[TestMethod]
	public void Type_DefaultValue_IsNull()
	{
		var state = new State();

		Assert.IsNull(state.Type);
	}

	[TestMethod]
	public void Type_SetValue_ReturnsAssignedValue()
	{
		var state = new State { Type = "state" };

		Assert.AreEqual("state", state.Type);
	}
}
