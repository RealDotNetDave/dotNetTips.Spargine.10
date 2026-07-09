// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : Copilot Agent
// Created          : 07-09-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-09-2026
// ***********************************************************************
// <copyright file="EfCoreModelBuilderExtensionsBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Benchmark tests for EfCoreModelBuilderExtensions methods.</summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using DotNetTips.Spargine.Benchmarking;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

/// <summary>
/// Benchmarks for <see cref="EfCoreModelBuilderExtensions"/> methods marked for benchmarking.
/// </summary>
[BenchmarkCategory(Categories.Database)]
[MemoryDiagnoser]
[TailCallDiagnoser]
public class EfCoreModelBuilderExtensionsBenchmark : Benchmark
{
	private enum TestStatus
	{
		None = 0,
		Active = 1,
		Inactive = 2
	}

	[Benchmark(Description = nameof(EfCoreModelBuilderExtensions.RegisterEnumAsStringConverters))]
	public void RegisterEnumAsStringConverters()
	{
		var modelBuilder = CreateModelBuilderWithEnumProperties();
		var result = modelBuilder.RegisterEnumAsStringConverters();

		this.Consume(result.Model);
	}

	[Benchmark(Description = nameof(EfCoreModelBuilderExtensions.RegisterGuidAsStringConverters))]
	public void RegisterGuidAsStringConverters()
	{
		var modelBuilder = CreateModelBuilderWithGuidProperties();
		var result = modelBuilder.RegisterGuidAsStringConverters();

		this.Consume(result.Model);
	}

	private static ModelBuilder CreateModelBuilderWithEnumProperties()
	{
		var modelBuilder = new ModelBuilder(new ConventionSet());
		_ = modelBuilder.Entity<EnumEntity>();

		return modelBuilder;
	}

	private static ModelBuilder CreateModelBuilderWithGuidProperties()
	{
		var modelBuilder = new ModelBuilder(new ConventionSet());
		_ = modelBuilder.Entity<GuidEntity>();

		return modelBuilder;
	}

	private sealed class EnumEntity
	{
		public int Id { get; set; }

		public TestStatus? OptionalStatus { get; set; }

		public TestStatus Status { get; set; }
	}

	private sealed class GuidEntity
	{

		public Guid CorrelationId { get; set; }
		public int Id { get; set; }

		public Guid? OptionalCorrelationId { get; set; }
	}
}
