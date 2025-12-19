// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Tester
// Author           : David McCarter
// Created          : 05-16-2025
//
// Last Modified By : David McCarter
// Last Modified On : 08-13-2025
// ***********************************************************************
// <copyright file="PersonExtensions.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Tester.Models.Common;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Tester.Extensions;

/// <summary>
/// Provides extension methods for the <see cref="Person"/> class.
/// </summary>
[Information(nameof(PersonExtensions), Status = Status.New)]
public static class PersonExtensions
{
	/// <summary>
	/// Extension methods for the <see cref="Person"/> class.
	/// </summary>
	extension<TPerson, TAddress>([NotNull] IPerson<TPerson, TAddress> person)
		where TPerson : IPerson<TPerson, TAddress>
		where TAddress : IAddress<TAddress>
	{
		/// <summary>
		/// Gets the full name of the person by concatenating the first and last names.
		/// </summary>
		/// <value>
		/// A string containing the person's first name followed by their last name, separated by a space.
		/// </value>
		[Information(nameof(get_FullName), UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
		public string FullName
		{
			get
			{
				return $"{person.FirstName}{ControlChars.Space}{person.LastName}".Trim();
			}
		}

		/// <summary>
		/// Gets the age of the person as a <see cref="TimeSpan"/> since their birth date.
		/// </summary>
		/// <value>
		/// A <see cref="TimeSpan"/> representing the duration from the person's birth date to the current UTC date and time.
		/// </value>
		[Information(nameof(get_Age), UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
		public TimeSpan Age
		{
			get
			{
				return person.BornOn.HasValue ? DateTimeOffset.UtcNow.Subtract(person.BornOn.Value) : TimeSpan.Zero;
			}
		}
	}
}
