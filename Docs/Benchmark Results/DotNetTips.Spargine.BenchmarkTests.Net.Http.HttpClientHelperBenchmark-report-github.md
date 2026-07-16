```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7548/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.204
  [Host]     : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=IO  

```
| Method                                        | Mean     | Error   | StdDev  | StdErr  | Min      | Q1       | Median   | Q3       | Max      | Op/s        | CI99.9% Margin | Iterations | Baseline | Exceptions | Gen0   | Code Size | Gen1   | Gen2   | Allocated |
|---------------------------------------------- |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|--------- |-----------:|-------:|----------:|-------:|-------:|----------:|
| **CreateOptimizedHttpClient()**                   | **216.0 ns** | **4.26 ns** | **4.91 ns** | **1.10 ns** | **203.8 ns** | **214.3 ns** | **217.7 ns** | **219.3 ns** | **220.5 ns** | **4,630,485.8** |       **9.451 ns** |      **20.00** | **No**       |          **-** | **0.0167** |   **4,692 B** | **0.0005** | **0.0005** |     **800 B** |
| **CreateOptimizedHttpClient(HttpClientOptions?)** | **212.1 ns** | **4.21 ns** | **3.94 ns** | **1.02 ns** | **200.4 ns** | **211.9 ns** | **213.1 ns** | **214.5 ns** | **216.3 ns** | **4,714,675.7** |       **6.992 ns** |      **15.00** | **No**       |          **-** | **0.0153** |   **4,679 B** | **0.0005** | **0.0005** |     **800 B** |
