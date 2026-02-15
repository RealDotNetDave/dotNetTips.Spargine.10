// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 02-15-2026
// ***********************************************************************
// <copyright file="EnumValue.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Used to supply the name and value for an Enum.</summary>
// ***********************************************************************

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)


using System.Diagnostics.CodeAnalysis;

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Represents a record that holds the name and value of an enumeration.
/// </summary>
public record EnumValue
{

	/// <summary>
	/// Initializes a new instance of the <see cref="EnumValue"/> record.
	/// </summary>
	/// <param name="value">The integer value of the enumeration.</param>
	/// <param name="name">The name of the enumeration. This cannot be null.</param>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="name"/> is null or empty.</exception>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public EnumValue(in int value, [NotNull] string name)
	{
		this.Value = value;
		this.Name = name;
	}

	/// <summary>
	/// Gets the name of the enumeration.
	/// </summary>
	/// <value>The name of the enumeration.</value>
	public string Name { get; init; }

	/// <summary>
	/// Gets the integer value of the enumeration.
	/// </summary>
	/// <value>The integer value.</value>
	public int Value { get; init; }

}
