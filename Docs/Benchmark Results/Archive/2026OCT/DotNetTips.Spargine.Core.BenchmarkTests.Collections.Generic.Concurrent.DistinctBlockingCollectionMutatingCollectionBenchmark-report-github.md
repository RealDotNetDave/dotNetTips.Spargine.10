```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7725/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=Async  

```
| Method                                     | Count | Mean         | Error      | StdDev      | StdErr     | Min          | Q1           | Median       | Q3           | Max          | Op/s     | CI99.9% Margin | Iterations | Baseline | Completed Work Items | Lock Contentions | Exceptions | Code Size | Allocated |
|------------------------------------------- |------ |-------------:|-----------:|------------:|-----------:|-------------:|-------------:|-------------:|-------------:|-------------:|---------:|---------------:|-----------:|--------- |---------------------:|-----------------:|-----------:|----------:|----------:|
| **&#39;TryAdd: with Timeout &amp; CancellationToken&#39;** | **64**    |  **73,331.6 ns** | **4,425.8 ns** | **12,698.4 ns** | **1,302.8 ns** |  **38,000.0 ns** |  **66,900.0 ns** |  **74,300.0 ns** |  **81,500.0 ns** | **101,400.0 ns** | **13,636.7** |      **-603.9 ns** |      **95.00** | **No**       |                    **-** |                **-** |          **-** |     **553 B** |   **1.64 KB** |
| **&#39;TryAdd: with Timeout&#39;**                     | **64**    |  **78,930.2 ns** | **3,806.4 ns** | **10,982.5 ns** | **1,120.9 ns** |  **50,550.0 ns** |  **71,550.0 ns** |  **79,450.0 ns** |  **86,375.0 ns** | **109,150.0 ns** | **12,669.4** |      **-512.4 ns** |      **96.00** | **No**       |                    **-** |                **-** |          **-** |     **515 B** |   **1.64 KB** |
| **&#39;TryAdd: with Timespan&#39;**                    | **64**    |  **78,000.0 ns** | **3,460.6 ns** | **10,039.8 ns** | **1,019.4 ns** |  **46,300.0 ns** |  **72,400.0 ns** |  **79,500.0 ns** |  **85,700.0 ns** |  **97,000.0 ns** | **12,820.5** |      **-461.2 ns** |      **97.00** | **No**       |                    **-** |                **-** |          **-** |     **594 B** |   **1.64 KB** |
| **Add**                                        | **64**    |  **77,166.1 ns** | **4,821.3 ns** | **13,677.3 ns** | **1,418.3 ns** |  **38,050.0 ns** |  **68,650.0 ns** |  **77,050.0 ns** |  **83,750.0 ns** | **108,250.0 ns** | **12,959.1** |      **-662.6 ns** |      **93.00** | **No**       |                    **-** |                **-** |          **-** |     **543 B** |   **1.64 KB** |
| **AddRange**                                   | **64**    | **301,052.9 ns** | **5,992.9 ns** | **14,587.6 ns** | **1,743.6 ns** | **276,650.0 ns** | **288,325.0 ns** | **300,850.0 ns** | **312,425.0 ns** | **332,550.0 ns** |  **3,321.7** |      **-836.8 ns** |      **70.00** | **No**       |                    **-** |                **-** |          **-** |        **NA** |   **26.3 KB** |
| **Clear**                                      | **64**    |           **NA** |         **NA** |          **NA** |         **NA** |           **NA** |           **NA** |           **NA** |           **NA** |           **NA** |       **NA** |             **NA** |         **NA** | **No**       |                   **NA** |               **NA** |         **NA** |        **NA** |        **NA** |

Benchmarks with issues:
  DistinctBlockingCollectionMutatingCollectionBenchmark.Clear: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1) [Count=64]
