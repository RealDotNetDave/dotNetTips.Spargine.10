// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-28-2026
// ***********************************************************************
// <copyright file="AppInfo.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Class designed to provide common data for an application.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Text;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Represents application-specific information such as company, product, version, and memory usage.
/// </summary>
[Serializable]
[ExcludeFromCodeCoverage(Justification = "Model class with no validation.")]
[Information(Documentation = "https://bit.ly/SpargineApp", Status = Status.Available)]
public record AppInfo
{
	/// <summary>
	/// The application name version format
	/// </summary>
	private static readonly CompositeFormat _appNameVersionFormat = CompositeFormat.Parse("{0} v{1}");

	/// <summary>
	/// Gets the company.
	/// </summary>
	/// <value>The company.</value>
	public string? Company
	{
		get; init;
	}

	/// <summary>
	/// Gets the configuration.
	/// </summary>
	/// <value>The configuration.</value>
	public string? Configuration
	{
		get; init;
	}

	/// <summary>
	/// Gets the copyright.
	/// </summary>
	/// <value>The copyright.</value>
	public string? Copyright
	{
		get; init;
	}

	/// <summary>
	/// Gets the culture.
	/// </summary>
	/// <value>The culture.</value>
	public string? Culture
	{
		get; init;
	}

	/// <summary>
	/// Gets the description.
	/// </summary>
	/// <value>The description.</value>
	public string? Description
	{
		get; init;
	}

	/// <summary>
	/// Gets the file version.
	/// </summary>
	/// <value>The file version.</value>
	public string? FileVersion
	{
		get; init;
	}

	/// <summary>
	/// Gets the memory allocated.
	/// </summary>
	/// <value>The memory allocated.</value>
	public long MemoryAllocated { get; internal set; }

	/// <summary>
	/// Gets the memory information.
	/// </summary>
	/// <value>The memory information.</value>
	public GCMemoryInfo MemoryInfo { get; internal set; }

	/// <summary>
	/// Gets the assembly product.
	/// </summary>
	/// <value>The assembly product.</value>
	public string? Product { get; init; }

	/// <summary>
	/// Gets the thread allocated bytes.
	/// </summary>
	/// <value>The thread allocated bytes.</value>
	public long ThreadAllocatedBytes { get; internal set; }

	/// <summary>
	/// Gets the assembly _title.
	/// </summary>
	/// <value>The assembly _title.</value>
	public string? Title
	{
		get; init;
	}

	/// <summary>
	/// Gets the total allocated bytes.
	/// </summary>
	/// <value>The total allocated bytes.</value>
	public long TotalAllocatedBytes { get; internal set; }

	/// <summary>
	/// Gets the assembly version.
	/// </summary>
	/// <value>The assembly version.</value>
	public string? Version
	{
		get; init;
	}

	/// <summary>
	/// Names the application name and version.
	/// </summary>
	/// <returns>System.String.</returns>
	[Pure]
	public string NameAndVersion()
	{
		return string.Format(CultureInfo.CurrentCulture, _appNameVersionFormat, this.Product, this.Version);
	}

}
