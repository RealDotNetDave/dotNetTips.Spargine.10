// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : Copilot Agent
// Created          : 07-09-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-09-2026
// ***********************************************************************
// <copyright file="DbContextExtensionsBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Benchmark tests for DbContextExtensions methods.</summary>
// ***********************************************************************

using System.Diagnostics.CodeAnalysis;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using DotNetTips.Spargine.Benchmarking;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

/// <summary>
/// Benchmarks for <see cref="DbContextExtensions"/> methods marked for benchmarking.
/// </summary>
[SuppressMessage("Reliability", "CA1001:Types that own disposable fields should be disposable", Justification = "Disposed in Cleanup() via BenchmarkDotNet lifecycle.")]
[BenchmarkCategory(Categories.Database)]
[MemoryDiagnoser]
[TailCallDiagnoser]
public class DbContextExtensionsBenchmark : Benchmark
{
	private const int EntityCount = 16;
	private const string MatchName = "Target";
	private TestDbContext? _context;

	private List<TestDbEntity> _entitiesToAdd = [];
	private List<TestDbEntity> _entitiesToDelete = [];

	private TestDbContext Context => this._context ?? throw new InvalidOperationException();

	[Benchmark(Description = nameof(DbContextExtensions.AddAndSaveAsync))]
	public async Task AddAndSaveAsync()
	{
		var result = await this.Context.AddAndSaveAsync(this._entitiesToAdd).ConfigureAwait(false);
		this.Consume(result);
	}

	/// <summary>
	/// Cleans up benchmark resources.
	/// </summary>
	public override void Cleanup()
	{
		this.DisposeContext();
		base.Cleanup();
	}

	[Benchmark(Description = nameof(DbContextExtensions.DeleteAndSaveAsync))]
	public async Task DeleteAndSaveAsync()
	{
		var result = await this.Context.DeleteAndSaveAsync(this._entitiesToDelete).ConfigureAwait(false);
		this.Consume(result);
	}

	[Benchmark(Description = nameof(DbContextExtensions.ExecuteInTransactionAsync))]
	public async Task ExecuteInTransactionAsync()
	{
		await this.Context.ExecuteInTransactionAsync(static async (dbContext, cancellationToken) =>
		{
			await dbContext.Set<TestDbEntity>().AddAsync(new TestDbEntity { Name = "Tx" }, cancellationToken).ConfigureAwait(false);
			_ = await dbContext.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
		}).ConfigureAwait(false);
	}

	[Benchmark(Description = nameof(DbContextExtensions.GetChangedEntities))]
	public void GetChangedEntities()
	{
		var result = this.Context.GetChangedEntities<TestDbEntity>(EntityState.Added);
		this.Consume(result);
	}

	[Benchmark(Description = nameof(DbContextExtensions.GetRecordCountAsync) + ": no predicate")]
	public async Task GetRecordCountAsync()
	{
		var result = await this.Context.GetRecordCountAsync<TestDbEntity>().ConfigureAwait(false);
		this.Consume(result);
	}

	[Benchmark(Description = nameof(DbContextExtensions.GetRecordCountAsync) + ": with predicate")]
	public async Task GetRecordCountWithPredicateAsync()
	{
		var result = await this.Context.GetRecordCountAsync<TestDbEntity>(static entity => entity.Name == MatchName).ConfigureAwait(false);
		this.Consume(result);
	}

	[Benchmark(Description = nameof(DbContextExtensions.HasChanges))]
	public void HasChanges()
	{
		var result = this.Context.HasChanges();
		this.Consume(result);
	}

	[Benchmark(Description = nameof(DbContextExtensions.HasRecordsAsync) + ": no predicate")]
	public async Task HasRecordsAsync()
	{
		var result = await this.Context.HasRecordsAsync<TestDbEntity>().ConfigureAwait(false);
		this.Consume(result);
	}

	[Benchmark(Description = nameof(DbContextExtensions.HasRecordsAsync) + ": with predicate")]
	public async Task HasRecordsWithPredicateAsync()
	{
		var result = await this.Context.HasRecordsAsync<TestDbEntity>(static entity => entity.Name == MatchName).ConfigureAwait(false);
		this.Consume(result);
	}

	/// <summary>
	/// Cleans up each benchmark iteration.
	/// </summary>
	[IterationCleanup]
	public void IterationCleanup()
	{
		this.DisposeContext();
	}

	/// <summary>
	/// Prepares reusable benchmark data.
	/// </summary>
	public override void Setup()
	{
		base.Setup();
		this._entitiesToAdd = CreateEntities(EntityCount, "Add");
	}

	[IterationSetup(Target = nameof(AddAndSaveAsync))]
	public void SetupAddAndSaveAsync()
	{
		this.PrepareContext(seedData: false);
		this._entitiesToAdd = CreateEntities(EntityCount, "Add");
	}

	[IterationSetup(Target = nameof(DeleteAndSaveAsync))]
	public void SetupDeleteAndSaveAsync()
	{
		this.PrepareContext(seedData: true);
		this._entitiesToDelete = [.. this.Context.TestEntities.AsNoTracking()];
	}

	[IterationSetup(Target = nameof(ExecuteInTransactionAsync))]
	public void SetupExecuteInTransactionAsync()
	{
		this.PrepareContext(seedData: false);
	}

	[IterationSetup(Target = nameof(GetChangedEntities))]
	public void SetupGetChangedEntities()
	{
		this.PrepareContext(seedData: false);
		_ = this.Context.TestEntities.Add(new TestDbEntity { Name = "Pending" });
	}

	[IterationSetup(Target = nameof(GetRecordCountAsync))]
	public void SetupGetRecordCountAsync()
	{
		this.PrepareContext(seedData: true);
	}

	[IterationSetup(Target = nameof(GetRecordCountWithPredicateAsync))]
	public void SetupGetRecordCountWithPredicateAsync()
	{
		this.PrepareContext(seedData: true);
	}

	[IterationSetup(Target = nameof(HasChanges))]
	public void SetupHasChanges()
	{
		this.PrepareContext(seedData: false);
		_ = this.Context.TestEntities.Add(new TestDbEntity { Name = "Pending" });
	}

	[IterationSetup(Target = nameof(HasRecordsAsync))]
	public void SetupHasRecordsAsync()
	{
		this.PrepareContext(seedData: true);
	}

	[IterationSetup(Target = nameof(HasRecordsWithPredicateAsync))]
	public void SetupHasRecordsWithPredicateAsync()
	{
		this.PrepareContext(seedData: true);
	}

	private static TestDbContext CreateContext()
	{
		var connection = new SqliteConnection("Data Source=:memory:");
		connection.Open();

		var options = new DbContextOptionsBuilder<TestDbContext>()
			.UseSqlite(connection)
			.Options;

		var context = new TestDbContext(options, connection);
		_ = context.Database.EnsureCreated();

		return context;
	}

	private static List<TestDbEntity> CreateEntities(int count, string matchingName, string nonMatchingName = "Other")
	{
		var entities = new List<TestDbEntity>(count);

		for (var entityIndex = 0; entityIndex < count; entityIndex++)
		{
			entities.Add(new TestDbEntity
			{
				Name = entityIndex % 2 == 0 ? matchingName : nonMatchingName
			});
		}

		return entities;
	}

	private void DisposeContext()
	{
		if (this._context is not null)
		{
			this._context.Dispose();
			this._context = null;
		}
	}

	private void PrepareContext(bool seedData)
	{
		this.DisposeContext();
		this._context = CreateContext();

		if (seedData)
		{
			var seedEntities = CreateEntities(EntityCount, MatchName, "Other");
			this.Context.TestEntities.AddRange(seedEntities);
			_ = this.Context.SaveChanges();
		}
	}

	private sealed class TestDbContext : DbContext
	{
		private readonly SqliteConnection _connection;
		private bool _isDisposed;

		public TestDbContext(DbContextOptions<TestDbContext> options, SqliteConnection connection)
			: base(options) => this._connection = connection;

		public DbSet<TestDbEntity> TestEntities => this.Set<TestDbEntity>();

		public override void Dispose()
		{
			base.Dispose();
			this.DisposeConnection();
		}

		public override async ValueTask DisposeAsync()
		{
			await base.DisposeAsync().ConfigureAwait(false);
			await this.DisposeConnectionAsync().ConfigureAwait(false);
		}

		private void DisposeConnection()
		{
			if (!this._isDisposed)
			{
				this._connection.Dispose();
				this._isDisposed = true;
			}
		}

		private async ValueTask DisposeConnectionAsync()
		{
			if (!this._isDisposed)
			{
				await this._connection.DisposeAsync().ConfigureAwait(false);
				this._isDisposed = true;
			}
		}
	}

	private sealed class TestDbEntity
	{
		public int Id { get; set; }

		public string Name { get; set; } = string.Empty;
	}
}
