```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7417/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.204
  [Host]     : .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=**NEW**,IO  

```
| Method     | Mean         | Error       | StdDev      | StdErr     | Min          | Q1           | Median       | Q3           | Max          | Op/s    | CI99.9% Margin | Iterations | Baseline | Exceptions | Code Size | Allocated |
|----------- |-------------:|------------:|------------:|-----------:|-------------:|-------------:|-------------:|-------------:|-------------:|--------:|---------------:|-----------:|--------- |-----------:|----------:|----------:|
| DeleteFile | 373,881.7 ns | 15,094.6 ns | 40,028.7 ns | 4,420.4 ns | 302,100.0 ns | 342,250.0 ns | 365,450.0 ns | 399,350.0 ns | 517,700.0 ns | 2,674.6 |    -2,169.2 ns |      82.00 | No       |          - |     170 B |     192 B |
