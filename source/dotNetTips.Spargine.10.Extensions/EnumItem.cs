// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 02-16-2026
// ***********************************************************************
// <copyright file="EnumItem.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary>Class to supply the description and value for an Enum.</summary>
// ***********************************************************************

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)



namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Class EnumItem.
/// </summary>
/// <typeparam name="T">Generic type parameter.</typeparam>
public sealed record EnumItem<T>
{

	/// <summary>
	/// Initializes a new instance of the <see cref="EnumItem{T}" /> class.
	/// </summary>
	/// <param name="description">The description.</param>
	/// <param name="value">The value.</param>
	public EnumItem(string description, T value)
	{
		this.Description = description;
		this.Value = value;
	}

	/// <summary>
	/// Gets or sets the description.
	/// </summary>
	/// <value>The description.</value>
	public string Description
	{
		get; init;
	}

	/// <summary>
	/// Gets or sets the value.
	/// </summary>
	/// <value>The value.</value>
	public T Value
	{
		get; init;
	}

}
