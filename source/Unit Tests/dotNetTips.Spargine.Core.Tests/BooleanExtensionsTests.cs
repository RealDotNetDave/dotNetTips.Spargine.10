
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

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
