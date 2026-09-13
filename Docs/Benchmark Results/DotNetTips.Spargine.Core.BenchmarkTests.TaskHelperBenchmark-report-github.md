```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7725/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  

```
| Method                                              | Mean       | Error    | StdDev   | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s      | CI99.9% Margin | Iterations | Baseline | Code Size | Gen0   | Exceptions | Allocated |
|---------------------------------------------------- |-----------:|---------:|---------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------------:|-----------:|--------- |----------:|-------:|-----------:|----------:|
| **&#39;RunSync(Func&lt;ValueTask&lt;TResult&gt;&gt;) - returns value&#39;** | **1,322.3 ns** |  **5.15 ns** |  **4.81 ns** | **1.24 ns** | **1,317.3 ns** | **1,318.2 ns** | **1,321.3 ns** | **1,325.2 ns** | **1,332.7 ns** | **756,282.5** |       **6.878 ns** |      **15.00** | **No**       |   **2,412 B** | **0.0076** |          **-** |     **264 B** |
| **RunSync(Func&lt;ValueTask&gt;)**                            | **1,314.0 ns** | **15.97 ns** | **14.94 ns** | **3.86 ns** | **1,290.0 ns** | **1,299.7 ns** | **1,321.5 ns** | **1,325.3 ns** | **1,332.8 ns** | **761,036.9** |       **5.571 ns** |      **15.00** | **No**       |        **NA** | **0.0076** |          **-** |     **248 B** |
