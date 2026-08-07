```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7548/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.302
  [Host]     : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  

```
| Method                         | Mean            | Error        | StdDev       | StdErr      | Min             | Q1              | Median          | Q3              | Max             | Op/s  | CI99.9% Margin | Iterations | Baseline | Exceptions | Allocated |
|------------------------------- |----------------:|-------------:|-------------:|------------:|----------------:|----------------:|----------------:|----------------:|----------------:|------:|---------------:|-----------:|--------- |-----------:|----------:|
| GetActiveNetworkInterfaceNames | 26,268,151.1 ns | 124,554.8 ns | 116,508.7 ns | 30,082.4 ns | 26,136,698.4 ns | 26,194,893.8 ns | 26,226,973.4 ns | 26,323,776.6 ns | 26,515,076.6 ns | 38.07 |   -15,033.7 ns |      15.00 | No       |          - |   53.5 KB |
