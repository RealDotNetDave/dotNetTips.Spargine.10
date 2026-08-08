```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7548/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.302
  [Host]     : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=IO  

```
| Method                    | Mean                | Error              | StdDev              | StdErr             | Min             | Q1              | Median              | Q3                  | Max                 | Op/s   | CI99.9% Margin    | Iterations | Baseline | Gen0      | Exceptions | Code Size | Allocated |
|-------------------------- |--------------------:|-------------------:|--------------------:|-------------------:|----------------:|----------------:|--------------------:|--------------------:|--------------------:|-------:|------------------:|-----------:|--------- |----------:|-----------:|----------:|----------:|
| MoveFilesWithOriginalPath | 21,246,031,030.0 ns | 5,624,628,215.4 ns | 16,584,344,401.6 ns | 1,658,434,440.2 ns | 86,712,900.0 ns | 93,949,125.0 ns | 22,417,003,350.0 ns | 34,934,219,900.0 ns | 49,217,646,400.0 ns | 0.0471 | -829,217,170.1 ns |      100.0 | No       | 1000.0000 |   256.0000 |  11,902 B | 128.48 MB |
