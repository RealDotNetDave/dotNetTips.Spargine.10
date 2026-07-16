```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7548/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.204
  [Host]     : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=IO  

```
| Method        | Mean           | Error       | StdDev      | StdErr     | Min            | Q1             | Median         | Q3             | Max            | Op/s  | CI99.9% Margin | Iterations | Baseline | Completed Work Items | Lock Contentions | Exceptions | Code Size | Allocated |
|-------------- |---------------:|------------:|------------:|-----------:|---------------:|---------------:|---------------:|---------------:|---------------:|------:|---------------:|-----------:|--------- |---------------------:|-----------------:|-----------:|----------:|----------:|
| **CopyFile**      | **1,134,215.2 ns** | **27,575.2 ns** | **77,776.4 ns** | **8,108.7 ns** |   **976,050.0 ns** | **1,082,025.0 ns** | **1,121,450.0 ns** | **1,176,625.0 ns** | **1,339,950.0 ns** | **881.7** |    **-4,008.4 ns** |      **92.00** | **No**       |                    **-** |                **-** |          **-** |        **NA** |  **81.35 KB** |
| **CopyFileAsync** | **1,271,026.7 ns** | **28,367.5 ns** | **77,175.9 ns** | **8,322.1 ns** | **1,124,000.0 ns** | **1,216,675.0 ns** | **1,265,850.0 ns** | **1,307,800.0 ns** | **1,504,300.0 ns** | **786.8** |    **-4,118.0 ns** |      **86.00** | **No**       |               **3.0000** |                **-** |          **-** |     **296 B** |  **83.02 KB** |
