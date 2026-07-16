```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7548/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.204
  [Host]     : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=IO  

```
| Method                   | Mean           | Error       | StdDev      | StdErr     | Min          | Q1             | Median         | Q3             | Max            | Op/s  | CI99.9% Margin | Iterations | Baseline | Exceptions | Code Size | Allocated |
|------------------------- |---------------:|------------:|------------:|-----------:|-------------:|---------------:|---------------:|---------------:|---------------:|------:|---------------:|-----------:|--------- |-----------:|----------:|----------:|
| DownloadFileFromWebAsync | 1,105,481.7 ns | 27,930.0 ns | 74,066.3 ns | 8,179.3 ns | 955,600.0 ns | 1,051,275.0 ns | 1,102,400.0 ns | 1,155,650.0 ns | 1,301,300.0 ns | 904.6 |    -4,048.6 ns |      82.00 | No       |          - |     296 B |  89.84 KB |
