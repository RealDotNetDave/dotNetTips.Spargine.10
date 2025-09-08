// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Tester
// Author           : David McCarter
// Created          : 03-08-2023
//
// Last Modified By : David McCarter
// Last Modified On : 10-27-2024
// ***********************************************************************
// <copyright file="PersonJsonSerializerContext.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// JSON context designed to optimize the serialization and
// deserialization processes for the "Person" type and collections of
// "Person."
// </summary>
// ***********************************************************************

using System.Text.Json.Serialization;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Tester.Models.Serializers;

/// <summary>  
/// Provides a custom JSON serialization context for optimizing the serialization  
/// and deserialization of <see cref="Person"/> types and their collections.  
/// </summary>  
[JsonSourceGenerationOptions(IncludeFields = false, PropertyNamingPolicy = JsonKnownNamingPolicy.KebabCaseLower)]
[JsonSerializable(typeof(PersonRecord), TypeInfoPropertyName = "Person")]
[JsonSerializable(typeof(List<PersonRecord>), TypeInfoPropertyName = "PersonList")]
[Information(nameof(PersonRecordJsonSerializerContext), Status = Status.Updated)]
public partial class PersonRecordJsonSerializerContext : JsonSerializerContext
{

}

