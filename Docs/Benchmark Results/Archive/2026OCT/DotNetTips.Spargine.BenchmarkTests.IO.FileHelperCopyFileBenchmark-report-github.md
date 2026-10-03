```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7725/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=IO  

```
| Method        | Mean           | Error       | StdDev       | StdErr      | Min            | Q1             | Median         | Q3             | Max            | Op/s  | CI99.9% Margin | Iterations | Baseline | Completed Work Items | Lock Contentions | Exceptions | Code Size | Allocated |
|-------------- |---------------:|------------:|-------------:|------------:|---------------:|---------------:|---------------:|---------------:|---------------:|------:|---------------:|-----------:|--------- |---------------------:|-----------------:|-----------:|----------:|----------:|
| **CopyFile**      | **1,127,300.0 ns** | **22,502.8 ns** |  **61,601.0 ns** |  **6,604.3 ns** | **1,004,900.0 ns** | **1,082,450.0 ns** | **1,124,600.0 ns** | **1,165,550.0 ns** | **1,316,300.0 ns** | **887.1** |    **-3,258.7 ns** |      **87.00** | **No**       |                    **-** |                **-** |          **-** |        **NA** |  **81.35 KB** |
| **CopyFileAsync** | **1,268,582.9 ns** | **52,911.1 ns** | **140,312.9 ns** | **15,495.0 ns** | **1,046,550.0 ns** | **1,188,550.0 ns** | **1,246,550.0 ns** | **1,302,475.0 ns** | **1,758,650.0 ns** | **788.3** |    **-7,706.5 ns** |      **82.00** | **No**       |               **3.0000** |                **-** |          **-** |     **296 B** |  **83.02 KB** |
