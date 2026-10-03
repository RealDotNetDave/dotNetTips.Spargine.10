```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7725/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=IO  

```
| Method     | FileCount | Mean         | Error       | StdDev      | StdErr     | Median       | Min          | Q1           | Q3           | Max          | Op/s    | CI99.9% Margin | Iterations | Baseline | Exceptions | Allocated |
|----------- |---------- |-------------:|------------:|------------:|-----------:|-------------:|-------------:|-------------:|-------------:|-------------:|--------:|---------------:|-----------:|--------- |-----------:|----------:|
| DeleteFile | 10        | 387,751.2 ns | 31,699.7 ns | 84,063.1 ns | 9,283.2 ns | 368,000.0 ns | 273,850.0 ns | 333,575.0 ns | 407,875.0 ns | 741,750.0 ns | 2,579.0 |    -4,600.6 ns |      82.00 | No       |          - |         - |
| DeleteFile | 100       | 316,078.4 ns | 11,102.6 ns | 31,855.4 ns | 3,268.3 ns | 306,850.0 ns | 263,850.0 ns | 293,000.0 ns | 334,450.0 ns | 403,350.0 ns | 3,163.8 |    -1,586.6 ns |      95.00 | No       |          - |         - |
| DeleteFile | 1000      | 358,484.7 ns | 14,911.1 ns | 42,782.7 ns | 4,389.4 ns | 346,050.0 ns | 275,450.0 ns | 329,800.0 ns | 389,100.0 ns | 484,150.0 ns | 2,789.5 |    -2,147.2 ns |      95.00 | No       |          - |         - |
