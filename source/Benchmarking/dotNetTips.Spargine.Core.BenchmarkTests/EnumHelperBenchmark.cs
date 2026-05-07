// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 06-02-2024
//
// Last Modified By : David McCarter
// Last Modified On : 11-28-2025
// ***********************************************************************
// <copyright file="EnumHelperBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.ComponentModel;
using System.Net.Cache;
using System.Reflection;
using System.Runtime.Serialization;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester.Data;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.BenchmarkTests;

public class EnumHelperBenchmark : Benchmark
{

	[Benchmark(Description = nameof(EnumHelper.GetDescription))]
	public void GetDescription()
	{
		var result = EnumHelper.GetDescription(CountryName.Japan);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(GetDescriptionNoCache))]
	[BenchmarkCategory(Categories.ForComparison)]
	public void GetDescription_NoCache()
	{
		var result = GetDescriptionNoCache(CountryName.Japan);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumHelper.GetItems))]
	public void GetValues()
	{
		var result = EnumHelper.GetItems<RequestCacheLevel>(false);

		this.ConsumeEnumerable(result);
	}

	private static string GetDescriptionNoCache(Enum input)
	{
		input = input.ArgumentNotNull();

		var type = input.GetType();

		// Verify this is actually an enum type
		if (!type.IsEnum)
		{
			throw new ArgumentException("Type provided must be an Enum.", nameof(input));
		}

		var name = Enum.GetName(type, input);

		if (name is null)
		{
			return input.ToString();
		}

		// Get field and look for Description attribute first
		var field = type.GetField(name);

		if (field is null)
		{
			return name;
		}

		// First try DescriptionAttribute
		var descriptionAttr = field.GetCustomAttribute<DescriptionAttribute>(inherit: false);
		if (descriptionAttr is not null && !string.IsNullOrEmpty(descriptionAttr.Description))
		{
			return descriptionAttr.Description;
		}

		// Then try EnumMemberAttribute
		var enumMemberAttr = field.GetCustomAttribute<EnumMemberAttribute>(inherit: false);
		if (enumMemberAttr is not null && !string.IsNullOrEmpty(enumMemberAttr.Value))
		{
			return enumMemberAttr.Value;
		}

		// Fall back to the enum name
		return name;
	}

}
