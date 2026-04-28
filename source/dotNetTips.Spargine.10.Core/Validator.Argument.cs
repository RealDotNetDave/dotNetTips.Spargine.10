// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 02-16-2022
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-28-2026
// ***********************************************************************
// <copyright file="Validator.Argument.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Methods facilitating the validation of arguments and values,
// ensuring both simplicity and accuracy. In the event of encountering
// invalid data, an Exception will be thrown, accompanied by an
// appropriate error message, which can be either custom or default.
// </summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using DotNetTips.Spargine.Core.Properties;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Class to validate method parameters.
/// </summary>
[Information(Status = Status.Available, Documentation = "https://bit.ly/SpargineValidatorArguments, https://bit.ly/SpargineValidatorData")]
public static partial class Validator
{
	/// <summary>
	/// The invalid string length format
	/// </summary>
	private static readonly CompositeFormat _invalidStringLengthFormat = CompositeFormat.Parse("Invalid string length. Acceptable range is between {0} and {1}.");

	/// <summary>
	/// Validates that the <see cref="IEnumerable{T}" /> has a count within the specified minimum and maximum range.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="input">The <see cref="IEnumerable{T}" /> to validate.</param>
	/// <param name="min">The minimum allowed count (inclusive).</param>
	/// <param name="max">The maximum allowed count (inclusive).</param>
	/// <param name="errorMessage">The error message to be used in the exception if validation fails. Optional.</param>
	/// <param name="paramName">The name of the parameter being validated. This is automatically provided and typically does not need to be specified manually.</param>
	/// <returns>The input collection if its count is within the specified range.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="input"/> is <c>null</c>.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if the collection's count is less than <paramref name="min"/> or greater than <paramref name="max"/>.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentCountInRange), "David McCarter", "5/25/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static IEnumerable<T> ArgumentCountInRange<T>([DisallowNull] this IEnumerable<T> input, int min, int max, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		input = input.ArgumentNotNull();

		_ = input.TryGetNonEnumeratedCount(out var count);

		if (count == 0)
		{
			count = input.Count();
		}

		if (count < min || count > max)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(
				CreateExceptionMessage(errorMessage, $"Collection count must be between {min} and {max}."), paramName);
		}
		return input;
	}

	/// <summary>
	/// Validates the input using a custom predicate function.
	/// </summary>
	/// <typeparam name="T">The type of the input to validate.</typeparam>
	/// <param name="input">The input value to validate.</param>
	/// <param name="predicate">A function that defines the validation logic. Should return <c>true</c> if the input is valid; otherwise, <c>false</c>.</param>
	/// <param name="errorMessage">The error message to be used in the exception if validation fails. Optional.</param>
	/// <param name="paramName">The name of the parameter being validated. This is automatically provided and typically does not need to be specified manually.</param>
	/// <returns>The input value if it passes the custom validation.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="input"/> or <paramref name="predicate"/> is <c>null</c>.</exception>
	/// <exception cref="ArgumentInvalidException">Thrown if the predicate returns <c>false</c> for the input value.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentCustom), "David McCarter", "5/25/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static T ArgumentCustom<T>([DisallowNull] this T input, [DisallowNull] Func<T, bool> predicate, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		input = input.ArgumentNotNull();
		predicate = predicate.ArgumentNotNull();

		if (!predicate(input))
		{
			ExceptionThrower.ThrowArgumentInvalidException(CreateExceptionMessage(errorMessage, Resources.CustomValidationFailed), paramName);
		}

		return input;
	}

	/// <summary>
	/// Tries to validate the <see cref="Enum" /> input.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="input">The <see cref="Enum" /> input to validate.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>Enum.</returns>
	/// <exception cref="ArgumentException">Input cannot be null.</exception>
	/// <exception cref="ArgumentOutOfRangeException">The value is not defined in the enum type.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentDefined), "David McCarter", "6/26/2017", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static T ArgumentDefined<T>([DisallowNull] this T input, in string errorMessage = ControlChars.EmptyString, [CallerArgumentExpression(nameof(input))] string paramName = ControlChars.EmptyString) where T : Enum
	{
		input = input.ArgumentNotNull();

		if (!Enum.IsDefined(typeof(T), input))
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(CreateExceptionMessage(errorMessage, Resources.ErrorEnumNotDefined), paramName);
		}

		return input;
	}

	/// <summary>
	/// Checks that the <see cref="DirectoryInfo" /> exists.
	/// </summary>
	/// <param name="input">The <see cref="DirectoryInfo" /> to validate.</param>
	/// <param name="defaultValue">The default value that will be returned if the directory does not exist.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>System.IO.DirectoryInfo.</returns>
	/// <exception cref="ArgumentNullException">Input cannot be null.</exception>
	/// <exception cref="DirectoryNotFoundException">Directory not found.</exception>
	/// <remarks>This also checks the input for null.</remarks>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentExists), "David McCarter", "6/26/2017", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static DirectoryInfo ArgumentExists([DisallowNull] this DirectoryInfo input, DirectoryInfo? defaultValue = null, string errorMessage = ControlChars.EmptyString, [CallerArgumentExpression(nameof(input))] string paramName = ControlChars.EmptyString)
	{
		input = input.ArgumentNotNull();

		var isValid = input.CheckExists();

		if (isValid is false && defaultValue is not null)
		{
			input = defaultValue;
		}
		else if (isValid is false)
		{
			ExceptionThrower.ThrowDirectoryNotFoundException(CreateParamExceptionMessage(errorMessage, paramName, $"{Resources.ErrorDirectoryDoesNotExist} Directory:{input.FullName}"), input);
		}

		return input;
	}

	/// <summary>
	/// Validates that the <see cref="FileInfo" /> exists.
	/// </summary>
	/// <param name="input">The <see cref="FileInfo" /> to validate.</param>
	/// <param name="defaultValue">The default <see cref="FileInfo" /> value that will be returned if the file does not exist.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>A valid <see cref="FileInfo" /> object.</returns>
	/// <exception cref="FileNotFoundException">File cannot be found.</exception>
	/// <remarks>This also checks the input for null.</remarks>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentExists), "David McCarter", "6/26/2017", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static FileInfo ArgumentExists([DisallowNull] this FileInfo input, FileInfo? defaultValue = null, string errorMessage = ControlChars.EmptyString, [CallerArgumentExpression(nameof(input))] string paramName = ControlChars.EmptyString)
	{
		input = input.ArgumentNotNull();

		var isValid = input.CheckExists();

		if (isValid is false && defaultValue is not null)
		{
			input = defaultValue;
		}
		else if (isValid is false)
		{
			throw ExceptionThrower.CreateFileNotFoundException(CreateParamExceptionMessage(errorMessage, paramName, Resources.ErrorFileNotFound), input.FullName);
		}

		return input;
	}

	/// <summary>
	/// Validates the <see cref="byte" /> is in range.
	/// </summary>
	/// <param name="input">The <see cref="byte" /> input to validate.</param>
	/// <param name="min">The minimum value. Default = 0.</param>
	/// <param name="max">The maximum value.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>System.Byte.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Validation of min or max failed.</exception>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentInRange), "David McCarter", "1/29/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static byte ArgumentInRange(this byte input, in byte min = byte.MinValue, in byte max = byte.MaxValue, string errorMessage = ControlChars.EmptyString, [CallerArgumentExpression(nameof(input))] string paramName = ControlChars.EmptyString)
	{
		var isValid = input.CheckIsInRange(min, max);

		if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(CreateExceptionMessage(errorMessage, Resources.ErrorNumberIsInvalidBasedOnTheMinMaxValue), paramName);
		}

		return input;
	}
	/// <summary>
	/// Tries the validate <see cref="DateTime" /> parameter.
	/// </summary>
	/// <param name="input">The <see cref="DateTime" /> to validate.</param>
	/// <param name="min">The minimum date time.</param>
	/// <param name="max">The maximum date time.</param>
	/// <param name="defaultValue">The default value that will be returned if validation fails.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>DateTime.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Validation failed for min or uppper.</exception>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentInRange), "David McCarter", "1/21/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static DateTime ArgumentInRange(this DateTime input, in DateTime min, in DateTime max, in DateTime? defaultValue = null, string errorMessage = ControlChars.EmptyString, [CallerArgumentExpression(nameof(input))] string paramName = ControlChars.EmptyString)
	{
		var isValid = input.CheckIsInRange(min, max);

		if (isValid is false && defaultValue.HasValue)
		{
			input = defaultValue.GetValueOrDefault();
		}
		else if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(CreateExceptionMessage(errorMessage, Resources.ErrorDateIsInvalidBasedOnMinMaxDateTime), paramName);
		}

		return input;
	}

	/// <summary>
	/// Tries the validate <see cref="DateTimeOffset" /> parameter.
	/// </summary>
	/// <param name="input">The <see cref="DateTimeOffset" /> to validate.</param>
	/// <param name="min">The minimum date time.</param>
	/// <param name="max">The maximum date time.</param>
	/// <param name="defaultValue">The default value that will be returned if validation fails.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>DateTimeOffset.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Validation failed for min or uppper.</exception>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentInRange), "David McCarter", "1/21/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static DateTimeOffset ArgumentInRange(this DateTimeOffset input, in DateTimeOffset min, in DateTimeOffset max, in DateTimeOffset? defaultValue = null, string errorMessage = ControlChars.EmptyString, [CallerArgumentExpression(nameof(input))] string paramName = ControlChars.EmptyString)
	{
		var isValid = input.CheckIsInRange(min, max);

		if (isValid is false && defaultValue is not null)
		{
			input = defaultValue.Value;
		}
		else if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(CreateExceptionMessage(errorMessage, Resources.ErrorDateIsInvalidBasedOnMinMaxDateTime), paramName);
		}

		return input;
	}

	/// <summary>
	/// Tries the validate an <see cref="int" /> value.
	/// </summary>
	/// <param name="input">The <see cref="int" /> to validate</param>
	/// <param name="min">The minimum value. Default = 0.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <param name="max">The maximum value.</param>
	/// <param name="defaultValue">The default value that will be returned if validation fails.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <returns>System.Int32.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Validation failed for min or uppper.</exception>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentInRange), "David McCarter", "6/26/2017", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static int ArgumentInRange(this int input, int min = 0, int max = int.MaxValue, in int? defaultValue = null, string errorMessage = ControlChars.EmptyString, [CallerArgumentExpression(nameof(input))] string paramName = ControlChars.EmptyString)
	{
		var isValid = input.CheckIsInRange(min, max);

		if (isValid is false && defaultValue is not null)
		{
			input = defaultValue.Value;
		}
		else if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(CreateExceptionMessage(errorMessage, Resources.ErrorNumberIsInvalidBasedOnTheMinMaxValue), paramName);
		}

		return input;
	}

	/// <summary>
	/// Tries the validate a <see cref="double" /> parameter.
	/// </summary>
	/// <param name="input">The <see cref="double" /> to validate.</param>
	/// <param name="min">The minimum value. Default = 0.</param>
	/// <param name="max">The maximum value.</param>
	/// <param name="defaultValue">The default value that will be returned if validation fails.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>System.Double.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Validation failed for min or uppper.</exception>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentInRange), "David McCarter", "6/26/2017", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static double ArgumentInRange(this double input, in double min = 0, in double max = double.MaxValue, in double? defaultValue = null, string errorMessage = ControlChars.EmptyString, [CallerArgumentExpression(nameof(input))] string paramName = ControlChars.EmptyString)
	{
		var isValid = input.CheckIsInRange(min, max);

		if (isValid is false && defaultValue is not null)
		{
			input = defaultValue.Value;
		}
		else if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(CreateExceptionMessage(errorMessage, Resources.ErrorNumberIsInvalidBasedOnTheMinMaxValue), paramName);
		}

		return input;
	}

	/// <summary>
	/// Tries the validate a <see cref="long" /> parameter.
	/// </summary>
	/// <param name="input">The <see cref="long" /> to validate.</param>
	/// <param name="min">The minimum value. Default = 0.</param>
	/// <param name="max">The maximum value.</param>
	/// <param name="defaultValue">The default value that will be returned if validation fails.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>System.Int64.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Validation failed for min or uppper.</exception>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentInRange), "David McCarter", "6/26/2017", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static long ArgumentInRange(this long input, in long min = 0, in long max = long.MaxValue, in long? defaultValue = null, string errorMessage = ControlChars.EmptyString, [CallerArgumentExpression(nameof(input))] string paramName = ControlChars.EmptyString)
	{
		var isValid = input.CheckIsInRange(min, max);

		if (isValid is false && defaultValue is not null)
		{
			input = defaultValue.Value;
		}
		else if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(CreateExceptionMessage(errorMessage, Resources.ErrorNumberIsInvalidBasedOnTheMinMaxValue), paramName);
		}

		return input;
	}

	/// <summary>
	/// Tries the validate a <see cref="decimal" /> input.
	/// </summary>
	/// <param name="input">The <see cref="decimal" /> to validate.</param>
	/// <param name="min">The minimum value.</param>
	/// <param name="max">The maximum value.</param>
	/// <param name="defaultValue">The default value that will be returned if validation fails.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>System.Decimal.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Validation failed for min or uppper.</exception>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentInRange), "David McCarter", "6/26/2017", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static decimal ArgumentInRange(this decimal input, in decimal min = 0, in decimal max = decimal.MaxValue, in decimal? defaultValue = null, string errorMessage = ControlChars.EmptyString, [CallerArgumentExpression(nameof(input))] string paramName = ControlChars.EmptyString)
	{
		var isValid = input.CheckIsInRange(min, max);

		if (isValid is false && defaultValue is not null)
		{
			input = defaultValue.Value;
		}
		else if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(CreateExceptionMessage(errorMessage, Resources.ErrorNumberIsInvalidBasedOnTheMinMaxValue), paramName);
		}

		return input;
	}

	/// <summary>
	/// Tries to validate the <see cref="DateOnly" /> input.
	/// </summary>
	/// <param name="input">The <see cref="DateOnly" /> input to validate.</param>
	/// <param name="min">The minimum date.</param>
	/// <param name="max">The maximum date.</param>
	/// <param name="defaultValue">The default value that will be returned if validation fails.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>DateOnly.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Validation failed for min or uppper.</exception>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentInRange), "David McCarter", "2/15/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static DateOnly ArgumentInRange(this DateOnly input, in DateOnly min, in DateOnly max, in DateOnly? defaultValue = null, string errorMessage = ControlChars.EmptyString, [CallerArgumentExpression(nameof(input))] string paramName = ControlChars.EmptyString)
	{
		var isValid = input.CheckIsInRange(min, max);

		if (isValid is false && defaultValue.HasValue)
		{
			input = defaultValue.GetValueOrDefault();
		}
		else if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(CreateExceptionMessage(errorMessage, Resources.ErrorDateIsInvalidBasedOnMinMaxDateTime), paramName);
		}

		return input;
	}

	/// <summary>
	/// Tries to validate the <see cref="TimeOnly" /> input.
	/// </summary>
	/// <param name="input">The <see cref="TimeOnly" /> to validate.</param>
	/// <param name="min">The minimum time.</param>
	/// <param name="max">The maximum time.</param>
	/// <param name="defaultValue">The default value that will be returned if validation fails.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>TimeOnly.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Validation failed for min or uppper.</exception>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentInRange), "David McCarter", "2/15/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static TimeOnly ArgumentInRange(this TimeOnly input, in TimeOnly min, in TimeOnly max, in TimeOnly? defaultValue = null, string errorMessage = ControlChars.EmptyString, [CallerArgumentExpression(nameof(input))] string paramName = ControlChars.EmptyString)
	{
		var isValid = input.CheckIsInRange(min, max);

		if (isValid is false && defaultValue.HasValue)
		{
			input = defaultValue.GetValueOrDefault();
		}
		else if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(CreateExceptionMessage(errorMessage, Resources.ErrorTimeIsInvalidBasedOnTheMinMaxRange), paramName);
		}

		return input;
	}

	/// <summary>
	/// Tries to validate the <see cref="string" /> input.
	/// </summary>
	/// <param name="input">The <see cref="string" /> to validate.</param>
	/// <param name="min">The minimum length.</param>
	/// <param name="max">The maximum length.</param>
	/// <param name="trim">if set to <c>true</c> trims the string.</param>
	/// <param name="defaultValue">The default value that will be returned if validation fails.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>System.String.</returns>
	/// <exception cref="ArgumentInvalidException">Input cannot be null.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Minimum length is not valid.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Value is not within range.</exception>
	/// <remarks>This also checks the input for null.</remarks>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentInRange), "David McCarter", "6/26/2017", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static string ArgumentInRange([DisallowNull] this string input, int min = 0, int max = int.MaxValue, bool trim = true, string? defaultValue = null, string errorMessage = ControlChars.EmptyString, [CallerArgumentExpression(nameof(input))] string paramName = ControlChars.EmptyString)
	{
		input = input.ArgumentNotNull();

		var isValid = input.Length.CheckIsInRange(min, max);

		if (isValid is false && string.IsNullOrEmpty(defaultValue) is false)
		{
			input = defaultValue;
		}
		else if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(CreateExceptionMessage(errorMessage, string.Format(CultureInfo.CurrentCulture, _invalidStringLengthFormat, min, max)), paramName);
		}

		return trim ? input.Trim() : input;
	}

	/// <summary>
	/// Tries to validate the <see cref="IEnumerable{T}" /> is not null and has items.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="input">The <see cref="IEnumerable{T}" /> to validate.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>IEnumerable.</returns>
	/// <exception cref="ArgumentNullException">Collection is null or has no items.</exception>
	/// <remarks>This also checks the input for null.</remarks>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentItemsExists), "David McCarter", "6/26/2017", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static IEnumerable<T> ArgumentItemsExists<T>([DisallowNull] this IEnumerable<T> input, string errorMessage = ControlChars.EmptyString, [CallerArgumentExpression(nameof(input))] string paramName = ControlChars.EmptyString)
	{
		var isValid = input.CheckItemsExists();

		if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentNullException(CreateExceptionMessage(errorMessage, Resources.ErrorCollectionIsNullOrHasNoItems), paramName);
		}

		return input;
	}

	/// <summary>
	/// Arguments the items exists.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="input">The input.</param>
	/// <param name="errorMessage">The error message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>IReadOnlyList&lt;T&gt;.</returns>
	/// <exception cref="ArgumentNullException">Input cannot be empty.</exception>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentItemsExists), "David McCarter", "5/25/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static IReadOnlyList<T> ArgumentItemsExists<T>(this IReadOnlyList<T> input, string errorMessage = ControlChars.EmptyString, [CallerArgumentExpression(nameof(input))] string paramName = ControlChars.EmptyString)
	{
		var isValid = input.CheckItemsExists();

		if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentNullException(CreateExceptionMessage(errorMessage, Resources.ErrorCollectionIsNullOrHasNoItems), paramName);
		}

		return input;
	}

	/// <summary>
	/// Arguments the items exists.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="input">The input.</param>
	/// <param name="errorMessage">The error message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>IReadOnlyCollection&lt;T&gt;.</returns>
	/// <exception cref="ArgumentNullException">Input cannot be empty.</exception>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentItemsExists), "David McCarter", "5/27/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static IReadOnlyCollection<T> ArgumentItemsExists<T>(this IReadOnlyCollection<T> input, string errorMessage = ControlChars.EmptyString, [CallerArgumentExpression(nameof(input))] string paramName = ControlChars.EmptyString)
	{
		var isValid = input.CheckItemsExists();

		if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentNullException(CreateExceptionMessage(errorMessage, Resources.ErrorCollectionIsNullOrHasNoItems), paramName);
		}

		return input;
	}

	/// <summary>
	/// Tries to validate the <see cref="List{T}" /> has items.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="input">The <see cref="List{T}" /> to validate.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>IEnumerable.</returns>
	/// <exception cref="ArgumentNullException">Collection is null or has no items.</exception>
	/// <remarks>This also checks the input for null.</remarks>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentItemsExists), "David McCarter", "2/17/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static List<T> ArgumentItemsExists<T>([DisallowNull] this List<T> input, string errorMessage = ControlChars.EmptyString, [CallerArgumentExpression(nameof(input))] string paramName = ControlChars.EmptyString)
	{
		var isValid = input.CheckItemsExists();

		if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentNullException(CreateExceptionMessage(errorMessage, Resources.ErrorCollectionIsNullOrHasNoItems), paramName);
		}

		return input;
	}

	/// <summary>
	/// Tries to validate the array has items.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="input">The array to validate.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>T[].</returns>
	/// <exception cref="ArgumentNullException">Input cannot be empty.</exception>
	/// <remarks>This also checks the input for null.</remarks>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentItemsExists), "David McCarter", "2/4/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static T[] ArgumentItemsExists<T>([DisallowNull] this T[] input, string errorMessage = ControlChars.EmptyString, [CallerArgumentExpression(nameof(input))] string paramName = ControlChars.EmptyString)
	{
		var isValid = input.CheckItemsExists();

		if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentNullException(CreateExceptionMessage(errorMessage, Resources.ErrorCollectionSizeIsNotValid), paramName);
		}

		return input;
	}

	/// <summary>
	/// Tries to validate the <see cref="IEnumerable{T}" /> has the given count.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="input">The <see cref="IEnumerable{T}" /> to validate.</param>
	/// <param name="count">The count.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>IEnumerable&lt;T&gt;.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Validation failed due to invalid count.</exception>
	/// <remarks>This also checks the input for null.</remarks>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentItemsExists), "David McCarter", "4/4/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static IEnumerable<T> ArgumentItemsExists<T>([DisallowNull] this IEnumerable<T> input, in long count, string errorMessage = ControlChars.EmptyString, [CallerArgumentExpression(nameof(input))] string paramName = ControlChars.EmptyString)
	{
		input = input.ArgumentNotNull();

		var isValid = input.TryGetNonEnumeratedCount(out var collectionCount) && collectionCount == count;

		if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(CreateExceptionMessage(errorMessage, "Collection has no items."), paramName);
		}

		return input;
	}

	/// <summary>
	/// Tries to validate the <see cref="string" /> input. Trims the string.
	/// </summary>
	/// <param name="input">The <see cref="string" /> to validate.</param>
	/// <param name="match">The match.</param>
	/// <param name="trim">if set to <c>true</c> trims the string.</param>
	/// <param name="defaultValue">The default value that will be returned if validation fails.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>System.String.</returns>
	/// <exception cref="ArgumentException">'input' cannot be null or empty.</exception>
	/// <exception cref="ArgumentNullException">'match' cannot be null or empty.</exception>
	/// <exception cref="ArgumentInvalidException">Argument not matched.</exception>
	/// <remarks>This also checks the input for null.</remarks>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentMatched), "David McCarter", "6/26/2017", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static string ArgumentMatched([DisallowNull] this string input, [DisallowNull] Regex match, bool trim = true, string? defaultValue = null, string errorMessage = ControlChars.EmptyString, [CallerArgumentExpression(nameof(input))] string paramName = ControlChars.EmptyString)
	{
		input = input.ArgumentNotNullOrEmpty(trim: trim);
		match = match.ArgumentNotNull();

		var isValid = match.IsMatch(input);

		if (isValid is false && string.IsNullOrEmpty(defaultValue) is false)
		{
			input = defaultValue;
		}
		else if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentInvalidException(CreateExceptionMessage(errorMessage, Resources.ErrorStringIsNotValid), paramName);
		}

		return trim ? input.Trim() : input;
	}

	/// <summary>
	/// Checks a condition against the input with a default value.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="input">The input to validate.</param>
	/// <param name="condition">if set to <c>true</c> [condition].</param>
	/// <param name="defaultValue">The default value to be returned if condition failed.</param>
	/// <returns>T.</returns>
	/// <exception cref="ArgumentInvalidException">Condition failed.</exception>
	/// <remarks>This also checks the input for null.</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentMeetsCondition), "David McCarter", "4/4/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static T ArgumentMeetsCondition<T>(this T input, in bool condition, [DisallowNull] T defaultValue)
	{
		var isValid = input is not null && condition;

		return isValid is false ? defaultValue : input;
	}

	/// <summary>
	/// Checks a condition against the input.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="input">The input to validate.</param>
	/// <param name="condition">if set to <c>true</c> [condition].</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>T.</returns>
	/// <exception cref="ArgumentInvalidException">Condition failed.</exception>
	/// <remarks>This also checks the input for null.</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentMeetsCondition), "David McCarter", "4/4/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static T ArgumentMeetsCondition<T>(this T input, in bool condition, string errorMessage = ControlChars.EmptyString, [CallerArgumentExpression(nameof(input))] string paramName = ControlChars.EmptyString)
	{
		input = input.ArgumentNotNull();

		if (condition is false)
		{
			ExceptionThrower.ThrowArgumentInvalidException(CreateExceptionMessage(errorMessage, Resources.ErrorInvalidValue), paramName);
		}

		return input;
	}

	/// <summary>
	/// Determines whether the <see cref="ReadOnlySpan{T}" /> is empty.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="input">The <see cref="ReadOnlySpan{T}" /> to validate.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>ReadOnlySpan&lt;T&gt;.</returns>
	/// <exception cref="ArgumentNullException">Argument is empty.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentNotEmpty), "David McCarter", "6/26/2017", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static ReadOnlySpan<T> ArgumentNotEmpty<T>([DisallowNull] this ReadOnlySpan<T> input, string errorMessage = ControlChars.EmptyString, [CallerArgumentExpression(nameof(input))] string paramName = ControlChars.EmptyString)
	{
		if (input.CheckIsNotEmpty() is false)
		{
			ExceptionThrower.ThrowArgumentNullException(CreateExceptionMessage(errorMessage, Resources.ErrorReadOnlySpanCannotBeNull), paramName);
		}

		return input;
	}

	/// <summary>
	/// Determines whether the <see cref="Span{T}" /> is empty.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="input">The <see cref="Span{T}" /> to validate.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>Span&lt;T&gt;.</returns>
	/// <exception cref="ArgumentNullException">Input is empty.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentNotEmpty), "David McCarter", "6/26/2017", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static Span<T> ArgumentNotEmpty<T>([DisallowNull] this Span<T> input, string errorMessage = ControlChars.EmptyString, [CallerArgumentExpression(nameof(input))] string paramName = ControlChars.EmptyString)
	{
		if (input.IsEmpty)
		{
			ExceptionThrower.ThrowArgumentNullException(CreateExceptionMessage(errorMessage, Resources.ErrorSpanCannotBeNullOrEmpty), paramName);
		}

		return input;
	}

	/// <summary>
	/// Validates the <see cref="Collection{T}" /> is not null.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="input">The <see cref="Collection{T}" /> to validate.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>Collections.Generic.Collection&lt;T&gt;.</returns>
	/// <exception cref="ArgumentNullException">Input cannot be null.</exception>
	/// <remarks>This also checks the input for null.</remarks>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentNotNull), "David McCarter", "10/24/2023", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static Collection<T> ArgumentNotNull<T>([DisallowNull] this Collection<T> input, string errorMessage = ControlChars.EmptyString, [CallerArgumentExpression(nameof(input))] string paramName = ControlChars.EmptyString)
	{
		if (input is null)
		{
			ExceptionThrower.ThrowArgumentNullException(CreateExceptionMessage(errorMessage, Resources.ErrorCollectionIsNullOrHasNoItems), paramName);
		}

		return input;
	}

	/// <summary>
	/// Validates the input is not <see langword="null" />.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="input">The input to validate.</param>
	/// <param name="defaultValue">The default value that will be returned if validation fails.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	/// <exception cref="ArgumentNullException">Input cannot be null.</exception>
	/// <remarks>This also checks the input for null.</remarks>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentNotNull), "David McCarter", "2/10/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static T ArgumentNotNull<T>(this T input, T? defaultValue = default, string errorMessage = ControlChars.EmptyString, [CallerArgumentExpression(nameof(input))] string paramName = ControlChars.EmptyString)
	{
		var isValid = input is not null;

		if (isValid is false && defaultValue is not null)
		{
			input = defaultValue;
		}
		else if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentNullException(CreateParamExceptionMessage(errorMessage, paramName, Resources.ErrorObjectCannotBeNull));
		}

		return input!;
	}

	/// <summary>
	/// Tries the validate that the <see cref="Uri" /> is not null.
	/// </summary>
	/// <param name="input">The <see cref="Uri" /> to validate.</param>
	/// <param name="defaultValue">The default value that will be returned if validation fails.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>Uri.</returns>
	/// <exception cref="ArgumentNullException">Input cannot be null.</exception>
	/// <remarks>This also checks the input for null.</remarks>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentNotNull), "David McCarter", "6/26/2017", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static Uri ArgumentNotNull([DisallowNull] this Uri input, [AllowNull] Uri? defaultValue = null, string errorMessage = ControlChars.EmptyString, [CallerArgumentExpression(nameof(input))] string paramName = ControlChars.EmptyString)
	{
		var isValid = input.CheckIsNotNull();

		if (isValid is false && defaultValue is not null)
		{
			input = defaultValue;
		}
		else if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentNullException(CreateExceptionMessage(errorMessage, Resources.ErrorUriCannotBeNull), paramName);
		}

		return input;
	}

	/// <summary>
	/// Tries to validate the <see cref="Guid" /> is not empty.
	/// </summary>
	/// <param name="input">The <see cref="Guid" /> to validate.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="defaultValue">The default value that will be returned if validation fails.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>Guid.</returns>
	/// <exception cref="ArgumentInvalidException">Guid cannot be empty.</exception>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentNotNullOrEmpty), "David McCarter", "6/26/2017", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static Guid ArgumentNotNullOrEmpty([DisallowNull] this Guid input, string errorMessage = ControlChars.EmptyString, [AllowNull] Guid? defaultValue = null, [CallerArgumentExpression(nameof(input))] string paramName = ControlChars.EmptyString)
	{
		var isValid = input.CheckIsNotEmpty();

		if (isValid is false && defaultValue is not null)
		{
			input = defaultValue.Value;
		}
		else if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentInvalidException(CreateExceptionMessage(errorMessage, Resources.ErrorGuidIsNullOrEmpty), paramName);
		}

		return input;
	}

	/// <summary>
	/// Validates that the provided string is not null or empty. Optionally trims the string before validation.
	/// </summary>
	/// <param name="input">The string to validate.</param>
	/// <param name="trim">Indicates whether to trim the string before validation. Default is true.</param>
	/// <param name="defaultValue">The default value to return if the input is null or empty. This parameter is optional.</param>
	/// <param name="errorMessage">The error message to use if validation fails. If not provided, a default message is used.</param>
	/// <param name="paramName">The name of the parameter being validated. This is automatically provided and typically does not need to be specified manually.</param>
	/// <returns>The input string if it is not null or empty.</returns>
	/// <exception cref="ArgumentNullException">Thrown if the input string is null.</exception>
	/// <exception cref="ArgumentException">Thrown if the input string is empty.</exception>
	/// <example>
	/// Here is an example of using <c>ArgumentNotNullOrEmpty</c>:
	/// <code>
	/// string name = "John Doe";
	/// name = Validator.ArgumentNotNullOrEmpty(name, trim: true, errorMessage: "Name cannot be empty");
	/// </code></example>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentNotNullOrEmpty), "David McCarter", "6/26/2017", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static string ArgumentNotNullOrEmpty([DisallowNull] this string input, bool trim = true, [AllowNull] string? defaultValue = null, string errorMessage = ControlChars.EmptyString, [CallerArgumentExpression(nameof(input))] string paramName = ControlChars.EmptyString)
	{
		var isValid = string.IsNullOrEmpty(input) is false;

		if (isValid is false && string.IsNullOrEmpty(defaultValue) is false)
		{
			input = defaultValue;
		}
		else if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentNullException(CreateExceptionMessage(errorMessage, Resources.ErrorStringIsNullOrEmpty), paramName);
		}

		return trim ? input.Trim() : input;
	}

	/// <summary>
	/// Validates the <see cref="IList{T}" /> is not read only.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="input">The <see cref="IList{T}" /> to validate.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>IList&lt;T&gt;.</returns>
	/// <exception cref="ArgumentReadOnlyException">Input cannot be read-only.</exception>
	/// <remarks>This also checks the input for null.</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentNotReadOnly), "David McCarter", "1/29/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static IList<T> ArgumentNotReadOnly<T>(this IList<T> input, string errorMessage = ControlChars.EmptyString, [CallerArgumentExpression(nameof(input))] string paramName = ControlChars.EmptyString)
	{
		input = input.ArgumentNotNull();

		var isValid = input.IsReadOnly is false;

		if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentReadOnlyException(CreateExceptionMessage(errorMessage, Resources.ErrorListCannotBeReadOnly), paramName);
		}

		return input;
	}

	/// <summary>
	/// Validates the <see cref="ICollection{T}" /> is not read only.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="input">The <see cref="ICollection{T}" /> to validate.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>ICollection&lt;T&gt;.</returns>
	/// <exception cref="ArgumentReadOnlyException">Input cannot be read-only.</exception>
	/// <remarks>This also checks the input for null.</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentNotReadOnly), "David McCarter", "1/28/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static ICollection<T> ArgumentNotReadOnly<T>(this ICollection<T> input, string errorMessage = ControlChars.EmptyString, [CallerArgumentExpression(nameof(input))] string paramName = ControlChars.EmptyString)
	{
		input = input.ArgumentNotNull();

		var isValid = input.IsReadOnly is false && input is not T[];

		if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentReadOnlyException(CreateExceptionMessage(errorMessage, Resources.ErrorReadOnlyCollection), paramName);
		}

		return input;
	}

	/// <summary>
	/// Tries to validate that the <see cref="Type" /> matches the expected <see cref="Type" />.
	/// </summary>
	/// <param name="input">The <see cref="Type" /> to validate.</param>
	/// <param name="expectedType">The expected <see cref="Type" />.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>Type.</returns>
	/// <exception cref="ArgumentInvalidException">Validation failed for Input.</exception>
	/// <exception cref="ArgumentException">Input cannot be null.</exception>
	/// <exception cref="ArgumentException">Expected Type cannot be null.</exception>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentTypeEquals), "David McCarter", "6/26/2017", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static Type ArgumentTypeEquals([DisallowNull] this Type input, [DisallowNull] Type expectedType, string errorMessage = ControlChars.EmptyString, [CallerArgumentExpression(nameof(input))] string paramName = ControlChars.EmptyString)
	{
		input = input.ArgumentNotNull();
		expectedType = expectedType.ArgumentNotNull();

		if (input.CheckTypeEquals(expectedType) is false)
		{
			ExceptionThrower.ThrowArgumentInvalidException(CreateExceptionMessage(errorMessage, Resources.ErrorInvalidType), paramName);
		}

		return input;
	}

	/// <summary>
	/// Creates the exception message.
	/// </summary>
	/// <param name="message">The message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <param name="messageFromResource">The message from resource.</param>
	/// <returns>System.String.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static string CreateParamExceptionMessage(string message, string paramName, string messageFromResource)
	{
		var returnMessage = $"{paramName}: ";

		return message switch
		{
			null => $"{returnMessage}{messageFromResource}",
			_ => $"{returnMessage}{message}"
		};
	}

}
