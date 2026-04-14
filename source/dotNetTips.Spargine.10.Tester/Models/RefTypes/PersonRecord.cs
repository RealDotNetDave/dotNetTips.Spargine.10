// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Tester
// Author           : David McCarter
// Created          : 01-03-2021
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-08-2026
// ***********************************************************************
// <copyright file="PersonRecord.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// A real-world type for testing and benchmarking named "PersonRecord"
// with the following properties: Addresses, Age, BornOn, CellPhone,
// Email, FirstName, FullName, LastName, and Phone. Additionally,
// this type includes methods to convert from both Person reference
// and value types to PersonRecord.
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
/// Represents a person record with identity, contact information, and
/// a collection of addresses.
/// Implements <see cref="IPerson{TSelf, TAddress}"/> as
/// <c>IPerson&lt;PersonRecord, AddressRecord&gt;</c>.
/// Comparison and equality are by <see cref="Id"/>.
/// </summary>
[DataContract(Name = "personRecord", Namespace = "http://DotNetTips.Spargine.Tester.Models.Ref")]
[DebuggerDisplay("{Email}")]
[Serializable]
[XmlRoot(ElementName = "PersonRecord", Namespace = "http://DotNetTips.Spargine.Tester.Models.Ref")]
[Information(Status = Status.Available, Documentation = "https://bit.ly/SpargineTester")]
public sealed record PersonRecord : IPerson<PersonRecord, AddressRecord>
{
	[JsonIgnore, NonSerialized] private Collection<AddressRecord> _addresses = [];
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
	public PersonRecord()
	{
	}

	/// <summary>
	/// Creates a new instance with the specified <paramref name="email"/>
	/// and <paramref name="id"/>.
	/// </summary>
	/// <param name="email">
	/// The email address of the person. Must be a valid email format
	/// and not exceed 75 characters.
	/// </param>
	/// <param name="id">
	/// The unique identifier for the person. Must not exceed 50
	/// characters.
	/// </param>
	/// <exception cref="ArgumentOutOfRangeException">
	/// Thrown if <paramref name="email"/> or <paramref name="id"/>
	/// do not meet length requirements.
	/// </exception>
	[JsonConstructor]
	[Information(nameof(PersonRecord), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public PersonRecord([NotNull] string email, [NotNull] string id)
	{
		this.Email = email;
		this.Id = id;
	}

	/// <summary>
	/// Gets the collection of addresses (init performs a defensive
	/// copy).
	/// </summary>
	[DataMember(Name = "addresses", IsRequired = false)]
	[JsonPropertyName("addresses")]
	[XmlIgnore]
	[Information(nameof(Addresses), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public Collection<AddressRecord> Addresses
	{
		get
		{
			return this._addresses;
		}
		init
		{
			this._addresses = [.. value];
		}
	}

	/// <summary>
	/// XML serialization shim for <see cref="Addresses"/>.
	/// </summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	[JsonIgnore]
	[XmlArray("Addresses")]
	[Preserve(PreserveReason.Other, "Preserve for XML serialization.", "4/24/2005", "David McCarter")]
	[Information(nameof(AddressesSerialization), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public Collection<AddressRecord> AddressesSerialization
	{
		get { return new Collection<AddressRecord>([.. this._addresses]); }
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
		init
		{
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
	[UnconditionalSuppressMessage("Trimming", "IL2026:Members annotated with 'RequiresUnreferencedCodeAttribute' require dynamic access otherwise can break functionality when trimming application code", Justification = "<Pending>")]
	[Information(nameof(CellPhone), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string CellPhone
	{
		get
		{
			return this._cellPhone;
		}
		init
		{
			var safeValue = value ?? string.Empty;

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
	[UnconditionalSuppressMessage("Trimming", "IL2026:Members annotated with 'RequiresUnreferencedCodeAttribute' require dynamic access otherwise can break functionality when trimming application code", Justification = "<Pending>")]
	[Information(nameof(Email), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string Email
	{
		get
		{
			return this._email;
		}

		init
		{
			if (string.IsNullOrWhiteSpace(value))
			{
				ExceptionThrower.ThrowArgumentNullException(nameof(this.Email));
			}

			if (value.HasValue(10, 75) is false)
			{
				ExceptionThrower.ThrowArgumentOutOfRangeException(Resources.ErrorMessageEmailLengthIsLimitedToCharacters, nameof(this.Email));
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
	[UnconditionalSuppressMessage("Trimming", "IL2026:Members annotated with 'RequiresUnreferencedCodeAttribute' require dynamic access otherwise can break functionality when trimming application code", Justification = "<Pending>")]
	[Information(nameof(FirstName), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string FirstName
	{
		get
		{
			return this._firstName;
		}
		init
		{
			var safeValue = value ?? string.Empty;

			if (safeValue.HasValue(0, 50) is false)
			{
				ExceptionThrower.ThrowArgumentOutOfRangeException(Resources.ErrorFirstNameLengthIsLimitedToCharacters, nameof(this.FirstName));
			}

			this._firstName = safeValue;
		}
	}

	/// <summary>
	/// Gets the unique identifier (init-only; 10–50 chars).
	/// </summary>
	/// <exception cref="ArgumentOutOfRangeException">
	/// Thrown if the value is not between 10 and 50 characters.
	/// </exception>
	[DataMember(Name = "id", IsRequired = true)]
	[DisallowNull]
	[JsonPropertyName("id")]
	[MaxLength(50, ErrorMessageResourceName = "ErrorIdLengthIsLimitedToCharacters", ErrorMessageResourceType = typeof(Resources))]
	[MinLength(10, ErrorMessageResourceName = "ErrorIdLengthIsMinimumCharacters", ErrorMessageResourceType = typeof(Resources))]
	[ReadOnly(true)]
	[Required(AllowEmptyStrings = false, ErrorMessageResourceName = "ErrorIdIsRequired", ErrorMessageResourceType = typeof(Resources))]
	[XmlElement("Id", IsNullable = false)]
	[UnconditionalSuppressMessage("Trimming", "IL2026:Members annotated with 'RequiresUnreferencedCodeAttribute' require dynamic access otherwise can break functionality when trimming application code", Justification = "<Pending>")]
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
				ExceptionThrower.ThrowArgumentOutOfRangeException(Resources.ErrorIdLengthIsLimitedToCharacters, nameof(this.Id));
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
	[UnconditionalSuppressMessage("Trimming", "IL2026:Members annotated with 'RequiresUnreferencedCodeAttribute' require dynamic access otherwise can break functionality when trimming application code", Justification = "<Pending>")]
	[Information(nameof(LastName), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string LastName
	{
		get
		{
			return this._lastName;
		}
		init
		{
			var safeValue = value ?? string.Empty;

			if (safeValue.HasValue(0, 50) is false)
			{
				ExceptionThrower.ThrowArgumentOutOfRangeException(Resources.ErrorLastNameLengthIsLimitedToCharacters, nameof(this.LastName));
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
	[UnconditionalSuppressMessage("Trimming", "IL2026:Members annotated with 'RequiresUnreferencedCodeAttribute' require dynamic access otherwise can break functionality when trimming application code", Justification = "<Pending>")]
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
				ExceptionThrower.ThrowArgumentOutOfRangeException(Resources.ErrorMessagePhoneNumberIsLimitedToCharacters, nameof(this.Phone));
			}

			this._phone = safeValue;
		}
	}

	/// <summary>
	/// Implicitly converts a <see cref="Person"/> to a <see cref="PersonRecord"/>.
	/// </summary>
	/// <param name="person">The person to convert.</param>
	/// <returns>A new <see cref="PersonRecord"/> instance.</returns>
	/// <exception cref="ArgumentNullException">
	/// Thrown if <paramref name="person"/> is null.
	/// </exception>
	[return: NotNull]
	[Information("op_Implicit", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static implicit operator PersonRecord(in Person person)
	{
		return ToPersonRecord(person);
	}

	/// <summary>
	/// Implicitly converts a <see cref="ValueTypes.Person"/> to a <see cref="PersonRecord"/>.
	/// </summary>
	/// <param name="person">The value type person to convert.</param>
	/// <returns>A new <see cref="PersonRecord"/> instance.</returns>
	/// <exception cref="ArgumentNullException">
	/// Thrown if <paramref name="person"/> is null.
	/// </exception>
	[return: NotNull]
	[Information("op_Implicit", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static implicit operator PersonRecord(in ValueTypes.Person person)
	{
		return ToPersonRecord(person);
	}

	/// <summary>
	/// Implements the &gt;= operator.
	/// </summary>
	/// <param name="left">The left.</param>
	/// <param name="right">The right.</param>
	/// <returns>The result of the operator.</returns>
	[DebuggerStepThrough]
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool operator >=(in PersonRecord? left, in PersonRecord? right)
	{
		return right is null ? true : left is null ? false : left.CompareTo(right) >= 0;
	}

	/// <summary>
	/// Implements the &gt; operator.
	/// </summary>
	/// <param name="left">The left.</param>
	/// <param name="right">The right.</param>
	/// <returns>The result of the operator.</returns>
	[DebuggerStepThrough]
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool operator >(in PersonRecord? left, in PersonRecord? right)
	{
		return left is null ? false : right is null ? true : left.CompareTo(right) > 0;
	}

	/// <summary>
	/// Implements the &lt;= operator.
	/// </summary>
	/// <param name="left">The left.</param>
	/// <param name="right">The right.</param>
	/// <returns>The result of the operator.</returns>
	[DebuggerStepThrough]
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool operator <=(in PersonRecord? left, in PersonRecord? right)
	{
		return left is null ? true : right is null ? false : left.CompareTo(right) <= 0;
	}

	/// <summary>
	/// Implements the &lt; operator.
	/// </summary>
	/// <param name="left">The left.</param>
	/// <param name="right">The right.</param>
	/// <returns>The result of the operator.</returns>
	[DebuggerStepThrough]
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool operator <(in PersonRecord? left, in PersonRecord? right)
	{
		return left is null ? right is not null : right is null ? false : left.CompareTo(right) < 0;
	}

	/// <summary>
	/// Creates a new <see cref="PersonRecord"/> with the specified
	/// values (required by <see cref="IPerson{TSelf, TAddress}"/>).
	/// </summary>
	/// <param name="id">The unique identifier for the person.</param>
	/// <param name="email">The email address of the person.</param>
	/// <param name="firstName">The first name of the person.</param>
	/// <param name="lastName">The last name of the person.</param>
	/// <param name="bornOn">The birth date of the person.</param>
	/// <param name="addresses">The collection of addresses.</param>
	/// <param name="cellPhone">The cell phone number.</param>
	/// <param name="phone">The home phone number.</param>
	/// <returns>A new <see cref="PersonRecord"/> instance.</returns>
	/// <exception cref="ArgumentOutOfRangeException">
	/// Thrown if any property value does not meet its length
	/// requirements.
	/// </exception>
	[Information(nameof(Create), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static PersonRecord Create(string id, string email, string firstName, string lastName, DateTimeOffset? bornOn, Collection<AddressRecord>? addresses = null, string? cellPhone = null, string? phone = null)
	{
		return new PersonRecord(email, id)
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
	/// Converts a reference <see cref="Person"/> to a
	/// <see cref="PersonRecord"/>.
	/// </summary>
	/// <param name="person">The <see cref="Person"/> to convert.</param>
	/// <returns>A <see cref="PersonRecord"/> instance.</returns>
	/// <exception cref="ArgumentNullException">
	/// Thrown if <paramref name="person"/> is null.
	/// </exception>
	[return: NotNull]
	[Information(nameof(ToPersonRecord), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static PersonRecord ToPersonRecord([NotNull] in Person person)
	{
		_ = person.ArgumentNotNull();

		PersonRecord newPerson = new()
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
				newPerson.Addresses.Add(AddressRecord.ToAddress(address));
			}
		}

		return newPerson;
	}

	/// <summary>
	/// Converts a value <see cref="ValueTypes.Person"/> to a
	/// <see cref="PersonRecord"/>.
	/// </summary>
	/// <param name="person">The <see cref="ValueTypes.Person"/> to
	/// convert.</param>
	/// <returns>A <see cref="PersonRecord"/> instance.</returns>
	/// <exception cref="ArgumentNullException">
	/// Thrown if <paramref name="person"/> is null.
	/// </exception>
	[return: NotNull]
	[Information(nameof(ToPersonRecord), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static PersonRecord ToPersonRecord([NotNull] in ValueTypes.Person person)
	{
		_ = person.ArgumentNotNull();

		PersonRecord newPerson = new()
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
				newPerson.Addresses.Add(AddressRecord.ToAddress(address));
			}
		}

		return newPerson;
	}

	/// <summary>
	/// Non-generic comparison required by <see cref="IComparable"/>.
	/// </summary>
	/// <param name="obj">Object to compare.</param>
	/// <returns>
	/// Value indicating the relative order of the objects.
	/// </returns>
	/// <exception cref="ArgumentException">
	/// Thrown when <paramref name="obj"/> is not a
	/// <see cref="PersonRecord"/>.
	/// </exception>
	[Information(nameof(CompareTo), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	int IComparable.CompareTo(object? obj)
	{
		return obj is null
			? 1
			: obj is PersonRecord other
			? this.CompareTo(other)
			: throw new ArgumentException($"Object must be of type {nameof(PersonRecord)}", nameof(obj));
	}

	/// <summary>
	/// Compares this instance with another <see cref="PersonRecord"/>
	/// using ordinal <see cref="Id"/>.
	/// </summary>
	/// <param name="other">Other <see cref="PersonRecord"/>.</param>
	/// <returns>
	/// Value indicating the relative order of the objects.
	/// </returns>
	public int CompareTo(in PersonRecord? other)
	{
		return other is null ? 1 : string.Compare(this.Id, other.Id, StringComparison.Ordinal);
	}

	/// <summary>
	/// Determines equality with another <see cref="PersonRecord"/>
	/// using ordinal <see cref="Id"/>.
	/// </summary>
	/// <param name="other">Other <see cref="PersonRecord"/>.</param>
	/// <returns>True if equal, otherwise false.</returns>
	public bool Equals(in PersonRecord? other)
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
	/// A string representation of the person record.
	/// </returns>
	[Information(nameof(ToString), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public override string ToString()
	{
#pragma warning disable IL2026 // PropertiesToString uses reflection — suppressed because ToString must match base signature
		return this.PropertiesToString();
#pragma warning restore IL2026
	}
}

