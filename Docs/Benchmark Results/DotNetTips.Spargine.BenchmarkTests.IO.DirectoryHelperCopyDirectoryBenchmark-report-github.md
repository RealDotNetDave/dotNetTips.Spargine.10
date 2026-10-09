```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7725/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=IO  

```
| Method        | Mean            | Error          | StdDev         | StdErr       | Median          | Min             | Q1              | Q3              | Max             | Op/s  | CI99.9% Margin | Iterations | Baseline | Code Size | Exceptions | Allocated |
|-------------- |----------------:|---------------:|---------------:|-------------:|----------------:|----------------:|----------------:|----------------:|----------------:|------:|---------------:|-----------:|--------- |----------:|-----------:|----------:|
| CopyDirectory | 70,519,827.7 ns | 1,268,294.3 ns | 1,974,581.6 ns | 349,060.0 ns | 69,539,828.6 ns | 68,649,557.1 ns | 69,254,032.1 ns | 71,700,560.7 ns | 75,175,142.9 ns | 14.18 |  -174,514.0 ns |      32.00 | No       |  14,721 B |          - | 333.85 KB |
