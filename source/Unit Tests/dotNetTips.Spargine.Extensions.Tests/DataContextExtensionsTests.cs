// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 04-05-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-27-2026
// ***********************************************************************
// <copyright file="DataContextExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Unit tests for DataContextExtensions methods.</summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using LinqToDB;
using LinqToDB.Async;
using LinqToDB.DataProvider.SQLite;
using LinqToDB.Mapping;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class DataContextExtensionsTests
{

	[TestMethod]
	public async Task DeleteCollectionAsync_CancellationRequested_ThrowsOperationCanceledException()
	{
		// Arrange
		using var context = CreateTestContext();
		var entities = new[] { new object() };
		using var cts = new CancellationTokenSource();
		cts.Cancel();

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<OperationCanceledException>(
			() => context.DeleteCollectionAsync(entities, cts.Token)).ConfigureAwait(false);
	}

	[TestMethod]
	public async Task DeleteCollectionAsync_EmptyCollection_ReturnsZero()
	{
		// Arrange
		using var context = CreateTestContext();
		var entities = Array.Empty<object>();

		// Act
		var result = await context.DeleteCollectionAsync(entities).ConfigureAwait(false);

		// Assert
		Assert.AreEqual(0, result);
	}

	[TestMethod]
	public async Task DeleteCollectionAsync_NullContext_ThrowsArgumentNullException()
	{
		// Arrange
		DataContext context = null;
		var entities = new[] { new object() };

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(
			() => context.DeleteCollectionAsync(entities)).ConfigureAwait(false);
	}

	[TestMethod]
	public async Task DeleteCollectionAsync_NullEntities_ThrowsArgumentNullException()
	{
		// Arrange
		using var context = CreateTestContext();
		IEnumerable<object> entities = null;

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(
			() => context.DeleteCollectionAsync(entities)).ConfigureAwait(false);
	}

	[TestMethod]
	public async Task ExecuteInTransactionAsync_NullAction_ThrowsArgumentNullException()
	{
		// Arrange
		using var context = CreateTestContext();
		Func<DataContext, CancellationToken, Task> action = null;

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(
			() => context.ExecuteInTransactionAsync(action)).ConfigureAwait(false);
	}

	[TestMethod]
	public async Task ExecuteInTransactionAsync_NullContext_ThrowsArgumentNullException()
	{
		// Arrange
		DataContext context = null;
		Func<DataContext, CancellationToken, Task> action = (_, _) => Task.CompletedTask;

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(
			() => context.ExecuteInTransactionAsync(action)).ConfigureAwait(false);
	}

	[TestMethod]
	public async Task GetRecordCountAsync_NullContext_ThrowsArgumentNullException()
	{
		// Arrange
		DataContext context = null;

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(
			() => context.GetRecordCountAsync<object>()).ConfigureAwait(false);
	}

	[TestMethod]
	public async Task GetRecordCountAsyncWithPredicate_NullContext_ThrowsArgumentNullException()
	{
		// Arrange
		DataContext context = null;
		Expression<Func<object, bool>> predicate = _ => true;

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(
			() => context.GetRecordCountAsync(predicate)).ConfigureAwait(false);
	}

	[TestMethod]
	public async Task GetRecordCountAsyncWithPredicate_NullPredicate_ThrowsArgumentNullException()
	{
		// Arrange
		using var context = CreateTestContext();
		Expression<Func<object, bool>> predicate = null;

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(
			() => context.GetRecordCountAsync(predicate)).ConfigureAwait(false);
	}

	[TestMethod]
	public void GetTrackedObjects_NullContext_ThrowsArgumentNullException()
	{
		// Arrange
		DataContext context = null;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => context.GetTrackedObjects<object>());
	}

	[TestMethod]
	public async Task HasRecordsAsync_NullContext_ThrowsArgumentNullException()
	{
		// Arrange
		DataContext context = null;

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(
			() => context.HasRecordsAsync<object>()).ConfigureAwait(false);
	}

	[TestMethod]
	public async Task HasRecordsAsyncWithPredicate_NullContext_ThrowsArgumentNullException()
	{
		// Arrange
		DataContext context = null;
		Expression<Func<object, bool>> predicate = _ => true;

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(
			() => context.HasRecordsAsync(predicate)).ConfigureAwait(false);
	}

	[TestMethod]
	public async Task HasRecordsAsyncWithPredicate_NullPredicate_ThrowsArgumentNullException()
	{
		// Arrange
		using var context = CreateTestContext();
		Expression<Func<object, bool>> predicate = null;

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(
			() => context.HasRecordsAsync(predicate)).ConfigureAwait(false);
	}

	[TestMethod]
	public async Task InsertCollectionAsync_CancellationRequested_ThrowsOperationCanceledException()
	{
		// Arrange
		using var context = CreateTestContext();
		var entities = new[] { new object() };
		using var cts = new CancellationTokenSource();
		cts.Cancel();

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<OperationCanceledException>(
			() => context.InsertCollectionAsync(entities, cts.Token)).ConfigureAwait(false);
	}

	[TestMethod]
	public async Task InsertCollectionAsync_EmptyCollection_ReturnsZero()
	{
		// Arrange
		using var context = CreateTestContext();
		var entities = Array.Empty<object>();

		// Act
		var result = await context.InsertCollectionAsync(entities).ConfigureAwait(false);

		// Assert
		Assert.AreEqual(0, result);
	}

	[TestMethod]
	public async Task InsertCollectionAsync_NullContext_ThrowsArgumentNullException()
	{
		// Arrange
		DataContext context = null;
		var entities = new[] { new object() };

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(
			() => context.InsertCollectionAsync(entities)).ConfigureAwait(false);
	}

	[TestMethod]
	public async Task InsertCollectionAsync_NullEntities_ThrowsArgumentNullException()
	{
		// Arrange
		using var context = CreateTestContext();
		IEnumerable<object> entities = null;

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(
			() => context.InsertCollectionAsync(entities)).ConfigureAwait(false);
	}

	[TestMethod]
	public async Task UpsertCollectionAsync_CancellationRequested_ThrowsOperationCanceledException()
	{
		// Arrange
		using var context = CreateTestContext();
		var entities = new[] { new object() };
		using var cts = new CancellationTokenSource();
		cts.Cancel();

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<OperationCanceledException>(
			() => context.UpsertCollectionAsync(entities, cts.Token)).ConfigureAwait(false);
	}

	[TestMethod]
	public async Task UpsertCollectionAsync_EmptyCollection_ReturnsZero()
	{
		// Arrange
		using var context = CreateTestContext();
		var entities = Array.Empty<object>();

		// Act
		var result = await context.UpsertCollectionAsync(entities).ConfigureAwait(false);

		// Assert
		Assert.AreEqual(0, result);
	}

	[TestMethod]
	public async Task UpsertCollectionAsync_NullContext_ThrowsArgumentNullException()
	{
		// Arrange
		DataContext context = null;
		var entities = new[] { new object() };

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(
			() => context.UpsertCollectionAsync(entities)).ConfigureAwait(false);
	}

	[TestMethod]
	public async Task UpsertCollectionAsync_NullEntities_ThrowsArgumentNullException()
	{
		// Arrange
		using var context = CreateTestContext();
		IEnumerable<object> entities = null;

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(
			() => context.UpsertCollectionAsync(entities)).ConfigureAwait(false);
	}

	[TestMethod]
	public async Task DeleteCollectionAsync_ValidEntities_ReturnsDeletedCount()
	{
		// Arrange
		using var context = CreateContextWithTable<TestDbEntity>();
		var entity = new TestDbEntity { Id = 1, Name = "ToDelete" };
		_ = await context.InsertAsync(entity).ConfigureAwait(false);

		// Act
		var result = await context.DeleteCollectionAsync(new[] { entity }).ConfigureAwait(false);

		// Assert
		Assert.AreEqual(1, result);
	}

	[TestMethod]
	public async Task ExecuteInTransactionAsync_ActionExecutesSuccessfully_DoesNotThrow()
	{
		// Arrange
		using var context = CreateTestContext();
		var executed = false;

		// Act
		await context.ExecuteInTransactionAsync(async (ctx, ct) =>
		{
			executed = true;
			await Task.CompletedTask.ConfigureAwait(false);
		}).ConfigureAwait(false);

		// Assert
		Assert.IsTrue(executed);
	}

	[TestMethod]
	public async Task ExecuteInTransactionAsync_ActionThrows_RethrowsException()
	{
		// Arrange
		using var context = CreateTestContext();

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<InvalidOperationException>(
			() => context.ExecuteInTransactionAsync((ctx, ct) => throw new InvalidOperationException("test error"))).ConfigureAwait(false);
	}

	[TestMethod]
	public async Task GetRecordCountAsync_EmptyTable_ReturnsZero()
	{
		// Arrange
		using var context = CreateContextWithTable<TestDbEntity>();

		// Act
		var result = await context.GetRecordCountAsync<TestDbEntity>().ConfigureAwait(false);

		// Assert
		Assert.AreEqual(0, result);
	}

	[TestMethod]
	public async Task GetRecordCountAsync_WithRecords_ReturnsCorrectCount()
	{
		// Arrange
		using var context = CreateContextWithTable<TestDbEntity>();
		_ = await context.InsertAsync(new TestDbEntity { Id = 1, Name = "A" }).ConfigureAwait(false);
		_ = await context.InsertAsync(new TestDbEntity { Id = 2, Name = "B" }).ConfigureAwait(false);

		// Act
		var result = await context.GetRecordCountAsync<TestDbEntity>().ConfigureAwait(false);

		// Assert
		Assert.AreEqual(2, result);
	}

	[TestMethod]
	public async Task GetRecordCountAsyncWithPredicate_WithMatchingRecords_ReturnsCount()
	{
		// Arrange
		using var context = CreateContextWithTable<TestDbEntity>();
		_ = await context.InsertAsync(new TestDbEntity { Id = 1, Name = "Target" }).ConfigureAwait(false);
		_ = await context.InsertAsync(new TestDbEntity { Id = 2, Name = "Other" }).ConfigureAwait(false);

		// Act
		var result = await context.GetRecordCountAsync<TestDbEntity>(e => e.Name == "Target").ConfigureAwait(false);

		// Assert
		Assert.AreEqual(1, result);
	}

	[TestMethod]
	public async Task GetRecordCountAsyncWithPredicate_WithNoMatchingRecords_ReturnsZero()
	{
		// Arrange
		using var context = CreateContextWithTable<TestDbEntity>();
		_ = await context.InsertAsync(new TestDbEntity { Id = 1, Name = "A" }).ConfigureAwait(false);

		// Act
		var result = await context.GetRecordCountAsync<TestDbEntity>(e => e.Name == "NoMatch").ConfigureAwait(false);

		// Assert
		Assert.AreEqual(0, result);
	}

	[TestMethod]
	public async Task HasRecordsAsync_EmptyTable_ReturnsFalse()
	{
		// Arrange
		using var context = CreateContextWithTable<TestDbEntity>();

		// Act
		var result = await context.HasRecordsAsync<TestDbEntity>().ConfigureAwait(false);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public async Task HasRecordsAsync_WithRecords_ReturnsTrue()
	{
		// Arrange
		using var context = CreateContextWithTable<TestDbEntity>();
		_ = await context.InsertAsync(new TestDbEntity { Id = 1, Name = "A" }).ConfigureAwait(false);

		// Act
		var result = await context.HasRecordsAsync<TestDbEntity>().ConfigureAwait(false);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public async Task HasRecordsAsyncWithPredicate_WithMatchingRecords_ReturnsTrue()
	{
		// Arrange
		using var context = CreateContextWithTable<TestDbEntity>();
		_ = await context.InsertAsync(new TestDbEntity { Id = 1, Name = "Target" }).ConfigureAwait(false);

		// Act
		var result = await context.HasRecordsAsync<TestDbEntity>(e => e.Name == "Target").ConfigureAwait(false);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public async Task HasRecordsAsyncWithPredicate_WithNoMatchingRecords_ReturnsFalse()
	{
		// Arrange
		using var context = CreateContextWithTable<TestDbEntity>();
		_ = await context.InsertAsync(new TestDbEntity { Id = 1, Name = "A" }).ConfigureAwait(false);

		// Act
		var result = await context.HasRecordsAsync<TestDbEntity>(e => e.Name == "NoMatch").ConfigureAwait(false);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public async Task InsertCollectionAsync_ValidEntities_ReturnsInsertedCount()
	{
		// Arrange
		using var context = CreateContextWithTable<TestDbEntity>();
		var entities = new[]
		{
			new TestDbEntity { Id = 1, Name = "Entity1" },
			new TestDbEntity { Id = 2, Name = "Entity2" }
		};

		// Act
		var result = await context.InsertCollectionAsync(entities).ConfigureAwait(false);

		// Assert
		Assert.AreEqual(2, result);
	}

	[TestMethod]
	public async Task UpsertCollectionAsync_ValidEntities_ReturnsUpsertedCount()
	{
		// Arrange
		using var context = CreateContextWithTable<TestDbEntity>();
		var entities = new[]
		{
			new TestDbEntity { Id = 1, Name = "Entity1" },
			new TestDbEntity { Id = 2, Name = "Entity2" }
		};

		// Act
		var result = await context.UpsertCollectionAsync(entities).ConfigureAwait(false);

		// Assert
		Assert.AreEqual(2, result);
	}

	private static DataContext CreateTestContext() => new(new DataOptions().UseSQLite("Data Source=:memory:", SQLiteProvider.Microsoft));

	private static DataContext CreateContextWithTable<T>() where T : class
	{
		// Use a unique file-based SQLite DB so all DataContext connections share the same schema.
		var dbPath = Path.Combine(Path.GetTempPath(), $"spargine_{Guid.NewGuid():N}.db");
		var ctx = new DataContext(new DataOptions().UseSQLite($"Data Source={dbPath}", SQLiteProvider.Microsoft));
		ctx.CreateTable<T>();
		return ctx;
	}

	[Table("TestEntities")]
	[ExcludeFromCodeCoverage]
	private sealed class TestDbEntity
	{
		[Column]
		[PrimaryKey]
		public int Id { get; set; }

		[Column]
		public string Name { get; set; } = string.Empty;
	}

}
