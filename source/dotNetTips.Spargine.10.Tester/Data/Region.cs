// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 01-10-2025
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-09-2026
// ***********************************************************************
// <copyright file="Region.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Defines an enumeration of geographic regions (e.g., Africa, Americas,
// Asia, Europe, Oceania) used for country classification.
// </summary>
// ***********************************************************************

using System.Diagnostics.CodeAnalysis;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Tester.Data;

/// <summary>
/// Represents all the geographic regions in the world.
/// </summary>
[SuppressMessage("Design", "CA1724:Type names should not match namespaces", Justification = "Region is a domain concept specific to this library and the namespace conflict is acceptable.")]
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
