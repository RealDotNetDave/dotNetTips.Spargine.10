// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Tester
// Author           : David McCarter
// Created          : 01-03-2021
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-29-2026
// ***********************************************************************
// <copyright file="AddressRecord.cs" company="dotNetTips.com - McCarter Consulting">
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
using DotNetTips.Spargine.Tester.Properties;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Tester.Models.RefTypes;

/// <summary>
/// Represents an address record with detailed information such as
/// address lines, city, state, country, postal code, and phone.
/// Implements <see cref="IAddress{TSelf}"/> as
/// <c>IAddress&lt;AddressRecord&gt;</c>. Comparison/equality are by
/// <see cref="Id"/>.
/// </summary>
[DataContract(Name = "addressRecord", Namespace = "http://DotNetTips.Spargine.Tester.Models.Ref")]
[DebuggerDisplay("Id = {Id}, Address1 = {Address1}, City = {City}, Country = {Country}")]
[Serializable]
[XmlRoot(ElementName = "AddressRecord", Namespace = "http://DotNetTips.Spargine.Tester.Models.Ref")]
[Information(Status = Status.Available, Documentation = "https://bit.ly/SpargineTester")]
public sealed record AddressRecord : IAddress<AddressRecord>
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
	/// For serializers; prefer <see cref="Create(string)"/> or the
	/// full factory.
	/// </summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public AddressRecord()
	{
	}

	/// <summary>
	/// Creates a new instance with the specified <paramref name="id"/>.
	/// </summary>
	/// <param name="id">
	/// Unique identifier (10–50 chars).
	/// </param>
	/// <exception cref="ArgumentOutOfRangeException">
	/// Thrown if <paramref name="id"/> does not meet length
	/// requirements.
	/// </exception>
	[JsonConstructor]
	[Information(nameof(AddressRecord), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public AddressRecord([NotNull] string id)
	{
		this.Id = id;
	}

	/// <summary>
	/// Convenience constructor with full set of fields.
	/// </summary>
	/// <param name="id">Unique identifier (10–50 chars).</param>
	/// <param name="address1">First address line (0–100 chars).</param>
	/// <param name="address2">Second address line (0–100 chars).</param>
	/// <param name="city">City (0–150 chars).</param>
	/// <param name="state">State (0–60 chars).</param>
	/// <param name="countyProvince">County/Province (0–50 chars).</param>
	/// <param name="country">Country (0–50 chars).</param>
	/// <param name="postalCode">Postal code (0–40 chars).</param>
	/// <param name="phone">Phone number (0–50 chars).</param>
	/// <exception cref="ArgumentOutOfRangeException">
	/// Thrown if any property value does not meet its length
	/// requirements.
	/// </exception>
	public AddressRecord([NotNull] string id, string address1, string address2, string city, string state, string countyProvince, string country, string postalCode, string phone) : this(id)
	{
		this.Address1 = address1;
		this.Address2 = address2;
		this.City = city;
		this.Country = country;
		this.CountyProvince = countyProvince;
		this.Phone = phone;
		this.PostalCode = postalCode;
		this.State = state;
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
	[UnconditionalSuppressMessage("Trimming", "IL2026:Members annotated with 'RequiresUnreferencedCodeAttribute' require dynamic access otherwise can break functionality when trimming application code", Justification = "The Resources type is referenced directly via typeof(Resources) in the same assembly, ensuring it is preserved by the trimmer.")]
	[Information(nameof(Address1), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string Address1
	{
		get
		{
			return this._address1;
		}
		init
		{
			var safeValue = value ?? string.Empty;

			if (safeValue.HasValue(0, 100) is false)
			{
				ExceptionThrower.ThrowArgumentOutOfRangeException(
					Resources.ErrorAddressLengthIsLimitedToCharacters, nameof(this.Address1));
			}

			this._address1 = safeValue;
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
	[UnconditionalSuppressMessage("Trimming", "IL2026:Members annotated with 'RequiresUnreferencedCodeAttribute' require dynamic access otherwise can break functionality when trimming application code", Justification = "The Resources type is referenced directly via typeof(Resources) in the same assembly, ensuring it is preserved by the trimmer.")]
	[Information(nameof(Address2), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string Address2
	{
		get
		{
			return this._address2;
		}
		init
		{
			var safeValue = value ?? string.Empty;

			if (safeValue.HasValue(0, 100) is false)
			{
				ExceptionThrower.ThrowArgumentOutOfRangeException(
					Resources.ErrorAddressLengthIsLimitedToCharacters, nameof(this.Address2));
			}

			this._address2 = safeValue;
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
	[UnconditionalSuppressMessage("Trimming", "IL2026:Members annotated with 'RequiresUnreferencedCodeAttribute' require dynamic access otherwise can break functionality when trimming application code", Justification = "The Resources type is referenced directly via typeof(Resources) in the same assembly, ensuring it is preserved by the trimmer.")]
	[Information(nameof(City), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string City
	{
		get
		{
			return this._city;
		}
		init
		{
			var safeValue = value ?? string.Empty;

			if (safeValue.HasValue(0, 100) is false)
			{
				ExceptionThrower.ThrowArgumentOutOfRangeException(
					Resources.ErrorCityLengthIsLimitedToCharacters, nameof(this.City));
			}

			this._city = safeValue;
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
	[UnconditionalSuppressMessage("Trimming", "IL2026:Members annotated with 'RequiresUnreferencedCodeAttribute' require dynamic access otherwise can break functionality when trimming application code", Justification = "The Resources type is referenced directly via typeof(Resources) in the same assembly, ensuring it is preserved by the trimmer.")]
	[Information(nameof(Country), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string Country
	{
		get
		{
			return this._country;
		}
		init
		{
			var safeValue = value ?? string.Empty;

			if (safeValue.HasValue(0, 55) is false)
			{
				ExceptionThrower.ThrowArgumentOutOfRangeException(
					Resources.ErrorCountryLengthIsLimitedToCharacters, nameof(this.Country));
			}

			this._country = safeValue;
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
	[UnconditionalSuppressMessage("Trimming", "IL2026:Members annotated with 'RequiresUnreferencedCodeAttribute' require dynamic access otherwise can break functionality when trimming application code", Justification = "The Resources type is referenced directly via typeof(Resources) in the same assembly, ensuring it is preserved by the trimmer.")]
	[Information(nameof(CountyProvince), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string CountyProvince
	{
		get
		{
			return this._countyProvince;
		}
		init
		{
			var safeValue = value ?? string.Empty;


			if (safeValue.HasValue(0, 60) is false)
			{
				ExceptionThrower.ThrowArgumentOutOfRangeException(
					Resources.ErrorCountyProvinceLengthIsLimitedToCharacter, nameof(this.CountyProvince));
			}

			this._countyProvince = safeValue;
		}
	}

	/// <summary>
	/// Gets the unique identifier (init-only; 10–50 chars).
	/// </summary>
	/// <exception cref="ArgumentOutOfRangeException">
	/// Thrown if the value is not between 10 and 50 characters.
	/// </exception>
	[DataMember(Name = "id", IsRequired = true, Order = 0)]
	[DisallowNull]
	[Display(Name = "Identifier")]
	[JsonPropertyName("id")]
	[MaxLength(50, ErrorMessageResourceName = "ErrorIdLengthIsLimitedToCharacters", ErrorMessageResourceType = typeof(Resources))]
	[MinLength(10, ErrorMessageResourceName = "ErrorIdLengthIsMinimumCharacters", ErrorMessageResourceType = typeof(Resources))]
	[ReadOnly(true)]
	[Required(AllowEmptyStrings = false, ErrorMessageResourceName = "ErrorIdIsRequired", ErrorMessageResourceType = typeof(Resources))]
	[XmlElement("Id", IsNullable = false)]
	[UnconditionalSuppressMessage("Trimming", "IL2026:Members annotated with 'RequiresUnreferencedCodeAttribute' require dynamic access otherwise can break functionality when trimming application code", Justification = "The Resources type is referenced directly via typeof(Resources) in the same assembly, ensuring it is preserved by the trimmer.")]
	[Information(nameof(Id), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string Id
	{
		get
		{
			return this._id;
		}
		init
		{
			if (value.HasValue(10, 50) is false)
			{
				ExceptionThrower.ThrowArgumentOutOfRangeException(
					Resources.ErrorIdLengthIsLimitedToCharacters, nameof(this.Id));
			}

			this._id = value;
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
	[UnconditionalSuppressMessage("Trimming", "IL2026:Members annotated with 'RequiresUnreferencedCodeAttribute' require dynamic access otherwise can break functionality when trimming application code", Justification = "The Resources type is referenced directly via typeof(Resources) in the same assembly, ensuring it is preserved by the trimmer.")]
	[Information(nameof(Phone), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string Phone
	{
		get
		{
			return this._phone;
		}
		init
		{
			var safeValue = value ?? string.Empty;

			if (safeValue.HasValue(0, 50) is false)
			{
				ExceptionThrower.ThrowArgumentOutOfRangeException(
					Resources.ErrorMessagePhoneNumberIsLimitedToCharacters, nameof(this.Phone));
			}

			this._phone = safeValue;
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
	[UnconditionalSuppressMessage("Trimming", "IL2026:Members annotated with 'RequiresUnreferencedCodeAttribute' require dynamic access otherwise can break functionality when trimming application code", Justification = "The Resources type is referenced directly via typeof(Resources) in the same assembly, ensuring it is preserved by the trimmer.")]
	[Information(nameof(PostalCode), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string PostalCode
	{
		get
		{
			return this._postalCode;
		}
		init
		{
			var safeValue = value ?? string.Empty;

			if (safeValue.HasValue(0, 25) is false)
			{
				ExceptionThrower.ThrowArgumentOutOfRangeException(
					Resources.ErrorPostalCodeLengthIsLimitedToCharacters, nameof(this.PostalCode));
			}

			this._postalCode = safeValue;
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
	[UnconditionalSuppressMessage("Trimming", "IL2026:Members annotated with 'RequiresUnreferencedCodeAttribute' require dynamic access otherwise can break functionality when trimming application code", Justification = "The Resources type is referenced directly via typeof(Resources) in the same assembly, ensuring it is preserved by the trimmer.")]
	[Information(nameof(State), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string State
	{
		get
		{
			return this._state;
		}
		init
		{
			var safeValue = value ?? string.Empty;

			if (safeValue.HasValue(0, 60) is false)
			{
				ExceptionThrower.ThrowArgumentOutOfRangeException(
					Resources.ErrorStateLengthIsLimitedToCharacters, nameof(this.State));
			}

			this._state = safeValue;
		}
	}

	/// <summary>
	/// Explicit conversion from <see cref="Address"/>.
	/// </summary>
	/// <param name="address">The <see cref="Address"/> to convert.</param>
	/// <returns>
	/// An <see cref="AddressRecord"/> instance.
	/// </returns>
	public static explicit operator AddressRecord(Address address) => ToAddress(address);

	/// <summary>
	/// Explicit conversion from <see cref="ValueTypes.Address"/>.
	/// </summary>
	/// <param name="address">The <see cref="ValueTypes.Address"/> to convert.</param>
	/// <returns>
	/// An <see cref="AddressRecord"/> instance.
	/// </returns>
	[return: NotNull]
	public static explicit operator AddressRecord(ValueTypes.Address address) => ToAddress(address);

	/// <summary>
	/// Greater-than-or-equal operator (identity compare).
	/// </summary>
	/// <param name="left">Left <see cref="AddressRecord"/>.</param>
	/// <param name="right">Right <see cref="AddressRecord"/>.</param>
	/// <returns>
	/// True if left is greater than or equal to right.
	/// </returns>
	[DebuggerStepThrough]
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool operator >=(in AddressRecord? left, in AddressRecord? right)
	{
		return right is null ? true : left is null ? false : left.CompareTo(right) >= 0;
	}

	/// <summary>
	/// Greater-than operator (identity compare).
	/// </summary>
	/// <param name="left">Left <see cref="AddressRecord"/>.</param>
	/// <param name="right">Right <see cref="AddressRecord"/>.</param>
	/// <returns>
	/// True if left is greater than right.
	/// </returns>
	[DebuggerStepThrough]
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool operator >(in AddressRecord? left, in AddressRecord? right)
	{
		return left is null ? false : right is null ? true : left.CompareTo(right) > 0;
	}

	/// <summary>
	/// Less-than-or-equal operator (identity compare).
	/// </summary>
	/// <param name="left">Left <see cref="AddressRecord"/>.</param>
	/// <param name="right">Right <see cref="AddressRecord"/>.</param>
	/// <returns>
	/// True if left is less than or equal to right.
	/// </returns>
	[DebuggerStepThrough]
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool operator <=(in AddressRecord? left, in AddressRecord? right)
	{
		return left is null ? true : right is null ? false : left.CompareTo(right) <= 0;
	}

	/// <summary>
	/// Less-than operator (identity compare).
	/// </summary>
	/// <param name="left">Left <see cref="AddressRecord"/>.</param>
	/// <param name="right">Right <see cref="AddressRecord"/>.</param>
	/// <returns>
	/// True if left is less than right.
	/// </returns>
	[DebuggerStepThrough]
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool operator <(in AddressRecord? left, in AddressRecord? right)
	{
		return left is null ? right is not null : right is null ? false : left.CompareTo(right) < 0;
	}

	/// <summary>
	/// Creates a new <see cref="AddressRecord"/> with only the
	/// identifier (required by <see cref="IDataModel{TSelf,TKey}"/>).
	/// </summary>
	/// <param name="id">Unique identifier (10–50 chars).</param>
	/// <returns>
	/// A new <see cref="AddressRecord"/> instance.
	/// </returns>
	/// <exception cref="ArgumentOutOfRangeException">
	/// Thrown if <paramref name="id"/> does not meet length
	/// requirements.
	/// </exception>
	public static AddressRecord Create(string id)
	{
		return new AddressRecord(id);
	}

	/// <summary>
	/// Creates a new <see cref="AddressRecord"/> with the specified
	/// values (required by <see cref="IAddress{TSelf}"/>).
	/// </summary>
	/// <param name="id">Unique identifier (10–50 chars).</param>
	/// <param name="address1">First address line (0–100 chars).</param>
	/// <param name="city">City (0–150 chars).</param>
	/// <param name="country">Country (0–50 chars).</param>
	/// <param name="postalCode">Postal code (0–40 chars).</param>
	/// <param name="address2">Second address line (optional).</param>
	/// <param name="countyProvince">County/Province (optional).</param>
	/// <param name="state">State (optional).</param>
	/// <param name="phone">Phone number (optional).</param>
	/// <returns>
	/// A new <see cref="AddressRecord"/> instance.
	/// </returns>
	/// <exception cref="ArgumentOutOfRangeException">
	/// Thrown if any property value does not meet its length
	/// requirements.
	/// </exception>
	public static AddressRecord Create(string id, string address1, string city, string country, string postalCode, string? address2 = null, string? countyProvince = null, string? state = null, string? phone = null)
	{
		return new AddressRecord(id)
		{
			Address1 = address1,
			City = city,
			Country = country,
			PostalCode = postalCode,
			Address2 = address2 ?? string.Empty,
			CountyProvince = countyProvince ?? string.Empty,
			State = state ?? string.Empty,
			Phone = phone ?? string.Empty
		};
	}

	/// <summary>
	/// Converts a reference <see cref="Address"/> to
	/// <see cref="AddressRecord"/>.
	/// </summary>
	/// <param name="address">
	/// The <see cref="Address"/> to convert.
	/// </param>
	/// <returns>
	/// An <see cref="AddressRecord"/> instance.
	/// </returns>
	/// <exception cref="ArgumentNullException">
	/// Thrown if <paramref name="address"/> is null.
	/// </exception>
	[UnconditionalSuppressMessage("Trimming", "IL2026:Members annotated with 'RequiresUnreferencedCodeAttribute' require dynamic access otherwise can break functionality when trimming application code", Justification = "Address is a statically known type in the same assembly; the trimmer preserves all required members.")]
	[Information(nameof(ToAddress), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static AddressRecord ToAddress([NotNull] in Address address)
	{
		_ = address.ArgumentNotNull();

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
	/// Converts a value <see cref="ValueTypes.Address"/> to
	/// <see cref="AddressRecord"/>.
	/// </summary>
	/// <param name="address">
	/// The <see cref="ValueTypes.Address"/> to convert.
	/// </param>
	/// <returns>
	/// An <see cref="AddressRecord"/> instance.
	/// </returns>
	/// <exception cref="ArgumentNullException">
	/// Thrown if <paramref name="address"/> is null.
	/// </exception>
	[Information(nameof(ToAddress), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static AddressRecord ToAddress([NotNull] in ValueTypes.Address address)
	{
		_ = address.ArgumentNotNull();

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
	/// Non-generic comparison required by <see cref="IComparable"/>.
	/// </summary>
	/// <param name="obj">Object to compare.</param>
	/// <returns>
	/// Value indicating the relative order of the objects.
	/// </returns>
	/// <exception cref="ArgumentException">
	/// Thrown when <paramref name="obj"/> is not an
	/// <see cref="AddressRecord"/>.
	/// </exception>
	[Information(nameof(CompareTo), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	int IComparable.CompareTo(object? obj)
	{
		return obj is null
			? 1
			: obj is AddressRecord other
			? this.CompareTo(other)
			: throw new ArgumentException($"Object must be of type {nameof(AddressRecord)}", nameof(obj));
	}

	/// <summary>
	/// Compares this instance with another <see cref="AddressRecord"/>
	/// using ordinal <see cref="Id"/>.
	/// </summary>
	/// <param name="other">Other <see cref="AddressRecord"/>.</param>
	/// <returns>
	/// Value indicating the relative order of the objects.
	/// </returns>
	[Information(nameof(CompareTo), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public int CompareTo(in AddressRecord? other)
	{
		return other is null ? 1 : string.Compare(this.Id, other.Id, StringComparison.Ordinal);
	}

	/// <summary>
	/// Determines equality with another <see cref="AddressRecord"/>
	/// using ordinal <see cref="Id"/>.
	/// </summary>
	/// <param name="other">Other <see cref="AddressRecord"/>.</param>
	/// <returns>
	/// True if equal, otherwise false.
	/// </returns>
	[Information(nameof(Equals), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public bool Equals(in AddressRecord? other)
	{
		return ReferenceEquals(this, other) ? true : other is not null && string.Equals(this.Id, other.Id, StringComparison.Ordinal);
	}

	/// <inheritdoc />
	public override int GetHashCode()
	{
		return this.Id?.GetHashCode(StringComparison.Ordinal) ?? 0;
	}

	/// <summary>
	/// Debug-friendly string via project helper.
	/// </summary>
	/// <returns>
	/// A string representation of the address record.
	/// </returns>
	[Information(nameof(ToString), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public override string ToString()
	{
#pragma warning disable IL2026 // PropertiesToString uses reflection — suppressed because ToString must match base signature
		return this.PropertiesToString();
#pragma warning restore IL2026
	}
}
