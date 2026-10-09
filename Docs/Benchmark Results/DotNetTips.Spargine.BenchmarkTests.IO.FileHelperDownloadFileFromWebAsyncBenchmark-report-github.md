```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7725/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=IO  

```
| Method                   | Mean           | Error       | StdDev      | StdErr     | Min          | Q1             | Median         | Q3             | Max            | Op/s  | CI99.9% Margin | Iterations | Baseline | Code Size | Exceptions | Allocated |
|------------------------- |---------------:|------------:|------------:|-----------:|-------------:|---------------:|---------------:|---------------:|---------------:|------:|---------------:|-----------:|--------- |----------:|-----------:|----------:|
| DownloadFileFromWebAsync | 1,057,189.0 ns | 28,296.5 ns | 75,038.4 ns | 8,286.6 ns | 928,350.0 ns | 1,006,275.0 ns | 1,042,400.0 ns | 1,092,075.0 ns | 1,338,150.0 ns | 945.9 |    -4,102.3 ns |      82.00 | No       |     230 B |          - |  89.84 KB |
