```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7548/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.302
  [Host]     : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  

```
| Method                         | Mean            | Error       | StdDev      | StdErr      | Min             | Q1              | Median          | Q3              | Max             | Op/s  | CI99.9% Margin | Iterations | Baseline | Exceptions | Allocated |
|------------------------------- |----------------:|------------:|------------:|------------:|----------------:|----------------:|----------------:|----------------:|----------------:|------:|---------------:|-----------:|--------- |-----------:|----------:|
| GetActiveNetworkInterfaceNames | 26,338,611.2 ns | 99,302.8 ns | 82,922.3 ns | 22,998.5 ns | 26,213,698.4 ns | 26,282,692.2 ns | 26,331,954.7 ns | 26,398,532.8 ns | 26,506,492.2 ns | 37.97 |   -11,492.8 ns |      13.00 | No       |          - |   53.5 KB |
