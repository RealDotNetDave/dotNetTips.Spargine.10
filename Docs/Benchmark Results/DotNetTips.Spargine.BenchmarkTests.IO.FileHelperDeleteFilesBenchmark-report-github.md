```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7725/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=IO  

```
| Method      | Mean            | Error        | StdDev       | StdErr       | Min             | Q1              | Median          | Q3              | Max             | Op/s  | CI99.9% Margin | Iterations | Baseline | Code Size | Exceptions | Allocated |
|------------ |----------------:|-------------:|-------------:|-------------:|----------------:|----------------:|----------------:|----------------:|----------------:|------:|---------------:|-----------:|--------- |----------:|-----------:|----------:|
| DeleteFiles | 39,159,665.8 ns | 772,628.7 ns | 858,774.7 ns | 197,016.4 ns | 37,860,250.0 ns | 38,570,000.0 ns | 39,205,350.0 ns | 39,686,900.0 ns | 41,133,150.0 ns | 25.54 |   -98,498.7 ns |      19.00 | No       |     621 B |          - |   4.09 KB |
