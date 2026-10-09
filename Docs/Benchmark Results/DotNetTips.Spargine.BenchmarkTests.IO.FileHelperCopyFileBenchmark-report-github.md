```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7725/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=IO  

```
| Method        | Mean           | Error       | StdDev      | StdErr     | Min            | Q1             | Median         | Q3             | Max            | Op/s  | CI99.9% Margin | Iterations | Baseline | Completed Work Items | Lock Contentions | Exceptions | Code Size | Allocated |
|-------------- |---------------:|------------:|------------:|-----------:|---------------:|---------------:|---------------:|---------------:|---------------:|------:|---------------:|-----------:|--------- |---------------------:|-----------------:|-----------:|----------:|----------:|
| **CopyFile**      | **1,123,310.0 ns** | **26,308.7 ns** | **71,127.1 ns** | **7,714.8 ns** |   **983,850.0 ns** | **1,079,650.0 ns** | **1,109,350.0 ns** | **1,161,950.0 ns** | **1,309,850.0 ns** | **890.2** |    **-3,814.9 ns** |      **85.00** | **No**       |                    **-** |                **-** |          **-** |        **NA** |  **81.35 KB** |
| **CopyFileAsync** | **1,247,867.6 ns** | **33,829.6 ns** | **91,460.3 ns** | **9,920.3 ns** | **1,093,450.0 ns** | **1,190,750.0 ns** | **1,231,750.0 ns** | **1,285,450.0 ns** | **1,552,850.0 ns** | **801.4** |    **-4,917.6 ns** |      **85.00** | **No**       |               **3.0000** |                **-** |          **-** |     **296 B** |  **83.02 KB** |
