```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7725/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=IO  

```
| Method        | Mean            | Error          | StdDev         | StdErr       | Min             | Q1              | Median          | Q3              | Max             | Op/s  | CI99.9% Margin | Iterations | Baseline | Code Size | Exceptions | Allocated |
|-------------- |----------------:|---------------:|---------------:|-------------:|----------------:|----------------:|----------------:|----------------:|----------------:|------:|---------------:|-----------:|--------- |----------:|-----------:|----------:|
| CopyDirectory | 70,532,072.4 ns | 1,355,504.9 ns | 1,201,619.8 ns | 321,146.4 ns | 69,282,242.9 ns | 69,691,157.1 ns | 70,055,821.4 ns | 71,061,660.7 ns | 73,415,228.6 ns | 14.18 |  -160,566.2 ns |      14.00 | No       |  14,780 B |          - | 321.25 KB |
