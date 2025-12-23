// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Tester
// Author           : David McCarter
// Created          : 03-08-2023
//
// Last Modified By : David McCarter
// Last Modified On : 12-15-2025
// ***********************************************************************
// <copyright file="PersonValJsonSerializerContext.cs" company="McCarter Consulting">
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
using DotNetTips.Spargine.Tester.Models.ValueTypes;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Tester.Models.Serializers;

/// <summary>  
/// Provides a custom JSON serialization context for optimizing the serialization  
/// and deserialization of value type <see cref="Person"/> (struct) and their collections using source generation.
/// </summary>
/// <remarks>
/// This class leverages the System.Text.Json source generation feature to provide compile-time
/// generation of serialization code for value types (structs), offering several benefits:
/// <list type="bullet">
/// <item><description>Improved performance through pre-generated serialization code optimized for value types</description></item>
/// <item><description>Reduced memory allocations during serialization/deserialization of struct types</description></item>
/// <item><description>Native AOT (Ahead-of-Time) compilation support</description></item>
/// <item><description>Trim-safe serialization without runtime reflection</description></item>
/// <item><description>Optimized handling of value types with stack allocation benefits</description></item>
/// </list>
/// The context is configured with the following options:
/// <list type="bullet">
/// <item><description><see cref="JsonSourceGenerationOptionsAttribute.IncludeFields"/> = false - Only properties are serialized, fields are excluded</description></item>
/// <item><description><see cref="JsonSourceGenerationOptionsAttribute.PropertyNamingPolicy"/> = <see cref="JsonKnownNamingPolicy.KebabCaseLower"/> - Properties are serialized using kebab-case-lower naming (e.g., "first-name")</description></item>
/// </list>
/// This context supports serialization of:
/// <list type="bullet">
/// <item><description>Single <see cref="Person"/> struct instances via the <c>Person</c> property</description></item>
/// <item><description>Collections of <see cref="Person"/> value types via the <c>PersonList</c> property</description></item>
/// </list>
/// </remarks>
/// <example>
/// This example shows how to use the PersonValJsonSerializerContext for serialization and deserialization of value type Person structs.
/// <code>
/// // Serialization
/// var person = new Person { FirstName = "John", LastName = "Doe" };
/// string json = JsonSerializer.Serialize(person, PersonValJsonSerializerContext.Default.Person);
/// // Result: {"first-name":"John","last-name":"Doe"}
/// 
/// // Deserialization
/// var deserializedPerson = JsonSerializer.Deserialize(json, PersonValJsonSerializerContext.Default.Person);
/// 
/// // Collection serialization
/// var people = new List&lt;Person&gt; { person };
/// string jsonList = JsonSerializer.Serialize(people, PersonValJsonSerializerContext.Default.PersonList);
/// 
/// // Using with JsonSerializerOptions
/// var options = new JsonSerializerOptions
/// {
///     TypeInfoResolver = PersonValJsonSerializerContext.Default
/// };
/// string jsonWithOptions = JsonSerializer.Serialize(person, options);
/// </code>
/// </example>
[JsonSourceGenerationOptions(IncludeFields = false, PropertyNamingPolicy = JsonKnownNamingPolicy.KebabCaseLower)]
[JsonSerializable(typeof(Person), TypeInfoPropertyName = "Person")]
[JsonSerializable(typeof(List<Person>), TypeInfoPropertyName = "PersonList")]
[Information(nameof(PersonValJsonSerializerContext), Status = Status.Updated)]
public partial class PersonValJsonSerializerContext : JsonSerializerContext
{

}

