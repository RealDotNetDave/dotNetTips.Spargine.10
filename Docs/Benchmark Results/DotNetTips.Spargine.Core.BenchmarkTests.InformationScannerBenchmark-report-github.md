```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7725/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=Reflection  

```
| Method                 | Mean           | Error       | StdDev      | StdErr     | Min            | Q1             | Median         | Q3             | Max            | Op/s  | CI99.9% Margin | Iterations | Baseline | Exceptions | Gen0    | Allocated |
|----------------------- |---------------:|------------:|------------:|-----------:|---------------:|---------------:|---------------:|---------------:|---------------:|------:|---------------:|-----------:|--------- |-----------:|--------:|----------:|
| GetInformationMetadata | 3,909,023.7 ns | 12,633.7 ns | 11,817.5 ns | 3,051.3 ns | 3,888,757.0 ns | 3,900,959.0 ns | 3,907,952.3 ns | 3,915,888.3 ns | 3,931,823.4 ns | 255.8 |    -1,518.1 ns |      15.00 | No       |          - | 46.8750 |   1.35 MB |
