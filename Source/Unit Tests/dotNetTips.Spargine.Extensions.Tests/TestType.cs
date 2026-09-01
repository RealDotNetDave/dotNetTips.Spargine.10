// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 04-16-2021
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-12-2026
// ***********************************************************************
// <copyright file="TestType.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Serialization;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[XmlRoot]
public class TestType
{

	/// <summary>
	/// A field decorated with <see cref="DebuggerBrowsableAttribute"/> for attribute-inspection tests.
	/// </summary>
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public string TestField;

	/// <summary>
	/// Gets or sets the name of the user.
	/// </summary>
	/// <value>The name of the user.</value>
	[XmlIgnore]
	[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
	public string UserName { get; set; }

	/// <summary>
	/// Gets the name.
	/// </summary>
	/// <returns>System.String.</returns>
	public static string GetName()
	{
		return "GetName";
	}

	/// <summary>
	/// Invokes the specified input.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <returns>System.String.</returns>
	public string Invoke(string input)
	{
		return input;
	}

	/// <summary>
	/// Runs this instance.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public void Run<T>() where T : class
	{
		//Do Nothing
	}

}

