// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Tester
// Author           : David McCarter
// Created          : 03-08-2023
//
// Last Modified By : David McCarter
// Last Modified On : 12-15-2025
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
/// and deserialization of <see cref="Person"/> types and their collections using source generation.
/// </summary>
/// <remarks>
/// This class leverages the System.Text.Json source generation feature to provide compile-time
/// generation of serialization code, offering several benefits:
/// <list type="bullet">
/// <item><description>Improved performance through pre-generated serialization code</description></item>
/// <item><description>Reduced memory allocations during serialization/deserialization</description></item>
/// <item><description>Native AOT (Ahead-of-Time) compilation support</description></item>
/// <item><description>Trim-safe serialization without runtime reflection</description></item>
/// </list>
/// The context is configured with the following options:
/// <list type="bullet">
/// <item><description><see cref="JsonSourceGenerationOptionsAttribute.IncludeFields"/> = false - Only properties are serialized, fields are excluded</description></item>
/// <item><description><see cref="JsonSourceGenerationOptionsAttribute.PropertyNamingPolicy"/> = <see cref="JsonKnownNamingPolicy.KebabCaseLower"/> - Properties are serialized using kebab-case-lower naming (e.g., "first-name")</description></item>
/// </list>
/// This context supports serialization of:
/// <list type="bullet">
/// <item><description>Single <see cref="Person"/> instances via the <c>Person</c> property</description></item>
/// <item><description>Collections of <see cref="Person"/> objects via the <c>PersonList</c> property</description></item>
/// </list>
/// </remarks>
/// <example>
/// This example shows how to use the PersonRefJsonSerializerContext for serialization and deserialization.
/// <code>
/// // Serialization
/// var person = new Person { FirstName = "John", LastName = "Doe" };
/// string json = JsonSerializer.Serialize(person, PersonRefJsonSerializerContext.Default.Person);
/// 
/// // Deserialization
/// var deserializedPerson = JsonSerializer.Deserialize(json, PersonRefJsonSerializerContext.Default.Person);
/// 
/// // Collection serialization
/// var people = new List&lt;Person&gt; { person };
/// string jsonList = JsonSerializer.Serialize(people, PersonRefJsonSerializerContext.Default.PersonList);
/// </code>
/// </example>
[JsonSourceGenerationOptions(IncludeFields = false, PropertyNamingPolicy = JsonKnownNamingPolicy.KebabCaseLower)]
[JsonSerializable(typeof(Person), TypeInfoPropertyName = "Person")]
[JsonSerializable(typeof(List<Person>), TypeInfoPropertyName = "PersonList")]
[Information(nameof(PersonRefJsonSerializerContext), Status = Status.Updated)]
public partial class PersonRefJsonSerializerContext : JsonSerializerContext
{

}

