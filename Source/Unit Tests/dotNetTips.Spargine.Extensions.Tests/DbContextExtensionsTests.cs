// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 04-13-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-13-2026
// ***********************************************************************
// <copyright file="DbContextExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Unit tests for DbContextExtensions methods.</summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class DbContextExtensionsTests
{

	[TestMethod]
	public async Task AddAndSaveAsync_EmptyCollection_ReturnsZero()
	{
		// Arrange
		using var context = CreateTestContext();
		var entities = Array.Empty<TestEntity>();

		// Act
		var result = await context.AddAndSaveAsync(entities).ConfigureAwait(false);

		// Assert
		Assert.AreEqual(0, result);
	}

	[TestMethod]
	public async Task AddAndSaveAsync_NullContext_ThrowsArgumentNullException()
	{
		// Arrange
		DbContext context = null;
		var entities = new[] { new TestEntity { Name = "Test" } };

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(
			() => context.AddAndSaveAsync(entities)).ConfigureAwait(false);
	}

	[TestMethod]
	public async Task AddAndSaveAsync_NullEntities_ThrowsArgumentNullException()
	{
		// Arrange
		using var context = CreateTestContext();
		IEnumerable<TestEntity> entities = null;

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(
			() => context.AddAndSaveAsync(entities)).ConfigureAwait(false);
	}

	[TestMethod]
	public async Task AddAndSaveAsync_WithEntities_SavesAndReturnsCount()
	{
		// Arrange
		using var context = CreateTestContext();
		var entities = new[] { new TestEntity { Name = "A" }, new TestEntity { Name = "B" } };

		// Act
		var result = await context.AddAndSaveAsync(entities).ConfigureAwait(false);

		// Assert
		Assert.AreEqual(2, result);
		Assert.AreEqual(2, await context.Set<TestEntity>().CountAsync().ConfigureAwait(false));
	}

	[TestMethod]
	public async Task DeleteAndSaveAsync_NullContext_ThrowsArgumentNullException()
	{
		// Arrange
		DbContext context = null;
		var entities = new[] { new TestEntity { Name = "Test" } };

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(
			() => context.DeleteAndSaveAsync(entities)).ConfigureAwait(false);
	}

	[TestMethod]
	public async Task DeleteAndSaveAsync_NullEntities_ThrowsArgumentNullException()
	{
		// Arrange
		using var context = CreateTestContext();
		IEnumerable<TestEntity> entities = null;

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(
			() => context.DeleteAndSaveAsync(entities)).ConfigureAwait(false);
	}

	[TestMethod]
	public async Task DeleteAndSaveAsync_WithEntities_RemovesAndReturnsCount()
	{
		// Arrange
		using var context = CreateTestContext();
		var entities = new[] { new TestEntity { Name = "A" }, new TestEntity { Name = "B" } };
		context.Set<TestEntity>().AddRange(entities);
		await context.SaveChangesAsync().ConfigureAwait(false);
		Assert.AreEqual(2, await context.Set<TestEntity>().CountAsync().ConfigureAwait(false));

		// Act
		var result = await context.DeleteAndSaveAsync(entities).ConfigureAwait(false);

		// Assert
		Assert.AreEqual(2, result);
		Assert.AreEqual(0, await context.Set<TestEntity>().CountAsync().ConfigureAwait(false));
	}

	[TestMethod]
	public async Task ExecuteInTransactionAsync_NullAction_ThrowsArgumentNullException()
	{
		// Arrange
		using var context = CreateTestContext();
		Func<DbContext, CancellationToken, Task> action = null;

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(
			() => context.ExecuteInTransactionAsync(action)).ConfigureAwait(false);
	}

	[TestMethod]
	public async Task ExecuteInTransactionAsync_NullContext_ThrowsArgumentNullException()
	{
		// Arrange
		DbContext context = null;
		Func<DbContext, CancellationToken, Task> action = (_, _) => Task.CompletedTask;

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(
			() => context.ExecuteInTransactionAsync(action)).ConfigureAwait(false);
	}

	[TestMethod]
	public async Task ExecuteInTransactionAsync_SuccessfulAction_CommitsTransaction()
	{
		// Arrange
		using var context = CreateTestContext();

		// Act
		await context.ExecuteInTransactionAsync(async (ctx, ct) =>
		{
			ctx.Set<TestEntity>().Add(new TestEntity { Name = "Transacted" });
			await ctx.SaveChangesAsync(ct).ConfigureAwait(false);
		}).ConfigureAwait(false);

		// Assert
		Assert.AreEqual(1, await context.Set<TestEntity>().CountAsync().ConfigureAwait(false));
	}

	[TestMethod]
	public async Task GetChangedEntities_InvalidState_ThrowsArgumentOutOfRangeException()
	{
		// Arrange
		using var context = CreateTestContext();

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(
			() => context.GetChangedEntities<TestEntity>((EntityState)999));
	}

	[TestMethod]
	public async Task GetChangedEntities_NoMatchingState_ReturnsEmpty()
	{
		// Arrange
		using var context = CreateTestContext();
		var entity = new TestEntity { Name = "Added" };
		context.Set<TestEntity>().Add(entity);

		// Act
		var result = context.GetChangedEntities<TestEntity>(EntityState.Deleted);

		// Assert
		Assert.AreEqual(0, result.Count);
	}

	[TestMethod]
	public async Task GetChangedEntities_NullContext_ThrowsArgumentNullException()
	{
		// Arrange
		DbContext context = null;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => context.GetChangedEntities<TestEntity>(EntityState.Added));
	}

	[TestMethod]
	public async Task GetChangedEntities_ReturnsAddedEntities()
	{
		// Arrange
		using var context = CreateTestContext();
		var entity = new TestEntity { Name = "Added" };
		context.Set<TestEntity>().Add(entity);

		// Act
		var result = context.GetChangedEntities<TestEntity>(EntityState.Added);

		// Assert
		Assert.AreEqual(1, result.Count);
		Assert.AreEqual("Added", result[0].Name);
	}

	[TestMethod]
	public async Task GetRecordCountAsync_EmptyTable_ReturnsZero()
	{
		// Arrange
		using var context = CreateTestContext();

		// Act
		var result = await context.GetRecordCountAsync<TestEntity>().ConfigureAwait(false);

		// Assert
		Assert.AreEqual(0, result);
	}

	[TestMethod]
	public async Task GetRecordCountAsync_NullContext_ThrowsArgumentNullException()
	{
		// Arrange
		DbContext context = null;

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(
			() => context.GetRecordCountAsync<TestEntity>()).ConfigureAwait(false);
	}

	[TestMethod]
	public async Task GetRecordCountAsync_WithRecords_ReturnsCount()
	{
		// Arrange
		using var context = CreateTestContext();
		context.Set<TestEntity>().AddRange(new TestEntity { Name = "A" }, new TestEntity { Name = "B" });
		await context.SaveChangesAsync().ConfigureAwait(false);

		// Act
		var result = await context.GetRecordCountAsync<TestEntity>().ConfigureAwait(false);

		// Assert
		Assert.AreEqual(2, result);
	}

	[TestMethod]
	public async Task GetRecordCountAsyncWithPredicate_FiltersCorrectly()
	{
		// Arrange
		using var context = CreateTestContext();
		context.Set<TestEntity>().AddRange(new TestEntity { Name = "Match" }, new TestEntity { Name = "Other" });
		await context.SaveChangesAsync().ConfigureAwait(false);

		// Act
		var result = await context.GetRecordCountAsync<TestEntity>(entity => entity.Name == "Match").ConfigureAwait(false);

		// Assert
		Assert.AreEqual(1, result);
	}

	[TestMethod]
	public async Task GetRecordCountAsyncWithPredicate_NullContext_ThrowsArgumentNullException()
	{
		// Arrange
		DbContext context = null;
		Expression<Func<TestEntity, bool>> predicate = _ => true;

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(
			() => context.GetRecordCountAsync(predicate)).ConfigureAwait(false);
	}

	[TestMethod]
	public async Task GetRecordCountAsyncWithPredicate_NullPredicate_ThrowsArgumentNullException()
	{
		// Arrange
		using var context = CreateTestContext();
		Expression<Func<TestEntity, bool>> predicate = null;

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(
			() => context.GetRecordCountAsync(predicate)).ConfigureAwait(false);
	}

	[TestMethod]
	public void HasChanges_NoChanges_ReturnsFalse()
	{
		// Arrange
		using var context = CreateTestContext();

		// Act
		var result = context.HasChanges();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void HasChanges_NullContext_ThrowsArgumentNullException()
	{
		// Arrange
		DbContext context = null;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => context.HasChanges());
	}

	[TestMethod]
	public void HasChanges_WithPendingChanges_ReturnsTrue()
	{
		// Arrange
		using var context = CreateTestContext();
		context.Set<TestEntity>().Add(new TestEntity { Name = "Pending" });

		// Act
		var result = context.HasChanges();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public async Task HasRecordsAsync_EmptyTable_ReturnsFalse()
	{
		// Arrange
		using var context = CreateTestContext();

		// Act
		var result = await context.HasRecordsAsync<TestEntity>().ConfigureAwait(false);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public async Task HasRecordsAsync_NullContext_ThrowsArgumentNullException()
	{
		// Arrange
		DbContext context = null;

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(
			() => context.HasRecordsAsync<TestEntity>()).ConfigureAwait(false);
	}

	[TestMethod]
	public async Task HasRecordsAsync_WithRecords_ReturnsTrue()
	{
		// Arrange
		using var context = CreateTestContext();
		context.Set<TestEntity>().Add(new TestEntity { Name = "Exists" });
		await context.SaveChangesAsync().ConfigureAwait(false);

		// Act
		var result = await context.HasRecordsAsync<TestEntity>().ConfigureAwait(false);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public async Task HasRecordsAsyncWithPredicate_MatchingRecords_ReturnsTrue()
	{
		// Arrange
		using var context = CreateTestContext();
		context.Set<TestEntity>().Add(new TestEntity { Name = "Target" });
		await context.SaveChangesAsync().ConfigureAwait(false);

		// Act
		var result = await context.HasRecordsAsync<TestEntity>(entity => entity.Name == "Target").ConfigureAwait(false);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public async Task HasRecordsAsyncWithPredicate_NoMatchingRecords_ReturnsFalse()
	{
		// Arrange
		using var context = CreateTestContext();
		context.Set<TestEntity>().Add(new TestEntity { Name = "Other" });
		await context.SaveChangesAsync().ConfigureAwait(false);

		// Act
		var result = await context.HasRecordsAsync<TestEntity>(entity => entity.Name == "NonExistent").ConfigureAwait(false);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public async Task HasRecordsAsyncWithPredicate_NullContext_ThrowsArgumentNullException()
	{
		// Arrange
		DbContext context = null;
		Expression<Func<TestEntity, bool>> predicate = _ => true;

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(
			() => context.HasRecordsAsync(predicate)).ConfigureAwait(false);
	}

	[TestMethod]
	public async Task HasRecordsAsyncWithPredicate_NullPredicate_ThrowsArgumentNullException()
	{
		// Arrange
		using var context = CreateTestContext();
		Expression<Func<TestEntity, bool>> predicate = null;

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(
			() => context.HasRecordsAsync(predicate)).ConfigureAwait(false);
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

	private sealed class TestDbContext : DbContext
	{
		public TestDbContext(DbContextOptions<TestDbContext> options) : base(options) { }

		public DbSet<TestEntity> TestEntities { get; set; }
	}
	private sealed class TestEntity
	{
		[Key]
		public int Id { get; set; }

		public string Name { get; set; } = string.Empty;
	}
}
