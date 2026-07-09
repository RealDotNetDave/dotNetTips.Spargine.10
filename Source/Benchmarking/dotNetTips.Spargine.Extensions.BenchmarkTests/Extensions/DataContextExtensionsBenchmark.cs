// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : Copilot Agent
// Created          : 07-09-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-09-2026
// ***********************************************************************
// <copyright file="DataContextExtensionsBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Benchmark tests for DataContextExtensions methods.</summary>
// ***********************************************************************

using System.Diagnostics.CodeAnalysis;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using DotNetTips.Spargine.Benchmarking;
using LinqToDB;
using LinqToDB.DataProvider.SQLite;
using LinqToDB.Mapping;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

/// <summary>
/// Benchmarks for <see cref="DataContextExtensions"/>.
/// </summary>
[MemoryDiagnoser]
[TailCallDiagnoser]
[ThreadingDiagnoser]
[BenchmarkCategory(Categories.IO)]
public class DataContextExtensionsBenchmark : Benchmark
{
	private const int EntityCount = 32;
	private const string MatchedName = "Target";
	private DataContext? _context;
	private TestDbEntity[] _entities = [];

	private DataContext Context => this._context ?? throw new InvalidOperationException();

	/// <summary>
	/// Cleans up benchmark resources.
	/// </summary>
	public override void Cleanup()
	{
		this.DisposeContext();

		base.Cleanup();
	}

	[Benchmark(Description = nameof(DataContextExtensions.DeleteCollectionAsync))]
	public async Task DeleteCollectionAsync()
	{
		var result = await this.Context.DeleteCollectionAsync(this._entities).ConfigureAwait(false);
		this.Consume(result);
	}

	[Benchmark(Description = nameof(DataContextExtensions.ExecuteInTransactionAsync))]
	public Task ExecuteInTransactionAsync() => this.Context.ExecuteInTransactionAsync(static (_, _) => Task.CompletedTask);

	[Benchmark(Description = nameof(DataContextExtensions.GetRecordCountAsync) + ": no predicate")]
	public async Task GetRecordCountAsync()
	{
		var result = await this.Context.GetRecordCountAsync<TestDbEntity>().ConfigureAwait(false);
		this.Consume(result);
	}

	[Benchmark(Description = nameof(DataContextExtensions.GetRecordCountAsync) + ": with predicate")]
	public async Task GetRecordCountWithPredicateAsync()
	{
		var result = await this.Context.GetRecordCountAsync<TestDbEntity>(static entity => entity.Name == MatchedName).ConfigureAwait(false);
		this.Consume(result);
	}

	[Benchmark(Description = nameof(DataContextExtensions.HasRecordsAsync) + ": no predicate")]
	public async Task HasRecordsAsync()
	{
		var result = await this.Context.HasRecordsAsync<TestDbEntity>().ConfigureAwait(false);
		this.Consume(result);
	}

	[Benchmark(Description = nameof(DataContextExtensions.HasRecordsAsync) + ": with predicate")]
	public async Task HasRecordsWithPredicateAsync()
	{
		var result = await this.Context.HasRecordsAsync<TestDbEntity>(static entity => entity.Name == MatchedName).ConfigureAwait(false);
		this.Consume(result);
	}

	[Benchmark(Description = nameof(DataContextExtensions.InsertCollectionAsync))]
	public async Task InsertCollectionAsync()
	{
		var result = await this.Context.InsertCollectionAsync(this._entities).ConfigureAwait(false);
		this.Consume(result);
	}

	/// <summary>
	/// Disposes resources created for each benchmark iteration.
	/// </summary>
	[IterationCleanup]
	public void IterationCleanup()
	{
		this.DisposeContext();
	}

	/// <summary>
	/// Creates benchmark entities.
	/// </summary>
	public override void Setup()
	{
		base.Setup();

		this._entities = CreateEntities(EntityCount);
	}

	/// <summary>
	/// Prepares context and entities for <see cref="DeleteCollectionAsync"/> benchmark.
	/// </summary>
	[IterationSetup(Target = nameof(DeleteCollectionAsync))]
	public void SetupDeleteCollectionAsync()
	{
		this._context = CreateContextWithTable<TestDbEntity>();

		foreach (var entity in this._entities)
		{
			_ = this.Context.Insert(entity);
		}
	}

	/// <summary>
	/// Prepares context for <see cref="ExecuteInTransactionAsync"/> benchmark.
	/// </summary>
	[IterationSetup(Target = nameof(ExecuteInTransactionAsync))]
	public void SetupExecuteInTransactionAsync() => this._context = CreateTestContext();

	/// <summary>
	/// Prepares context and seed records for <see cref="GetRecordCountAsync"/> benchmark.
	/// </summary>
	[IterationSetup(Target = nameof(GetRecordCountAsync))]
	public void SetupGetRecordCountAsync()
	{
		this._context = CreateContextWithTable<TestDbEntity>();

		foreach (var entity in this._entities)
		{
			_ = this.Context.Insert(entity);
		}
	}

	/// <summary>
	/// Prepares context and seed records for <see cref="GetRecordCountWithPredicateAsync"/> benchmark.
	/// </summary>
	[IterationSetup(Target = nameof(GetRecordCountWithPredicateAsync))]
	public void SetupGetRecordCountWithPredicateAsync()
	{
		this._context = CreateContextWithTable<TestDbEntity>();

		foreach (var entity in this._entities)
		{
			_ = this.Context.Insert(entity);
		}
	}

	/// <summary>
	/// Prepares context and seed records for <see cref="HasRecordsAsync"/> benchmark.
	/// </summary>
	[IterationSetup(Target = nameof(HasRecordsAsync))]
	public void SetupHasRecordsAsync()
	{
		this._context = CreateContextWithTable<TestDbEntity>();

		foreach (var entity in this._entities)
		{
			_ = this.Context.Insert(entity);
		}
	}

	/// <summary>
	/// Prepares context and seed records for <see cref="HasRecordsWithPredicateAsync"/> benchmark.
	/// </summary>
	[IterationSetup(Target = nameof(HasRecordsWithPredicateAsync))]
	public void SetupHasRecordsWithPredicateAsync()
	{
		this._context = CreateContextWithTable<TestDbEntity>();

		foreach (var entity in this._entities)
		{
			_ = this.Context.Insert(entity);
		}
	}

	/// <summary>
	/// Prepares context for <see cref="InsertCollectionAsync"/> benchmark.
	/// </summary>
	[IterationSetup(Target = nameof(InsertCollectionAsync))]
	public void SetupInsertCollectionAsync() => this._context = CreateContextWithTable<TestDbEntity>();

	/// <summary>
	/// Prepares context and seed records for <see cref="UpsertCollectionAsync"/> benchmark.
	/// </summary>
	[IterationSetup(Target = nameof(UpsertCollectionAsync))]
	public void SetupUpsertCollectionAsync()
	{
		this._context = CreateContextWithTable<TestDbEntity>();

		foreach (var entity in this._entities)
		{
			_ = this.Context.Insert(entity);
		}
	}

	[Benchmark(Description = nameof(DataContextExtensions.UpsertCollectionAsync))]
	public async Task UpsertCollectionAsync()
	{
		var result = await this.Context.UpsertCollectionAsync(this._entities).ConfigureAwait(false);
		this.Consume(result);
	}

	private static TempFileDataContext CreateContextWithTable<T>() where T : class
	{
		var dbPath = Path.Combine(Path.GetTempPath(), $"spargine_benchmark_{Guid.NewGuid():N}.db");
		var context = new TempFileDataContext(new DataOptions().UseSQLite($"Data Source={dbPath}", SQLiteProvider.Microsoft), dbPath);
		_ = context.CreateTable<T>();
		return context;
	}

	private static TestDbEntity[] CreateEntities(int count)
	{
		var entities = new TestDbEntity[count];

		for (var entityIndex = 0; entityIndex < count; entityIndex++)
		{
			entities[entityIndex] = new TestDbEntity
			{
				Id = entityIndex + 1,
				Name = entityIndex % 2 == 0 ? MatchedName : "Other"
			};
		}

		return entities;
	}

	private static DataContext CreateTestContext() => new(new DataOptions().UseSQLite("Data Source=:memory:", SQLiteProvider.Microsoft));

	private void DisposeContext()
	{
		if (this._context is not null)
		{
			this._context.Dispose();
			this._context = null;
		}
	}

	private sealed class TempFileDataContext : DataContext
	{
		private readonly string _dbPath;

		public TempFileDataContext(DataOptions options, string dbPath) : base(options) => this._dbPath = dbPath;

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);

			if (disposing && File.Exists(this._dbPath))
			{
				try
				{
					File.Delete(this._dbPath);
				}
				catch (IOException)
				{
				}
			}
		}
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
