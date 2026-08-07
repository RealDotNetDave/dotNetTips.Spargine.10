```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7548/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.302
  [Host]     : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  

```
| Method                                              | Mean       | Error    | StdDev   | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s      | CI99.9% Margin | Iterations | Baseline | Gen0   | Exceptions | Code Size | Allocated |
|---------------------------------------------------- |-----------:|---------:|---------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------------:|-----------:|--------- |-------:|-----------:|----------:|----------:|
| **&#39;RunSync(Func&lt;ValueTask&lt;TResult&gt;&gt;) - returns value&#39;** | **1,304.3 ns** |  **4.17 ns** |  **3.70 ns** | **0.99 ns** | **1,297.0 ns** | **1,302.5 ns** | **1,304.4 ns** | **1,306.0 ns** | **1,311.4 ns** | **766,666.3** |       **6.506 ns** |      **14.00** | **No**       | **0.0076** |          **-** |   **2,412 B** |     **264 B** |
| **RunSync(Func&lt;ValueTask&gt;)**                            | **1,328.7 ns** | **19.32 ns** | **18.07 ns** | **4.67 ns** | **1,304.8 ns** | **1,310.8 ns** | **1,330.9 ns** | **1,346.3 ns** | **1,352.3 ns** | **752,642.3** |       **5.167 ns** |      **15.00** | **No**       | **0.0076** |          **-** |        **NA** |     **248 B** |
