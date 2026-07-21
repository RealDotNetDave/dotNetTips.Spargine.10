```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7548/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.204
  [Host]     : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  

```
| Method                         | Mean            | Error        | StdDev      | StdErr      | Min             | Q1              | Median          | Q3              | Max             | Op/s  | CI99.9% Margin | Iterations | Baseline | Exceptions | Allocated |
|------------------------------- |----------------:|-------------:|------------:|------------:|----------------:|----------------:|----------------:|----------------:|----------------:|------:|---------------:|-----------:|--------- |-----------:|----------:|
| GetActiveNetworkInterfaceNames | 26,427,026.7 ns | 111,154.0 ns | 92,818.6 ns | 25,743.2 ns | 26,242,628.1 ns | 26,384,881.2 ns | 26,426,025.0 ns | 26,454,428.1 ns | 26,631,743.8 ns | 37.84 |   -12,865.1 ns |      13.00 | No       |          - |   53.5 KB |
