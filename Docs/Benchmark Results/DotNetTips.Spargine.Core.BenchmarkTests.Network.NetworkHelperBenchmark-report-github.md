```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7725/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  

```
| Method                         | Mean            | Error       | StdDev      | StdErr      | Min             | Q1              | Median          | Q3              | Max             | Op/s  | CI99.9% Margin | Iterations | Baseline | Exceptions | Allocated |
|------------------------------- |----------------:|------------:|------------:|------------:|----------------:|----------------:|----------------:|----------------:|----------------:|------:|---------------:|-----------:|--------- |-----------:|----------:|
| GetActiveNetworkInterfaceNames | 25,828,598.9 ns | 64,227.9 ns | 56,936.4 ns | 15,216.9 ns | 25,749,201.6 ns | 25,796,467.2 ns | 25,822,956.2 ns | 25,850,968.0 ns | 25,927,832.8 ns | 38.72 |    -7,601.4 ns |      14.00 | No       |          - |   53.5 KB |
