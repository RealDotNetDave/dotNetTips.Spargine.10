```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7725/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=IO  

```
| Method                                        | Mean     | Error   | StdDev  | StdErr  | Min      | Q1       | Median   | Q3       | Max      | Op/s        | CI99.9% Margin | Iterations | Baseline | Exceptions | Gen0   | Code Size | Gen1   | Gen2   | Allocated |
|---------------------------------------------- |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|--------- |-----------:|-------:|----------:|-------:|-------:|----------:|
| **CreateOptimizedHttpClient()**                   | **217.7 ns** | **1.82 ns** | **1.61 ns** | **0.43 ns** | **214.4 ns** | **217.3 ns** | **217.8 ns** | **218.5 ns** | **220.2 ns** | **4,593,472.5** |       **6.784 ns** |      **14.00** | **No**       |          **-** | **0.0167** |   **4,672 B** | **0.0005** | **0.0005** |     **800 B** |
| **CreateOptimizedHttpClient(HttpClientOptions?)** | **216.7 ns** | **2.24 ns** | **2.09 ns** | **0.54 ns** | **213.8 ns** | **214.9 ns** | **216.7 ns** | **217.7 ns** | **221.7 ns** | **4,615,025.9** |       **7.230 ns** |      **15.00** | **No**       |          **-** | **0.0157** |   **4,673 B** | **0.0005** | **0.0005** |     **800 B** |
