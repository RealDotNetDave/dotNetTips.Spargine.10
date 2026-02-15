// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 02-05-2020
//
// Last Modified By : David McCarter
// Last Modified On : 02-15-2026
// ***********************************************************************
// <copyright file="IDataModel.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Interface designed for model classes, enforcing the implementation of
// the "Id" property, which is mandatory.
// </summary>
// ***********************************************************************

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core;

#pragma warning disable IDE0040

/// <summary>
/// Interface designed for model classes, enforcing the implementation of the <see cref="Id"/> property, which is mandatory.
/// Provides consistent comparison and equality based on <see cref="Id"/> and common helpers for model classes.
/// </summary>
/// <typeparam name="TSelf">The type that implements this interface.</typeparam>
/// <typeparam name="TKey">The type of the unique identifier.</typeparam>
[Information(Status = Status.NeedsDocumentation)]
public interface IDataModel<TSelf, TKey> :
	IComparable<TSelf>, IComparable, IEquatable<TSelf>
	where TSelf : IDataModel<TSelf, TKey>
	where TKey : notnull
{

	/// <summary>
	/// Gets the unique identifier for this model. The value is settable only at initialization.
	/// </summary>
	TKey Id { get; init; }

	/// <summary>
	/// Gets a value indicating whether this instance is transient (i.e., has the default <see cref="Id"/> value).
	/// </summary>
	[Information(UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	bool IsTransient => EqualityComparer<TKey>.Default.Equals(this.Id, default);

	/// <summary>
	/// Compares the current instance with another object of the same type based on <see cref="Id"/>.
	/// </summary>
	/// <param name="other">An object to compare with this instance.</param>
	/// <returns>
	/// A value that indicates the relative order of the objects being compared.
	/// The return value has these meanings:
	/// <list type="table">
	/// <item><term>Less than zero</term><description>This instance precedes <paramref name="other"/> in the sort order.</description></item>
	/// <item><term>Zero</term><description>This instance occurs in the same position in the sort order as <paramref name="other"/>.</description></item>
	/// <item><term>Greater than zero</term><description>This instance follows <paramref name="other"/> in the sort order.</description></item>
	/// </list>
	/// </returns>
	int IComparable<TSelf>.CompareTo(TSelf? other)
	{
		return other is null ? 1
			: Comparer<TKey>.Default.Compare(this.Id, other.Id);
	}

	/// <summary>
	/// Determines whether the specified object is equal to the current object based on <see cref="Id"/>.
	/// </summary>
	/// <param name="other">The object to compare with the current object.</param>
	/// <returns><c>true</c> if the specified object is equal to the current object; otherwise, <c>false</c>.</returns>
	bool IEquatable<TSelf>.Equals(TSelf? other)
	{
		return other is not null && EqualityComparer<TKey>.Default.Equals(this.Id, other.Id);
	}

	/// <summary>
	/// Returns a string suitable for debugging that displays the type name and <see cref="Id"/> value.
	/// </summary>
	/// <returns>A string representation for debugging purposes.</returns>
	[Information(UnitTestStatus = UnitTestStatus.NotRequired, Status = Status.Available)]
	string DebugDisplay()
	{
		return $"{typeof(TSelf).Name}({this.Id})";
	}
}
#pragma warning restore IDE0040
