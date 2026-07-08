// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : Copilot Agent
// Created          : 07-08-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-08-2026
// ***********************************************************************
// <copyright file="OpenTelemetryExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Unit tests for OpenTelemetryExtensions methods.</summary>
// ***********************************************************************

using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class OpenTelemetryExtensionsTests
{
	[TestMethod]
	public void AddTagsIfPresent_AddsOnlyValidTags()
	{
		using var activity = new Activity("add-tags-test");
		activity.Start();

		var tags = new List<KeyValuePair<string, object?>>
		{
			new("valid.key", "value"),
			new("another.key", 42),
			new(string.Empty, "ignored"),
			new("null.value", null),
		};

		_ = activity.AddTagsIfPresent(tags);

		var activityTags = activity.TagObjects.ToDictionary(tag => tag.Key, tag => tag.Value);

		Assert.AreEqual(2, activityTags.Count);
		Assert.AreEqual("value", activityTags["valid.key"]);
		Assert.AreEqual(42, activityTags["another.key"]);
	}

	[TestMethod]
	public void AddTagsIfPresent_NullActivity_ReturnsNull()
	{
		Activity activity = null;
		var tags = new List<KeyValuePair<string, object?>> { new("key", "value") };

		var result = activity.AddTagsIfPresent(tags);

		Assert.IsNull(result);
	}

	[TestMethod]
	public void AddTagsIfPresent_NullTags_DoesNothing()
	{
		using var activity = new Activity("null-tags-test");
		activity.Start();

		IEnumerable<KeyValuePair<string, object?>> tags = null;
		var result = activity.AddTagsIfPresent(tags);

		Assert.AreSame(activity, result);
		Assert.AreEqual(0, activity.Tags.Count());
	}

	[TestMethod]
	public void SetStatusIfError_NullActivity_ReturnsNull()
	{
		Activity activity = null;
		var exception = new InvalidOperationException("boom");

		var result = activity.SetStatusIfError(exception);

		Assert.IsNull(result);
	}

	[TestMethod]
	public void SetStatusIfError_NullException_DoesNotSetError()
	{
		using var activity = new Activity("null-exception-test");
		activity.Start();

		var result = activity.SetStatusIfError(null);

		Assert.AreSame(activity, result);
		Assert.AreEqual(ActivityStatusCode.Unset, activity.Status);
	}

	[TestMethod]
	public void SetStatusIfError_SetsErrorStatusAndDescription()
	{
		using var activity = new Activity("error-status-test");
		activity.Start();

		var exception = new InvalidOperationException("failure-message");
		var result = activity.SetStatusIfError(exception);

		Assert.AreSame(activity, result);
		Assert.AreEqual(ActivityStatusCode.Error, activity.Status);
		Assert.AreEqual("failure-message", activity.StatusDescription);
	}
}
