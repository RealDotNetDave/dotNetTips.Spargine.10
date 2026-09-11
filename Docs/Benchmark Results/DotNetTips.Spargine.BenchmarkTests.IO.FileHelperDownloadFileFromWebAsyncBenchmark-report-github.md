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
| DownloadFileFromWebAsync | 1,088,596.5 ns | 22,156.8 ns | 60,279.3 ns | 6,500.1 ns | 958,300.0 ns | 1,052,075.0 ns | 1,078,850.0 ns | 1,109,025.0 ns | 1,282,800.0 ns | 918.6 |    -3,207.0 ns |      86.00 | No       |     230 B |          - |  89.92 KB |
