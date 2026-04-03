// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 05-05-2023
//
// Last Modified By : David McCarter
// Last Modified On : 04-03-2026
// ***********************************************************************
// <copyright file="WIP.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Threading;
using DotNetTips.Spargine.Core.Devices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class WIP
{

	[TestMethod]
	public void TEST03()
	{
		//var result = PathHelper.InvalidFilterChars().ToList().ToDelimitedString();

		Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-HK");

		var result = string.Format(CultureInfo.CurrentCulture, "The time is now: {0}.", Clock.LocalTime);

		Assert.IsNotNull(result);
	}

}
