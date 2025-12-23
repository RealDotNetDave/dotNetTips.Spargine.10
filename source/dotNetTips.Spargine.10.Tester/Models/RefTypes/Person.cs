// ***********************************************************************
// Assembly         : dotNetTips.Spargine8.Tester
// Author           : David McCarter
// Created          : 07-17-2019
//
// Last Modified By : David McCarter
// Last Modified On : 11-17-2025
// ***********************************************************************
// <copyright file="Person.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// A real-world type for testing and benchmarking named "Person" with
// the following properties: Addresses, Age, BornOn, CellPhone,
// Email, FirstName, FullName, LastName, and Phone. This type also
// includes methods to convert from PersonRecord and Person value
// types to Person.
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
using DotNetTips.Spargine.Tester.Properties;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Tester.Models.RefTypes;

/// <summary>
/// Represents a person with identity, contact info, and addresses.
/// </summary>
/// <remarks>
/// Implements <see cref="IPerson{TSelf, TAddress}"/> as
/// <c>IPerson&lt;Person, Address&gt;</c>. The requirements from
/// <see cref="IDataModel{T, TKey}"/> (comparison and equality)
/// flow through that interface.
/// </remarks>
[DataContract(Name = "person", Namespace = "http://DotNetTips.Spargine.Tester.Models.Ref")]
[DebuggerDisplay("{Email}")]
[Serializable]
[XmlRoot(ElementName = "Person", Namespace = "http://DotNetTips.Spargine.Tester.Models.Ref")]
[Information(Status = Status.UpdateDocumentation, Documentation = "https://bit.ly/SpargineTester")]
public sealed class Person : IPerson<Person, Address>
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
	/// For serializers.
	/// </summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public Person()
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="Person"/> class
	/// with the specified email and id.
	/// </summary>
	/// <param name="email">
	/// The email address of the person. Must be a valid email format and
	/// not exceed 75 characters.
	/// </param>
	/// <param name="id">
	/// The unique identifier for the person. Must not exceed 50
	/// characters.
	/// </param>
	/// <exception cref="ArgumentOutOfRangeException">
	/// Thrown if <paramref name="email"/> or <paramref name="id"/> do
	/// not meet length requirements.
	/// </exception>
	[JsonConstructor]
	[Information(nameof(IPerson<,>), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public Person([NotNull] string email, [NotNull] string id)
	{
		this.Email = email;
		this.Id = id;
	}

	/// <summary>
	/// Inequality operator (identity).
	/// </summary>
	/// <param name="left">Left <see cref="Person"/>.</param>
	/// <param name="right">Right <see cref="Person"/>.</param>
	/// <returns>True if not equal, otherwise false.</returns>
	public static bool operator !=(in Person? left, in Person? right)
	{
		return !(left == right);
	}

	/// <summary>
	/// Less-than operator (identity compare).
	/// </summary>
	/// <param name="left">Left <see cref="Person"/>.</param>
	/// <param name="right">Right <see cref="Person"/>.</param>
	/// <returns>True if left is less than right.</returns>
	public static bool operator <(in Person? left, in Person? right)
	{
		return left is null ? right is not null : right is null ? false : left.CompareTo(right) < 0;
	}

	/// <summary>
	/// Less-than-or-equal operator (identity compare).
	/// </summary>
	/// <param name="left">Left <see cref="Person"/>.</param>
	/// <param name="right">Right <see cref="Person"/>.</param>
	/// <returns>True if left is less than or equal to right.</returns>
	public static bool operator <=(in Person? left, in Person? right)
	{
		return left is null ? true : right is null ? false : left.CompareTo(right) <= 0;
	}

	/// <summary>
	/// Equality operator (identity).
	/// </summary>
	/// <param name="left">Left <see cref="Person"/>.</param>
	/// <param name="right">Right <see cref="Person"/>.</param>
	/// <returns>True if equal, otherwise false.</returns>
	public static bool operator ==(in Person? left, in Person? right)
	{
		return EqualityComparer<Person>.Default.Equals(left, right);
	}

	/// <summary>
	/// Greater-than operator (identity compare).
	/// </summary>
	/// <param name="left">Left <see cref="Person"/>.</param>
	/// <param name="right">Right <see cref="Person"/>.</param>
	/// <returns>True if left is greater than right.</returns>
	public static bool operator >(in Person? left, in Person? right)
	{
		return left is null ? false : right is null ? true : left.CompareTo(right) > 0;
	}

	/// <summary>
	/// Greater-than-or-equal operator (identity compare).
	/// </summary>
	/// <param name="left">Left <see cref="Person"/>.</param>
	/// <param name="right">Right <see cref="Person"/>.</param>
	/// <returns>True if left is greater than or equal to right.</returns>
	public static bool operator >=(in Person? left, in Person? right)
	{
		return right is null ? true : left is null ? false : left.CompareTo(right) >= 0;
	}

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
	int IComparable.CompareTo(object? obj)
	{
		return obj is null
			? 1
			: obj is Person other
			? this.CompareTo(other)
			: throw new ArgumentException($"Object must be of type {nameof(Person)}", nameof(obj));
	}

	/// <summary>
	/// Compares this instance with another <see cref="Person"/>
	/// using ordinal <see cref="Id"/>.
	/// </summary>
	/// <param name="other">Other <see cref="Person"/>.</param>
	/// <returns>
	/// Value indicating the relative order of the objects.
	/// </returns>
	public int CompareTo(in Person? other)
	{
		return other is null ? 1 : string.Compare(this.Id, other.Id, StringComparison.Ordinal);
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
	public static Person Create(string id, string email, string firstName, string lastName, DateTimeOffset? bornOn, Collection<Address>? addresses = null, string? cellPhone = null, string? phone = null)
	{
		return new Person(id, email)
		{
			FirstName = firstName ?? string.Empty,
			LastName = lastName ?? string.Empty,
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
	public bool Equals(in Person? other)
	{
		return ReferenceEquals(this, other) ? true : other is not null && string.Equals(this.Id, other.Id, StringComparison.Ordinal);
	}

	/// <inheritdoc />
	public override bool Equals(object? obj)
	{
		return ReferenceEquals(this, obj) ? true : obj is Person other && this.Equals(other);
	}

	/// <inheritdoc />
	public override int GetHashCode()
	{
		return this.Id?.GetHashCode(StringComparison.Ordinal) ?? 0;
	}


	/// <summary>
	/// Converts to <see cref="ValueTypes.Person"/> to <see cref="Person"/>.
	/// </summary>
	/// <param name="person">The person.</param>
	/// <returns>DotNetTips.Spargine.Tester.Models.RefTypes.Person.</returns>
	[return: NotNull]
	[Information(nameof(ToPerson), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static Person ToPerson(in ValueTypes.Person person)
	{
		_ = person.ArgumentNotNull();

		Person newPerson = new()
		{
			Id = person.Id,
			Email = person.Email,
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
	/// Converts a <see cref="PersonRecord"/> to a <see cref="Person"/>.
	/// </summary>
	/// <param name="person">The <see cref="PersonRecord"/> to convert.</param>
	/// <returns>A new instance of <see cref="Person"/> based on the provided <see cref="PersonRecord"/>.</returns>
	[return: NotNull]
	[Information(nameof(ToPerson), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
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
	/// Returns a string representation of the <see cref="Person"/>.
	/// </summary>
	/// <returns>
	/// A string containing the property values of the person.
	/// </returns>
	[DebuggerStepThrough]
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
		get
		{
			return this._addresses;
		}
		set
		{
			if (ReferenceEquals(this._addresses, value))
			{
				return;
			}

			this._addresses = [.. value];
		}
	}

	/// <summary>
	/// XML-only shim for <see cref="Addresses"/>.
	/// </summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	[JsonIgnore]
	[XmlArray("Addresses")]
	[Preserve(PreserveReason.Other, "Preserve for XML serialization.", "4/24/2005", "David McCarter")]
	[Information(nameof(AddressesSerialization), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public Collection<Address> AddressesSerialization
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
		get
		{
			return this._bornOn;
		}
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

			this._bornOn = value;
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
		get
		{
			return this._cellPhone;
		}
		set
		{
			var safeValue = value ?? string.Empty;

			if (this._cellPhone.FastEquals(safeValue))
			{
				return;
			}

			if (safeValue.HasValue(0, 50) is false)
			{
				ExceptionThrower.ThrowArgumentOutOfRangeException(
					Resources.ErrorMessagePhoneNumberIsLimitedToCharacters, nameof(this.CellPhone));
			}

			this._cellPhone = safeValue;
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
		get
		{
			return this._email;
		}
		init
		{
			if (string.IsNullOrEmpty(value))
			{
				ExceptionThrower.ThrowArgumentNullException(nameof(this.Email));
			}

			if (value.HasValue(10, 75) is false)
			{
				ExceptionThrower.ThrowArgumentOutOfRangeException(
					Resources.ErrorMessageEmailLengthIsLimitedToCharacters, nameof(this.Email));
			}

			this._email = value;
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
		get
		{
			return this._firstName;
		}
		set
		{
			var safeValue = value ?? string.Empty;

			if (this._firstName.FastEquals(safeValue, StringComparison.CurrentCultureIgnoreCase))
			{
				return;
			}

			if (safeValue.HasValue(0, 50) is false)
			{
				ExceptionThrower.ThrowArgumentOutOfRangeException(
					Resources.ErrorFirstNameLengthIsLimitedToCharacters, nameof(this.FirstName));
			}

			this._firstName = safeValue;
		}
	}

	/// <summary>
	/// Gets the unique identifier (init-only; 10–50 chars).
	/// </summary>
	/// <exception cref="ArgumentOutOfRangeException">
	/// Thrown if the value is not between 10 and 50 chars.
	/// </exception>
	[DataMember(Name = "id", IsRequired = true)]
	[JsonPropertyName("id")]
	[MaxLength(50, ErrorMessageResourceName = "ErrorIdLengthIsLimitedToCharacters", ErrorMessageResourceType = typeof(Resources))]
	[MinLength(10, ErrorMessageResourceName = "ErrorIdLengthIsMinimumCharacters", ErrorMessageResourceType = typeof(Resources))]
	[ReadOnly(true)]
	[Required(AllowEmptyStrings = false, ErrorMessageResourceName = "ErrorIdIsRequired", ErrorMessageResourceType = typeof(Resources))]
	[XmlElement("Id", IsNullable = false)]
	[Information(nameof(IDataModel<,>.Id), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
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
		get
		{
			return this._lastName;
		}
		set
		{
			var safeValue = value ?? string.Empty;

			if (this._lastName.FastEquals(safeValue, StringComparison.CurrentCultureIgnoreCase))
			{
				return;
			}

			if (safeValue.HasValue(0, 50) is false)
			{
				ExceptionThrower.ThrowArgumentOutOfRangeException(
					Resources.ErrorLastNameLengthIsLimitedToCharacters, nameof(this.LastName));
			}

			this._lastName = safeValue;
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
		get
		{
			return this._phone;
		}
		set
		{
			var safeValue = value ?? string.Empty;

			if (this._phone.FastEquals(safeValue))
			{
				return;
			}

			if (safeValue.HasValue(0, 50) is false)
			{
				ExceptionThrower.ThrowArgumentOutOfRangeException(
					Resources.ErrorMessagePhoneNumberIsLimitedToCharacters, nameof(this.Phone));
			}

			this._phone = safeValue;
		}
	}
}
