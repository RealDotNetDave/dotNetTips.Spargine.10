```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7725/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=Database  

```
| Method                         | Mean       | Error     | StdDev    | StdErr   | Min        | Q1         | Median     | Q3         | Max        | Op/s      | CI99.9% Margin | Iterations | Baseline | Exceptions | Gen0   | Allocated |
|------------------------------- |-----------:|----------:|----------:|---------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------------:|-----------:|--------- |-----------:|-------:|----------:|
| **RegisterEnumAsStringConverters** | **6,934.8 ns** |  **49.54 ns** |  **38.68 ns** | **11.17 ns** | **6,893.3 ns** | **6,912.6 ns** | **6,922.7 ns** | **6,951.9 ns** | **7,015.2 ns** | **144,200.4** |      **0.4169 ns** |      **12.00** | **No**       |          **-** | **0.3510** |  **10.53 KB** |
| **RegisterGuidAsStringConverters** | **6,637.0 ns** | **123.58 ns** | **169.16 ns** | **33.17 ns** | **6,450.7 ns** | **6,516.5 ns** | **6,565.6 ns** | **6,700.5 ns** | **7,025.5 ns** | **150,671.5** |     **-3.5872 ns** |      **26.00** | **No**       |          **-** | **0.3357** |  **10.45 KB** |
