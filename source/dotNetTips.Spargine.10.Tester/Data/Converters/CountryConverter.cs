// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 01-10-2025
//
// Last Modified By : David McCarter
// Last Modified On : 01-10-2025
// ***********************************************************************
// <copyright file="CountryConverter.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
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
