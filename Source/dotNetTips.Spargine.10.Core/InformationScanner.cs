// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : Copilot Agent
// Created          : 07-09-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 08-03-2026
// ***********************************************************************
// <copyright file="InformationScanner.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Helper to discover members annotated with the InformationAttribute at runtime.
// Provides a small DTO useful for tooling and prioritization (tests/benchmarks).
// </summary>
// ***********************************************************************

using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Scans assemblies to extract InformationAttribute metadata for tooling and reporting.
/// Reflection-based and therefore marked with RequiresUnreferencedCode to warn about trimming.
/// </summary>
[Information(Status = Status.Available, Documentation = "https://bit.ly/SpargineInformationAttribute")]
public static class InformationScanner
{
	/// <summary>
	/// Scans the provided assembly (or entry assembly when null) and returns discovered Information attributes.
	/// </summary>
	/// <param name="assembly">Assembly to scan. When null, the entry assembly is scanned.</param>
	/// <returns>Enumeration of InformationMetadata items for each annotated member.</returns>
	[RequiresUnreferencedCode("Scans assembly types and members via reflection; trimming may remove members required by consumers.")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GetInformationMetadata), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public static IEnumerable<InformationMetadata> GetInformationMetadata([AllowNull] Assembly? assembly = null)
	{
		assembly ??= Assembly.GetEntryAssembly() ?? Assembly.GetExecutingAssembly();

		foreach (var type in assembly.GetTypes())
		{
			var typeInfo = type.GetTypeInfo();

			// Type-level attribute
			var infoAttr = typeInfo.GetCustomAttribute<InformationAttribute>(inherit: false);
			if (infoAttr is not null)
			{
				yield return new InformationMetadata(
					assembly.FullName ?? assembly.GetName().Name ?? string.Empty,
					type.FullName ?? type.Name,
					string.Empty,
					"Type",
					infoAttr.Description,
					infoAttr.Author ?? string.Empty,
					infoAttr.UnitTestStatus,
					infoAttr.BenchmarkStatus,
					infoAttr.OptimizationStatus,
					infoAttr.Status,
					infoAttr.Documentation ?? string.Empty);
			}

			// Member-level attributes
			var members = new List<MemberInfo>();
			members.AddRange(typeInfo.DeclaredMethods.Cast<MemberInfo>());
			members.AddRange(typeInfo.DeclaredFields);
			members.AddRange(typeInfo.DeclaredProperties);
			members.AddRange(typeInfo.DeclaredNestedTypes);

			foreach (var m in members)
			{
				var attr = m.GetCustomAttribute<InformationAttribute>(inherit: false);
				if (attr is not null)
				{
					yield return new InformationMetadata(
						assembly.FullName ?? assembly.GetName().Name ?? string.Empty,
						type.FullName ?? type.Name,
						m.Name,
						m.MemberType.ToString(),
						attr.Description,
						attr.Author ?? string.Empty,
						attr.UnitTestStatus,
						attr.BenchmarkStatus,
						attr.OptimizationStatus,
						attr.Status,
						attr.Documentation ?? string.Empty);
				}
			}
		}
	}
}

/// <summary>
/// Represents discovered Information attribute metadata for a member.
/// </summary>
public sealed record InformationMetadata(
	string AssemblyName,
	string TypeName,
	string MemberName,
	string MemberKind,
	string Description,
	string Author,
	UnitTestStatus UnitTestStatus,
	BenchmarkStatus BenchmarkStatus,
	OptimizationStatus OptimizationStatus,
	Status Status,
	string Documentation);
