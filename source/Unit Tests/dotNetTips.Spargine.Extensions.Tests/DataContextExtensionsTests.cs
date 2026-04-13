// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 04-05-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-13-2026
// ***********************************************************************
// <copyright file="DataContextExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Unit tests for DataContextExtensions methods.</summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using LinqToDB;
using LinqToDB.DataProvider.SQLite;
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
	private static DataContext CreateTestContext() => new(new DataOptions().UseSQLite("Data Source=:memory:", SQLiteProvider.Microsoft));

}
