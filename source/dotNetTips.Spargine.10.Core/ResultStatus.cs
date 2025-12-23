// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 01-29-2025
//
// Last Modified By : David McCarter
// Last Modified On : 03-23-2025
// ***********************************************************************
// <copyright file="ResultStatus.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

using System.Runtime.Serialization;

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Represents the status of a result.
/// </summary>
public enum ResultStatus
{
	/// <summary>
	/// The action has failed
	/// </summary>
	[EnumMember(Value = "Failed")]
	Failed,

	/// <summary>
	/// The action has succeeded
	/// </summary>
	[EnumMember(Value = "Succeeded")]
	Succeeded,

	/// <summary>
	/// The action had partial success
	/// </summary>
	[EnumMember(Value = "Partial Success")]
	PartialSuccess,
}
