```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7184/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.202
  [Host]     : .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=Encryption  

```
| Method           | Mean       | Error   | StdDev  | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s      | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions |
|----------------- |-----------:|--------:|--------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|
| GeneratePassword | 1,130.8 ns | 3.44 ns | 3.05 ns | 0.82 ns | 1,124.1 ns | 1,129.4 ns | 1,130.6 ns | 1,133.6 ns | 1,134.7 ns | 884,316.7 |       6.592 ns |      14.00 |    2.415 |  2.000 |  -0.5572 |    1 | *            | No       |          - |
