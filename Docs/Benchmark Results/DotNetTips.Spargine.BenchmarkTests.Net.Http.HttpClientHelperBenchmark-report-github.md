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
| **CreateOptimizedHttpClient()**                   | **217.3 ns** | **1.78 ns** | **1.58 ns** | **0.42 ns** | **214.1 ns** | **216.5 ns** | **217.1 ns** | **218.3 ns** | **219.9 ns** | **4,602,963.1** |       **6.789 ns** |      **14.00** | **No**       |          **-** | **0.0165** |   **4,672 B** | **0.0005** | **0.0005** |     **800 B** |
| **CreateOptimizedHttpClient(HttpClientOptions?)** | **213.3 ns** | **3.35 ns** | **3.14 ns** | **0.81 ns** | **208.9 ns** | **211.0 ns** | **212.1 ns** | **214.7 ns** | **219.5 ns** | **4,689,309.5** |       **7.095 ns** |      **15.00** | **No**       |          **-** | **0.0160** |   **4,697 B** | **0.0005** | **0.0005** |     **800 B** |
