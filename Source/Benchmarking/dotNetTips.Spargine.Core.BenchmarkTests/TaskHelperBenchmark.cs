// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : Copilot Agent
// Created          : 07-10-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-10-2026
// ***********************************************************************
// <copyright file="TaskHelperBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Benchmarks for TaskHelper.RunSync overloads annotated for benchmarking.
// </summary>
// ***********************************************************************
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.BenchmarkTests;

[MemoryDiagnoser]
public class TaskHelperBenchmark : Benchmark
{
	private Func<ValueTask> _valueTaskAction = () => ValueTask.CompletedTask;
	private Func<ValueTask<int>> _valueTaskFunc = () => new ValueTask<int>(42);

	[Benchmark(Description = "RunSync(Func<ValueTask>)")]
	public void RunSyncValueTask()
	{
		TaskHelper.RunSync(this._valueTaskAction);
	}

	[Benchmark(Description = "RunSync(Func<ValueTask<TResult>>) - returns value")]
	public int RunSyncValueTaskTResult()
	{
		return TaskHelper.RunSync(this._valueTaskFunc);
	}

	public override void Setup()
	{
		base.Setup();

		this._valueTaskAction = async () =>
		{
			// simulate lightweight asynchronous work
			await Task.Yield();
		};

		this._valueTaskFunc = async () =>
		{
			await Task.Yield();
			return 123;
		};
	}
}
