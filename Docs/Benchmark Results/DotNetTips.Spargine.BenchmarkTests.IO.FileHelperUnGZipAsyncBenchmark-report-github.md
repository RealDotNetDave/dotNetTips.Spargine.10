```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7548/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.302
  [Host]     : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=IO  

```
| Method      | Mean           | Error       | StdDev      | StdErr      | Min            | Q1             | Median         | Q3             | Max            | Op/s  | CI99.9% Margin | Iterations | Baseline | Code Size | Exceptions | Completed Work Items | Lock Contentions | Allocated |
|------------ |---------------:|------------:|------------:|------------:|---------------:|---------------:|---------------:|---------------:|---------------:|------:|---------------:|-----------:|--------- |----------:|-----------:|---------------------:|-----------------:|----------:|
| UnGZipAsync | 1,267,319.4 ns | 35,831.4 ns | 96,872.4 ns | 10,507.3 ns | 1,096,050.0 ns | 1,195,750.0 ns | 1,250,550.0 ns | 1,328,050.0 ns | 1,562,350.0 ns | 789.1 |    -5,211.1 ns |      85.00 | No       |     298 B |          - |               3.0000 |                - |  83.63 KB |
