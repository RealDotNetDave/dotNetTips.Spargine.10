```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7417/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.204
  [Host]     : .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=**NEW**,IO  

```
| Method                    | Mean                | Error              | StdDev              | StdErr             | Min             | Q1              | Median              | Q3                  | Max                 | Op/s   | CI99.9% Margin    | Iterations | Baseline | Gen0      | Exceptions | Code Size | Allocated |
|-------------------------- |--------------------:|-------------------:|--------------------:|-------------------:|----------------:|----------------:|--------------------:|--------------------:|--------------------:|-------:|------------------:|-----------:|--------- |----------:|-----------:|----------:|----------:|
| MoveFilesWithOriginalPath | 20,438,853,854.0 ns | 5,449,065,034.3 ns | 16,066,692,363.4 ns | 1,606,669,236.3 ns | 87,099,000.0 ns | 92,871,025.0 ns | 21,437,024,200.0 ns | 33,383,862,825.0 ns | 48,227,096,300.0 ns | 0.0489 | -803,334,568.2 ns |      100.0 | No       | 1000.0000 |   256.0000 |  12,023 B | 128.48 MB |
