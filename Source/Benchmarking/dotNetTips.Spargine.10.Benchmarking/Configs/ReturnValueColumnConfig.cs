// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Benchmarking
// Author           : David McCarter
// Created          : 08-03-2026
//
// Last Modified By : David McCarter
// Last Modified On : 08-03-2026
// ***********************************************************************
// <copyright file="ReturnValueColumnConfig.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>BenchmarkDotNet configuration that registers a custom column for rendering benchmark return values.</summary>
// ***********************************************************************

using BenchmarkDotNet.Configs;
using DotNetTips.Spargine.Benchmarking.Columns;
using DotNetTips.Spargine.Core;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Benchmarking.Configs;

/// <summary>
/// Provides a <see cref="ManualConfig"/> that adds the <see cref="ReturnValueColumn"/>
/// to BenchmarkDotNet output.
/// </summary>
[Information(nameof(ReturnValueColumnConfig), Status = Status.New)]
public sealed class ReturnValueColumnConfig : ManualConfig
{
	/// <summary>
	/// Initializes a new instance of the <see cref="ReturnValueColumnConfig"/> class and
	/// registers the custom return-value column.
	/// </summary>
	public ReturnValueColumnConfig()
	{
		_ = this.AddColumn(new ReturnValueColumn());
	}
}
