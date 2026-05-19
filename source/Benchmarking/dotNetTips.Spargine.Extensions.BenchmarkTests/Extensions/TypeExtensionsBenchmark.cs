// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 06-02-2024
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-19-2026
// ***********************************************************************
// <copyright file="TypeExtensionsBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Text.Json.Serialization;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

[BenchmarkCategory(Categories.Reflection)]
[MemoryDiagnoser]
[TailCallDiagnoser]
public class TypeExtensionsBenchmark : Benchmark
{

	[Benchmark(Description = nameof(TypeExtensions.GetAllDeclaredFields))]
	[BenchmarkCategory(Categories.Strings)]
	public void GetAllDeclaredFields()
	{
		var result = typeof(Person).GetAllDeclaredFields();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeExtensions.GetAllDeclaredMethods))]
	[BenchmarkCategory(Categories.Strings)]
	public void GetAllDeclaredMethods()
	{
		var result = typeof(Person).GetAllDeclaredMethods();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeExtensions.GetAllFields))]
	[BenchmarkCategory(Categories.Strings)]
	public void GetAllFields()
	{
		var result = typeof(Person).GetAllFields();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeExtensions.GetAllMethods))]
	[BenchmarkCategory(Categories.Strings)]
	public void GetAllMethods()
	{
		var result = typeof(Person).GetAllMethods();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeExtensions.GetAllProperties))]
	[BenchmarkCategory(Categories.Strings)]
	public void GetAllProperties()
	{
		try
		{
			var result = typeof(Person).GetAllProperties();

			this.Consume(result);
		}
		catch (Exception ex)
		{
			LogInfo($"Exception: {ex.GetType().Name} - {ex.Message}");
			LogInfo($"StackTrace: {ex.StackTrace}");
			throw;
		}
	}

	[Benchmark(Description = nameof(TypeExtensions.GetTypeMembersWithAttribute))]
	[BenchmarkCategory(Categories.Strings)]
	public void GetTypeMembersWithAttribute()
	{
		var result = typeof(Person).GetTypeMembersWithAttribute<JsonPropertyNameAttribute>();

		this.Consume(result);
	}

}
