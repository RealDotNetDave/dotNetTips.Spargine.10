// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 01-29-2025
//
// Last Modified By : David McCarter
// Last Modified On : 01-20-2026
// ***********************************************************************
// <copyright file="SimpleResult.Generic.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Concurrent;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Use for return results from methods. This type is thread-safe.
/// </summary>
/// <typeparam name="T"></typeparam>
[Information(nameof(SimpleResult), author: "David McCarter", createdOn: "6/20/2023", Status = Core.Status.UpdateDocumentation, Documentation = "https://bit.ly/SpargineSimpleResult")]
public class SimpleResult<T>
{
	private readonly ConcurrentBag<Exception> _exceptions = [];
	private readonly List<string> _messages = [];

	/// <summary>
	/// The value associated with this result.
	/// </summary>
	private T _value;

	/// <summary>
	/// Indicates whether the value has been set for this result.
	/// </summary>
	private bool _valueSet;

	/// <summary>
	/// Initializes a new instance of the <see cref="SimpleResult{T}" /> class.
	/// </summary>
	[ExcludeFromCodeCoverage]
	public SimpleResult() => this._value = default!;

	/// <summary>
	/// Initializes a new successful result.
	/// </summary>
	/// <param name="value">The value to be stored as result.</param>
	[Information(nameof(SimpleResult), UnitTestStatus = UnitTestStatus.Completed, Status = Core.Status.Available)]
	public SimpleResult([DisallowNull] T value)
	{
		this._value = value.ArgumentNotNull();
		this._valueSet = true;
	}

	/// <summary>
	/// Initializes a new unsuccessful result.
	/// </summary>
	/// <param name="error">The exception representing error. Cannot be <see langword="null" />.</param>
	[Information(nameof(SimpleResult), UnitTestStatus = UnitTestStatus.Completed, Status = Core.Status.Available)]
	public SimpleResult(Exception error)
	{
		this._value = default!;
		this.AddException(error);
	}

	/// <summary>
	/// Gets exceptions associated with this result.
	/// </summary>
	/// <returns>ReadOnlyCollection&lt;Exception&gt;.</returns>
	[Information(nameof(Errors), UnitTestStatus = UnitTestStatus.Completed, Status = Core.Status.Available)]
	public ReadOnlyCollection<Exception> Errors => this._exceptions.ToList().AsReadOnly();

	/// <summary>
	/// Indicates if there are any errors.
	/// </summary>
	[Information(nameof(HasErrors), UnitTestStatus = UnitTestStatus.Completed, Status = Core.Status.New)]
	public bool HasErrors => !this._exceptions.IsEmpty;

	/// <summary>
	/// Indicates if the result is a failure (no value or only errors).
	/// </summary>
	[Information(nameof(IsFailure), UnitTestStatus = UnitTestStatus.NotRequired, Status = Core.Status.New)]
	public bool IsFailure => this.Status == ResultStatus.Failed;

	/// <summary>
	/// Indicates if the result is successful (no errors and value set).
	/// </summary>
	[Information(nameof(IsSuccess), UnitTestStatus = UnitTestStatus.NotRequired, Status = Core.Status.New)]
	public bool IsSuccess => this.Status == ResultStatus.Succeeded;

	/// <summary>
	/// Gets the collection of messages associated with this result.
	/// </summary>
	/// <value>A read-only collection of informational or diagnostic messages.</value>
	/// <remarks>
	/// Messages can be added using the <see cref="AddMessage"/> method to provide
	/// additional context about the operation's outcome.
	/// </remarks>
	[Information(nameof(Messages), UnitTestStatus = UnitTestStatus.None, Status = Core.Status.New)]
	public ReadOnlyCollection<string> Messages => this._messages.AsReadOnly();

	/// <summary>
	/// Indicates the status of the result.
	/// </summary>
	/// <value>
	/// <see cref="ResultStatus.Succeeded"/> if the result is successful; 
	/// <see cref="ResultStatus.PartialSuccess"/> if there are exceptions but a value is present;
	/// otherwise, <see cref="ResultStatus.Failed"/>.
	/// </value>>
	[Information(nameof(Status), UnitTestStatus = UnitTestStatus.WIP, Status = Core.Status.Available)]
	public ResultStatus Status
	{
		get
		{
			return this._valueSet && this._exceptions.IsEmpty
				? ResultStatus.Succeeded
				: this._valueSet ? ResultStatus.PartialSuccess : ResultStatus.Failed;
		}
	}

	/// <summary>
	/// Gets the value associated with this result.
	/// </summary>
	/// <value>The value of type <typeparamref name="T"/>.</value>
	[Information(nameof(Value), UnitTestStatus = UnitTestStatus.Completed, Status = Core.Status.Available)]
	public T Value => this._value;

	/// <summary>
	/// Extracts the actual result from the specified <see cref="SimpleResult{T}"/>.
	/// </summary>
	/// <param name="result">The result object containing the value.</param>
	/// <returns>The value of type <typeparamref name="T"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="result"/> is <see langword="null"/>.</exception>
	[Information(nameof(FromResult), UnitTestStatus = UnitTestStatus.Completed, Status = Core.Status.Available)]
	public static T FromResult([DisallowNull] in SimpleResult<T> result)
	{
		return result.ArgumentNotNull().Value;
	}

	/// <summary>
	/// Adds an exception to the collection of exceptions. This method captures the exception
	/// and stores it, allowing multiple exceptions to be associated with a single result.
	/// </summary>
	/// <param name="error">The exception to add. Cannot be <see langword="null"/>.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="error"/> is <see langword="null"/>.</exception>
	[Information(nameof(AddException), UnitTestStatus = UnitTestStatus.Completed, Status = Core.Status.Available)]
	public void AddException([DisallowNull] Exception error)
	{
		error = error.ArgumentNotNull();

		this._exceptions.Add(ExceptionDispatchInfo.Capture(error).SourceException);
	}

	/// <summary>
	/// Adds a message to the collection of messages associated with this result.
	/// If the message is <see langword="null"/> or empty, the method returns without adding anything.
	/// </summary>
	/// <param name="message">The message to add. If <see langword="null"/> or empty, the message is ignored.</param>
	/// <remarks>
	/// This method allows associating informational or diagnostic messages with a result,
	/// which can be useful for providing additional context about the operation's outcome.
	/// </remarks>
	[Information(nameof(AddMessage), UnitTestStatus = UnitTestStatus.None, Status = Core.Status.New)]
	public void AddMessage([DisallowNull] string message)
	{
		if (message.CheckIsNotNullOrEmpty() == false)
		{
			return;
		}

		this._messages.Add(message);
	}

	/// <summary>
	/// Binds the result to another result-producing function.
	/// </summary>
	[Information(nameof(Bind), UnitTestStatus = UnitTestStatus.Completed, Status = Core.Status.New)]
	public SimpleResult<TResult> Bind<TResult>([DisallowNull] Func<T, SimpleResult<TResult>> binder)
	{
		binder = binder.ArgumentNotNull();

		if (this.IsSuccess)
		{
			return binder.Invoke(this._value);
		}
		var result = new SimpleResult<TResult>();

		foreach (var ex in this._exceptions)
		{
			result.AddException(ex);
		}

		return result;
	}

	/// <summary>
	/// Deconstructs the result into value and errors.
	/// </summary>
	[Information(nameof(Deconstruct), UnitTestStatus = UnitTestStatus.Completed, Status = Core.Status.New)]
	public void Deconstruct(out T value, out ReadOnlyCollection<Exception> errors)
	{
		value = this._value;
		errors = this.Errors;
	}

	/// <summary>
	/// Returns the error messages, including the InnerException, if any.
	/// </summary>
	/// <returns>A string containing all error messages.</returns>
	[Information(nameof(GetErrorMessages), UnitTestStatus = UnitTestStatus.Completed, Status = Core.Status.Available)]
	public string GetErrorMessages() => this.GenerateExceptionMessages();

	/// <summary>
	/// Gets the hash code for the current instance.
	/// </summary>
	/// <returns>An integer representing the hash code of the current instance.</returns>
	public override int GetHashCode() => base.GetHashCode();

	/// <summary>
	/// Maps the value to a new result if successful.
	/// </summary>
	[Information(nameof(Map), UnitTestStatus = UnitTestStatus.Completed, Status = Core.Status.New)]
	public SimpleResult<TResult> Map<TResult>([DisallowNull] Func<T, TResult> mapper)
	{
		mapper = mapper.ArgumentNotNull();

		if (this.IsSuccess)
		{
			return new SimpleResult<TResult>(mapper.Invoke(this._value)!);
		}
		var result = new SimpleResult<TResult>();

		foreach (var ex in this._exceptions)
		{
			result.AddException(ex);
		}

		return result;
	}

	/// <summary>
	/// Returns the value if present; otherwise return the default value.
	/// </summary>
	/// <param name="defaultValue">The value to be returned if this result is unsuccessful.</param>
	/// <returns>The value, if present, otherwise <paramref name="defaultValue" />.</returns>
	[Information(nameof(Or), UnitTestStatus = UnitTestStatus.Completed, Status = Core.Status.Available)]
	public T Or(T defaultValue) => this._exceptions.IsEmpty ? this._value : defaultValue;

	/// <summary>
	/// Returns the value if present; otherwise return default value.
	/// </summary>
	/// <returns>The value, if present, otherwise <c>default</c>.</returns>
	[Information(nameof(OrDefault), UnitTestStatus = UnitTestStatus.Completed, Status = Core.Status.Available)]
	public T OrDefault() => this._value;

	/// <summary>
	/// Sets the value associated with this result.
	/// </summary>
	/// <param name="value">The value to be set.</param>
	[Information(nameof(SetValue), UnitTestStatus = UnitTestStatus.Completed, Status = Core.Status.Available)]
	public void SetValue([DisallowNull] T value)
	{
		this._value = value.ArgumentNotNull();
		this._valueSet = true;
	}

	/// <summary>
	/// Returns the error message or the string representation of the value.
	/// </summary>
	/// <returns>The textual representation of this object.</returns>
	[Information(nameof(ToString), UnitTestStatus = UnitTestStatus.Completed, Status = Core.Status.Available)]
	public override string? ToString()
	{
		return this._exceptions.IsEmpty ? this._value?.ToString() ?? string.Empty : this.GenerateExceptionMessages();
	}

	/// <summary>
	/// Attempts to extract value if it is present.
	/// </summary>
	/// <param name="value">Extracted value.</param>
	/// <returns><see langword="true" /> if value is present; otherwise, <see langword="false" />.</returns>
	[Information(nameof(TryGet), UnitTestStatus = UnitTestStatus.Completed, Status = Core.Status.Available)]
	public bool TryGet(out T value)
	{
		value = this._value;
		return this._valueSet;
	}

	/// <summary>
	/// Gets the reference to the value associated with the specified result.
	/// </summary>
	/// <param name="result">The result object containing the value.</param>
	/// <returns>A reference to the value of type <typeparamref name="T"/>.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static ref readonly T GetReference([DisallowNull] in SimpleResult<T> result)
	{
		return ref result._value;
	}

	/// <summary>
	/// Generates the exception messages.
	/// </summary>
	/// <returns>A string containing all exception messages.</returns>
	[return: NotNull]
	private string GenerateExceptionMessages()
	{
		return FastStringBuilder.Join(this._exceptions.Select(e => e.GetAllMessages()), ControlChars.CR);
	}

}
