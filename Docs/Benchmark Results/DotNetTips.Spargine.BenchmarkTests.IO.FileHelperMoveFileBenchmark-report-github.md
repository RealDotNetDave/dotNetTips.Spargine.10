```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7725/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=IO  

```
| Method   | Mean         | Error       | StdDev      | StdErr     | Min          | Q1           | Median       | Q3           | Max          | Op/s    | CI99.9% Margin | Iterations | Baseline | Code Size | Exceptions | Allocated |
|--------- |-------------:|------------:|------------:|-----------:|-------------:|-------------:|-------------:|-------------:|-------------:|--------:|---------------:|-----------:|--------- |----------:|-----------:|----------:|
| MoveFile | 855,226.7 ns | 16,554.9 ns | 24,778.6 ns | 4,523.9 ns | 812,400.0 ns | 831,500.0 ns | 856,550.0 ns | 874,175.0 ns | 906,200.0 ns | 1,169.3 |    -2,247.0 ns |      30.00 | No       |     580 B |          - |     696 B |
