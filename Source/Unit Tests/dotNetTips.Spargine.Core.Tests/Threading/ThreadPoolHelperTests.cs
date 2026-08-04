// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : Copilot Agent
// Created          : 08-04-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 08-04-2026
// ***********************************************************************
// <copyright file="ThreadPoolHelperTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Tests for ThreadPoolHelper.</summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core.Threading;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class ThreadPoolHelperTests
{

	[TestMethod]
	public void GetStatistics_WhenCalled_ReturnsNonNegativeThreadCount()
	{
		var statistics = ThreadPoolHelper.GetStatistics();

		Assert.IsTrue(statistics.MaxWorkerThreads > 0);
	}

	[TestMethod]
	public async Task RunAsync_ActionOperationIsNull_ThrowsArgumentNullException()
	{
		try
		{
			await ThreadPoolHelper.RunAsync((Action<CancellationToken>)null!, 1_000).ConfigureAwait(false);
			Assert.Fail("Expected ArgumentNullException.");
		}
		catch (ArgumentNullException exception)
		{
			StringAssert.StartsWith(exception.ParamName, "operation");
		}
	}

	[TestMethod]
	public async Task RunAsync_ActionOperationRuns_CompletesOperation()
	{
		var executed = false;

		await ThreadPoolHelper.RunAsync(_ => executed = true, 1_000).ConfigureAwait(false);

		Assert.IsTrue(executed);
	}

	[TestMethod]
	public async Task RunAsync_AsyncOperationIsNull_ThrowsArgumentNullException()
	{
		try
		{
			_ = await ThreadPoolHelper.RunAsync((Func<CancellationToken, Task<int>>)null!, 1_000).ConfigureAwait(false);
			Assert.Fail("Expected ArgumentNullException.");
		}
		catch (ArgumentNullException exception)
		{
			StringAssert.StartsWith(exception.ParamName, "operation");
		}
	}

	[TestMethod]
	public async Task RunAsync_AsyncOperationReturnsResult_ReturnsResult()
	{
		var result = await ThreadPoolHelper.RunAsync(async _ =>
		{
			await Task.Yield();
			return 84;
		}, 1_000).ConfigureAwait(false);

		Assert.AreEqual(84, result);
	}

	[TestMethod]
	public async Task RunAsync_BoundedConcurrencyBelowMinimum_ThrowsArgumentOutOfRangeException()
	{
		var operations = new Func<CancellationToken, int>[] { _ => 1 };

		try
		{
			_ = await ThreadPoolHelper.RunAsync(operations, 0, 1_000).ConfigureAwait(false);
			Assert.Fail("Expected ArgumentOutOfRangeException.");
		}
		catch (ArgumentOutOfRangeException exception)
		{
			StringAssert.StartsWith(exception.ParamName, "maxDegreeOfParallelism");
		}
	}

	[TestMethod]
	public async Task RunAsync_BoundedConcurrencyOperations_ReturnsResultsInInputOrder()
	{
		var operations = new Func<CancellationToken, int>[]
		{
			_ => 1,
			_ => 2,
			_ => 3,
			_ => 4
		};

		var result = await ThreadPoolHelper.RunAsync(operations, 2, 1_000).ConfigureAwait(false);

		CollectionAssert.AreEqual(new[] { 1, 2, 3, 4 }, result);
	}

	[TestMethod]
	public async Task RunAsync_CancellationTokenCanceledBeforeCall_ThrowsOperationCanceledException()
	{
		using var cancellationTokenSource = new CancellationTokenSource();

		cancellationTokenSource.Cancel();

		try
		{
			_ = await ThreadPoolHelper.RunAsync(_ => 42, 1_000, cancellationTokenSource.Token).ConfigureAwait(false);
			Assert.Fail("Expected OperationCanceledException.");
		}
		catch (OperationCanceledException exception)
		{
			Assert.AreEqual(cancellationTokenSource.Token, exception.CancellationToken);
		}
	}

	[TestMethod]
	public async Task RunAsync_MillisecondsTimeOutBelowMinimum_ThrowsArgumentOutOfRangeException()
	{
		try
		{
			_ = await ThreadPoolHelper.RunAsync(_ => 42, 0).ConfigureAwait(false);
			Assert.Fail("Expected ArgumentOutOfRangeException.");
		}
		catch (ArgumentOutOfRangeException exception)
		{
			StringAssert.StartsWith(exception.ParamName, "millisecondsTimeOut");
		}
	}

	[TestMethod]
	public async Task RunAsync_OperationInBatchIsNull_ThrowsArgumentNullException()
	{
		var operations = new Func<CancellationToken, int>[]
		{
			_ => 1,
			null!
		};

		try
		{
			_ = await ThreadPoolHelper.RunAsync(operations, 1_000).ConfigureAwait(false);
			Assert.Fail("Expected ArgumentNullException.");
		}
		catch (ArgumentNullException exception)
		{
			StringAssert.StartsWith(exception.ParamName, "operation");
		}
	}

	[TestMethod]
	public async Task RunAsync_OperationIsNull_ThrowsArgumentNullException()
	{
		try
		{
			_ = await ThreadPoolHelper.RunAsync((Func<CancellationToken, int>)null!, 1_000).ConfigureAwait(false);
			Assert.Fail("Expected ArgumentNullException.");
		}
		catch (ArgumentNullException exception)
		{
			StringAssert.StartsWith(exception.ParamName, "operation");
		}
	}
	[TestMethod]
	public async Task RunAsync_OperationReturnsResult_ReturnsResult()
	{
		var result = await ThreadPoolHelper.RunAsync(_ => 42, 1_000).ConfigureAwait(false);

		Assert.AreEqual(42, result);
	}

	[TestMethod]
	public async Task RunAsync_OperationsIsEmpty_ReturnsEmptyArray()
	{
		var result = await ThreadPoolHelper.RunAsync(Array.Empty<Func<CancellationToken, int>>(), 1_000).ConfigureAwait(false);

		Assert.AreEqual(0, result.Length);
	}

	[TestMethod]
	public async Task RunAsync_OperationsIsNull_ThrowsArgumentNullException()
	{
		try
		{
			_ = await ThreadPoolHelper.RunAsync((IReadOnlyCollection<Func<CancellationToken, int>>)null!, 1_000).ConfigureAwait(false);
			Assert.Fail("Expected ArgumentNullException.");
		}
		catch (ArgumentNullException exception)
		{
			StringAssert.StartsWith(exception.ParamName, "operations");
		}
	}

	[TestMethod]
	public async Task RunAsync_OperationsReturnResults_ReturnsResultsInInputOrder()
	{
		var operations = new Func<CancellationToken, int>[]
		{
			_ => 1,
			_ => 2,
			_ => 3
		};

		var result = await ThreadPoolHelper.RunAsync(operations, 1_000).ConfigureAwait(false);

		CollectionAssert.AreEqual(new[] { 1, 2, 3 }, result);
	}

	[TestMethod]
	public async Task RunAsync_OperationThrowsOperationCanceledException_ThrowsOperationCanceledException()
	{
		using var cancellationTokenSource = new CancellationTokenSource();

		try
		{
			_ = await ThreadPoolHelper.RunAsync((Func<CancellationToken, int>)(_ => throw new OperationCanceledException(cancellationTokenSource.Token)), 1_000, cancellationTokenSource.Token).ConfigureAwait(false);
			Assert.Fail("Expected OperationCanceledException.");
		}
		catch (OperationCanceledException exception)
		{
			Assert.AreEqual(cancellationTokenSource.Token, exception.CancellationToken);
		}
	}

	[TestMethod]
	public async Task RunWhenAnyAsync_OperationsIsEmpty_ThrowsArgumentOutOfRangeException()
	{
		try
		{
			_ = await ThreadPoolHelper.RunWhenAnyAsync(Array.Empty<Func<CancellationToken, int>>(), 1_000).ConfigureAwait(false);
			Assert.Fail("Expected ArgumentOutOfRangeException.");
		}
		catch (ArgumentOutOfRangeException)
		{
		}
	}

	[TestMethod]
	public async Task RunWhenAnyAsync_OperationsProvided_ReturnsAResult()
	{
		var operations = new Func<CancellationToken, int>[]
		{
			_ => 10,
			_ => 20,
			_ => 30
		};

		var result = await ThreadPoolHelper.RunWhenAnyAsync(operations, 1_000).ConfigureAwait(false);

		CollectionAssert.Contains(new[] { 10, 20, 30 }, result);
	}

	[TestMethod]
	public async Task TryRunAsync_OperationSucceeds_ReturnsSuccessResult()
	{
		var result = await ThreadPoolHelper.TryRunAsync(_ => 42, 1_000).ConfigureAwait(false);

		Assert.IsTrue(result.IsSuccess);
	}

	[TestMethod]
	public async Task TryRunAsync_OperationThrows_ReturnsFailureResult()
	{
		var result = await ThreadPoolHelper.TryRunAsync<int>(_ => throw new InvalidOperationException("boom"), 1_000).ConfigureAwait(false);

		Assert.IsTrue(result.HasErrors);
	}
}
