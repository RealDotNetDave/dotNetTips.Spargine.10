```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7548/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.302
  [Host]     : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=IO  

```
| Method                                        | Mean     | Error   | StdDev  | StdErr  | Min      | Q1       | Median   | Q3       | Max      | Op/s        | CI99.9% Margin | Iterations | Baseline | Exceptions | Gen0   | Code Size | Gen1   | Gen2   | Allocated |
|---------------------------------------------- |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|--------- |-----------:|-------:|----------:|-------:|-------:|----------:|
| **CreateOptimizedHttpClient()**                   | **218.7 ns** | **4.34 ns** | **6.37 ns** | **1.18 ns** | **204.1 ns** | **217.0 ns** | **219.6 ns** | **222.8 ns** | **230.8 ns** | **4,572,555.0** |       **13.91 ns** |      **29.00** | **No**       |          **-** | **0.0162** |   **4,671 B** | **0.0005** | **0.0005** |     **800 B** |
| **CreateOptimizedHttpClient(HttpClientOptions?)** | **213.2 ns** | **4.29 ns** | **6.01 ns** | **1.16 ns** | **198.6 ns** | **212.0 ns** | **215.4 ns** | **216.7 ns** | **220.4 ns** | **4,691,321.6** |       **12.92 ns** |      **27.00** | **No**       |          **-** | **0.0162** |   **4,702 B** | **0.0005** | **0.0005** |     **800 B** |
