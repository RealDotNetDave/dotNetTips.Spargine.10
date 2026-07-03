```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7291/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.204
  [Host]     : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=**NEW**,IO  

```
| Method                    | Mean                | Error              | StdDev              | StdErr             | Min             | Q1              | Median              | Q3                  | Max                 | Op/s   | CI99.9% Margin    | Iterations | Baseline | Gen0      | Exceptions | Code Size | Allocated |
|-------------------------- |--------------------:|-------------------:|--------------------:|-------------------:|----------------:|----------------:|--------------------:|--------------------:|--------------------:|-------:|------------------:|-----------:|--------- |----------:|-----------:|----------:|----------:|
| MoveFilesWithOriginalPath | 21,003,129,701.0 ns | 5,515,509,449.0 ns | 16,262,605,233.5 ns | 1,626,260,523.3 ns | 90,713,150.0 ns | 97,189,025.0 ns | 22,011,438,900.0 ns | 34,188,222,650.0 ns | 48,612,279,050.0 ns | 0.0476 | -813,130,211.7 ns |      100.0 | No       | 1000.0000 |   256.0000 |  11,985 B | 128.48 MB |
