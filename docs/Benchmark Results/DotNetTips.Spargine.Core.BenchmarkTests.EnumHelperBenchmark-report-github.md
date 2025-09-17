```

BenchmarkDotNet v0.15.2, Windows 10 (10.0.19045.6332/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.100-rc.1.25451.107
  [Host]     : .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
  Job-PSYKRA : .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests  

```
| Method    | Mean       | Error    | StdDev   | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s      | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Gen0   | Completed Work Items | Lock Contentions | Allocated |
|---------- |-----------:|---------:|---------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|-------:|---------------------:|-----------------:|----------:|
| GetValues | 1,572.6 ns | 13.29 ns | 12.43 ns | 3.21 ns | 1,554.1 ns | 1,562.3 ns | 1,567.9 ns | 1,580.6 ns | 1,597.7 ns | 635,889.9 |       5.895 ns |      15.00 |    1.988 |  2.000 |   0.4365 |    1 | *            | No       |          - | 0.0267 |                    - |                - |     840 B |
