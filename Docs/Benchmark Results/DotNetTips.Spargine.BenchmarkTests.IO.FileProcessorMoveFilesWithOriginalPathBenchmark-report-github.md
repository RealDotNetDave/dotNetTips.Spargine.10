```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7725/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=IO  

```
| Method                    | Mean                | Error              | StdDev              | StdErr             | Min             | Q1              | Median              | Q3                  | Max                 | Op/s   | CI99.9% Margin    | Iterations | Baseline | Code Size | Gen0      | Exceptions | Allocated |
|-------------------------- |--------------------:|-------------------:|--------------------:|-------------------:|----------------:|----------------:|--------------------:|--------------------:|--------------------:|-------:|------------------:|-----------:|--------- |----------:|----------:|-----------:|----------:|
| MoveFilesWithOriginalPath | 20,685,627,161.0 ns | 5,551,841,966.8 ns | 16,369,732,489.7 ns | 1,636,973,249.0 ns | 83,663,400.0 ns | 89,029,975.0 ns | 21,428,005,800.0 ns | 34,400,701,275.0 ns | 48,885,500,200.0 ns | 0.0483 | -818,486,574.5 ns |      100.0 | No       |  11,755 B | 1000.0000 |   256.0000 | 128.48 MB |
