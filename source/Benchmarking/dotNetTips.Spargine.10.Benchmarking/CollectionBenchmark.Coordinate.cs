// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Benchmarking
// Author           : David McCarter
// Created          : 04-18-2022
//
// Last Modified By : David McCarter
// Last Modified On : 10-07-2025
// ***********************************************************************
// <copyright file="CollectionBenchmark.Coordinate.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Base class for tests that leverage collections, with added functionality
// for preloading Coordinate collections to improve benchmark test speed.
// </summary>
// ***********************************************************************

using System.Collections.ObjectModel;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.ValueTypes;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Benchmarking;

/// <summary>
/// Represents the base class for benchmarks that involve collections, specifically optimized for handling Coordinate objects.
/// This partial class provides methods to preload Coordinate collections to improve benchmark test speed and efficiency.
/// </summary>
public partial class CollectionBenchmark
{

	/// <summary>
	/// The coordinate array.
	/// </summary>
	private Coordinate[] _coordinateArray;


	/// <summary>
	/// Loads the coordinate collections into memory. This includes both a list and an array of Coordinate objects,
	/// populated to the maximum count specified for the benchmark. This method is called to prepare data for benchmark tests.
	/// </summary>
	protected void LoadCoordinateCollections()
	{
		this._coordinateArray = [.. RandomData.GenerateCoordinateCollection<Coordinate>(this.MaxCount)];
	}

	/// <summary>
	/// Gets a clone of the Coordinate array. This method ensures that benchmarks operate on a fresh copy of the data,
	/// preventing modifications from affecting subsequent benchmark runs.
	/// </summary>
	/// <returns>A clone of the Coordinate array.</returns>
	public Coordinate[] GetCoordinateValArray()
	{
		return this._coordinateArray.FastClone<Coordinate[]>();
	}

	/// <summary>
	/// Gets a clone of the Coordinate list as a <see cref="Collection{T}"/>.
	/// Similar to <see cref="GetCoordinateValArray"/>, this method provides a fresh copy of the data for benchmark tests.
	/// </summary>
	/// <returns>A clone of the Coordinate list as a Collection.</returns>
	public Collection<Coordinate> GetCoordinateValCollection()
	{
		return this._coordinateArray.FastClone<Coordinate[]>().ToCollection();
	}
}
