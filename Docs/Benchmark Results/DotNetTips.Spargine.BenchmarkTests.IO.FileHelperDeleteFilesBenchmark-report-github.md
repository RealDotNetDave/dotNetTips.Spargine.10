```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7548/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.302
  [Host]     : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=IO  

```
| Method      | Mean            | Error        | StdDev         | StdErr       | Min             | Q1              | Median          | Q3              | Max             | Op/s  | CI99.9% Margin | Iterations | Baseline | Exceptions | Code Size | Allocated |
|------------ |----------------:|-------------:|---------------:|-------------:|----------------:|----------------:|----------------:|----------------:|----------------:|------:|---------------:|-----------:|--------- |-----------:|----------:|----------:|
| DeleteFiles | 40,280,946.6 ns | 767,316.9 ns | 1,124,723.3 ns | 208,855.9 ns | 38,591,350.0 ns | 39,481,150.0 ns | 40,397,750.0 ns | 40,938,650.0 ns | 42,744,750.0 ns | 24.83 |  -104,413.4 ns |      29.00 | No       |          - |     621 B |   4.09 KB |
