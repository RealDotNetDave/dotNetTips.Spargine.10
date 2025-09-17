```

BenchmarkDotNet v0.15.2, Windows 10 (10.0.19045.6332/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.100-rc.1.25451.107
  [Host]     : .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
  Job-PSYKRA : .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests  

```
| Method    | Mean        | Error      | StdDev     | StdErr   | Min         | Q1          | Median      | Q3          | Max         | Op/s     | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Gen0   | Exceptions | Completed Work Items | Lock Contentions | Allocated |
|---------- |------------:|-----------:|-----------:|---------:|------------:|------------:|------------:|------------:|------------:|---------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-------:|-----------:|---------------------:|-----------------:|----------:|
| GetValues | 83,117.9 ns | 1,514.6 ns | 1,803.1 ns | 393.5 ns | 80,038.1 ns | 81,992.4 ns | 82,635.3 ns | 84,069.0 ns | 86,690.2 ns | 12,031.1 |      -186.2 ns |      21.00 |    2.214 |  2.000 |   0.4717 |    1 | *            | No       | 0.7324 |          - |                    - |                - |  27.51 KB |
