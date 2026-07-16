```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7548/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.204
  [Host]     : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=IO  

```
| Method      | Mean           | Error       | StdDev      | StdErr      | Min            | Q1             | Median         | Q3             | Max            | Op/s  | CI99.9% Margin | Iterations | Baseline | Code Size | Exceptions | Completed Work Items | Lock Contentions | Allocated |
|------------ |---------------:|------------:|------------:|------------:|---------------:|---------------:|---------------:|---------------:|---------------:|------:|---------------:|-----------:|--------- |----------:|-----------:|---------------------:|-----------------:|----------:|
| UnGZipAsync | 1,268,789.9 ns | 34,652.2 ns | 96,021.1 ns | 10,178.2 ns | 1,139,800.0 ns | 1,203,200.0 ns | 1,244,000.0 ns | 1,316,600.0 ns | 1,560,200.0 ns | 788.2 |    -5,044.6 ns |      89.00 | No       |     298 B |          - |               3.0000 |                - |  83.63 KB |
