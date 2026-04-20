```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7184/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.202
  [Host]     : .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  

```
| Method  | Mean       | Error    | StdDev   | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s      | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Code Size |
|-------- |-----------:|---------:|---------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|----------:|
| ToWords | 4,645.3 ns | 29.98 ns | 28.05 ns | 7.24 ns | 4,608.0 ns | 4,623.2 ns | 4,641.4 ns | 4,663.6 ns | 4,702.2 ns | 215,271.8 |       3.879 ns |      15.00 |    1.965 |  2.000 |   0.3809 |    1 | *            | No       |          - |  26,505 B |
