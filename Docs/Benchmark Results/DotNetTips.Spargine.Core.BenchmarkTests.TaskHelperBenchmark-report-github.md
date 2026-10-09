```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7725/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  

```
| Method                                              | Mean       | Error   | StdDev  | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s      | CI99.9% Margin | Iterations | Baseline | Code Size | Gen0   | Exceptions | Allocated |
|---------------------------------------------------- |-----------:|--------:|--------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------------:|-----------:|--------- |----------:|-------:|-----------:|----------:|
| **&#39;RunSync(Func&lt;ValueTask&lt;TResult&gt;&gt;) - returns value&#39;** | **1,289.9 ns** | **5.88 ns** | **4.91 ns** | **1.36 ns** | **1,280.5 ns** | **1,286.2 ns** | **1,290.6 ns** | **1,291.9 ns** | **1,298.1 ns** | **775,250.3** |       **5.819 ns** |      **13.00** | **No**       |   **2,412 B** | **0.0076** |          **-** |     **264 B** |
| **RunSync(Func&lt;ValueTask&gt;)**                            | **1,290.1 ns** | **7.94 ns** | **7.43 ns** | **1.92 ns** | **1,277.2 ns** | **1,285.8 ns** | **1,290.4 ns** | **1,295.5 ns** | **1,303.4 ns** | **775,161.5** |       **6.541 ns** |      **15.00** | **No**       |        **NA** | **0.0076** |          **-** |     **248 B** |
