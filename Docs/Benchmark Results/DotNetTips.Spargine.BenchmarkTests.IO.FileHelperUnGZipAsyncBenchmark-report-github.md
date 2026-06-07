```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7291/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.204
  [Host]     : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=**NEW**,IO  

```
| Method      | Mean           | Error       | StdDev      | StdErr      | Min            | Q1             | Median         | Q3             | Max            | Op/s  | CI99.9% Margin | Iterations | Baseline | Exceptions | Code Size | Completed Work Items | Lock Contentions | Allocated |
|------------ |---------------:|------------:|------------:|------------:|---------------:|---------------:|---------------:|---------------:|---------------:|------:|---------------:|-----------:|--------- |-----------:|----------:|---------------------:|-----------------:|----------:|
| UnGZipAsync | 1,267,535.2 ns | 35,337.0 ns | 97,328.4 ns | 10,375.2 ns | 1,101,400.0 ns | 1,200,400.0 ns | 1,244,400.0 ns | 1,320,700.0 ns | 1,545,200.0 ns | 788.9 |    -5,143.6 ns |      88.00 | No       |          - |     296 B |               3.0000 |                - |  83.63 KB |
