// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 02-27-2021
//
// Last Modified By : David McCarter
// Last Modified On : 07-30-2025
// ***********************************************************************
// <copyright file="Status.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Enumeration used in InformationAttribute.</summary>
// ***********************************************************************

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)


using System.Runtime.Serialization;

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Defines the availability status for use in the InformationAttribute.
/// </summary>
[Information(description: "For use in InformationAttribute.", author: "David McCarter", createdOn: "7/29/2020", BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Available)]
public enum Status
{
	/// <summary>
	/// Indicates that the status has not been set.
	/// </summary>
	[EnumMember(Value = "Not Set")]
	NotSet,

	/// <summary>
	/// Indicates that the method or class is new.
	/// </summary>
	[EnumMember(Value = "New")]
	New,

	/// <summary>
	/// Indicates that the method or class is available for use.
	/// </summary>
	[EnumMember(Value = "Available")]
	Available,

	/// <summary>
	/// Indicates that the method or class is not used.
	/// </summary>
	[EnumMember(Value = "Not Used")]
	NotUsed,

	/// <summary>
	/// Indicates that the method or class is obsolete.
	/// </summary>
	[EnumMember(Value = "Not Used")]
	Obsolete,

	/// <summary>
	/// Indicates that the method or class has been updated.
	/// </summary>
	[EnumMember(Value = "Updated")]
	Updated,

	/// <summary>
	/// Indicates that the code needs documentation.
	/// </summary>
	[EnumMember(Value = "Needs Documentation")]
	NeedsDocumentation,

	/// <summary>
	/// Indicates that the code needs its documentation updated.
	/// </summary>
	[EnumMember(Value = "Update Documentation")]
	UpdateDocumentation,
}
