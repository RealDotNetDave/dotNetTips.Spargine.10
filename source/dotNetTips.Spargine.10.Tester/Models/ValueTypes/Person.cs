// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Tester
// Author           : David McCarter
// Created          : 10-25-2021
//
// Last Modified By : David McCarter
// Last Modified On : 11-21-2025
// ***********************************************************************
// <copyright file="Person.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Represents an immutable value type for a person, designed for testing and benchmarking.
// Includes identity, contact information, and a collection of addresses.
// Implements <see cref="IPerson{Person, Address}"/> with comparison and equality by <see cref="Id"/>.
// Properties include Addresses, Age, BornOn, CellPhone, Email, FirstName, FullName, LastName, and Phone.
// </summary>
// ***********************************************************************
using System.Collections.ObjectModel;
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
/// Represents a person value type with identity, contact info, and
/// a collection of addresses. Implements
/// <see cref="IPerson{TSelf, TAddress}"/> as
/// <c>IPerson&lt;Person, Address&gt;</c>. Comparison and equality
/// are by <see cref="Id"/>.
/// </summary>
[DataContract(Name = "person", Namespace = "http://DotNetTips.Spargine.Tester.Models.Val")]
[DebuggerDisplay("{Email}")]
[Serializable]
[XmlRoot(ElementName = "Person", Namespace = "http://DotNetTips.Spargine.Tester.Models.Val")]
[Information(Status = Status.UpdateDocumentation, Documentation = "https://bit.ly/SpargineTester")]
[method: EditorBrowsable(EditorBrowsableState.Never)]
public struct Person() : IPerson<Person, Address>
{
	[JsonIgnore, NonSerialized] private Collection<Address> _addresses = [];
	[JsonIgnore, NonSerialized] private DateTimeOffset? _bornOn;
	[JsonIgnore, NonSerialized] private string _cellPhone = string.Empty;
	[JsonIgnore, NonSerialized] private string _email = string.Empty;
	[JsonIgnore, NonSerialized] private string _firstName = string.Empty;
	[JsonIgnore, NonSerialized] private string _id = string.Empty;
	[JsonIgnore, NonSerialized] private string _lastName = string.Empty;
	[JsonIgnore, NonSerialized] private string _phone = string.Empty;

	/// <summary>
	/// Initializes a new instance of the <see cref="Person"/> class
	/// with the specified email and id.
	/// </summary>
	/// <param name="email">
	/// The email address. Must be a valid email format and not exceed
	/// 75 characters.
	/// </param>
	/// <param name="id">
	/// The unique identifier. Must not exceed 50 characters.
	/// </param>
	/// <exception cref="ArgumentOutOfRangeException">
	/// Thrown if <paramref name="email"/> or <paramref name="id"/>
	/// do not meet length requirements.
	/// </exception>
	[JsonConstructor]
	[Information(nameof(Person), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public Person([NotNull] string email, [NotNull] string id) : this()
	{
		this.Id = id;
		this.Email = email;
	}

	/// <summary>
	/// Inequality operator (identity).
	/// </summary>
	/// <param name="left">Left <see cref="Person"/>.</param>
	/// <param name="right">Right <see cref="Person"/>.</param>
	/// <returns>True if not equal, otherwise false.</returns>
	[DebuggerStepThrough]
	public static bool operator !=(Person left, Person right) => !(left == right);

	/// <summary>
	/// Less-than operator (identity compare).
	/// </summary>
	/// <param name="left">Left <see cref="Person"/>.</param>
	/// <param name="right">Right <see cref="Person"/>.</param>
	/// <returns>True if left is less than right.</returns>
	[DebuggerStepThrough]
	public static bool operator <(Person left, Person right) => left.CompareTo(right) < 0;

	/// <summary>
	/// Less-than-or-equal operator (identity compare).
	/// </summary>
	/// <param name="left">Left <see cref="Person"/>.</param>
	/// <param name="right">Right <see cref="Person"/>.</param>
	/// <returns>True if left is less than or equal to right.</returns>
	[DebuggerStepThrough]
	public static bool operator <=(Person left, Person right) => left.CompareTo(right) <= 0;

	/// <summary>
	/// Equality operator (identity).
	/// </summary>
	/// <param name="left">Left <see cref="Person"/>.</param>
	/// <param name="right">Right <see cref="Person"/>.</param>
	/// <returns>True if equal, otherwise false.</returns>
	[DebuggerStepThrough]
	public static bool operator ==(Person left, Person right) => left.Equals(right);

	/// <summary>
	/// Greater-than operator (identity compare).
	/// </summary>
	/// <param name="left">Left <see cref="Person"/>.</param>
	/// <param name="right">Right <see cref="Person"/>.</param>
	/// <returns>True if left is greater than right.</returns>
	[DebuggerStepThrough]
	public static bool operator >(Person left, Person right) => left.CompareTo(right) > 0;

	/// <summary>
	/// Greater-than-or-equal operator (identity compare).
	/// </summary>
	/// <param name="left">Left <see cref="Person"/>.</param>
	/// <param name="right">Right <see cref="Person"/>.</param>
	/// <returns>True if left is greater than or equal to right.</returns>
	[DebuggerStepThrough]
	public static bool operator >=(Person left, Person right) => left.CompareTo(right) >= 0;

	/// <summary>
	/// Explicitly converts a <see cref="PersonRecord"/> to a
	/// <see cref="Person"/>.
	/// </summary>
	/// <param name="person">The <see cref="PersonRecord"/> to convert.</param>
	/// <returns>A new <see cref="Person"/> instance.</returns>
	/// <exception cref="ArgumentNullException">
	/// Thrown if <paramref name="person"/> is null.
	/// </exception>
	[return: NotNull]
	public static explicit operator Person(in PersonRecord person) => ToPerson(person);

	/// <summary>
	/// Explicitly converts a <see cref="RefTypes.Person"/> to a
	/// <see cref="Person"/>.
	/// </summary>
	/// <param name="refPerson">The <see cref="RefTypes.Person"/> to convert.</param>
	/// <returns>A <see cref="Person"/> instance.</returns>
	/// <exception cref="ArgumentNullException">
	/// Thrown if <paramref name="refPerson"/> is null.
	/// </exception>
	public static explicit operator Person(in RefTypes.Person refPerson) => ToPerson(refPerson);

	/// <summary>
	/// Non-generic comparison required by <see cref="IComparable"/>.
	/// </summary>
	/// <param name="obj">Object to compare.</param>
	/// <returns>
	/// Value indicating the relative order of the objects.
	/// </returns>
	/// <exception cref="ArgumentException">
	/// Thrown when <paramref name="obj"/> is not a <see cref="Person"/>.
	/// </exception>
	readonly int IComparable.CompareTo(object? obj)
	{
		if (obj is null)
		{
			return 1;
		}

		if (obj is Person other)
		{
			return this.CompareTo(other);
		}

		throw new ArgumentException($"Object must be of type {nameof(Person)}", nameof(obj));
	}

	/// <summary>
	/// Compares this instance with another <see cref="Person"/>
	/// using ordinal <see cref="Id"/>.
	/// </summary>
	/// <param name="other">Other <see cref="Person"/>.</param>
	/// <returns>
	/// Value indicating the relative order of the objects.
	/// </returns>
	public readonly int CompareTo(Person other)
	{
		return string.Compare(this.Id, other.Id, StringComparison.Ordinal);
	}

	/// <summary>
	/// Creates a new <see cref="Person"/> with the specified values.
	/// </summary>
	/// <param name="id">The unique identifier for the person.</param>
	/// <param name="email">The email address of the person.</param>
	/// <param name="firstName">The first name of the person.</param>
	/// <param name="lastName">The last name of the person.</param>
	/// <param name="bornOn">The birth date of the person.</param>
	/// <param name="addresses">The collection of addresses.</param>
	/// <param name="cellPhone">The cell phone number.</param>
	/// <param name="phone">The home phone number.</param>
	/// <returns>A new <see cref="Person"/> instance.</returns>
	/// <exception cref="ArgumentOutOfRangeException">
	/// Thrown if any property value does not meet its length
	/// requirements.
	/// </exception>
	public static Person Create(string id, string email, string firstName, string lastName, DateTimeOffset? bornOn, Collection<Address>? addresses = null, string? cellPhone = null, string? phone = null)
	{
		return new Person(email, id)
		{
			FirstName = firstName,
			LastName = lastName,
			BornOn = bornOn,
			Addresses = addresses ?? [],
			CellPhone = cellPhone ?? string.Empty,
			Phone = phone ?? string.Empty
		};
	}

	/// <summary>
	/// Determines equality with another <see cref="Person"/>
	/// using ordinal <see cref="Id"/>.
	/// </summary>
	/// <param name="other">Other <see cref="Person"/>.</param>
	/// <returns>True if equal, otherwise false.</returns>
	public readonly bool Equals(Person other)
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
		return obj is Person other && this.Equals(other);
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
	/// Converts a <see cref="PersonRecord"/> to a <see cref="Person"/>.
	/// </summary>
	/// <param name="person">The <see cref="PersonRecord"/> to convert.</param>
	/// <returns>A new <see cref="Person"/> instance.</returns>
	/// <exception cref="ArgumentNullException">
	/// Thrown if <paramref name="person"/> is null.
	/// </exception>
	[return: NotNull]
	public static Person ToPerson([NotNull] in PersonRecord person)
	{
		_ = person.ArgumentNotNull();

		Person newPerson = new(person.Email, person.Id)
		{
			FirstName = person.FirstName,
			LastName = person.LastName,
			BornOn = person.BornOn,
			CellPhone = person.CellPhone,
			Phone = person.Phone,
		};

		if (person.Addresses.IsNotEmpty())
		{
			foreach (var address in person.Addresses)
			{
				newPerson.Addresses.Add(Address.ToAddress(address));
			}
		}

		return newPerson;
	}

	/// <summary>
	/// Converts a <see cref="RefTypes.Person"/> to a <see cref="Person"/>.
	/// </summary>
	/// <param name="person">The <see cref="RefTypes.Person"/> to convert.</param>
	/// <returns>A new <see cref="Person"/> instance.</returns>
	/// <exception cref="ArgumentNullException">
	/// Thrown if <paramref name="person"/> is null.
	/// </exception>
	[return: NotNull]
	public static Person ToPerson([NotNull] in RefTypes.Person person)
	{
		_ = person.ArgumentNotNull();

		var newPerson = new Person(person.Email, person.Id)
		{
			FirstName = person.FirstName,
			LastName = person.LastName,
			BornOn = person.BornOn,
			CellPhone = person.CellPhone,
			Phone = person.Phone
		};

		if (person.Addresses.IsNotEmpty())
		{
			foreach (var address in person.Addresses)
			{
				newPerson.Addresses.Add(Address.ToAddress(address));
			}
		}

		return newPerson;
	}

	/// <summary>
	/// String representation via helper.
	/// </summary>
	/// <returns>
	/// A string representation of the person.
	/// </returns>
	[Information(nameof(ToString), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public override string ToString()
	{
		return this.PropertiesToString();
	}

	/// <summary>
	/// Gets or sets the collection of addresses.
	/// Setter defensively copies the collection.
	/// </summary>
	[DataMember(Name = "addresses", IsRequired = false)]
	[JsonPropertyName("addresses")]
	[XmlIgnore]
	[Information(nameof(Addresses), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public Collection<Address> Addresses
	{
		readonly get
		{
			return this._addresses;
		}
		set
		{
			if (value is null)
			{
				this._addresses = [];
				return;
			}

			if (ReferenceEquals(this._addresses, value))
			{
				return;
			}

			this._addresses = [.. value];
		}
	}

	/// <summary>
	/// Gets or sets the addresses for XML serialization only.
	/// </summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	[JsonIgnore]
	[XmlArray("Addresses")]
	[Preserve(PreserveReason.Other, "Preserve for XML serialization.", "4/24/2005", "David McCarter")]
	[Information(nameof(AddressesSerialization), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public readonly Collection<Address> AddressesSerialization
	{
		get { return new Collection<Address>([.. this._addresses]); }
	}

	/// <summary>
	/// Gets or sets the birth date; must not be in the future.
	/// </summary>
	/// <exception cref="ArgumentOutOfRangeException">
	/// Thrown if the value is in the future.
	/// </exception>
	[DataMember(Name = "bornOn", IsRequired = false)]
	[DataType(DataType.Date, ErrorMessageResourceName = "ErrorMessageBornOnMustBeDate", ErrorMessageResourceType = typeof(Resources))]
	[JsonPropertyName("bornOn")]
	[XmlElement("BornOn")]
	[Information(nameof(BornOn), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public DateTimeOffset? BornOn
	{
		readonly get { return this._bornOn; }
		set
		{
			if (this._bornOn == value)
			{
				return;
			}

			if (value > DateTimeOffset.UtcNow)
			{
				ExceptionThrower.ThrowArgumentOutOfRangeException(
					Resources.ErrorMessageBornOnCannotBeInTheFuture, nameof(this.BornOn));
			}
			else
			{
				this._bornOn = value;
			}
		}
	}

	/// <summary>
	/// Gets or sets the optional cell phone (0–50 chars).
	/// </summary>
	/// <exception cref="ArgumentOutOfRangeException">
	/// Thrown if the value is not between 0 and 50 chars.
	/// </exception>
	[DataMember(Name = "cellPhone", IsRequired = false)]
	[JsonPropertyName("cellPhone")]
	[MaxLength(50, ErrorMessageResourceName = "ErrorMessagePhoneNumberIsLimitedToCharacters", ErrorMessageResourceType = typeof(Resources))]
	[Phone(ErrorMessageResourceName = "ErrorMessagePhoneNumberIsLimitedToCharacters", ErrorMessageResourceType = typeof(Resources))]
	[XmlElement("CellPhone")]
	[Information(nameof(CellPhone), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string CellPhone
	{
		readonly get { return this._cellPhone!; }
		set
		{
			var safeValue = value ?? string.Empty;

			if (this._cellPhone.FastCompare(safeValue))
			{
				return;
			}

			if (safeValue.HasValue(0, 50) is false)
			{
				ExceptionThrower.ThrowArgumentOutOfRangeException(
					Resources.ErrorMessagePhoneNumberIsLimitedToCharacters, nameof(this.CellPhone));
			}
			else
			{
				this._cellPhone = safeValue;
			}
		}
	}

	/// <summary>
	/// Gets the email (init-only; ≤ 75; valid email format).
	/// </summary>
	/// <exception cref="ArgumentNullException">
	/// Thrown if the value is null or empty.
	/// </exception>
	/// <exception cref="ArgumentOutOfRangeException">
	/// Thrown if the value is not between 10 and 75 chars.
	/// </exception>
	[DataMember(Name = "email", IsRequired = true)]
	[EmailAddress(ErrorMessageResourceName = "ErrorMessageEmailLengthIsLimitedToCharacters", ErrorMessageResourceType = typeof(Resources))]
	[JsonPropertyName("email")]
	[MaxLength(75, ErrorMessageResourceName = "ErrorMessageEmailLengthIsLimitedToCharacters", ErrorMessageResourceType = typeof(Resources))]
	[Required(ErrorMessageResourceName = "ErrorMessageEmailIsRequired", ErrorMessageResourceType = typeof(Resources))]
	[XmlElement("Email", IsNullable = false)]
	[Information(nameof(Email), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string Email
	{
		readonly get { return this._email; }
		init
		{
			if (value is null)
			{
				ExceptionThrower.ThrowArgumentNullException(nameof(this.Email));
			}

			if (value.HasValue(10, 75) is false)
			{
				ExceptionThrower.ThrowArgumentOutOfRangeException(
					Resources.ErrorMessageEmailLengthIsLimitedToCharacters, nameof(this.Email));
			}
			else
			{
				this._email = value;
			}
		}
	}

	/// <summary>
	/// Gets or sets the first name (0–50 chars).
	/// </summary>
	/// <exception cref="ArgumentOutOfRangeException">
	/// Thrown if the value is not between 0 and 50 chars.
	/// </exception>
	[DataMember(Name = "firstName", IsRequired = true)]
	[JsonPropertyName("firstName")]
	[MaxLength(50, ErrorMessageResourceName = "ErrorFirstNameLengthIsLimitedToCharacters", ErrorMessageResourceType = typeof(Resources))]
	[Required(ErrorMessageResourceName = "ErrorFirstNameIsRequired", ErrorMessageResourceType = typeof(Resources))]
	[StringLength(50, ErrorMessageResourceName = "ErrorFirstNameLengthIsLimitedToCharacters", ErrorMessageResourceType = typeof(Resources))]
	[XmlElement("FirstName")]
	[Information(nameof(FirstName), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string FirstName
	{
		readonly get { return this._firstName!; }
		set
		{
			var safeValue = value ?? string.Empty;

			if (this._firstName.FastCompare(safeValue, StringComparison.CurrentCultureIgnoreCase))
			{
				return;
			}

			if (safeValue.HasValue(0, 50) is false)
			{
				ExceptionThrower.ThrowArgumentOutOfRangeException(
					Resources.ErrorFirstNameLengthIsLimitedToCharacters, nameof(this.FirstName));
			}
			else
			{
				this._firstName = safeValue;
			}
		}
	}

	/// <summary>
	/// Gets the unique identifier (init-only; 10–50 chars).
	/// </summary>
	/// <exception cref="ArgumentOutOfRangeException">
	/// Thrown if the value is not between 10 and 50 characters.
	/// </exception>
	[DataMember(Name = "id", IsRequired = true)]
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
	/// Gets or sets the last name (0–50 chars).
	/// </summary>
	/// <exception cref="ArgumentOutOfRangeException">
	/// Thrown if the value is not between 0 and 50 chars.
	/// </exception>
	[DataMember(Name = "lastName", IsRequired = true)]
	[JsonPropertyName("lastName")]
	[MaxLength(50, ErrorMessageResourceName = "ErrorLastNameLengthIsLimitedToCharacters", ErrorMessageResourceType = typeof(Resources))]
	[Required(ErrorMessageResourceName = "ErrorLastNameIsRequired", ErrorMessageResourceType = typeof(Resources))]
	[StringLength(50, ErrorMessageResourceName = "ErrorLastNameLengthIsLimitedToCharacters", ErrorMessageResourceType = typeof(Resources))]
	[XmlElement("LastName")]
	[Information(nameof(LastName), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string LastName
	{
		readonly get { return this._lastName!; }
		set
		{
			var safeValue = value ?? string.Empty;

			if (this._lastName.FastCompare(safeValue))
			{
				return;
			}

			if (safeValue.HasValue(0, 50) is false)
			{
				ExceptionThrower.ThrowArgumentOutOfRangeException(
					Resources.ErrorLastNameLengthIsLimitedToCharacters, nameof(this.LastName));
			}
			else
			{
				this._lastName = safeValue;
			}
		}
	}

	/// <summary>
	/// Gets or sets the optional home phone (0–50 chars).
	/// </summary>
	/// <exception cref="ArgumentOutOfRangeException">
	/// Thrown if the value is not between 0 and 50 chars.
	/// </exception>
	[DataMember(Name = "homePhone", IsRequired = false)]
	[JsonPropertyName("homePhone")]
	[MaxLength(50, ErrorMessageResourceName = "ErrorMessagePhoneNumberIsLimitedToCharacters", ErrorMessageResourceType = typeof(Resources))]
	[Phone(ErrorMessageResourceName = "ErrorPhoneNumberInvalid", ErrorMessageResourceType = typeof(Resources))]
	[XmlElement("Phone")]
	[Information(nameof(Phone), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string Phone
	{
		readonly get { return this._phone!; }
		set
		{
			var safeValue = value ?? string.Empty;

			if (this._phone.FastCompare(safeValue, StringComparison.CurrentCultureIgnoreCase))
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
}

