// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Tester
// Author           : David McCarter
// Created          : 07-10-2019
//
// Last Modified By : David McCarter
// Last Modified On : 08-12-2025
// ***********************************************************************
// <copyright file="IPerson.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Interface "IPerson" that defines properties for Addresses, BornOn,
// CellPhone, Email, FirstName, LastName, and Phone.
// </summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Tester.Models.Common;
#pragma warning disable IDE0040

/// <summary>
/// Contract for a person model with identity via <see cref="IDataModel{TSelf, TKey}"/>.
/// Uses the CRTP pattern so static members can return the implementing type.
/// </summary>
/// <typeparam name="TSelf">The implementing person type.</typeparam>
/// <typeparam name="TAddress">The implementing address type.</typeparam>
[Information(Status = Status.Available, Documentation = "https://bit.ly/SpargineTester")]
public interface IPerson<TSelf, TAddress> : IDataModel<TSelf, string>
	where TSelf : IPerson<TSelf, TAddress>
	where TAddress : IAddress<TAddress>
{

	/// <summary>
	/// Creates a new instance of <typeparamref name="TSelf"/>.
	/// </summary>
	/// <param name="id">Identifier (init-only in implementations).</param>
	/// <param name="email">Email address.</param>
	/// <param name="firstName">First name.</param>
	/// <param name="lastName">Last name.</param>
	/// <param name="bornOn">Birth date.</param>
	/// <param name="addresses">Initial addresses (optional).</param>
	/// <param name="cellPhone">Cell phone (optional).</param>
	/// <param name="phone">Home phone (optional).</param>
	/// <returns>A new person instance.</returns>
	static abstract TSelf Create(string id, string email, string firstName, string lastName, DateTimeOffset? bornOn, Collection<TAddress>? addresses = null, string? cellPhone = null, string? phone = null);

	/// <summary>Gets the collection of addresses. Returns an empty collection if none exist.</summary>
	Collection<TAddress>? Addresses { get; }

	/// <summary>Gets the birth date.</summary>
	DateTimeOffset? BornOn { get; }

	/// <summary>Gets the cell phone number.</summary>
	string? CellPhone { get; }

	/// <summary>Gets the email address.</summary>
	string Email { get; init; }

	/// <summary>Gets the first name.</summary>
	string FirstName { get; }

	/// <summary>Gets the last name.</summary>
	string LastName { get; }

	/// <summary>Gets the home phone number.</summary>
	string? Phone { get; }

}
#pragma warning restore IDE0040
