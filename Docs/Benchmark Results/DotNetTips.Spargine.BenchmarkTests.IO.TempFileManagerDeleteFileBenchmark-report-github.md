```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7725/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=IO  

```
| Method     | FileCount | Mean         | Error       | StdDev      | StdErr     | Min          | Q1           | Median       | Q3           | Max          | Op/s    | CI99.9% Margin | Iterations | Baseline | Exceptions | Allocated |
|----------- |---------- |-------------:|------------:|------------:|-----------:|-------------:|-------------:|-------------:|-------------:|-------------:|--------:|---------------:|-----------:|--------- |-----------:|----------:|
| DeleteFile | 10        | 353,365.2 ns | 11,447.4 ns | 32,287.5 ns | 3,366.2 ns | 280,250.0 ns | 331,225.0 ns | 349,150.0 ns | 373,200.0 ns | 443,650.0 ns | 2,829.9 |    -1,637.1 ns |      92.00 | No       |          - |         - |
| DeleteFile | 100       | 334,722.3 ns | 14,133.0 ns | 40,322.2 ns | 4,158.9 ns | 275,500.0 ns | 306,100.0 ns | 326,000.0 ns | 350,850.0 ns | 441,000.0 ns | 2,987.6 |    -2,032.5 ns |      94.00 | No       |          - |         - |
| DeleteFile | 1000      | 331,637.9 ns | 13,407.9 ns | 38,469.7 ns | 3,946.9 ns | 238,900.0 ns | 305,850.0 ns | 322,900.0 ns | 355,450.0 ns | 421,500.0 ns | 3,015.3 |    -1,926.0 ns |      95.00 | No       |          - |         - |
