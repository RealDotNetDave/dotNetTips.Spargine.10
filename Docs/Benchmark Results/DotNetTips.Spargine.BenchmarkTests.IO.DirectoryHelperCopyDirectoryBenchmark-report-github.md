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
| CopyDirectory | 64,001,662.5 ns | 1,206,258.1 ns | 1,007,280.1 ns | 279,369.2 ns | 63,164,650.0 ns | 63,352,762.5 ns | 63,622,862.5 ns | 64,135,175.0 ns | 66,684,487.5 ns | 15.62 |  -139,678.1 ns |      13.00 | No       |  10,533 B |          - | 307.23 KB |
