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
| &#39;StopwatchScope.Start + Dispose&#39; | 60.13 ns | 0.173 ns | 0.153 ns | 0.041 ns | 59.88 ns | 60.03 ns | 60.14 ns | 60.18 ns | 60.43 ns | 16,631,167.3 |       6.980 ns |      14.00 | No       | 0.0010 |     471 B |          - |      40 B |
