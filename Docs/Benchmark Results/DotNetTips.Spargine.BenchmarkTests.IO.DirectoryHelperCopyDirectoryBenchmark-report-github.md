```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7417/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.204
  [Host]     : .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=**NEW**,IO  

```
| Method        | Mean            | Error          | StdDev         | StdErr       | Min             | Q1              | Median          | Q3              | Max             | Op/s  | CI99.9% Margin | Iterations | Baseline | Code Size | Exceptions | Allocated |
|-------------- |----------------:|---------------:|---------------:|-------------:|----------------:|----------------:|----------------:|----------------:|----------------:|------:|---------------:|-----------:|--------- |----------:|-----------:|----------:|
| CopyDirectory | 70,601,122.0 ns | 1,409,020.3 ns | 2,065,323.8 ns | 383,521.0 ns | 68,647,787.5 ns | 69,135,450.0 ns | 69,546,462.5 ns | 72,337,312.5 ns | 75,595,825.0 ns | 14.16 |  -191,746.0 ns |      29.00 | No       |  14,707 B |          - | 326.07 KB |
