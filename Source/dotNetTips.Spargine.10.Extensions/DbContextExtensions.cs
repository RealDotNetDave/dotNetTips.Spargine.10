// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 04-13-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-21-2026
// ***********************************************************************
// <copyright file="DbContextExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Extension methods for <see cref="Microsoft.EntityFrameworkCore.DbContext"/> reducing EF Core boilerplate.
// Includes <c>AddAndSaveAsync</c> (bulk add + save), <c>DeleteAndSaveAsync</c> (bulk delete + save),
// <c>ExecuteInTransactionAsync</c> (transaction-scoped execution), <c>GetChangedEntities</c>
// (change-tracker query by <see cref="Microsoft.EntityFrameworkCore.EntityState"/>),
// <c>HasChanges</c> (unsaved-change detection), <c>HasRecordsAsync</c> (existence check with optional
// predicate), and <c>GetRecordCountAsync</c> (row count with optional predicate).
// </summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions.Properties;
using Microsoft.EntityFrameworkCore;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Extension methods for <see cref="DbContext"/> that reduce Entity Framework Core boilerplate
/// and provide common data-access patterns in a consistent, async-first API.
/// </summary>
/// <remarks>
/// Provides methods for batch add and save (<c>AddAndSaveAsync</c>), batch delete and save
/// (<c>DeleteAndSaveAsync</c>), transaction-scoped execution (<c>ExecuteInTransactionAsync</c>),
/// change-tracker queries filtered by <see cref="EntityState"/> (<c>GetChangedEntities</c>),
/// unsaved-change detection (<c>HasChanges</c>), record existence checks with optional predicate
/// (<c>HasRecordsAsync</c>), and row counts with optional predicate (<c>GetRecordCountAsync</c>).
/// </remarks>
[Information(Status = Status.NeedsDocumentation)]
public static class DbContextExtensions
{
	/// <summary>
	/// Adds a collection of entities to the context and saves all changes to the database.
	/// Validates that <paramref name="context"/> and <paramref name="entities"/> are not null.
	/// </summary>
	/// <typeparam name="T">The entity type to add.</typeparam>
	/// <param name="context">The <see cref="DbContext"/> to use.</param>
	/// <param name="entities">The collection of entities to add.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>The number of state entries written to the database.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="context"/> or <paramref name="entities"/> is null.</exception>
	[Information(nameof(AddAndSaveAsync), author: "Copilot Agent", createdOn: "4/13/2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public static async Task<int> AddAndSaveAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties | DynamicallyAccessedMemberTypes.Interfaces)] T>([DisallowNull] this DbContext context, [DisallowNull] IEnumerable<T> entities, CancellationToken cancellationToken = default)
		where T : class
	{
		context = context.ArgumentNotNull();
		entities = entities.ArgumentNotNull();

		await context.Set<T>().AddRangeAsync(entities, cancellationToken).ConfigureAwait(false);

		return await context.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Removes a collection of entities from the context and saves all changes to the database.
	/// Validates that <paramref name="context"/> and <paramref name="entities"/> are not null.
	/// </summary>
	/// <typeparam name="T">The entity type to delete.</typeparam>
	/// <param name="context">The <see cref="DbContext"/> to use.</param>
	/// <param name="entities">The collection of entities to remove.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>The number of state entries written to the database.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="context"/> or <paramref name="entities"/> is null.</exception>
	[Information(nameof(DeleteAndSaveAsync), author: "Copilot Agent", createdOn: "4/13/2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public static async Task<int> DeleteAndSaveAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties | DynamicallyAccessedMemberTypes.Interfaces)] T>([DisallowNull] this DbContext context, [DisallowNull] IEnumerable<T> entities, CancellationToken cancellationToken = default)
		where T : class
	{
		context = context.ArgumentNotNull();
		entities = entities.ArgumentNotNull();

		context.Set<T>().RemoveRange(entities);

		return await context.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Executes the specified asynchronous delegate within a database transaction.
	/// The transaction is committed on success and rolled back on failure.
	/// Validates that <paramref name="context"/> and <paramref name="action"/> are not null.
	/// </summary>
	/// <param name="context">The <see cref="DbContext"/> to use.</param>
	/// <param name="action">The asynchronous delegate to execute within the transaction.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="context"/> or <paramref name="action"/> is null.</exception>
	[Information(nameof(ExecuteInTransactionAsync), author: "Copilot Agent", createdOn: "4/13/2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public static async Task ExecuteInTransactionAsync([DisallowNull] this DbContext context, [DisallowNull] Func<DbContext, CancellationToken, Task> action, CancellationToken cancellationToken = default)
	{
		context = context.ArgumentNotNull();
		ArgumentNullException.ThrowIfNull(action);

		var transaction = await context.Database.BeginTransactionAsync(cancellationToken).ConfigureAwait(false);

		try
		{
			await action(context, cancellationToken).ConfigureAwait(false);
			await transaction.CommitAsync(cancellationToken).ConfigureAwait(false);
		}
		catch
		{
			await transaction.RollbackAsync(cancellationToken).ConfigureAwait(false);
			throw;
		}
		finally
		{
			await transaction.DisposeAsync().ConfigureAwait(false);
		}
	}

	/// <summary>
	/// Gets all tracked entities of the specified type that are in the given <see cref="EntityState"/>.
	/// Validates that <paramref name="context"/> is not null.
	/// </summary>
	/// <typeparam name="T">The entity type to query.</typeparam>
	/// <param name="context">The <see cref="DbContext"/> to use.</param>
	/// <param name="state">The <see cref="EntityState"/> to filter by.</param>
	/// <returns>A read-only collection of entities matching the specified state.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="context"/> is null.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="state"/> is not a defined <see cref="EntityState"/> value.</exception>
	[Information(nameof(GetChangedEntities), author: "Copilot Agent", createdOn: "4/13/2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public static ReadOnlyCollection<T> GetChangedEntities<T>([DisallowNull] this DbContext context, EntityState state)
		where T : class
	{
		context = context.ArgumentNotNull();

		if (!Enum.IsDefined(state))
		{
			throw new ArgumentOutOfRangeException(nameof(state), state, Resources.EntityStateNotDefined);
		}

		var entries = context.ChangeTracker.Entries<T>();
		var result = new List<T>();

		foreach (var entry in entries)
		{
			if (entry.State == state)
			{
				result.Add(entry.Entity);
			}
		}

		return result.AsReadOnly();
	}

	/// <summary>
	/// Gets the count of records in the table for the specified entity type.
	/// Validates that <paramref name="context"/> is not null.
	/// </summary>
	/// <typeparam name="T">The entity type mapped to a table.</typeparam>
	/// <param name="context">The <see cref="DbContext"/> to use.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>The number of records in the table.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="context"/> is null.</exception>
	[Information(nameof(GetRecordCountAsync), author: "Copilot Agent", createdOn: "4/13/2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public static async Task<int> GetRecordCountAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties | DynamicallyAccessedMemberTypes.Interfaces)] T>([DisallowNull] this DbContext context, CancellationToken cancellationToken = default)
		where T : class
	{
		context = context.ArgumentNotNull();

		return await context.Set<T>().CountAsync(cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Gets the count of records matching the specified predicate in the table for the given entity type.
	/// Validates that <paramref name="context"/> and <paramref name="predicate"/> are not null.
	/// </summary>
	/// <typeparam name="T">The entity type mapped to a table.</typeparam>
	/// <param name="context">The <see cref="DbContext"/> to use.</param>
	/// <param name="predicate">An expression to filter the records to count.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>The number of records matching the predicate.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="context"/> or <paramref name="predicate"/> is null.</exception>
	[Information(nameof(GetRecordCountAsync), author: "Copilot Agent", createdOn: "4/13/2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public static async Task<int> GetRecordCountAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties | DynamicallyAccessedMemberTypes.Interfaces)] T>([DisallowNull] this DbContext context, [DisallowNull] Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default)
		where T : class
	{
		context = context.ArgumentNotNull();
		ArgumentNullException.ThrowIfNull(predicate);

		return await context.Set<T>().CountAsync(predicate, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Determines whether the context has any unsaved changes in its change tracker.
	/// Validates that <paramref name="context"/> is not null.
	/// </summary>
	/// <param name="context">The <see cref="DbContext"/> to check.</param>
	/// <returns><c>true</c> if there are unsaved changes; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="context"/> is null.</exception>
	[Information(nameof(HasChanges), author: "Copilot Agent", createdOn: "4/13/2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public static bool HasChanges([DisallowNull] this DbContext context)
	{
		context = context.ArgumentNotNull();

		return context.ChangeTracker.HasChanges();
	}

	/// <summary>
	/// Determines whether the table for the specified entity type contains any records.
	/// Validates that <paramref name="context"/> is not null.
	/// </summary>
	/// <typeparam name="T">The entity type mapped to a table.</typeparam>
	/// <param name="context">The <see cref="DbContext"/> to use.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns><c>true</c> if the table contains any records; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="context"/> is null.</exception>
	[Information(nameof(HasRecordsAsync), author: "Copilot Agent", createdOn: "4/13/2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public static async Task<bool> HasRecordsAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties | DynamicallyAccessedMemberTypes.Interfaces)] T>([DisallowNull] this DbContext context, CancellationToken cancellationToken = default)
		where T : class
	{
		context = context.ArgumentNotNull();

		return await context.Set<T>().AnyAsync(cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Determines whether the table for the specified entity type contains any records matching the predicate.
	/// Validates that <paramref name="context"/> and <paramref name="predicate"/> are not null.
	/// </summary>
	/// <typeparam name="T">The entity type mapped to a table.</typeparam>
	/// <param name="context">The <see cref="DbContext"/> to use.</param>
	/// <param name="predicate">An expression to filter the records to check.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns><c>true</c> if any records match the predicate; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="context"/> or <paramref name="predicate"/> is null.</exception>
	[Information(nameof(HasRecordsAsync), author: "Copilot Agent", createdOn: "4/13/2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public static async Task<bool> HasRecordsAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties | DynamicallyAccessedMemberTypes.Interfaces)] T>([DisallowNull] this DbContext context, [DisallowNull] Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default)
		where T : class
	{
		context = context.ArgumentNotNull();
		ArgumentNullException.ThrowIfNull(predicate);

		return await context.Set<T>().AnyAsync(predicate, cancellationToken).ConfigureAwait(false);
	}
}
