```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7291/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.204
  [Host]     : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=**NEW**,IO  

```
| Method        | Mean           | Error       | StdDev      | StdErr      | Min            | Q1             | Median         | Q3             | Max            | Op/s  | CI99.9% Margin | Iterations | Baseline | Completed Work Items | Lock Contentions | Exceptions | Code Size | Allocated |
|-------------- |---------------:|------------:|------------:|------------:|---------------:|---------------:|---------------:|---------------:|---------------:|------:|---------------:|-----------:|--------- |---------------------:|-----------------:|-----------:|----------:|----------:|
| **CopyFile**      | **1,096,675.3 ns** | **25,115.1 ns** | **67,900.2 ns** |  **7,364.8 ns** |   **943,700.0 ns** | **1,051,100.0 ns** | **1,100,200.0 ns** | **1,141,700.0 ns** | **1,266,700.0 ns** | **911.8** |    **-3,639.9 ns** |      **85.00** | **No**       |                    **-** |                **-** |          **-** |        **NA** |  **81.35 KB** |
| **CopyFileAsync** | **1,295,402.3 ns** | **34,954.5 ns** | **95,096.3 ns** | **10,254.5 ns** | **1,145,200.0 ns** | **1,214,075.0 ns** | **1,291,150.0 ns** | **1,351,125.0 ns** | **1,644,700.0 ns** | **772.0** |    **-5,084.3 ns** |      **86.00** | **No**       |               **3.0000** |                **-** |          **-** |     **296 B** |  **83.02 KB** |
