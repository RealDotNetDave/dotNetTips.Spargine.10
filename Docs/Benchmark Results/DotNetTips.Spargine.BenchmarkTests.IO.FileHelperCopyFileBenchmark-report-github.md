```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7548/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.302
  [Host]     : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=IO  

```
| Method        | Mean           | Error       | StdDev      | StdErr      | Min            | Q1             | Median         | Q3             | Max            | Op/s  | CI99.9% Margin | Iterations | Baseline | Completed Work Items | Lock Contentions | Exceptions | Code Size | Allocated |
|-------------- |---------------:|------------:|------------:|------------:|---------------:|---------------:|---------------:|---------------:|---------------:|------:|---------------:|-----------:|--------- |---------------------:|-----------------:|-----------:|----------:|----------:|
| **CopyFile**      | **1,115,044.7 ns** | **36,766.9 ns** | **99,401.4 ns** | **10,781.6 ns** |   **939,200.0 ns** | **1,057,000.0 ns** | **1,100,300.0 ns** | **1,149,200.0 ns** | **1,444,200.0 ns** | **896.8** |    **-5,348.3 ns** |      **85.00** | **No**       |                    **-** |                **-** |          **-** |        **NA** |  **81.35 KB** |
| **CopyFileAsync** | **1,267,712.7 ns** | **34,862.5 ns** | **93,055.1 ns** | **10,214.1 ns** | **1,082,550.0 ns** | **1,212,350.0 ns** | **1,249,850.0 ns** | **1,312,500.0 ns** | **1,569,450.0 ns** | **788.8** |    **-5,065.6 ns** |      **83.00** | **No**       |               **3.0000** |                **-** |          **-** |     **296 B** |  **83.02 KB** |
