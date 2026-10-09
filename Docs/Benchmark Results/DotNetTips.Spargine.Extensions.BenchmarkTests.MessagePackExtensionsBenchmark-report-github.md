```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7725/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=Serialization  

```
| Method             | Mean     | Error    | StdDev   | StdErr   | Min      | Q1       | Median   | Q3       | Max      | Op/s         | CI99.9% Margin | Iterations | Baseline | Exceptions | Gen0   | Code Size | Allocated |
|------------------- |---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------:|-------------:|---------------:|-----------:|--------- |-----------:|-------:|----------:|----------:|
| **FromMessagePack**    | **95.98 ns** | **1.059 ns** | **0.991 ns** | **0.256 ns** | **94.57 ns** | **95.32 ns** | **95.60 ns** | **96.84 ns** | **97.65 ns** | **10,419,253.2** |       **7.372 ns** |      **15.00** | **No**       |          **-** | **0.0006** |   **5,522 B** |      **72 B** |
| **ToMessagePackBytes** | **60.66 ns** | **0.540 ns** | **0.422 ns** | **0.122 ns** | **59.69 ns** | **60.49 ns** | **60.79 ns** | **60.91 ns** | **61.14 ns** | **16,485,005.8** |       **5.939 ns** |      **12.00** | **No**       |          **-** | **0.0013** |   **5,013 B** |      **40 B** |
