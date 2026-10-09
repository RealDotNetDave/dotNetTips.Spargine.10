```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7725/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=IO  

```
| Method    | Mean             | Error          | StdDev         | StdErr       | Min              | Q1               | Median           | Q3               | Max              | Op/s  | CI99.9% Margin | Iterations | Baseline | Code Size | Exceptions | Allocated |
|---------- |-----------------:|---------------:|---------------:|-------------:|-----------------:|-----------------:|-----------------:|-----------------:|-----------------:|------:|---------------:|-----------:|--------- |----------:|-----------:|----------:|
| MoveFiles | 174,480,328.6 ns | 1,973,877.6 ns | 1,749,791.1 ns | 467,651.3 ns | 171,918,800.0 ns | 173,363,025.0 ns | 174,145,300.0 ns | 175,342,800.0 ns | 178,146,300.0 ns | 5.731 |  -233,818.7 ns |      14.00 | No       |     756 B |          - | 224.09 KB |
