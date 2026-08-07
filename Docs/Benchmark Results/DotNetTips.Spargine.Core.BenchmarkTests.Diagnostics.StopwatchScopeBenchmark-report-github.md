```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7548/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.302
  [Host]     : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  

```
| Method                           | Mean     | Error    | StdDev   | StdErr   | Min      | Q1       | Median   | Q3       | Max      | Op/s         | CI99.9% Margin | Iterations | Baseline | Exceptions | Gen0   | Code Size | Allocated |
|--------------------------------- |---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------:|-------------:|---------------:|-----------:|--------- |-----------:|-------:|----------:|----------:|
| &#39;StopwatchScope.Start + Dispose&#39; | 59.45 ns | 0.241 ns | 0.214 ns | 0.057 ns | 59.18 ns | 59.27 ns | 59.39 ns | 59.61 ns | 59.89 ns | 16,821,939.5 |       6.971 ns |      14.00 | No       |          - | 0.0013 |     471 B |      40 B |
