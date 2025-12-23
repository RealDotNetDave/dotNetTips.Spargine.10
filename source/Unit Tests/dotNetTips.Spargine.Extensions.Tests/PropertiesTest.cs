// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 04-16-2021
//
// Last Modified By : David McCarter
// Last Modified On : 01-21-2024
// ***********************************************************************
// <copyright file="PropertiesTest.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
public class PropertiesTest
{

	public DateTimeOffset? ClosedOn { get; set; }
	public string Id { get; set; }

	public Person Person { get; set; }

	public PersonRecord PersonRecord { get; set; }

	public DateTimeOffset Today { get; set; }

}
