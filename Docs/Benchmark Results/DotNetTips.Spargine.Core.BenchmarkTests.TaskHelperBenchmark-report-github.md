```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7548/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.204
  [Host]     : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  

```
| Method                                              | Mean       | Error    | StdDev   | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s      | CI99.9% Margin | Iterations | Baseline | Code Size | Exceptions | Gen0   | Allocated |
|---------------------------------------------------- |-----------:|---------:|---------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------------:|-----------:|--------- |----------:|-----------:|-------:|----------:|
| **&#39;RunSync(Func&lt;ValueTask&lt;TResult&gt;&gt;) - returns value&#39;** | **1,310.3 ns** |  **5.11 ns** |  **4.53 ns** | **1.21 ns** | **1,303.0 ns** | **1,308.6 ns** | **1,309.7 ns** | **1,311.7 ns** | **1,319.0 ns** | **763,157.5** |       **6.395 ns** |      **14.00** | **No**       |   **2,412 B** |          **-** | **0.0076** |     **264 B** |
| **RunSync(Func&lt;ValueTask&gt;)**                            | **1,315.9 ns** | **21.93 ns** | **20.52 ns** | **5.30 ns** | **1,287.0 ns** | **1,298.7 ns** | **1,322.3 ns** | **1,327.7 ns** | **1,356.6 ns** | **759,962.0** |       **4.851 ns** |      **15.00** | **No**       |        **NA** |          **-** | **0.0076** |     **248 B** |
