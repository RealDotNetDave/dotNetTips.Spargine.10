```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7725/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=IO  

```
| Method      | Mean           | Error       | StdDev      | StdErr      | Min            | Q1             | Median         | Q3             | Max            | Op/s  | CI99.9% Margin | Iterations | Baseline | Completed Work Items | Lock Contentions | Code Size | Exceptions | Allocated |
|------------ |---------------:|------------:|------------:|------------:|---------------:|---------------:|---------------:|---------------:|---------------:|------:|---------------:|-----------:|--------- |---------------------:|-----------------:|----------:|-----------:|----------:|
| UnGZipAsync | 1,294,172.2 ns | 34,773.9 ns | 96,935.8 ns | 10,217.9 ns | 1,121,500.0 ns | 1,226,650.0 ns | 1,281,850.0 ns | 1,334,525.0 ns | 1,566,500.0 ns | 772.7 |    -5,064.0 ns |      90.00 | No       |               3.0000 |                - |     224 B |          - |  83.63 KB |
