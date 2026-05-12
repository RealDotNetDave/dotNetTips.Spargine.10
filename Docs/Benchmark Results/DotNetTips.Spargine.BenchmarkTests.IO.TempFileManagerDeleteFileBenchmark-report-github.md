```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7184/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=**NEW**,IO  

```
| Method     | Mean         | Error       | StdDev       | StdErr      | Median       | Min          | Q1           | Q3           | Max            | Op/s    | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Code Size | Allocated |
|----------- |-------------:|------------:|-------------:|------------:|-------------:|-------------:|-------------:|-------------:|---------------:|--------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|----------:|----------:|
| DeleteFile | 525,200.5 ns | 79,322.7 ns | 227,591.8 ns | 23,350.4 ns | 415,550.0 ns | 314,950.0 ns | 371,650.0 ns | 627,500.0 ns | 1,104,850.0 ns | 1,904.0 |   -11,627.7 ns |      95.00 |    3.324 |  2.429 |    1.300 |    1 | *            | No       |          - |     338 B |   2.62 KB |
