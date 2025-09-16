// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Tester
// Author           : David McCarter
// Created          : 12-04-2023
//
// Last Modified By : David McCarter
// Last Modified On : 08-25-2025
// ***********************************************************************
// <copyright file="Address.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Reference type representing a physical address, including Address1, Address2, City, Country, CountyProvince, Phone, PostalCode, and State.
// Implements <see cref="IAddress{Address}"/> for identity, comparison, and equality semantics.
// All address properties are validated for length and never return <c>null</c>; unset optional fields return <c>string.Empty</c>.
// </summary>
// ***********************************************************************
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Models.Common;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using DotNetTips.Spargine.Tester.Properties;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Tester.Models.ValueTypes;

/// <summary>
/// Value type named "Address" with properties for Address1 and
/// Address2, City, Country, CountryProvince, Phone, PostalCode,
/// and State. This type implements <see cref="IAddress{Address}"/>.
/// </summary>
[DataContract(Name = "address", Namespace = "http://DotNetTips.Spargine.Tester.Models.Val")]
[DebuggerDisplay("Id = {Id}, Address1 = {Address1}, City = {City}, Country = {Country}")]
[Serializable]
[XmlRoot(ElementName = "Address", Namespace = "http://DotNetTips.Spargine.Tester.Models.Val")]
[Information(Status = Status.UpdateDocumentation, Documentation = "https://bit.ly/SpargineTester")]
public struct Address : IAddress<Address>
{
	[JsonIgnore, NonSerialized] private string _address1 = string.Empty;
	[JsonIgnore, NonSerialized] private string _address2 = string.Empty;
	[JsonIgnore, NonSerialized] private string _city = string.Empty;
	[JsonIgnore, NonSerialized] private string _country = string.Empty;
	[JsonIgnore, NonSerialized] private string _countyProvince = string.Empty;
	[JsonIgnore, NonSerialized] private string _id = string.Empty;
	[JsonIgnore, NonSerialized] private string _phone = string.Empty;
	[JsonIgnore, NonSerialized] private string _postalCode = string.Empty;
	[JsonIgnore, NonSerialized] private string _state = string.Empty;

	/// <summary>
	/// Initializes a new instance of the <see cref="Address"/> class
	/// with the specified identifier, address line 1, city, country,
	/// and postal code.
	/// </summary>
	/// <param name="id">The unique identifier for the address.</param>
	/// <param name="address1">The first line of the address.</param>
	/// <param name="city">The city of the address.</param>
	/// <param name="country">The country of the address.</param>
	/// <param name="postalCode">The postal code of the address.</param>
	/// <exception cref="ArgumentOutOfRangeException">
	/// Thrown if any property value does not meet its length
	/// requirements.
	/// </exception>
	private Address(string id, string address1, string city, string country, string postalCode)
		: this(id)
	{
		this.Address1 = address1;
		this.City = city;
		this.Country = country;
		this.PostalCode = postalCode;
	}

	/// <summary>
	/// Prevent default construction except for serializers.
	/// </summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public Address() { }

	/// <summary>
	/// Creates a new instance with the specified <paramref name="id"/>.
	/// </summary>
	/// <param name="id">Unique identifier (10–50 chars).</param>
	/// <exception cref="ArgumentOutOfRangeException">
	/// Thrown if <paramref name="id"/> does not meet length
	/// requirements.
	/// </exception>
	[JsonConstructor]
	[Information(nameof(Address), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public Address([NotNull] string id)
	{
		this.Id = id;
	}

	/// <summary>
	/// Inequality operator (identity).
	/// </summary>
	/// <param name="left">Left <see cref="Address"/>.</param>
	/// <param name="right">Right <see cref="Address"/>.</param>
	/// <returns>True if not equal, otherwise false.</returns>
	[DebuggerStepThrough]
	public static bool operator !=(Address left, Address right) => !(left == right);

	/// <summary>
	/// Less-than operator (identity compare).
	/// </summary>
	/// <param name="left">Left <see cref="Address"/>.</param>
	/// <param name="right">Right <see cref="Address"/>.</param>
	/// <returns>True if left is less than right.</returns>
	[DebuggerStepThrough]
	public static bool operator <(Address left, Address right) => left.CompareTo(right) < 0;

	/// <summary>
	/// Less-than-or-equal operator (identity compare).
	/// </summary>
	/// <param name="left">Left <see cref="Address"/>.</param>
	/// <param name="right">Right <see cref="Address"/>.</param>
	/// <returns>True if left is less than or equal to right.</returns>
	[DebuggerStepThrough]
	public static bool operator <=(Address left, Address right) => left.CompareTo(right) <= 0;

	/// <summary>
	/// Equality operator (identity).
	/// </summary>
	/// <param name="left">Left <see cref="Address"/>.</param>
	/// <param name="right">Right <see cref="Address"/>.</param>
	/// <returns>True if equal, otherwise false.</returns>
	[DebuggerStepThrough]
	public static bool operator ==(Address left, Address right) => left.Equals(right);

	/// <summary>
	/// Greater-than operator (identity compare).
	/// </summary>
	/// <param name="left">Left <see cref="Address"/>.</param>
	/// <param name="right">Right <see cref="Address"/>.</param>
	/// <returns>True if left is greater than right.</returns>
	[DebuggerStepThrough]
	public static bool operator >(Address left, Address right) => left.CompareTo(right) > 0;

	/// <summary>
	/// Greater-than-or-equal operator (identity compare).
	/// </summary>
	/// <param name="left">Left <see cref="Address"/>.</param>
	/// <param name="right">Right <see cref="Address"/>.</param>
	/// <returns>True if left is greater than or equal to right.</returns>
	[DebuggerStepThrough]
	public static bool operator >=(Address left, Address right) => left.CompareTo(right) >= 0;

	/// <summary>
	/// Converts an <see cref="AddressRecord"/> to <see cref="Address"/>.
	/// </summary>
	/// <param name="address">The <see cref="AddressRecord"/> to convert.</param>
	/// <returns>An <see cref="Address"/> instance.</returns>
	/// <exception cref="ArgumentNullException">
	/// Thrown if <paramref name="address"/> is null.
	/// </exception>
	[return: NotNull]
	public static explicit operator Address(AddressRecord address) => ToAddress(address);

	/// <summary>
	/// Converts a <see cref="RefTypes.Address"/> to <see cref="Address"/>.
	/// </summary>
	/// <param name="address">The <see cref="RefTypes.Address"/> to convert.</param>
	/// <returns>An <see cref="Address"/> instance.</returns>
	/// <exception cref="ArgumentNullException">
	/// Thrown if <paramref name="address"/> is null.
	/// </exception>
	public static explicit operator Address(RefTypes.Address address) => ToAddress(address);

	/// <summary>
	/// Non-generic comparison required by <see cref="IComparable"/>.
	/// </summary>
	/// <param name="obj">Object to compare.</param>
	/// <returns>
	/// Value indicating the relative order of the objects.
	/// </returns>
	/// <exception cref="ArgumentException">
	/// Thrown when <paramref name="obj"/> is not an
	/// <see cref="Address"/>.
	/// </exception>
	readonly int IComparable.CompareTo(object? obj)
	{
		if (obj is null)
		{
			return 1;
		}

		return obj is Address other
			? this.CompareTo(other)
			: throw new ArgumentException($"Object must be of type {nameof(Address)}", nameof(obj));
	}

	/// <summary>
	/// Compares this instance with another <see cref="Address"/>
	/// using ordinal <see cref="Id"/>.
	/// </summary>
	/// <param name="other">Other <see cref="Address"/>.</param>
	/// <returns>
	/// Value indicating the relative order of the objects.
	/// </returns>
	public readonly int CompareTo(Address other)
	{
		return string.Compare(this.Id, other.Id, StringComparison.Ordinal);
	}

	/// <summary>
	/// Creates a new <see cref="Address"/> with only the identifier.
	/// </summary>
	/// <param name="id">Unique identifier (10–50 chars).</param>
	/// <returns>A new <see cref="Address"/> instance.</returns>
	/// <exception cref="ArgumentOutOfRangeException">
	/// Thrown if <paramref name="id"/> does not meet length
	/// requirements.
	/// </exception>
	public static Address Create(string id)
	{
		return new(id);
	}

	/// <summary>
	/// Factory method to create a new <see cref="Address"/> instance with the specified values.
	/// All fields are validated for length. Optional fields default to <c>string.Empty</c> if <c>null</c> is provided.
	/// </summary>
	/// <param name="id">The unique identifier for the address.</param>
	/// <param name="address1">The first line of the address.</param>
	/// <param name="city">The city of the address.</param>
	/// <param name="country">The country of the address.</param>
	/// <param name="postalCode">The postal code of the address.</param>
	/// <param name="address2">The second line of the address
	/// (optional).</param>
	/// <param name="countyProvince">The county or province
	/// (optional).</param>
	/// <param name="state">The state or region (optional).</param>
	/// <param name="phone">The phone number (optional).</param>
	/// <returns>A new <see cref="Address"/> instance.</returns>
	/// <exception cref="ArgumentOutOfRangeException">
	/// Thrown if any property value does not meet its length
	/// requirements.
	/// </exception>
	public static Address Create(string id, string address1, string city, string country, string postalCode, string? address2 = null, string? countyProvince = null, string? state = null, string? phone = null)
	{
		return new Address(id, address1, city, country, postalCode)
		{
			Address2 = address2 ?? string.Empty,
			CountyProvince = countyProvince ?? string.Empty,
			State = state ?? string.Empty,
			Phone = phone ?? string.Empty
		};
	}

	/// <summary>
	/// Determines equality with another <see cref="Address"/>
	/// using ordinal <see cref="Id"/>.
	/// </summary>
	/// <param name="other">Other <see cref="Address"/>.</param>
	/// <returns>True if equal, otherwise false.</returns>
	public readonly bool Equals(Address other)
	{
		return string.Equals(this.Id, other.Id, StringComparison.Ordinal);
	}

	/// <summary>
	/// Determines whether the specified object is equal to the
	/// current object.
	/// </summary>
	/// <param name="obj">The object to compare with the current
	/// object.</param>
	/// <returns>
	/// True if the specified object is equal to the current object;
	/// otherwise, false.
	/// </returns>
	public override readonly bool Equals(object? obj)
	{
		return obj is Address other && this.Equals(other);
	}

	/// <summary>
	/// Returns a hash code for this instance.
	/// </summary>
	/// <returns>
	/// A hash code for the current object.
	/// </returns>
	public override readonly int GetHashCode()
	{
		return this.Id?.GetHashCode(StringComparison.Ordinal) ?? 0;
	}

	/// <summary>
	/// Converts an <see cref="AddressRecord"/> to <see cref="Address"/>.
	/// </summary>
	/// <param name="address">The <see cref="AddressRecord"/> to convert.</param>
	/// <returns>An <see cref="Address"/> instance.</returns>
	/// <exception cref="ArgumentNullException">
	/// Thrown if <paramref name="address"/> is null.
	/// </exception>
	[Information(nameof(ToAddress), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static Address ToAddress([NotNull] AddressRecord address)
	{
		address = address.ArgumentNotNull();

		return new(address.Id)
		{
			Address1 = address.Address1,
			Address2 = address.Address2,
			City = address.City,
			Country = address.Country,
			CountyProvince = address.CountyProvince,
			Phone = address.Phone,
			PostalCode = address.PostalCode,
			State = address.State,
		};
	}

	/// <summary>
	/// Converts a <see cref="RefTypes.Address"/> to <see cref="Address"/>.
	/// </summary>
	/// <param name="address">The <see cref="RefTypes.Address"/> to convert.</param>
	/// <returns>An <see cref="Address"/> instance.</returns>
	/// <exception cref="ArgumentNullException">
	/// Thrown if <paramref name="address"/> is null.
	/// </exception>
	public static Address ToAddress([NotNull] in RefTypes.Address address)
	{
		_ = address.ArgumentNotNull();

		return new Address(address.Id)
		{
			Address1 = address.Address1,
			Address2 = address.Address2,
			City = address.City,
			State = address.State,
			CountyProvince = address.CountyProvince,
			Country = address.Country,
			PostalCode = address.PostalCode,
			Phone = address.Phone
		};
	}

	/// <summary>
	/// Debug-friendly string.
	/// </summary>
	/// <returns>
	/// A string representation of the address.
	/// </returns>
	[DebuggerStepThrough]
	[Information(nameof(ToString), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public override string ToString()
	{
		return this.PropertiesToString();
	}

	/// <summary>
	/// Gets or sets the first address line (0–100 chars).
	/// </summary>
	/// <exception cref="ArgumentOutOfRangeException">
	/// Thrown if the value is not between 0 and 100 characters.
	/// </exception>
	[DataMember(Name = "address1", IsRequired = false, Order = 1)]
	[Display(Name = "Address Line 1")]
	[JsonPropertyName("address1")]
	[MaxLength(100, ErrorMessageResourceName = "ErrorAddressLengthIsLimitedToCharacters", ErrorMessageResourceType = typeof(Resources))]
	[StringLength(100, ErrorMessageResourceName = "ErrorAddressLengthIsLimitedToCharacters", ErrorMessageResourceType = typeof(Resources))]
	[XmlElement("Address1")]
	[Information(nameof(Address1), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string Address1
	{
		readonly get { return this._address1; }
		set
		{
			var safeValue = value ?? string.Empty;

			if (this._address1.FastCompare(safeValue))
			{
				return;
			}

			if (safeValue.HasValue(0, 100) is false)
			{
				ExceptionThrower.ThrowArgumentOutOfRangeException(
					Resources.ErrorAddressLengthIsLimitedToCharacters, nameof(this.Address1));
			}
			else
			{
				this._address1 = safeValue;
			}
		}
	}

	/// <summary>
	/// Gets or sets the optional second address line (0–100 chars).
	/// Never returns <c>null</c>; returns <c>string.Empty</c> if unset.
	/// </summary>
	/// <exception cref="ArgumentOutOfRangeException">
	/// Thrown if the value is not between 0 and 100 characters.
	/// </exception>
	[DataMember(Name = "address2", IsRequired = false, Order = 2)]
	[Display(Name = "Address Line 2")]
	[JsonPropertyName("address2")]
	[MaxLength(100, ErrorMessageResourceName = "ErrorAddressLengthIsLimitedToCharacters", ErrorMessageResourceType = typeof(Resources))]
	[StringLength(100, ErrorMessageResourceName = "ErrorAddressLengthIsLimitedToCharacters", ErrorMessageResourceType = typeof(Resources))]
	[XmlElement("Address2")]
	[Information(nameof(Address2), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string Address2
	{
		readonly get { return this._address2; }
		set
		{
			var safeValue = value ?? string.Empty;

			if (this._address2.FastCompare(safeValue))
			{
				return;
			}

			if (safeValue.HasValue(0, 100) is false)
			{
				ExceptionThrower.ThrowArgumentOutOfRangeException(
					Resources.ErrorAddressLengthIsLimitedToCharacters, nameof(this.Address2));
			}
			else
			{
				this._address2 = safeValue;
			}
		}
	}

	/// <summary>
	/// Gets or sets the city (0–100 chars).
	/// </summary>
	/// <exception cref="ArgumentOutOfRangeException">
	/// Thrown if the value is not between 0 and 100 characters.
	/// </exception>
	[DataMember(Name = "city", IsRequired = false, Order = 3)]
	[Display(Name = "City")]
	[JsonPropertyName("city")]
	[MaxLength(100, ErrorMessageResourceName = "ErrorCityLengthIsLimitedToCharacters", ErrorMessageResourceType = typeof(Resources))]
	[StringLength(100, ErrorMessageResourceName = "ErrorCityLengthIsLimitedToCharacters", ErrorMessageResourceType = typeof(Resources))]
	[XmlElement("City")]
	[Information(nameof(City), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string City
	{
		readonly get { return this._city; }
		set
		{
			var safeValue = value ?? string.Empty;

			if (this._city.FastCompare(safeValue))
			{
				return;
			}

			if (safeValue.HasValue(0, 100) is false)
			{
				ExceptionThrower.ThrowArgumentOutOfRangeException(
					Resources.ErrorCityLengthIsLimitedToCharacters, nameof(this.City));
			}
			else
			{
				this._city = safeValue;
			}
		}
	}

	/// <summary>
	/// Gets or sets the country (0–55 chars).
	/// </summary>
	/// <exception cref="ArgumentOutOfRangeException">
	/// Thrown if the value is not between 0 and 55 characters.
	/// </exception>
	[DataMember(Name = "country", IsRequired = false, Order = 4)]
	[Display(Name = "Country")]
	[JsonPropertyName("country")]
	[MaxLength(55, ErrorMessageResourceName = "ErrorCountryLengthIsLimitedToCharacters", ErrorMessageResourceType = typeof(Resources))]
	[StringLength(55, ErrorMessageResourceName = "ErrorCountryLengthIsLimitedToCharacters", ErrorMessageResourceType = typeof(Resources))]
	[XmlElement("Country")]
	[Information(nameof(Country), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string Country
	{
		readonly get { return this._country; }
		set
		{
			var safeValue = value ?? string.Empty;

			if (this._country.FastCompare(safeValue))
			{
				return;
			}

			if (safeValue.HasValue(0, 55) is false)
			{
				ExceptionThrower.ThrowArgumentOutOfRangeException(
					Resources.ErrorCountryLengthIsLimitedToCharacters, nameof(this.Country));
			}
			else
			{
				this._country = safeValue;
			}
		}
	}

	/// <summary>
	/// Gets or sets the county/province (0–60 chars).
	/// Never returns <c>null</c>; returns <c>string.Empty</c> if unset.
	/// </summary>
	/// <exception cref="ArgumentOutOfRangeException">
	/// Thrown if the value is longer than 60 characters.
	/// </exception>
	[DataMember(Name = "countyProvince", IsRequired = false, Order = 5)]
	[Display(Name = "County/Province")]
	[JsonPropertyName("countyProvince")]
	[MaxLength(60, ErrorMessageResourceName = "ErrorCountyProvinceLengthIsLimitedToCharacter", ErrorMessageResourceType = typeof(Resources))]
	[StringLength(60, ErrorMessageResourceName = "ErrorCountyProvinceLengthIsLimitedToCharacter", ErrorMessageResourceType = typeof(Resources))]
	[XmlElement("CountyProvince")]
	[Information(nameof(CountyProvince), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string CountyProvince
	{
		readonly get { return this._countyProvince; }
		set
		{
			var safeValue = value ?? string.Empty;

			if (this._countyProvince.FastCompare(safeValue))
			{
				return;
			}

			if (safeValue.HasValue(0, 60) is false)
			{
				ExceptionThrower.ThrowArgumentOutOfRangeException(
					Resources.ErrorCountyProvinceLengthIsLimitedToCharacter, nameof(this.CountyProvince));
			}
			else
			{
				this._countyProvince = safeValue;
			}
		}
	}

	/// <summary>
	/// Gets the unique identifier (init-only; 10–50 chars).
	/// </summary>
	/// <exception cref="ArgumentOutOfRangeException">
	/// Thrown if the value is not between 10 and 50 characters.
	/// </exception>
	[DataMember(Name = "id", IsRequired = true, Order = 0)]
	[Display(Name = "Identifier")]
	[JsonPropertyName("id")]
	[MaxLength(50, ErrorMessageResourceName = "ErrorIdLengthIsLimitedToCharacters", ErrorMessageResourceType = typeof(Resources))]
	[MinLength(10, ErrorMessageResourceName = "ErrorIdLengthIsMinimumCharacters", ErrorMessageResourceType = typeof(Resources))]
	[ReadOnly(true)]
	[Required(AllowEmptyStrings = false, ErrorMessageResourceName = "ErrorIdIsRequired", ErrorMessageResourceType = typeof(Resources))]
	[XmlElement("Id", IsNullable = false)]
	[Information(nameof(Id), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string Id
	{
		readonly get { return this._id; }
		init
		{
			if (value.HasValue(10, 50) is false)
			{
				ExceptionThrower.ThrowArgumentOutOfRangeException(
					Resources.ErrorIdLengthIsLimitedToCharacters, nameof(this.Id));
			}
			else
			{
				this._id = value;
			}
		}
	}

	/// <summary>
	/// Gets or sets the phone number (0–50 chars).
	/// Never returns <c>null</c>; returns <c>string.Empty</c> if unset.
	/// </summary>
	/// <exception cref="ArgumentOutOfRangeException">
	/// Thrown if the value is not between 0 and 50 characters.
	/// </exception>
	[DataMember(Name = "phone", IsRequired = false, Order = 6)]
	[Display(Name = "Phone Number")]
	[JsonPropertyName("phone")]
	[MaxLength(50, ErrorMessageResourceName = "ErrorMessagePhoneNumberIsLimitedToCharacters", ErrorMessageResourceType = typeof(Resources))]
	[Phone(ErrorMessageResourceName = "ErrorMessagePhoneNumberIsLimitedToCharacters", ErrorMessageResourceType = typeof(Resources))]
	[XmlElement("Phone")]
	[Information(nameof(Phone), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string Phone
	{
		readonly get { return this._phone; }
		set
		{
			var safeValue = value ?? string.Empty;

			if (this._phone.FastCompare(safeValue))
			{
				return;
			}

			if (safeValue.HasValue(0, 50) is false)
			{
				ExceptionThrower.ThrowArgumentOutOfRangeException(
					Resources.ErrorMessagePhoneNumberIsLimitedToCharacters, nameof(this.Phone));
			}
			else
			{
				this._phone = safeValue;
			}
		}
	}

	/// <summary>
	/// Gets or sets the postal/ZIP code (0–25 chars).
	/// </summary>
	/// <exception cref="ArgumentOutOfRangeException">
	/// Thrown if the value is not between 0 and 25 characters.
	/// </exception>
	[DataMember(Name = "postalCode", IsRequired = false, Order = 7)]
	[Display(Name = "Postal Code")]
	[JsonPropertyName("postalCode")]
	[MaxLength(25, ErrorMessageResourceName = "ErrorPostalCodeLengthIsLimitedToCharacters", ErrorMessageResourceType = typeof(Resources))]
	[StringLength(25, ErrorMessageResourceName = "ErrorPostalCodeLengthIsLimitedToCharacters", ErrorMessageResourceType = typeof(Resources))]
	[XmlElement("PostalCode")]
	[Information(nameof(PostalCode), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string PostalCode
	{
		readonly get { return this._postalCode; }
		set
		{
			var safeValue = value ?? string.Empty;

			if (this._postalCode.FastCompare(safeValue))
			{
				return;
			}

			if (safeValue.HasValue(0, 25) is false)
			{
				ExceptionThrower.ThrowArgumentOutOfRangeException(
					Resources.ErrorPostalCodeLengthIsLimitedToCharacters, nameof(this.PostalCode));
			}
			else
			{
				this._postalCode = safeValue;
			}
		}
	}

	/// <summary>
	/// Gets or sets the state/region (0–60 chars).
	/// Never returns <c>null</c>; returns <c>string.Empty</c> if unset.
	/// </summary>
	/// <exception cref="ArgumentOutOfRangeException">
	/// Thrown if the value is not between 0 and 60 characters.
	/// </exception>
	[DataMember(Name = "state", IsRequired = false, Order = 8)]
	[Display(Name = "State")]
	[JsonPropertyName("state")]
	[MaxLength(60, ErrorMessageResourceName = "ErrorStateLengthIsLimitedToCharacters", ErrorMessageResourceType = typeof(Resources))]
	[StringLength(60, ErrorMessageResourceName = "ErrorStateLengthIsLimitedToCharacters", ErrorMessageResourceType = typeof(Resources))]
	[XmlElement("State")]
	[Information(nameof(State), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string State
	{
		readonly get { return this._state; }
		set
		{
			var safeValue = value ?? string.Empty;

			if (this._state.FastCompare(safeValue))
			{
				return;
			}

			if (safeValue.HasValue(0, 60) is false)
			{
				ExceptionThrower.ThrowArgumentOutOfRangeException(
					Resources.ErrorStateLengthIsLimitedToCharacters, nameof(this.State));
			}
			else
			{
				this._state = safeValue;
			}
		}
	}
}

