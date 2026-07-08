// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : Copilot Agent
// Created          : 07-08-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-08-2026
// ***********************************************************************
// <copyright file="MessagePackExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class MessagePackExtensionsTests
{
	[TestMethod]
	public void FromMessagePack_EmptyBytes_ThrowsArgumentNullException()
	{
		var bytes = Array.Empty<byte>();

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => bytes.FromMessagePack<Person>());
	}

	[TestMethod]
	public void FromMessagePack_NullBytes_ThrowsArgumentNullException()
	{
		byte[] bytes = null;

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => bytes.FromMessagePack<Person>());
	}

	[TestMethod]
	public void MessagePack_RoundTrip_Person_PreservesValues()
	{
		var person = RandomData.GeneratePerson<Person>();

		var bytes = person.ToMessagePackBytes();
		var restored = bytes.FromMessagePack<Person>();

		Assert.IsNotNull(restored);
		Assert.AreEqual(person.Id, restored.Id);
		Assert.AreEqual(person.FirstName, restored.FirstName);
		Assert.AreEqual(person.LastName, restored.LastName);
	}

	[TestMethod]
	public void ToMessagePackBytes_NullValue_ThrowsArgumentNullException()
	{
		Person person = null;

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => person.ToMessagePackBytes());
	}

	[TestMethod]
	public void ToMessagePackBytes_ValidValue_ReturnsBytes()
	{
		var person = RandomData.GeneratePerson<Person>();

		var bytes = person.ToMessagePackBytes();

		Assert.IsNotNull(bytes);
		Assert.IsTrue(bytes.Length > 0);
	}
}
