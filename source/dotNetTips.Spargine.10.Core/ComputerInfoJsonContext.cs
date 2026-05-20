// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 05-12-2026
//
// Last Modified By : David McCarter
// Last Modified On : 05-12-2026
// ***********************************************************************
// <copyright file="ComputerInfoJsonContext.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Text.Json.Serialization;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core;

[JsonSerializable(typeof(ComputerInfo))]
internal sealed partial class ComputerInfoJsonContext : JsonSerializerContext
{
}
