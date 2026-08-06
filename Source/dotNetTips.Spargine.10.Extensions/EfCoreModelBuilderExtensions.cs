// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : Copilot Agent
// Created          : 07-08-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-09-2026
// ***********************************************************************
// <copyright file="EfCoreModelBuilderExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Extension methods for EF Core ModelBuilder value-converter registrations.
// </summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides common <see cref="ModelBuilder"/> helpers for registering EF Core <see cref="ValueConverter"/> instances.
/// </summary>
[Information(Status = Status.NeedsDocumentation)]
public static class EfCoreModelBuilderExtensions
{

	/// <summary>
	/// Registers enum-to-string value converters for all enum and nullable enum properties in the current model.
	/// Existing property-level converters are preserved.
	/// </summary>
	/// <param name="modelBuilder">The EF Core model builder.</param>
	/// <returns>The same <see cref="ModelBuilder"/> instance for fluent chaining.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="modelBuilder"/> is <see langword="null"/>.</exception>
	[Information(nameof(RegisterEnumAsStringConverters), "Copilot Agent", "07-08-2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static ModelBuilder RegisterEnumAsStringConverters([DisallowNull] this ModelBuilder modelBuilder)
	{
		modelBuilder = modelBuilder.ArgumentNotNull();

		foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(static entityType => entityType.GetProperties()))
		{
			if (property.GetValueConverter() is not null)
			{
				continue;
			}

			var clrType = property.ClrType;
			var underlyingType = Nullable.GetUnderlyingType(clrType);

			if (clrType.IsEnum || underlyingType?.IsEnum == true)
			{
				var enumType = underlyingType ?? clrType;
				var converterType = typeof(EnumToStringConverter<>).MakeGenericType(enumType);
				property.SetValueConverter((ValueConverter)Activator.CreateInstance(converterType)!);
			}
		}

		return modelBuilder;
	}

	/// <summary>
	/// Registers Guid-to-string value converters for all <see cref="Guid"/> and nullable <see cref="Guid"/> properties in the current model.
	/// Existing property-level converters are preserved.
	/// </summary>
	/// <param name="modelBuilder">The EF Core model builder.</param>
	/// <returns>The same <see cref="ModelBuilder"/> instance for fluent chaining.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="modelBuilder"/> is <see langword="null"/>.</exception>
	[Information(nameof(RegisterGuidAsStringConverters), "Copilot Agent", "07-08-2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static ModelBuilder RegisterGuidAsStringConverters([DisallowNull] this ModelBuilder modelBuilder)
	{
		modelBuilder = modelBuilder.ArgumentNotNull();

		foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(static entityType => entityType.GetProperties()))
		{
			if (property.GetValueConverter() is not null)
			{
				continue;
			}

			var clrType = property.ClrType;
			var underlyingType = Nullable.GetUnderlyingType(clrType);

			if (clrType == typeof(Guid))
			{
				property.SetValueConverter(new ValueConverter<Guid, string>(
					value => value.ToString(),
					value => Guid.Parse(value)));
			}
			else if (underlyingType == typeof(Guid))
			{
				property.SetValueConverter(new ValueConverter<Guid?, string?>(
					value => value.HasValue ? value.Value.ToString() : null,
					value => string.IsNullOrWhiteSpace(value) ? null : Guid.Parse(value)));
			}
		}

		return modelBuilder;
	}

}
