// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Benchmarking
// Author           : David McCarter
// Created          : 04-18-2022
//
// Last Modified By : David McCarter
// Last Modified On : 09-27-2026
// ***********************************************************************
// <copyright file="CollectionBenchmark.Coordinate.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Partial class of CollectionBenchmark that provides preloaded Coordinate
// value-type collections in arrays, lists, ReadOnlyCollections, and
// dictionaries for benchmark consumption.
// </summary>
// ***********************************************************************

using System.Collections.ObjectModel;
using DotNetTips.Spargine.Core;
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
	/// Copies the internal reference-type coordinate buffer into the provided destination span.
	/// Throws if the destination is smaller than the source.
	/// </summary>
	[Information(nameof(CopyCoordinateRefTo), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public void CopyCoordinateRefTo(Span<Tester.Models.RefTypes.Coordinate> destination)
	{
		this._coordinateRefArray.AsSpan().CopyTo(destination);
	}

	/// <summary>
	/// Copies the internal value-type coordinate buffer into the provided destination span.
	/// Throws if the destination is smaller than the source.
	/// </summary>
	[Information(nameof(CopyCoordinateValTo), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public void CopyCoordinateValTo(Span<Coordinate> destination)
	{
		this._coordinateValArray.AsSpan().CopyTo(destination);
	}

	/// <summary>
	/// Gets a clone of the Coordinate array. This method ensures that benchmarks operate on a fresh copy of the data,
	/// preventing modifications from affecting subsequent benchmark runs.
	/// </summary>
	/// <returns>A clone of the Coordinate array.</returns>
	[Information(nameof(GetCoordinateRefArray), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public Tester.Models.RefTypes.Coordinate[] GetCoordinateRefArray()
	{
		// Return a shallow clone of the backing array so callers may modify the
		// returned buffer without affecting the benchmark's internal state.
		return (Tester.Models.RefTypes.Coordinate[])this._coordinateRefArray.Clone();
	}

	/// <summary>
	/// Gets a clone of the Coordinate list as a <see cref="Collection{T}"/>.
	/// Similar to <see cref="GetCoordinateValArray"/>, this method provides a fresh copy of the data for benchmark tests.
	/// </summary>
	/// <returns>A clone of the Coordinate list as a Collection.</returns>
	[Information(nameof(GetCoordinateRefCollection), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public Collection<Tester.Models.RefTypes.Coordinate> GetCoordinateRefCollection()
	{
		return this._coordinateRefArray.ToCollection();
	}

	/// <summary>
	/// Returns a ReadOnlySpan over the internal reference-type coordinate array.
	/// The caller MUST NOT mutate the underlying collection; this provides
	/// allocation-free read access for hot-path benchmarks.
	/// </summary>
	[Information(nameof(GetCoordinateRefReadOnlySpan), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public ReadOnlySpan<Tester.Models.RefTypes.Coordinate> GetCoordinateRefReadOnlySpan()
	{
		return this._coordinateRefArray.AsSpan();
	}

	/// <summary>
	/// Gets a clone of the Coordinate array. This method ensures that benchmarks operate on a fresh copy of the data,
	/// preventing modifications from affecting subsequent benchmark runs.
	/// </summary>
	/// <returns>A clone of the Coordinate array.</returns>
	[Information(nameof(GetCoordinateValArray), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public Coordinate[] GetCoordinateValArray()
	{
		// Return a shallow clone of the backing array so callers may modify the
		// returned buffer without affecting the benchmark's internal state.
		return (Coordinate[])this._coordinateValArray.Clone();
	}

	/// <summary>
	/// Gets a clone of the Coordinate list as a <see cref="Collection{T}"/>.
	/// Similar to <see cref="GetCoordinateValArray"/>, this method provides a fresh copy of the data for benchmark tests.
	/// </summary>
	/// <returns>A clone of the Coordinate list as a Collection.</returns>
	[Information(nameof(GetCoordinateValCollection), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public Collection<Coordinate> GetCoordinateValCollection()
	{
		return this._coordinateValArray.ToCollection();
	}

	/// <summary>
	/// Returns a ReadOnlySpan over the internal value-type coordinate array.
	/// The caller MUST NOT mutate the underlying collection; this provides
	/// allocation-free read access for hot-path benchmarks.
	/// </summary>
	[Information(nameof(GetCoordinateValReadOnlySpan), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public ReadOnlySpan<Coordinate> GetCoordinateValReadOnlySpan()
	{
		return this._coordinateValArray.AsSpan();
	}

	/// <summary>
	/// Loads the coordinate collections into memory. This includes both a list and an array of Coordinate objects,
	/// populated to the maximum count specified for the benchmark. This method is called to prepare data for benchmark tests.
	/// </summary>
	[Information(nameof(LoadCoordinateCollections), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	protected void LoadCoordinateCollections()
	{
		this._coordinateValArray = [.. RandomData.GenerateCoordinateCollection<Coordinate>(this.MaxCount)];
		this._coordinateRefArray = [.. RandomData.GenerateCoordinateCollection<Tester.Models.RefTypes.Coordinate>(this.MaxCount)];
	}
}
