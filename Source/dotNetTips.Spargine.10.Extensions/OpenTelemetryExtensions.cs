// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : Copilot Agent
// Created          : 07-08-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-09-2026
// ***********************************************************************
// <copyright file="OpenTelemetryExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Null-safe OpenTelemetry-focused helpers for <see cref="System.Diagnostics.Activity"/>.
// </summary>
// ***********************************************************************
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides null-safe helper extensions for OpenTelemetry-style activity tagging and status assignment.
/// </summary>
[Information(Status = Status.NeedsDocumentation)]
public static class OpenTelemetryExtensions
{
	/// <summary>
	/// Adds tags to an <see cref="Activity"/> when both key and value are present.
	/// If <paramref name="activity"/> or <paramref name="tags"/> is <see langword="null"/>, this method performs no action.
	/// </summary>
	/// <param name="activity">The target activity.</param>
	/// <param name="tags">The tags to add.</param>
	/// <returns>The original <paramref name="activity"/> for fluent chaining.</returns>
	[Information(nameof(AddTagsIfPresent), "Copilot Agent", "07-08-2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static Activity? AddTagsIfPresent([AllowNull] this Activity activity, [AllowNull] IEnumerable<KeyValuePair<string, object?>> tags)
	{
		if (activity is null || tags is null)
		{
			return activity;
		}

		foreach (var tag in tags)
		{
			if (string.IsNullOrWhiteSpace(tag.Key) || tag.Value is null)
			{
				continue;
			}

			_ = activity.SetTag(tag.Key, tag.Value);
		}

		return activity;
	}

	/// <summary>
	/// Sets the activity status to <see cref="ActivityStatusCode.Error"/> when <paramref name="exception"/> is present.
	/// If <paramref name="activity"/> is <see langword="null"/>, this method performs no action.
	/// </summary>
	/// <param name="activity">The target activity.</param>
	/// <param name="exception">The exception that indicates an error.</param>
	/// <returns>The original <paramref name="activity"/> for fluent chaining.</returns>
	[Information(nameof(SetStatusIfError), "Copilot Agent", "07-08-2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static Activity? SetStatusIfError([AllowNull] this Activity activity, Exception? exception)
	{
		if (activity is null || exception is null)
		{
			return activity;
		}

		_ = activity.SetStatus(ActivityStatusCode.Error, exception.Message);

		return activity;
	}
}
