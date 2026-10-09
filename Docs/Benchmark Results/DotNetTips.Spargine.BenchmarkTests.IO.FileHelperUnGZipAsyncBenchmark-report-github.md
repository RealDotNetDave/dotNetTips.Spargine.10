```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7725/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=IO  

```
| Method      | Mean           | Error       | StdDev      | StdErr     | Min            | Q1             | Median         | Q3             | Max            | Op/s  | CI99.9% Margin | Iterations | Baseline | Completed Work Items | Lock Contentions | Code Size | Exceptions | Allocated |
|------------ |---------------:|------------:|------------:|-----------:|---------------:|---------------:|---------------:|---------------:|---------------:|------:|---------------:|-----------:|--------- |---------------------:|-----------------:|----------:|-----------:|----------:|
| UnGZipAsync | 1,263,713.8 ns | 25,006.6 ns | 65,437.8 ns | 7,316.2 ns | 1,150,350.0 ns | 1,216,750.0 ns | 1,253,050.0 ns | 1,291,800.0 ns | 1,504,750.0 ns | 791.3 |    -3,618.1 ns |      80.00 | No       |               3.0000 |                - |     224 B |          - |  83.63 KB |
