
// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Tester
// Author           : David McCarter
// Created          : 12-29-2020
//
// Last Modified By : David McCarter
// Last Modified On : 07-15-2024
// ***********************************************************************
// <copyright file="ICoordinate.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// An interface named "ICoordinate" with properties X, Y,
// and Z for coordinating values.
// </summary>
// ***********************************************************************

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

using DotNetTips.Spargine.Core;

namespace DotNetTips.Spargine.Tester.Models.Common;

/// <summary>
/// Defines a set of properties for working with coordinates in a 3D space.
/// </summary>
[Information(Status = Status.Available, Documentation = "https://bit.ly/SpargineTester")]
public interface ICoordinate
{

	/// <summary>
	/// Converts to string representation of the coordinate.
	/// </summary>
	/// <returns>A <see cref="string" /> that represents the current object.</returns>
	public string ToString();

	/// <summary>
	/// Gets or sets the x coordinate.
	/// </summary>
	/// <value>The x value.</value>
	public int X { get; set; }

	/// <summary>
	/// Gets or sets the y coordinate.
	/// </summary>
	/// <value>The y value.</value>
	public int Y { get; set; }

	/// <summary>
	/// Gets or sets the z coordinate.
	/// </summary>
	/// <value>The z.</value>
	public int Z { get; set; }

}
