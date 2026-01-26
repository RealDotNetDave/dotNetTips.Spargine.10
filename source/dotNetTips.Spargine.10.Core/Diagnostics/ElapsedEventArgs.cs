// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 05-09-2025
//
// Last Modified By : David McCarter
// Last Modified On : 12-17-2025
// ***********************************************************************
// <copyright file="ElapsedEventArgs.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Diagnostics;

/// <summary>
/// Provides data for events that report elapsed time information.
/// </summary>
/// <param name="elapsed">
/// The elapsed time to be reported. Represents the duration of an operation or time period.
/// </param>
/// <remarks>
/// This class derives from <see cref="EventArgs"/> and follows the standard .NET event pattern
/// for custom event data. It uses a primary constructor to initialize the <see cref="Elapsed"/> property.
/// <para>
/// <strong>Event Pattern Compliance:</strong>
/// This class follows the .NET Framework Design Guidelines for event argument classes:
/// <list type="bullet">
/// <item><description>Derives from <see cref="EventArgs"/> as required by convention</description></item>
/// <item><description>Named with the "EventArgs" suffix to indicate its purpose</description></item>
/// <item><description>Provides read-only access to event data through properties</description></item>
/// <item><description>Is a reference type (class) to support passing event data by reference</description></item>
/// </list>
/// </para>
/// <para>
/// <strong>Primary Constructor:</strong>
/// The class uses a C# 12 primary constructor that accepts the <paramref name="elapsed"/> parameter
/// and automatically captures it for the <see cref="Elapsed"/> property initializer.
/// </para>
/// <para>
/// <strong>Immutability:</strong>
/// The <see cref="Elapsed"/> property is read-only (get-only), ensuring that event data
/// cannot be modified after the event args are created. This prevents race conditions
/// when multiple event handlers access the same event arguments.
/// </para>
/// </remarks>
/// <example>
/// Example usage in an event-driven scenario:
/// <code>
/// // Define an event using ElapsedEventArgs
/// public event EventHandler&lt;ElapsedEventArgs&gt;? OperationCompleted;
/// 
/// // Raise the event with elapsed time
/// protected virtual void OnOperationCompleted(TimeSpan elapsed)
/// {
///     OperationCompleted?.Invoke(this, new ElapsedEventArgs(elapsed));
/// }
/// 
/// // Subscribe to the event
/// obj.OperationCompleted += (sender, e) =&gt;
/// {
///     Console.WriteLine($"Operation completed in {e.Elapsed.TotalMilliseconds} ms");
/// };
/// 
/// // Usage example
/// var stopwatch = Stopwatch.StartNew();
/// // ... perform operation ...
/// stopwatch.Stop();
/// OnOperationCompleted(stopwatch.Elapsed);
/// </code>
/// </example>
/// <seealso cref="EventArgs"/>
/// <seealso cref="TimeSpan"/>
/// <seealso cref="EventHandler{TEventArgs}"/>
[Information(nameof(ElapsedEventArgs), "David McCarter", "05/08/2025", Status = Status.Available)]
public class ElapsedEventArgs(TimeSpan elapsed) : EventArgs
{
	/// <summary>
	/// Gets the elapsed time reported by this event.
	/// </summary>
	/// <value>
	/// A <see cref="TimeSpan"/> representing the elapsed time. This value is immutable once set during construction.
	/// </value>
	/// <remarks>
	/// This property is initialized from the primary constructor parameter <c>elapsed</c>.
	/// The value represents the duration of an operation or time interval being reported.
	/// <para>
	/// <strong>Thread Safety:</strong>
	/// As a read-only property, this value is thread-safe for reading after construction.
	/// Multiple event handlers can safely access this property concurrently without synchronization.
	/// </para>
	/// <para>
	/// <strong>Immutability:</strong>
	/// Once an <see cref="ElapsedEventArgs"/> instance is created, the elapsed time cannot be changed.
	/// This ensures consistent data across all event subscribers and prevents unintended modifications.
	/// </para>
	/// </remarks>
	/// <example>
	/// Accessing the elapsed time in an event handler:
	/// <code>
	/// void OnOperationCompleted(object sender, ElapsedEventArgs e)
	/// {
	///     // Access different time units
	///     Console.WriteLine($"Total seconds: {e.Elapsed.TotalSeconds}");
	///     Console.WriteLine($"Milliseconds: {e.Elapsed.TotalMilliseconds}");
	///     Console.WriteLine($"Formatted: {e.Elapsed:hh\\:mm\\:ss\\.fff}");
	///     
	///     // Conditional logic based on elapsed time
	///     if (e.Elapsed > TimeSpan.FromSeconds(5))
	///     {
	///         Console.WriteLine("Warning: Operation took longer than expected");
	///     }
	/// }
	/// </code>
	/// </example>
	/// <seealso cref="TimeSpan"/>
	/// <seealso cref="ElapsedEventArgs"/>
	[Information(nameof(Elapsed), "David McCarter", "05/08/2025", UnitTestStatus = UnitTestStatus.NotRequired, Status = Status.Available)]
	public TimeSpan Elapsed { get; } = elapsed;
}
