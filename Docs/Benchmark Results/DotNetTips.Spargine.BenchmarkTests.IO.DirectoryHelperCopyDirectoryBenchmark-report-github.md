```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7291/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.204
  [Host]     : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=**NEW**,IO  

```
| Method        | Mean            | Error          | StdDev         | StdErr       | Min             | Q1              | Median          | Q3              | Max             | Op/s  | CI99.9% Margin | Iterations | Baseline | Code Size | Exceptions | Allocated |
|-------------- |----------------:|---------------:|---------------:|-------------:|----------------:|----------------:|----------------:|----------------:|----------------:|------:|---------------:|-----------:|--------- |----------:|-----------:|----------:|
| CopyDirectory | 69,272,474.5 ns | 1,380,887.3 ns | 3,539,742.2 ns | 403,391.1 ns | 63,631,187.5 ns | 66,742,175.0 ns | 68,748,400.0 ns | 71,482,787.5 ns | 78,255,350.0 ns | 14.44 |  -201,657.0 ns |      77.00 | No       |  10,544 B |          - | 309.05 KB |
