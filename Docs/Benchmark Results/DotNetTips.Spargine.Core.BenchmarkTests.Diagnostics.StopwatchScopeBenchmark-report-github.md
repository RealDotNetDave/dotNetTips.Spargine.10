```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7725/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  

```
| Method                           | Mean     | Error    | StdDev   | StdErr   | Min      | Q1       | Median   | Q3       | Max      | Op/s         | CI99.9% Margin | Iterations | Baseline | Gen0   | Code Size | Exceptions | Allocated |
|--------------------------------- |---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------:|-------------:|---------------:|-----------:|--------- |-------:|----------:|-----------:|----------:|
| &#39;StopwatchScope.Start + Dispose&#39; | 59.64 ns | 0.198 ns | 0.176 ns | 0.047 ns | 59.46 ns | 59.47 ns | 59.66 ns | 59.76 ns | 59.96 ns | 16,766,169.0 |       6.977 ns |      14.00 | No       | 0.0013 |     463 B |          - |      40 B |
