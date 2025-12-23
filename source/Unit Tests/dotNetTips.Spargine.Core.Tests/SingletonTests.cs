// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 01-16-2022
//
// Last Modified By : David McCarter
// Last Modified On : 08-09-2023
// ***********************************************************************
// <copyright file="SingletonTests.cs" company="McCarter Consulting">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class SingletonTests
{

	[TestMethod]
	public void SingletonTest01()
	{
		var list = Singleton<ObservableList<string>>.Instance;

		Assert.IsNotNull(list);

		Assert.IsInstanceOfType(list, typeof(ObservableList<string>));
	}

}
