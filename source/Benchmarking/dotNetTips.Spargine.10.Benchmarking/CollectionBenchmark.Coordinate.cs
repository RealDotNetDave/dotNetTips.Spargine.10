// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Benchmarking
// Author           : David McCarter
// Created          : 04-18-2022
//
// Last Modified By : David McCarter
// Last Modified On : 03-16-2026
// ***********************************************************************
// <copyright file="CollectionBenchmark.Coordinate.cs" company="dotNetTips.com - McCarter Consulting">
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
	private Tester.Models.RefTypes.Coordinate[] _coordinateRefArray;
	private Coordinate[] _coordinateValArray;

	/// <summary>
	/// Gets a clone of the Coordinate array. This method ensures that benchmarks operate on a fresh copy of the data,
	/// preventing modifications from affecting subsequent benchmark runs.
	/// </summary>
	/// <returns>A clone of the Coordinate array.</returns>
	public Tester.Models.RefTypes.Coordinate[] GetCoordinateRefArray()
	{
		return [.. this._coordinateRefArray];
	}

	/// <summary>
	/// Gets a clone of the Coordinate list as a <see cref="Collection{T}"/>.
	/// Similar to <see cref="GetCoordinateValArray"/>, this method provides a fresh copy of the data for benchmark tests.
	/// </summary>
	/// <returns>A clone of the Coordinate list as a Collection.</returns>
	public Collection<Tester.Models.RefTypes.Coordinate> GetCoordinateRefCollection()
	{
		return this._coordinateRefArray.AsSpan().ToArray().ToCollection();
	}

	/// <summary>
	/// Gets a clone of the Coordinate array. This method ensures that benchmarks operate on a fresh copy of the data,
	/// preventing modifications from affecting subsequent benchmark runs.
	/// </summary>
	/// <returns>A clone of the Coordinate array.</returns>
	public Coordinate[] GetCoordinateValArray()
	{
		return [.. this._coordinateValArray];
	}

	/// <summary>
	/// Gets a clone of the Coordinate list as a <see cref="Collection{T}"/>.
	/// Similar to <see cref="GetCoordinateValArray"/>, this method provides a fresh copy of the data for benchmark tests.
	/// </summary>
	/// <returns>A clone of the Coordinate list as a Collection.</returns>
	public Collection<Coordinate> GetCoordinateValCollection()
	{
		return this._coordinateValArray.AsSpan().ToArray().ToCollection();
	}

	/// <summary>
	/// Loads the coordinate collections into memory. This includes both a list and an array of Coordinate objects,
	/// populated to the maximum count specified for the benchmark. This method is called to prepare data for benchmark tests.
	/// </summary>
	protected void LoadCoordinateCollections()
	{
		this._coordinateValArray = [.. RandomData.GenerateCoordinateCollection<Coordinate>(this.MaxCount)];
		this._coordinateRefArray = [.. RandomData.GenerateCoordinateCollection<Tester.Models.RefTypes.Coordinate>(this.MaxCount)];
	}
}
