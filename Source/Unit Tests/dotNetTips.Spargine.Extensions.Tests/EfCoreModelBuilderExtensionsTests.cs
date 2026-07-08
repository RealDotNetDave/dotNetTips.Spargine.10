// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : Copilot Agent
// Created          : 07-08-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-08-2026
// ***********************************************************************
// <copyright file="EfCoreModelBuilderExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Unit tests for EfCoreModelBuilderExtensions methods.</summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class EfCoreModelBuilderExtensionsTests
{

	private enum TestStatus
	{
		Unknown,
		Active,
		Inactive,
	}

	[TestMethod]
	public void RegisterEnumAsStringConverters_NullModelBuilder_ThrowsArgumentNullException()
	{
		ModelBuilder modelBuilder = null;

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => modelBuilder.RegisterEnumAsStringConverters());
	}

	[TestMethod]
	public void RegisterEnumAsStringConverters_SetsConvertersForEnumAndNullableEnumProperties()
	{
		using var context = CreateTestContext();
		var model = context.Model;
		var entityType = model.FindEntityType(typeof(TestEntity));

		Assert.IsNotNull(entityType);

		var enumProperty = entityType.FindProperty(nameof(TestEntity.Status));
		var nullableEnumProperty = entityType.FindProperty(nameof(TestEntity.OptionalStatus));

		Assert.IsNotNull(enumProperty);
		Assert.IsNotNull(nullableEnumProperty);
		Assert.IsNotNull(enumProperty.GetValueConverter());
		Assert.IsNotNull(nullableEnumProperty.GetValueConverter());
	}

	[TestMethod]
	public void RegisterGuidAsStringConverters_DoesNotOverrideExistingConverter()
	{
		using var context = CreateExistingConverterContext();
		var model = context.Model;
		var entityType = model.FindEntityType(typeof(EntityWithExistingConverter));

		Assert.IsNotNull(entityType);

		var property = entityType.FindProperty(nameof(EntityWithExistingConverter.ExternalId));

		Assert.IsNotNull(property);
		var converter = property.GetValueConverter();
		Assert.IsNotNull(converter);
		Assert.AreEqual(typeof(Guid), converter.ModelClrType);
		Assert.AreEqual(typeof(Guid), converter.ProviderClrType);
	}

	[TestMethod]
	public void RegisterGuidAsStringConverters_NullModelBuilder_ThrowsArgumentNullException()
	{
		ModelBuilder modelBuilder = null;

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => modelBuilder.RegisterGuidAsStringConverters());
	}

	[TestMethod]
	public void RegisterGuidAsStringConverters_SetsConvertersForGuidAndNullableGuidProperties()
	{
		using var context = CreateTestContext();
		var model = context.Model;
		var entityType = model.FindEntityType(typeof(TestEntity));

		Assert.IsNotNull(entityType);

		var guidProperty = entityType.FindProperty(nameof(TestEntity.ExternalId));
		var nullableGuidProperty = entityType.FindProperty(nameof(TestEntity.OptionalExternalId));

		Assert.IsNotNull(guidProperty);
		Assert.IsNotNull(nullableGuidProperty);
		Assert.IsNotNull(guidProperty.GetValueConverter());
		Assert.IsNotNull(nullableGuidProperty.GetValueConverter());
	}

	private static ExistingConverterContext CreateExistingConverterContext()
	{
		var options = new DbContextOptionsBuilder<ExistingConverterContext>()
			.UseSqlite("Data Source=:memory:")
			.Options;

		var context = new ExistingConverterContext(options);
		context.Database.OpenConnection();
		context.Database.EnsureCreated();

		return context;
	}

	private static TestDbContext CreateTestContext()
	{
		var options = new DbContextOptionsBuilder<TestDbContext>()
			.UseSqlite("Data Source=:memory:")
			.Options;

		var context = new TestDbContext(options);
		context.Database.OpenConnection();
		context.Database.EnsureCreated();

		return context;
	}

	private sealed class EntityWithExistingConverter
	{

		public Guid ExternalId { get; set; }
		public int Id { get; set; }
	}

	private sealed class ExistingConverterContext : DbContext
	{
		public ExistingConverterContext(DbContextOptions<ExistingConverterContext> options) : base(options) { }

		public DbSet<EntityWithExistingConverter> Entities { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<EntityWithExistingConverter>(ConfigureEntityWithExistingConverter);
			modelBuilder.RegisterGuidAsStringConverters();
		}

		private static void ConfigureEntityWithExistingConverter(EntityTypeBuilder<EntityWithExistingConverter> builder)
		{
			builder.Property(static entity => entity.ExternalId)
				.HasConversion(new ValueConverter<Guid, Guid>(value => value, value => value));
		}
	}

	private sealed class TestDbContext : DbContext
	{
		public TestDbContext(DbContextOptions<TestDbContext> options) : base(options) { }

		public DbSet<TestEntity> TestEntities { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.RegisterEnumAsStringConverters();
			modelBuilder.RegisterGuidAsStringConverters();
		}
	}

	private sealed class TestEntity
	{

		public Guid ExternalId { get; set; }
		public int Id { get; set; }

		public Guid? OptionalExternalId { get; set; }

		public TestStatus? OptionalStatus { get; set; }

		public TestStatus Status { get; set; }
	}
}
