// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 01-10-2025
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-17-2026
// ***********************************************************************
// <copyright file="Region.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Defines an enumeration of geographic regions (e.g., Africa, Americas,
// Asia, Europe, Oceania) used for country classification.
// </summary>
// ***********************************************************************


namespace DotNetTips.Spargine.Tester.Data;

/// <summary>
/// Represents all the geographic regions in the world.
/// </summary>
public enum Region
{
	/// <summary>
	/// The African region.
	/// </summary>
	Africa,

	/// <summary>
	/// The Americas region, including both North and South America.
	/// </summary>
	Americas,

	/// <summary>
	/// The Asian region.
	/// </summary>
	Asia,

	/// <summary>
	/// Represents an undefined or unspecified region.
	/// </summary>
	Empty,

	/// <summary>
	/// The European region.
	/// </summary>
	Europe,

	/// <summary>
	/// The Oceania region, including Australasia, Melanesia, Micronesia, and Polynesia.
	/// </summary>
	Oceania,

	/// <summary>
	/// The Polar regions, including the Arctic and Antarctica.
	/// </summary>
	Polar
};
