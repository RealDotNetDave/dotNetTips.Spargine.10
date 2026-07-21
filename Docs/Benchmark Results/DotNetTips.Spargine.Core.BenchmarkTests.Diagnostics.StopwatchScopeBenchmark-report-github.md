```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7548/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.204
  [Host]     : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  

```
| Method                           | Mean     | Error    | StdDev   | StdErr   | Min      | Q1       | Median   | Q3       | Max      | Op/s         | CI99.9% Margin | Iterations | Baseline | Code Size | Gen0   | Exceptions | Allocated |
|--------------------------------- |---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------:|-------------:|---------------:|-----------:|--------- |----------:|-------:|-----------:|----------:|
| &#39;StopwatchScope.Start + Dispose&#39; | 59.39 ns | 0.170 ns | 0.151 ns | 0.040 ns | 59.15 ns | 59.24 ns | 59.44 ns | 59.49 ns | 59.58 ns | 16,838,031.4 |       6.980 ns |      14.00 | No       |     471 B | 0.0013 |          - |      40 B |
