// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 10-08-2020
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-13-2026
// ***********************************************************************
// <copyright file="DataContextExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Extension methods for the DataContext type, including HasRecordsAsync,
// GetRecordCountAsync, InsertCollectionAsync, UpsertCollectionAsync,
// DeleteCollectionAsync, ExecuteInTransactionAsync, and GetTrackedObjects.
// </summary>
// ***********************************************************************
using System.Collections;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Linq.Expressions;
using System.Reflection;
using DotNetTips.Spargine.Core;
using LinqToDB;
using LinqToDB.Async;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Extension methods for the <see cref="DataContext"/> type, enhancing its functionality with additional utility methods.
/// </summary>
/// <remarks>
/// This class provides methods to interact with a <see cref="DataContext"/> in ways that are not supported by default.
/// Methods include batch insert, upsert, and delete operations for collections; record existence and count queries;
/// transaction-scoped execution; and retrieving tracked objects within a DataContext for debugging or auditing changes.
/// Note: The use of reflection to access internal properties of DataContext may be subject to change in future versions of the framework.
/// </remarks>
[Information(Status = Status.Available)]
public static class DataContextExtensions
{
	/// <summary>
	/// Deletes a collection of entities from the database.
	/// Validates that <paramref name="context"/> and <paramref name="entities"/> are not null.
	/// </summary>
	/// <typeparam name="T">The entity type to delete.</typeparam>
	/// <param name="context">The <see cref="DataContext"/> to use.</param>
	/// <param name="entities">The collection of entities to delete.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>The total number of entities successfully deleted.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="context"/> or <paramref name="entities"/> is null.</exception>
	[Information(nameof(DeleteCollectionAsync), author: "Copilot Agent", createdOn: "4/13/2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public static async Task<int> DeleteCollectionAsync<T>([DisallowNull] this DataContext context, [DisallowNull] IEnumerable<T> entities, CancellationToken cancellationToken = default)
		where T : class
	{
		context = context.ArgumentNotNull();
		entities = entities.ArgumentNotNull();

		var deletedCount = 0;

		foreach (var entity in entities)
		{
			cancellationToken.ThrowIfCancellationRequested();
			deletedCount += await context.DeleteAsync(entity, token: cancellationToken).ConfigureAwait(false);
		}

		return deletedCount;
	}

	/// <summary>
	/// Executes the specified asynchronous delegate within a <see cref="DataContext"/> transaction.
	/// The transaction is committed on success and rolled back on failure.
	/// Validates that <paramref name="context"/> and <paramref name="action"/> are not null.
	/// </summary>
	/// <param name="context">The <see cref="DataContext"/> to use.</param>
	/// <param name="action">The asynchronous delegate to execute within the transaction.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="context"/> or <paramref name="action"/> is null.</exception>
	[Information(nameof(ExecuteInTransactionAsync), author: "Copilot Agent", createdOn: "4/13/2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public static async Task ExecuteInTransactionAsync([DisallowNull] this DataContext context, [DisallowNull] Func<DataContext, CancellationToken, Task> action, CancellationToken cancellationToken = default)
	{
		context = context.ArgumentNotNull();
		ArgumentNullException.ThrowIfNull(action);

		var transaction = await context.BeginTransactionAsync(cancellationToken).ConfigureAwait(false);

		try
		{
			await action(context, cancellationToken).ConfigureAwait(false);
			await transaction.CommitTransactionAsync(cancellationToken).ConfigureAwait(false);
		}
		catch
		{
			await transaction.RollbackTransactionAsync(cancellationToken).ConfigureAwait(false);
			throw;
		}
		finally
		{
			await ((IAsyncDisposable)transaction).DisposeAsync().ConfigureAwait(false);
		}
	}

	/// <summary>
	/// Gets the count of records in the table for the specified entity type.
	/// Validates that <paramref name="context"/> is not null.
	/// </summary>
	/// <typeparam name="T">The entity type mapped to a table.</typeparam>
	/// <param name="context">The <see cref="DataContext"/> to use.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>The number of records in the table.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="context"/> is null.</exception>
	[Information(nameof(GetRecordCountAsync), author: "Copilot Agent", createdOn: "4/13/2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public static async Task<int> GetRecordCountAsync<T>([DisallowNull] this DataContext context, CancellationToken cancellationToken = default)
		where T : class
	{
		context = context.ArgumentNotNull();

		return await context.GetTable<T>().CountAsync(cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Gets the count of records matching the specified predicate in the table for the given entity type.
	/// Validates that <paramref name="context"/> and <paramref name="predicate"/> are not null.
	/// </summary>
	/// <typeparam name="T">The entity type mapped to a table.</typeparam>
	/// <param name="context">The <see cref="DataContext"/> to use.</param>
	/// <param name="predicate">An expression to filter the records to count.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>The number of records matching the predicate.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="context"/> or <paramref name="predicate"/> is null.</exception>
	[Information(nameof(GetRecordCountAsync), author: "Copilot Agent", createdOn: "4/13/2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public static async Task<int> GetRecordCountAsync<T>([DisallowNull] this DataContext context, [DisallowNull] Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default)
		where T : class
	{
		context = context.ArgumentNotNull();
		ArgumentNullException.ThrowIfNull(predicate);

		return await context.GetTable<T>().CountAsync(predicate, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Gets the tracked objects from a <see cref="DataContext" />.
	/// Validates that <paramref name="context" /> is not null
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="context">The context.</param>
	/// <returns>ReadOnlyCollection&lt;Tuple&lt;T, T&gt;&gt;.</returns>
	/// <exception cref="ArgumentNullException">context</exception>
	[Pure]
	[return: NotNull]
	[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
	[Information(nameof(GetTrackedObjects), author: "David McCarter", createdOn: "10/8/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<Tuple<T, T>> GetTrackedObjects<T>([DisallowNull] this DataContext context)
	{
		context = context.ArgumentNotNull();

		var result = new List<Tuple<T, T>>();
		var dcType = typeof(DataContext);

		// Use reflection to get to the underlying items being tracked in the DataContext
		const BindingFlags Bindings = BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.GetField;

		var services = dcType.GetField("services", Bindings)?.GetValue(context);
#pragma warning disable IL2070 // GetType() returns Type without DynamicallyAccessedMembers — method marked RequiresUnreferencedCode
		var tracker = services!.GetType().GetField("tracker", Bindings)?.GetValue(services);
		var trackerItems = (IDictionary)tracker?.GetType().GetField("items", Bindings)?.GetValue(tracker)!;
#pragma warning restore IL2070

		// iterate through each update in context, adding only those that are of type T to the method's result variable
		foreach (DictionaryEntry entry in trackerItems)
		{
#pragma warning disable IL2070
			var originalField = entry.Value?.GetType().GetField("original", Bindings);
#pragma warning restore IL2070

			if (originalField is null)
			{
				continue;
			}

			dynamic original = originalField.GetValue(entry.Value)!;

			if (entry.Key is T t && original is T)
			{
				result.Add(new Tuple<T, T>(original, t));
			}
		}

		return result.AsReadOnly();
	}

	/// <summary>
	/// Determines whether the table for the specified entity type contains any records.
	/// Validates that <paramref name="context"/> is not null.
	/// </summary>
	/// <typeparam name="T">The entity type mapped to a table.</typeparam>
	/// <param name="context">The <see cref="DataContext"/> to use.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns><c>true</c> if the table contains any records; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="context"/> is null.</exception>
	[Information(nameof(HasRecordsAsync), author: "Copilot Agent", createdOn: "4/13/2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public static async Task<bool> HasRecordsAsync<T>([DisallowNull] this DataContext context, CancellationToken cancellationToken = default)
		where T : class
	{
		context = context.ArgumentNotNull();

		return await context.GetTable<T>().AnyAsync(cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Determines whether the table for the specified entity type contains any records matching the predicate.
	/// Validates that <paramref name="context"/> and <paramref name="predicate"/> are not null.
	/// </summary>
	/// <typeparam name="T">The entity type mapped to a table.</typeparam>
	/// <param name="context">The <see cref="DataContext"/> to use.</param>
	/// <param name="predicate">An expression to filter the records to check.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns><c>true</c> if any records match the predicate; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="context"/> or <paramref name="predicate"/> is null.</exception>
	[Information(nameof(HasRecordsAsync), author: "Copilot Agent", createdOn: "4/13/2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public static async Task<bool> HasRecordsAsync<T>([DisallowNull] this DataContext context, [DisallowNull] Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default)
		where T : class
	{
		context = context.ArgumentNotNull();
		ArgumentNullException.ThrowIfNull(predicate);

		return await context.GetTable<T>().AnyAsync(predicate, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Inserts a collection of entities into the database.
	/// Validates that <paramref name="context"/> and <paramref name="entities"/> are not null.
	/// </summary>
	/// <typeparam name="T">The entity type to insert.</typeparam>
	/// <param name="context">The <see cref="DataContext"/> to use.</param>
	/// <param name="entities">The collection of entities to insert.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>The total number of entities successfully inserted.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="context"/> or <paramref name="entities"/> is null.</exception>
	[Information(nameof(InsertCollectionAsync), author: "Copilot Agent", createdOn: "4/13/2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public static async Task<int> InsertCollectionAsync<T>([DisallowNull] this DataContext context, [DisallowNull] IEnumerable<T> entities, CancellationToken cancellationToken = default)
		where T : class
	{
		context = context.ArgumentNotNull();
		entities = entities.ArgumentNotNull();

		var insertedCount = 0;

		foreach (var entity in entities)
		{
			cancellationToken.ThrowIfCancellationRequested();
			_ = await context.InsertAsync(entity, token: cancellationToken).ConfigureAwait(false);
			insertedCount++;
		}

		return insertedCount;
	}

	/// <summary>
	/// Inserts or replaces a collection of entities in the database (upsert).
	/// Validates that <paramref name="context"/> and <paramref name="entities"/> are not null.
	/// </summary>
	/// <typeparam name="T">The entity type to upsert.</typeparam>
	/// <param name="context">The <see cref="DataContext"/> to use.</param>
	/// <param name="entities">The collection of entities to insert or replace.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>The total number of entities successfully upserted.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="context"/> or <paramref name="entities"/> is null.</exception>
	[Information(nameof(UpsertCollectionAsync), author: "Copilot Agent", createdOn: "4/13/2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public static async Task<int> UpsertCollectionAsync<T>([DisallowNull] this DataContext context, [DisallowNull] IEnumerable<T> entities, CancellationToken cancellationToken = default)
		where T : class
	{
		context = context.ArgumentNotNull();
		entities = entities.ArgumentNotNull();

		var upsertedCount = 0;

		foreach (var entity in entities)
		{
			cancellationToken.ThrowIfCancellationRequested();
			_ = await context.InsertOrReplaceAsync(entity, token: cancellationToken).ConfigureAwait(false);
			upsertedCount++;
		}

		return upsertedCount;
	}

}
