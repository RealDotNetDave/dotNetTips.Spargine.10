// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 05-01-2025
//
// Last Modified By : David McCarter
// Last Modified On : 12-30-2025
// ***********************************************************************
// <copyright file="TypeHelperBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.BenchmarkTests;

/// <summary>
/// TypeHelper PerfTestRunner.
/// Implements the <see cref="Benchmarking.PerfTestRunner" />
/// </summary>
/// <seealso cref="Benchmarking.PerfTestRunner" />
public class TypeHelperBenchmark : Benchmark
{

	private readonly int _collectionCount = 50;
	private List<Person> _people;

	private Dictionary<Type, string> BuiltInTypeNamesNoCache()
	{

		var builtInTypes = new Dictionary<Type, string>();

		// Add primitive types
		var primitiveTypes = new[]
		{
				typeof(bool), typeof(byte), typeof(char), typeof(decimal), typeof(double),
				typeof(float), typeof(int), typeof(long), typeof(sbyte), typeof(short),
				typeof(uint), typeof(ulong), typeof(ushort)
			};

		var options = new DisplayNameOptions(fullName: false, includeGenericParameterNames: true, includeGenericParameters: true);

		foreach (var type in primitiveTypes)
		{
			builtInTypes[type] = TypeHelper.GetTypeDisplayName(type, options);
		}

		// Add other common built-in types
		var commonTypes = new[]
		{
				typeof(string), typeof(object), typeof(DateTime), typeof(DateTimeOffset),
				typeof(TimeSpan), typeof(Guid), typeof(Uri), typeof(BigInteger), typeof(Half),
				typeof(IntPtr), typeof(UIntPtr), typeof(DateTimeKind), typeof(Nullable<>),
				typeof(ValueTuple), typeof(Tuple), typeof(Span<>), typeof(ReadOnlySpan<>),
				typeof(Memory<>), typeof(ReadOnlyMemory<>), typeof(ArraySegment<>),
				typeof(KeyValuePair<,>), typeof(List<>), typeof(Dictionary<,>), typeof(HashSet<>),
				typeof(Queue<>), typeof(Stack<>), typeof(LinkedList<>), typeof(SortedList<,>),
				typeof(SortedDictionary<,>), typeof(SortedSet<>), typeof(ConcurrentDictionary<,>),
				typeof(ConcurrentQueue<>), typeof(ConcurrentStack<>), typeof(BlockingCollection<>),
				typeof(ObservableCollection<>), typeof(ReadOnlyCollection<>), typeof(ReadOnlyDictionary<,>),
				typeof(ReadOnlyObservableCollection<>), typeof(ImmutableArray<>), typeof(ImmutableList<>),
				typeof(ImmutableDictionary<,>), typeof(ImmutableHashSet<>), typeof(ImmutableQueue<>),
				typeof(ImmutableStack<>), typeof(ImmutableSortedDictionary<,>), typeof(ImmutableSortedSet<>)
			};

		foreach (var type in commonTypes)
		{
			builtInTypes[type] = TypeHelper.GetTypeDisplayName(type, includeGenericParameterNames: true, includeGenericParameters: true);
		}

		// Add types from the System namespace
		var systemTypes = Assembly.GetAssembly(typeof(int))?.GetTypes()
			.Where(t => string.Equals(t.Namespace, "System", StringComparison.Ordinal) && t.IsPublic && !t.IsGenericType)
			.ToList();

		foreach (var type in systemTypes!)
		{
			builtInTypes[type] = TypeHelper.GetTypeDisplayName(type, includeGenericParameterNames: true, includeGenericParameters: true);
		}

		return builtInTypes;
	}

	private ReadOnlyCollection<Type> FindDerivedTypesNoCache([DisallowNull] AppDomain currentDomain, [DisallowNull] Type baseType, bool classOnly)
	{
		currentDomain = currentDomain.ArgumentNotNull();
		baseType = baseType.ArgumentNotNull();

		var assemblyCollection = currentDomain.GetAssemblies();

		List<Type> types = [];

		foreach (var assembly in assemblyCollection)
		{
			try
			{
				types.AddRange(this.LoadDerivedTypesNoCache(assembly.DefinedTypes, baseType, classOnly));
			}
			catch (ReflectionTypeLoadException reflectionEx)
			{
				Trace.WriteLine(reflectionEx.GetAllMessages());
			}
		}

		var result = types.ToArray();

		return Array.AsReadOnly(result);
	}

	private ReadOnlyCollection<MethodInfo> GetAllAbstractMethodsNoCache([DisallowNull] Type type)
	{
		type = type.ArgumentNotNull();


		var methods = type.GetTypeInfo().DeclaredMethods.Where(m => m.IsAbstract).ToArray();

		return Array.AsReadOnly(methods);
	}

	private IEnumerable<ConstructorInfo> GetAllConstructorsNoCache([DisallowNull] Type type)
	{
		type = type.ArgumentNotNull();


		var typeInfo = type.GetTypeInfo();
		var constructors = new List<ConstructorInfo>();

		while (typeInfo is not null)
		{
			constructors.AddRange(typeInfo.DeclaredConstructors);
			typeInfo = typeInfo.BaseType?.GetTypeInfo();
		}


		foreach (var ctor in constructors)
		{
			yield return ctor;
		}
	}


	private IEnumerable<FieldInfo> GetAllDeclaredFieldsNoCache([DisallowNull] Type type)
	{
		type = type.ArgumentNotNull();


		var fields = type.GetFields(
			BindingFlags.Instance |
			BindingFlags.Static |
			BindingFlags.Public |
			BindingFlags.NonPublic |
			BindingFlags.DeclaredOnly);


		foreach (var field in fields)
		{
			yield return field;
		}
	}

	private IEnumerable<MethodInfo> GetAllDeclaredMethodsNoCache([DisallowNull] Type type)
	{
		type = type.ArgumentNotNull();

		var methods = type.GetMethods(
			BindingFlags.Instance |
			BindingFlags.Static |
			BindingFlags.Public |
			BindingFlags.NonPublic |
			BindingFlags.DeclaredOnly);


		foreach (var method in methods)
		{
			yield return method;
		}
	}

	private IEnumerable<FieldInfo> GetAllFieldsNoCache([DisallowNull] Type type)
	{
		type = type.ArgumentNotNull();

		var fields = new List<FieldInfo>();
		var typeInfo = type.GetTypeInfo();

		while (typeInfo is not null)
		{
			fields.AddRange(typeInfo.DeclaredFields);
			typeInfo = typeInfo.BaseType?.GetTypeInfo();
		}

		foreach (var field in fields)
		{
			yield return field;
		}
	}

	private IEnumerable<MethodInfo> GetAllMethodsNoCache([DisallowNull] Type type)
	{
		type = type.ArgumentNotNull();


		var methods = new List<MethodInfo>();
		var typeInfo = type.GetTypeInfo();

		while (typeInfo is not null)
		{
			methods.AddRange(typeInfo.DeclaredMethods);
			typeInfo = typeInfo.BaseType?.GetTypeInfo();
		}

		foreach (var method in methods)
		{
			yield return method;
		}
	}

	private IEnumerable<PropertyInfo> GetAllPropertiesNoCache([DisallowNull] Type type)
	{
		type = type.ArgumentNotNull();

		var properties = new List<PropertyInfo>();
		var typeInfo = type.GetTypeInfo();

		while (typeInfo is not null)
		{
			properties.AddRange(typeInfo.DeclaredProperties);
			typeInfo = typeInfo.BaseType?.GetTypeInfo();
		}


		foreach (var property in properties)
		{
			yield return property;
		}
	}

	private IEnumerable<MemberInfo> GetMembersWithAttributeNoCache<TAttribute>([DisallowNull] Type type) where TAttribute : Attribute
	{
		type = type.ArgumentNotNull();

		var membersWithAttribute = new List<MemberInfo>();

		// Check for attributes on the type itself
		if (Attribute.IsDefined(type, typeof(TAttribute), true))
		{
			membersWithAttribute.Add(type);
		}

		// Define binding flags once to avoid repetition
		var bindingFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;

		// Check for attributes on the properties, methods, fields, and events of the type
		foreach (var member in type.GetMembers(bindingFlags))
		{
			if (Attribute.IsDefined(member, typeof(TAttribute), true))
			{
				membersWithAttribute.Add(member);
			}
		}

		foreach (var member in membersWithAttribute)
		{
			yield return member;
		}
	}

	private bool HasBaseClassNoCache(Type type, Type baseClass)
	{
		type = type.ArgumentNotNull();

		if (baseClass == null)
		{
			return false;
		}

		// Calculate the result if not cached
		var result = false;
		var currentType = type;

		while (currentType is not null)
		{
			if (currentType == baseClass)
			{
				result = true;
				break;
			}

			currentType = currentType.BaseType!;
		}

		return result;
	}

	private bool ImplementsInterfaceNoCache([DisallowNull] Type type, [DisallowNull] Type interfaceType)
	{
		type = type.ArgumentNotNull();

		if (interfaceType == null || interfaceType.IsInterface == false)
		{
			return false;
		}

		// Calculate the result if not cached
		var result = type.GetInterfaces().Any(i => i == interfaceType);

		return result;
	}

	private IEnumerable<Type> LoadDerivedTypesNoCache(IEnumerable<TypeInfo> types, Type baseType, bool classOnly)
	{
		foreach (var type in types)
		{
			if (classOnly && !type.IsClass)
			{
				continue;
			}

			if (baseType.IsInterface)
			{
				if (type.ImplementedInterfaces.Contains(baseType))
				{
					yield return type.AsType();
				}
			}
			else if (type.IsSubclassOf(baseType))
			{
				yield return type.AsType();
			}
		}
	}

	[Benchmark(Description = nameof(TypeHelper.BuiltInTypeNames) + ": No Cache")]
	[BenchmarkCategory(Categories.ForComparison, Categories.New)]
	public void BuiltInTypeNames_NoCache()
	{
		var result = this.BuiltInTypeNamesNoCache();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.BuiltInTypeNames) + ": Cached")]
	[BenchmarkCategory(Categories.Reflection, Categories.New)]
	public void BuiltInTypeNamesCached()
	{
		var result = TypeHelper.BuiltInTypeNames();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.BuiltInTypes))]
	[BenchmarkCategory(Categories.Reflection)]
	public void BuiltInTypes()
	{
		var result = TypeHelper.BuiltInTypes;

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.Create))]
	[BenchmarkCategory(Categories.Strings)]
	public void CreateNormal()
	{
		var result = TypeHelper.Create<Person>();

		this.Consume(result);
	}

	[Benchmark(Description = "Looping Collection: Normal StringBuilder")]
	[BenchmarkCategory(Categories.Strings)]
	public void CreateStringBuilder()
	{
		var sb = new StringBuilder();

		foreach (var person in this._people)
		{
			_ = sb.AppendFormat(CultureInfo.InvariantCulture, "{0}={1}", person.Email, person.Id);
		}

		this.Consume(sb.ToString());
	}

	[Benchmark(Description = nameof(TypeHelper.Create) + ": With Parameters")]
	[BenchmarkCategory(Categories.Strings)]
	public void CreateWithParameters()
	{
		var result = TypeHelper.Create<Person>("DOTNETDAVE@LIVE.COM", "TESTID12345678");

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.DoesObjectEqualInstance))]
	[BenchmarkCategory(Categories.Strings)]
	public void DoesObjectEqualInstance()
	{
		var result = TypeHelper.DoesObjectEqualInstance(this.PersonRef01, this.PersonRef02);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.FindDerivedTypes) + ": No Cache")]
	[BenchmarkCategory(Categories.ForComparison)]
	public void FindDerivedTypes()
	{
		var result = this.FindDerivedTypesNoCache(AppDomain.CurrentDomain, typeof(Exception), true);
		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.FindDerivedTypes) + ": Cached")]
	[BenchmarkCategory(Categories.Reflection)]
	public void FindDerivedTypesCached()
	{
		var result = TypeHelper.FindDerivedTypes(AppDomain.CurrentDomain, typeof(Exception), true);
		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.GetAllAbstractMethods) + ": No Cache")]
	[BenchmarkCategory(Categories.ForComparison)]
	public void GetAllAbstractMethods()
	{
		var result = this.GetAllAbstractMethodsNoCache(typeof(Benchmark));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.GetAllAbstractMethods) + ": Cached")]
	[BenchmarkCategory(Categories.Reflection, Categories.New)]
	public void GetAllAbstractMethodsCached()
	{
		var result = TypeHelper.GetAllAbstractMethods(typeof(Benchmark));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.GetAllConstructors) + ": No Cache")]
	[BenchmarkCategory(Categories.ForComparison)]
	public void GetAllConstructors()
	{
		var result = this.GetAllConstructorsNoCache(typeof(Benchmark));

		foreach (var item in result)
		{
			this.Consume(item);
		}
	}

	[Benchmark(Description = nameof(TypeHelper.GetAllConstructors) + ": Cached")]
	[BenchmarkCategory(Categories.Reflection, Categories.New)]
	public void GetAllConstructorsCached()
	{
		var result = TypeHelper.GetAllConstructors(typeof(Benchmark));

		foreach (var item in result)
		{
			this.Consume(item);
		}
	}

	[Benchmark(Description = nameof(TypeHelper.GetAllDeclaredFields) + ": No Cache")]
	[BenchmarkCategory(Categories.ForComparison)]
	public void GetAllDeclaredFields()
	{
		var result = this.GetAllDeclaredFieldsNoCache(typeof(Benchmark));

		foreach (var item in result)
		{
			this.Consume(item);
		}
	}

	[Benchmark(Description = nameof(TypeHelper.GetAllDeclaredFields) + ": Cached")]
	[BenchmarkCategory(Categories.Reflection, Categories.New)]
	public void GetAllDeclaredFieldsCached()
	{
		var result = TypeHelper.GetAllDeclaredFields(typeof(Benchmark));

		this.Consume(result.Count());
	}

	[Benchmark(Description = nameof(TypeHelper.GetAllDeclaredMethods) + ": No Cache")]
	[BenchmarkCategory(Categories.ForComparison)]
	public void GetAllDeclaredMethods()
	{
		var result = this.GetAllDeclaredMethodsNoCache(typeof(Benchmark));

		foreach (var item in result)
		{
			this.Consume(item);
		}
	}


	[Benchmark(Description = nameof(TypeHelper.GetAllDeclaredMethods) + ": Cached")]
	[BenchmarkCategory(Categories.Reflection, Categories.New)]
	public void GetAllDeclaredMethodsCached()
	{
		var result = TypeHelper.GetAllDeclaredMethods(typeof(Benchmark));

		foreach (var item in result)
		{
			this.Consume(item);
		}
	}

	[Benchmark(Description = nameof(TypeHelper.GetAllFields) + ": No Cache")]
	[BenchmarkCategory(Categories.ForComparison)]
	public void GetAllFields()
	{
		var result = this.GetAllFieldsNoCache(typeof(Benchmark));

		foreach (var item in result)
		{
			this.Consume(item);
		}
	}


	[Benchmark(Description = nameof(TypeHelper.GetAllFields) + ": Cached")]
	[BenchmarkCategory(Categories.Reflection, Categories.New)]
	public void GetAllFieldsCached()
	{
		var result = TypeHelper.GetAllFields(typeof(Benchmark));

		foreach (var item in result)
		{
			this.Consume(item);
		}
	}

	[Benchmark(Description = nameof(TypeHelper.GetAllGenericMethods))]
	[BenchmarkCategory(Categories.Reflection, Categories.New)]
	public void GetAllGenericMethods()
	{
		var result = TypeHelper.GetAllGenericMethods(typeof(StringBuilder));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.GetAllMethods) + ": No Cache")]
	[BenchmarkCategory(Categories.ForComparison)]
	public void GetAllMethods()
	{
		var result = this.GetAllMethodsNoCache(typeof(StringBuilder));

		foreach (var item in result)
		{
			this.Consume(item);
		}
	}

	[Benchmark(Description = nameof(TypeHelper.GetAllMethods) + ": Cached")]
	[BenchmarkCategory(Categories.Reflection, Categories.New)]
	public void GetAllMethodsCached()
	{
		var result = TypeHelper.GetAllMethods(typeof(StringBuilder));

		foreach (var item in result)
		{
			this.Consume(item);
		}
	}

	[Benchmark(Description = nameof(TypeHelper.GetAllProperties) + ": No Cache")]
	[BenchmarkCategory(Categories.ForComparison)]
	public void GetAllProperties()
	{
		var result = this.GetAllPropertiesNoCache(typeof(Person));

		foreach (var item in result)
		{
			this.Consume(item);
		}
	}


	[Benchmark(Description = nameof(TypeHelper.GetAllProperties) + ": Cached")]
	[BenchmarkCategory(Categories.Reflection, Categories.New)]
	public void GetAllPropertiesCached()
	{
		var result = TypeHelper.GetAllProperties(typeof(Person));

		foreach (var item in result)
		{
			this.Consume(item);
		}
	}

	[Benchmark(Description = nameof(TypeHelper.GetAllPublicMethods))]
	[BenchmarkCategory(Categories.Reflection, Categories.New)]
	public void GetAllPublicMethods()
	{
		var result = TypeHelper.GetAllPublicMethods(typeof(Person));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.GetAllStaticMethods))]
	[BenchmarkCategory(Categories.Reflection, Categories.New)]
	public void GetAllStaticMethods()
	{
		var result = TypeHelper.GetAllPublicMethods(typeof(TypeHelper));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.GetAttribute) + ": FieldInfo")]
	[BenchmarkCategory(Categories.Reflection, Categories.New)]
	public void GetAttributeFieldInfo()
	{
#pragma warning disable CS0612 // Type or member is obsolete
		var field = typeof(FieldWithAttributeTestClass).GetField(nameof(FieldWithAttributeTestClass.MarkedField));
#pragma warning restore CS0612 // Type or member is obsolete
		var result = TypeHelper.GetAttribute<ObsoleteAttribute>(field);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.GetGenericArguments))]
	[BenchmarkCategory(Categories.Reflection, Categories.New)]
	public void GetGenericArguments()
	{
		var result = TypeHelper.GetGenericArguments(typeof(Dictionary<string, int>));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.GetImplementedInterfaces))]
	[BenchmarkCategory(Categories.Reflection)]
	public void GetImplementedInterfaces()
	{
		var list = new List<int>();
		var result = TypeHelper.GetImplementedInterfaces(list);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.GetImplementedInterfaces) + ": Interface Names")]
	[BenchmarkCategory(Categories.Reflection, Categories.New)]
	public void GetImplementedInterfacesInterfaceNames()
	{
		var list = new List<int>();
		var result = TypeHelper.GetImplementedInterfaces(list, new List<string> { nameof(IEnumerable), nameof(IDisposable) });

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.GetImplementedInterfaceTypes))]
	[BenchmarkCategory(Categories.Reflection, Categories.New)]
	public void GetImplementedInterfaceTypes()
	{
		var list = new List<int>();
		var result = TypeHelper.GetImplementedInterfaceTypes(list);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.GetInstanceHashCode))]
	[BenchmarkCategory(Categories.Reflection)]
	public void GetInstanceHashCode()
	{
		var person = RandomData.GeneratePerson<Person>();

		var result = TypeHelper.GetInstanceHashCode(person);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.GetMembersWithAttribute) + ": No Cache")]
	[BenchmarkCategory(Categories.ForComparison)]
	public void GetMembersWithAttribute()
	{
		var type = typeof(Person);

		var result = this.GetMembersWithAttributeNoCache<InformationAttribute>(type);

		foreach (var item in result)
		{
			this.Consume(item);
		}
	}

	[Benchmark(Description = nameof(TypeHelper.GetMembersWithAttribute) + ": Cached")]
	[BenchmarkCategory(Categories.Strings)]
	public void GetMembersWithAttributeCached()
	{
		var type = typeof(Person);

		var result = TypeHelper.GetMembersWithAttribute<InformationAttribute>(type);

		foreach (var item in result)
		{
			this.Consume(item);
		}
	}

	[Benchmark(Description = nameof(TypeHelper.GetPropertyValues))]
	[BenchmarkCategory(Categories.Reflection)]
	public void GetPropertyValues()
	{
		var person = RandomData.GeneratePerson<Person>();

		var result = TypeHelper.GetPropertyValues(person);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.GetTypeDisplayName) + ": Cached")]
	[BenchmarkCategory(Categories.Reflection, Categories.New)]
	public void GetTypeDisplayNameCached()
	{
		var type = typeof(int[]);
		var options = new DisplayNameOptions(fullName: true, includeGenericParameterNames: false, includeGenericParameters: true);

		var result = TypeHelper.GetTypeDisplayName(type, options);

		this.Consume(result);
	}


	[Benchmark(Description = nameof(TypeHelper.GetTypeMembersWithAttribute))]
	[BenchmarkCategory(Categories.Reflection, Categories.New)]
	public void GetTypeMembersWithAttribute()
	{
		var result = TypeHelper.GetTypeMembersWithAttribute<InformationAttribute>(typeof(TypeHelper));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.HasBaseClass) + ": No Cache")]
	[BenchmarkCategory(Categories.ForComparison)]
	public void HasBaseClass()
	{
		var result = this.HasBaseClassNoCache(typeof(Exception), typeof(object));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.HasBaseClass) + ": Cached")]
	[BenchmarkCategory(Categories.Reflection, Categories.New)]
	public void HasBaseClassCached()
	{
		var result = TypeHelper.HasBaseClass(typeof(Exception), typeof(object));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.HasMethod))]
	[BenchmarkCategory(Categories.Reflection, Categories.New)]
	public void HasMethod()
	{
		var result = TypeHelper.HasMethod(typeof(Person), "ToString");

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.HasParameterlessConstructor))]
	[BenchmarkCategory(Categories.Reflection, Categories.New)]
	public void HasParameterlessConstructor()
	{
		var result = TypeHelper.HasParameterlessConstructor(typeof(StringBuilder));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.HasProperty))]
	[BenchmarkCategory(Categories.Reflection, Categories.New)]
	public void HasProperty()
	{
		var result = TypeHelper.HasProperty(typeof(string), "Length");

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.ImplementsInterface) + ": No Cache")]
	[BenchmarkCategory(Categories.ForComparison)]
	public void ImplementsInterface()
	{
		var result = this.ImplementsInterfaceNoCache(typeof(List<int>), typeof(IEnumerable<>).MakeGenericType(typeof(int)));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.ImplementsInterface) + ": Cached")]
	[BenchmarkCategory(Categories.Reflection, Categories.New)]
	public void ImplementsInterfaceCached()
	{
		var result = TypeHelper.ImplementsInterface(typeof(List<int>), typeof(IEnumerable<>).MakeGenericType(typeof(int)));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.IsAssignableTo))]
	[BenchmarkCategory(Categories.Reflection, Categories.New)]
	public void IsAssignableTo()
	{
		var result = TypeHelper.IsAssignableTo(typeof(string), typeof(object));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.IsClosedGeneric))]
	[BenchmarkCategory(Categories.Reflection, Categories.New)]
	public void IsClosedGeneric()
	{
		var result = TypeHelper.IsClosedGeneric(typeof(List<int>));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.IsEnumerable))]
	[BenchmarkCategory(Categories.Reflection, Categories.New)]
	public void IsEnumerable()
	{
		var result = TypeHelper.IsEnumerable(typeof(List<int>));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.ProcessGenericType))]
	[BenchmarkCategory(Categories.Reflection, Categories.New)]
	public void ProcessGenericType()
	{
		var builder = new StringBuilder();
		var type = typeof(List<>);
		var genericArguments = Array.Empty<Type>();
		var options = new DisplayNameOptions(fullName: true, includeGenericParameterNames: false, includeGenericParameters: true, nestedTypeDelimiter: '.');

		TypeHelper.ProcessGenericType(builder, type, genericArguments, genericArguments.Length, options);

		this.Consume(builder.ToString());
	}

	public override void Setup()
	{
		base.Setup();

		var list = new Dictionary<string, string>(this._collectionCount);
		for (var i = 0; i < this._collectionCount; i++)
		{
			list.Add(RandomData.GenerateKey(), RandomData.GenerateKey());
		}

		this._people = [.. RandomData.GeneratePersonRefCollection(this._collectionCount)];
	}

	private sealed class FieldWithAttributeTestClass
	{
		[Obsolete]
		public int MarkedField;
	}

}
