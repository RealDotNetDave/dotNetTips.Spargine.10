// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 01-10-2025
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-17-2026
// ***********************************************************************
// <copyright file="CountryConverter.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Provides a custom System.Text.Json converter for serializing and
// deserializing Country objects from the country data JSON format.
// </summary>
// ***********************************************************************

using System.Text.Json;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Tester.Data.Converters;

/// <summary>
/// Provides a centralized JsonSerializerOptions instance with converters tailored for country-related data.
/// </summary>
internal static class CountryConverter
{

	/// <summary>
	/// Gets the JsonSerializerOptions with converters for region, date, time, and ISO date-time offset handling.
	/// </summary>
	public static readonly JsonSerializerOptions Settings = new(JsonSerializerDefaults.General)
	{
		Converters =
		{
			RegionConverter.Singleton,
			new DateOnlyConverter(),
			new TimeOnlyConverter(),
			IsoDateTimeOffsetConverter.Singleton,
		},
	};

}
