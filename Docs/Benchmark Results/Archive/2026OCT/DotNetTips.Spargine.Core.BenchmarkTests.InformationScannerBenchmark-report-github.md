```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7725/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=Reflection  

```
| Method                 | Mean           | Error       | StdDev      | StdErr      | Min            | Q1             | Median         | Q3             | Max            | Op/s  | CI99.9% Margin | Iterations | Baseline | Exceptions | Gen0    | Allocated |
|----------------------- |---------------:|------------:|------------:|------------:|---------------:|---------------:|---------------:|---------------:|---------------:|------:|---------------:|-----------:|--------- |-----------:|--------:|----------:|
| GetInformationMetadata | 3,970,863.8 ns | 77,981.8 ns | 89,804.0 ns | 20,080.8 ns | 3,819,091.4 ns | 3,904,480.3 ns | 3,962,030.1 ns | 4,008,548.8 ns | 4,161,593.8 ns | 251.8 |   -10,030.4 ns |      20.00 | No       |          - | 46.8750 |   1.38 MB |
