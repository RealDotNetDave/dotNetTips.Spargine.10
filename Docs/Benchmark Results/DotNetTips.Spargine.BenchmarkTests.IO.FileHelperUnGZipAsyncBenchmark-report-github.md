```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7417/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.204
  [Host]     : .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=**NEW**,IO  

```
| Method      | Mean           | Error       | StdDev      | StdErr     | Min            | Q1             | Median         | Q3             | Max            | Op/s  | CI99.9% Margin | Iterations | Baseline | Code Size | Completed Work Items | Lock Contentions | Exceptions | Allocated |
|------------ |---------------:|------------:|------------:|-----------:|---------------:|---------------:|---------------:|---------------:|---------------:|------:|---------------:|-----------:|--------- |----------:|---------------------:|-----------------:|-----------:|----------:|
| UnGZipAsync | 1,294,911.8 ns | 27,309.3 ns | 75,674.0 ns | 8,021.4 ns | 1,132,350.0 ns | 1,249,250.0 ns | 1,288,050.0 ns | 1,341,650.0 ns | 1,504,950.0 ns | 772.3 |    -3,966.2 ns |      89.00 | No       |     298 B |               3.0000 |                - |          - |  83.63 KB |
