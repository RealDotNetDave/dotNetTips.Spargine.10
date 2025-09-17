```

BenchmarkDotNet v0.15.2, Windows 10 (10.0.19045.6332/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.100-rc.1.25451.107
  [Host]     : .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
  Job-PSYKRA : .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests.Security  Categories=Encryption,**NEW**  

```
| Method           | Mean       | Error    | StdDev   | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s      | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Completed Work Items | Lock Contentions | Exceptions | Gen0   | Allocated |
|----------------- |-----------:|---------:|---------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |---------------------:|-----------------:|-----------:|-------:|----------:|
| GeneratePassword | 2,263.0 ns | 35.06 ns | 32.80 ns | 8.47 ns | 2,213.4 ns | 2,242.5 ns | 2,256.5 ns | 2,277.2 ns | 2,324.4 ns | 441,890.9 |       3.266 ns |      15.00 |    2.092 |  2.000 |   0.4313 |    1 | *            | No       |                    - |                - |          - | 0.0038 |     176 B |
