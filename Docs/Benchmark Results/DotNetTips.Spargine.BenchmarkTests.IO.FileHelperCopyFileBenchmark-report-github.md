```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7417/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.204
  [Host]     : .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=**NEW**,IO  

```
| Method        | Mean           | Error       | StdDev      | StdErr     | Min            | Q1             | Median         | Q3             | Max            | Op/s  | CI99.9% Margin | Iterations | Baseline | Completed Work Items | Lock Contentions | Exceptions | Code Size | Allocated |
|-------------- |---------------:|------------:|------------:|-----------:|---------------:|---------------:|---------------:|---------------:|---------------:|------:|---------------:|-----------:|--------- |---------------------:|-----------------:|-----------:|----------:|----------:|
| **CopyFile**      | **1,063,609.2 ns** | **21,044.6 ns** | **53,565.2 ns** | **6,144.4 ns** |   **894,600.0 ns** | **1,025,525.0 ns** | **1,062,450.0 ns** | **1,093,275.0 ns** | **1,237,000.0 ns** | **940.2** |    **-3,034.2 ns** |      **76.00** | **No**       |                    **-** |                **-** |          **-** |        **NA** |  **81.35 KB** |
| **CopyFileAsync** | **1,184,772.8 ns** | **31,335.4 ns** | **82,549.9 ns** | **9,172.2 ns** | **1,006,000.0 ns** | **1,127,400.0 ns** | **1,179,800.0 ns** | **1,231,600.0 ns** | **1,479,000.0 ns** | **844.0** |    **-4,545.6 ns** |      **81.00** | **No**       |               **3.0000** |                **-** |          **-** |     **296 B** |  **83.02 KB** |
