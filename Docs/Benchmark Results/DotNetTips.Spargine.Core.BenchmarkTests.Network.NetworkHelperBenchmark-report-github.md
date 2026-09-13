```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7725/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  

```
| Method                         | Mean            | Error        | StdDev       | StdErr      | Min             | Q1              | Median          | Q3              | Max             | Op/s  | CI99.9% Margin | Iterations | Baseline | Exceptions | Allocated |
|------------------------------- |----------------:|-------------:|-------------:|------------:|----------------:|----------------:|----------------:|----------------:|----------------:|------:|---------------:|-----------:|--------- |-----------:|----------:|
| GetActiveNetworkInterfaceNames | 26,149,800.7 ns | 193,683.6 ns | 181,171.7 ns | 46,778.3 ns | 25,752,123.4 ns | 26,051,656.2 ns | 26,117,151.6 ns | 26,274,648.4 ns | 26,431,626.6 ns | 38.24 |   -23,381.7 ns |      15.00 | No       |          - |   53.5 KB |
