// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : Copilot Agent
// Created          : 07-09-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 08-03-2026
// ***********************************************************************
// <copyright file="InformationScannerTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class InformationScannerTests
{

	[TestMethod]
	public void GetInformationMetadata_AssemblyWithoutInformationAttributes_ReturnsEmpty()
	{
		var assembly = typeof(StringBuilder).Assembly;

		var items = InformationScanner.GetInformationMetadata(assembly).Where(item => item.TypeName.StartsWith("System.Text.StringBuilder", StringComparison.Ordinal)).ToArray();

		Assert.AreEqual(0, items.Length);
	}

	[TestMethod]
	public void GetInformationMetadata_FastStringBuilderAssembly_ReturnsTypeAndMemberEntries()
	{
		var assembly = typeof(FastStringBuilder).Assembly;

		var items = InformationScanner.GetInformationMetadata(assembly).ToArray();

		Assert.IsTrue(items.Any(i => i.TypeName != null && i.TypeName.EndsWith("FastStringBuilder")), "Expected at least one InformationMetadata entry for FastStringBuilder type.");
		Assert.IsTrue(items.Any(i => i.TypeName != null && i.TypeName.EndsWith("FastStringBuilder") && i.MemberName == "Format" && i.MemberKind == "Method"), "Expected a member-level InformationMetadata entry for FastStringBuilder.Format method.");
	}

	[TestMethod]
	public void GetInformationMetadata_NullAssembly_ReturnsResultsFromEntryAssembly()
	{
		var expected = InformationScanner.GetInformationMetadata(Assembly.GetEntryAssembly()).ToArray();
		var actual = InformationScanner.GetInformationMetadata().ToArray();

		CollectionAssert.AreEqual(expected, actual);
	}

	[TestMethod]
	public void GetInformationMetadata_TestAssembly_ReturnsAnnotatedTypeAndMemberMetadata()
	{
		var assembly = typeof(InformationScannerTests).Assembly;

		var items = InformationScanner.GetInformationMetadata(assembly).Where(item => item.TypeName.Contains(nameof(AnnotatedType), StringComparison.Ordinal) || item.TypeName.Contains(nameof(AnnotatedNestedType), StringComparison.Ordinal)).ToArray();

		Assert.AreEqual(7, items.Length);
		Assert.IsTrue(items.Any(item => item.TypeName.EndsWith(nameof(AnnotatedType), StringComparison.Ordinal) && item.MemberName == string.Empty && item.MemberKind == "Type" && item.Description == "Type test"));
		Assert.IsTrue(items.Any(item => item.TypeName.EndsWith(nameof(AnnotatedType), StringComparison.Ordinal) && item.MemberName == nameof(AnnotatedType.AnnotatedField) && item.MemberKind == "Field" && item.Description == "Field test"));
		Assert.IsTrue(items.Any(item => item.TypeName.EndsWith(nameof(AnnotatedType), StringComparison.Ordinal) && item.MemberName == nameof(AnnotatedType.AnnotatedProperty) && item.MemberKind == "Property" && item.Description == "Property test"));
		Assert.IsTrue(items.Any(item => item.TypeName.EndsWith(nameof(AnnotatedType), StringComparison.Ordinal) && item.MemberName == nameof(AnnotatedType.AnnotatedMethod) && item.MemberKind == "Method" && item.Description == "Method test"));
		Assert.IsTrue(items.Any(item => item.TypeName.EndsWith(nameof(AnnotatedType), StringComparison.Ordinal) && item.MemberName == nameof(AnnotatedType.ChildAnnotatedType) && item.MemberKind == "NestedType" && item.Description == "Nested type test"));
		Assert.IsTrue(items.Any(item => item.TypeName.EndsWith(nameof(AnnotatedNestedType), StringComparison.Ordinal) && item.MemberName == string.Empty && item.MemberKind == "Type" && item.Description == "Nested type test"));
		Assert.IsTrue(items.Any(item => item.TypeName.EndsWith(nameof(AnnotatedType.ChildAnnotatedType), StringComparison.Ordinal) && item.MemberName == string.Empty && item.MemberKind == "Type" && item.Description == "Nested type test"));
	}

	[Information("Nested type test", "Copilot Agent", "08-03-2026", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available, Documentation = "https://example.invalid/nested")]
	private sealed class AnnotatedNestedType
	{
	}

	[Information("Type test", "Copilot Agent", "08-03-2026", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available, Documentation = "https://example.invalid/type")]
	private sealed class AnnotatedType
	{
		[Information("Field test", "Copilot Agent", "08-03-2026", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available, Documentation = "https://example.invalid/field")]
		public const string AnnotatedField = nameof(AnnotatedField);

		[Information("Property test", "Copilot Agent", "08-03-2026", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available, Documentation = "https://example.invalid/property")]
		public string AnnotatedProperty => nameof(this.AnnotatedProperty);

		[Information("Method test", "Copilot Agent", "08-03-2026", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available, Documentation = "https://example.invalid/method")]
		public void AnnotatedMethod()
		{
		}

		[Information("Nested type test", "Copilot Agent", "08-03-2026", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available, Documentation = "https://example.invalid/nested")]
		public sealed class ChildAnnotatedType
		{
		}
	}
}
