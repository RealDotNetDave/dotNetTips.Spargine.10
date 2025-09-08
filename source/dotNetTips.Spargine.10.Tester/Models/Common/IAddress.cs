// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Tester
// Author           : David McCarter
// Created          : 11-22-2023
//
// Last Modified By : David McCarter
// Last Modified On : 08-12-2025
// ***********************************************************************
// <copyright file="IAddress.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Interface "IAddress" that defines properties for Address1 and
// Address2, City, Country, CountryProvince, Phone, PostalCode,
// and State. This interface inherits from another interface named
// IAddress.
// </summary>
// ***********************************************************************

using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Tester.Models.Common;

#pragma warning disable IDE0040 // Interface members are implicitly public.

/// <summary>
/// Contract for an address model with identity via <see cref="IDataModel{TSelf, TKey}"/>.
/// Uses the CRTP pattern so static members can return the implementing type.
/// </summary>
/// <typeparam name="TSelf">The implementing address type.</typeparam>
public interface IAddress<TSelf> : IDataModel<TSelf, string>
	where TSelf : IAddress<TSelf>
{

	/// <summary>
	/// Creates a new instance of <typeparamref name="TSelf"/>.
	/// </summary>
	/// <param name="id">Identifier (init-only in implementations).</param>
	/// <param name="address1">First line.</param>
	/// <param name="city">City.</param>
	/// <param name="country">Country.</param>
	/// <param name="postalCode">Postal/ZIP.</param>
	/// <param name="address2">Second line (optional).</param>
	/// <param name="countyProvince">County/province (optional).</param>
	/// <param name="state">State/region (optional).</param>
	/// <param name="phone">Phone (optional).</param>
	/// <returns>A new address instance.</returns>
	static abstract TSelf Create(string id, string address1, string city, string country, string postalCode, string? address2 = null, string? countyProvince = null, string? state = null, string? phone = null);

	/// <summary>Gets the first address line.</summary>
	string Address1 { get; }

	/// <summary>Gets the optional second address line.</summary>
	string? Address2 { get; }

	/// <summary>Gets the city.</summary>
	string City { get; }

	/// <summary>Gets the country.</summary>
	string Country { get; }

	/// <summary>Gets the county or province.</summary>
	string? CountyProvince { get; }

	/// <summary>Gets the phone number.</summary>
	string? Phone { get; }

	/// <summary>Gets the postal or ZIP code.</summary>
	string PostalCode { get; }

	/// <summary>Gets the state or region.</summary>
	string? State { get; }
}

#pragma warning restore IDE0040

