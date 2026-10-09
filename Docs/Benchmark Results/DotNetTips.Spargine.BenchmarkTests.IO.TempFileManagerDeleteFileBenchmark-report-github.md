```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7725/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=IO  

```
| Method     | FileCount | Mean         | Error       | StdDev      | StdErr     | Min          | Q1           | Median       | Q3           | Max          | Op/s    | CI99.9% Margin | Iterations | Baseline | Exceptions | Code Size | Allocated |
|----------- |---------- |-------------:|------------:|------------:|-----------:|-------------:|-------------:|-------------:|-------------:|-------------:|--------:|---------------:|-----------:|--------- |-----------:|----------:|----------:|
| DeleteFile | 10        | 343,893.8 ns | 13,677.6 ns | 37,900.7 ns | 4,017.5 ns | 283,850.0 ns | 313,550.0 ns | 338,850.0 ns | 370,650.0 ns | 437,450.0 ns | 2,907.9 |    -1,964.2 ns |      89.00 | No       |          - |     170 B |         - |
| DeleteFile | 100       | 316,816.3 ns |  7,570.3 ns | 20,595.6 ns | 2,220.9 ns | 250,000.0 ns | 302,900.0 ns | 318,450.0 ns | 329,875.0 ns | 369,900.0 ns | 3,156.4 |    -1,067.4 ns |      86.00 | No       |          - |        NA |         - |
| DeleteFile | 1000      | 323,139.6 ns | 11,837.6 ns | 34,154.2 ns | 3,485.8 ns | 225,200.0 ns | 300,075.0 ns | 317,050.0 ns | 334,425.0 ns | 404,800.0 ns | 3,094.6 |    -1,694.9 ns |      96.00 | No       |          - |        NA |         - |
