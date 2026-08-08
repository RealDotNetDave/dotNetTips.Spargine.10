```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7548/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.302
  [Host]     : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=IO  

```
| Method         | Mean            | Error        | StdDev       | StdErr       | Min             | Q1              | Median          | Q3              | Max             | Op/s  | CI99.9% Margin | Iterations | Baseline | Exceptions | Code Size | Allocated |
|--------------- |----------------:|-------------:|-------------:|-------------:|----------------:|----------------:|----------------:|----------------:|----------------:|------:|---------------:|-----------:|--------- |-----------:|----------:|----------:|
| DeleteAllFiles | 35,381,837.5 ns | 701,870.4 ns | 689,330.6 ns | 172,332.6 ns | 34,596,200.0 ns | 34,812,650.0 ns | 35,204,100.0 ns | 35,716,150.0 ns | 37,019,300.0 ns | 28.26 |   -86,158.3 ns |      16.00 | No       |          - |     248 B |   6.13 KB |
