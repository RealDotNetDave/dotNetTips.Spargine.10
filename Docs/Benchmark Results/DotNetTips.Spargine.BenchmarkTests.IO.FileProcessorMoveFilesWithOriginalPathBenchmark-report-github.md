```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7548/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.204
  [Host]     : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=IO  

```
| Method                    | Mean                | Error              | StdDev              | StdErr             | Min             | Q1              | Median              | Q3                  | Max                 | Op/s   | CI99.9% Margin    | Iterations | Baseline | Gen0      | Exceptions | Code Size | Allocated |
|-------------------------- |--------------------:|-------------------:|--------------------:|-------------------:|----------------:|----------------:|--------------------:|--------------------:|--------------------:|-------:|------------------:|-----------:|--------- |----------:|-----------:|----------:|----------:|
| MoveFilesWithOriginalPath | 21,135,107,329.0 ns | 5,612,972,553.2 ns | 16,549,977,416.2 ns | 1,654,997,741.6 ns | 86,056,500.0 ns | 90,403,075.0 ns | 22,326,253,600.0 ns | 34,663,551,000.0 ns | 49,991,301,900.0 ns | 0.0473 | -827,498,820.8 ns |      100.0 | No       | 1000.0000 |   256.0000 |  11,798 B | 128.48 MB |
