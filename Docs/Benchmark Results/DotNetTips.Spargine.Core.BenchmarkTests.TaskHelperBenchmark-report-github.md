```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7548/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.302
  [Host]     : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  

```
| Method                                              | Mean       | Error   | StdDev  | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s      | CI99.9% Margin | Iterations | Baseline | Code Size | Exceptions | Gen0   | Allocated |
|---------------------------------------------------- |-----------:|--------:|--------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------------:|-----------:|--------- |----------:|-----------:|-------:|----------:|
| **&#39;RunSync(Func&lt;ValueTask&lt;TResult&gt;&gt;) - returns value&#39;** | **1,313.4 ns** | **5.14 ns** | **4.81 ns** | **1.24 ns** | **1,303.0 ns** | **1,310.7 ns** | **1,313.6 ns** | **1,316.4 ns** | **1,322.6 ns** | **761,355.6** |       **6.879 ns** |      **15.00** | **No**       |   **2,412 B** |          **-** | **0.0076** |     **264 B** |
| **RunSync(Func&lt;ValueTask&gt;)**                            | **1,315.4 ns** | **3.98 ns** | **3.72 ns** | **0.96 ns** | **1,311.0 ns** | **1,312.7 ns** | **1,314.3 ns** | **1,317.6 ns** | **1,322.8 ns** | **760,205.5** |       **7.019 ns** |      **15.00** | **No**       |        **NA** |          **-** | **0.0076** |     **248 B** |
