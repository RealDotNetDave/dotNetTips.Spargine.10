
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class BooleanExtensionsTests
{

	[TestMethod]
	public void ToLowerCase_False_ReturnsFalseLowerCase()
	{
		// Act
		var result = false.ToLowerCase();

		// Assert
		Assert.AreEqual("false", result);
	}
	[TestMethod]
	public void ToLowerCase_True_ReturnsTrueLowerCase()
	{
		// Act
		var result = true.ToLowerCase();

		// Assert
		Assert.AreEqual("true", result);
	}
}
