```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7417/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.204
  [Host]     : .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=**NEW**,IO  

```
| Method      | Mean           | Error       | StdDev       | StdErr      | Min            | Q1             | Median         | Q3             | Max            | Op/s  | CI99.9% Margin | Iterations | Baseline | Code Size | Exceptions | Allocated |
|------------ |---------------:|------------:|-------------:|------------:|---------------:|---------------:|---------------:|---------------:|---------------:|------:|---------------:|-----------:|--------- |----------:|-----------:|----------:|
| DeleteFiles | 4,010,985.4 ns | 80,166.6 ns | 144,557.0 ns | 22,576.0 ns | 3,805,800.0 ns | 3,925,700.0 ns | 3,984,600.0 ns | 4,043,100.0 ns | 4,436,900.0 ns | 249.3 |   -11,267.5 ns |      41.00 | No       |     513 B |          - |   3.23 KB |
