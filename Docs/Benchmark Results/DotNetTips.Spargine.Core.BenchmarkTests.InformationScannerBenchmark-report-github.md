```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7548/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.302
  [Host]     : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=Reflection  

```
| Method                 | Mean           | Error       | StdDev      | StdErr     | Min            | Q1             | Median         | Q3             | Max            | Op/s  | CI99.9% Margin | Iterations | Baseline | Exceptions | Gen0    | Allocated |
|----------------------- |---------------:|------------:|------------:|-----------:|---------------:|---------------:|---------------:|---------------:|---------------:|------:|---------------:|-----------:|--------- |-----------:|--------:|----------:|
| GetInformationMetadata | 3,703,699.2 ns | 27,851.9 ns | 26,052.7 ns | 6,726.8 ns | 3,672,087.5 ns | 3,682,149.6 ns | 3,702,946.9 ns | 3,719,616.0 ns | 3,762,535.2 ns | 270.0 |    -3,355.9 ns |      15.00 | No       |          - | 46.8750 |   1.37 MB |
