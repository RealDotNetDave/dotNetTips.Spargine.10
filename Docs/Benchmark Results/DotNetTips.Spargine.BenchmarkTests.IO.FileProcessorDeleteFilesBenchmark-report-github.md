```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7548/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.302
  [Host]     : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=IO  

```
| Method      | Mean           | Error       | StdDev       | StdErr      | Median         | Min            | Q1             | Q3             | Max            | Op/s  | CI99.9% Margin | Iterations | Baseline | Exceptions | Code Size | Allocated |
|------------ |---------------:|------------:|-------------:|------------:|---------------:|---------------:|---------------:|---------------:|---------------:|------:|---------------:|-----------:|--------- |-----------:|----------:|----------:|
| DeleteFiles | 4,206,348.9 ns | 90,454.0 ns | 259,529.5 ns | 26,627.2 ns | 4,109,550.0 ns | 3,895,050.0 ns | 4,006,250.0 ns | 4,406,150.0 ns | 4,998,750.0 ns | 237.7 |   -13,266.1 ns |      95.00 | No       |          - |   9,286 B |   3.23 KB |
