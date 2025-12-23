// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 09-28-2020
//
// Last Modified By : David McCarter
// Last Modified On : 07-30-2025
// ***********************************************************************
// <copyright file="InformationAttribute.cs" company="McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary>
// Attribute that enables the addition of informational data to methods.
// Properties include Author, BenchmarkStatus, CreatedOn, Description,
// Documentation, ModifiedBy, ModifiedOn, Status, UnitTestCoverage.
// </summary>
// ***********************************************************************
using DotNetTips.Spargine.Core.Properties;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Attribute that enables the addition of informational data to methods, classes, and other members.
/// This includes authorship, creation and modification dates, documentation links, and more.
/// </summary>
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Delegate, Inherited = false)]
[Information(Status = Status.Available, Documentation = "https://bit.ly/SpargineInformationAttribute")]
public sealed class InformationAttribute : Attribute
{

	/// <summary>
	/// Initializes a new instance of the <see cref="InformationAttribute"/> class.
	/// </summary>
	public InformationAttribute()
		: this(description: string.Empty, author: Resources.UserUnknown, createdOn: string.Empty, modifiedOn: string.Empty) => this.Documentation = string.Empty;

	/// <summary>
	/// Initializes a new instance of the <see cref="InformationAttribute"/> class with a description.
	/// </summary>
	/// <param name="description">The description of the member this attribute is applied to.</param>
	public InformationAttribute(string description)
		: this(description, string.Empty, string.Empty, string.Empty)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="InformationAttribute"/> class with a description, author, and creation date.
	/// </summary>
	/// <param name="description">The description of the member this attribute is applied to.</param>
	/// <param name="author">The author of the member.</param>
	/// <param name="createdOn">The creation date of the member.</param>
	public InformationAttribute(string description, string author, string createdOn)
		: this(description, author, createdOn, createdOn)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="InformationAttribute"/> class with a description, author, creation date, and modification date.
	/// </summary>
	/// <param name="description">The description of the member this attribute is applied to.</param>
	/// <param name="author">The author of the member.</param>
	/// <param name="createdOn">The creation date of the member.</param>
	/// <param name="modifiedOn">The modification date of the member.</param>
	public InformationAttribute(string description, string author, string createdOn, string modifiedOn)
	{
		this.Description = description;
		this.Author = string.IsNullOrEmpty(author) ? Resources.UserUnknown : author;

		if (string.IsNullOrEmpty(createdOn) is false && DateTimeOffset.TryParse(createdOn, out var createdDate))
		{
			this.CreatedOn = createdDate;

			if (string.IsNullOrEmpty(modifiedOn) == DateTimeOffset.TryParse(modifiedOn, out var modifiedDate))
			{
				this.ModifiedOn = modifiedDate;
			}
		}

		if (string.IsNullOrEmpty(this.ModifiedBy))
		{
			this.ModifiedBy = author;
		}

		this.Documentation = string.Empty;
	}

	/// <summary>
	/// Gets the author of the member.
	/// </summary>
	public string Author { get; }

	/// <summary>
	/// Gets or sets the benchmark status of the member.
	/// </summary>
	public BenchmarkStatus BenchmarkStatus { get; init; } = BenchmarkStatus.None;

	/// <summary>
	/// Gets the creation date of the member.
	/// </summary>
	public DateTimeOffset? CreatedOn { get; init; }

	/// <summary>
	/// Gets the description of the member.
	/// </summary>
	public string Description { get; }

	/// <summary>
	/// Gets or sets the Uri for external documentation related to the member.
	/// </summary>
	public string Documentation { get; init; }

	/// <summary>
	/// Gets or sets the name of the person who last modified the member.
	/// </summary>
	public string ModifiedBy { get; init; }

	/// <summary>
	/// Gets the last modification date of the member.
	/// </summary>
	public DateTimeOffset? ModifiedOn { get; private set; }

	/// <summary>
	/// Gets or sets the optimization status of the member.
	/// </summary>
	public OptimizationStatus OptimizationStatus { get; init; } = OptimizationStatus.None;

	/// <summary>
	/// Gets or sets the development status of the member.
	/// </summary>
	public Status Status { get; init; } = Status.NotSet;

	/// <summary>
	/// Gets or sets tags that provide additional categorization or context for the member.
	/// </summary>
	public string[] Tags { get; init; } = [];

	/// <summary>
	/// Gets or sets the unit test status of the member.
	/// </summary>
	public UnitTestStatus UnitTestStatus { get; init; } = UnitTestStatus.None;

	/// <summary>
	/// Gets or sets the version of the member, useful for tracking changes and versioning.
	/// </summary>
	public string Version { get; init; } = string.Empty;

}
