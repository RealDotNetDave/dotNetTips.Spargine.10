```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7417/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.204
  [Host]     : .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=**NEW**,IO  

```
| Method                                        | Mean     | Error   | StdDev  | StdErr  | Min      | Q1       | Median   | Q3       | Max      | Op/s        | CI99.9% Margin | Iterations | Baseline | Exceptions | Gen0   | Code Size | Gen1   | Gen2   | Allocated |
|---------------------------------------------- |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|--------- |-----------:|-------:|----------:|-------:|-------:|----------:|
| **CreateOptimizedHttpClient()**                   | **217.8 ns** | **4.00 ns** | **7.52 ns** | **1.13 ns** | **205.8 ns** | **210.3 ns** | **218.3 ns** | **223.6 ns** | **231.8 ns** | **4,590,984.6** |       **21.43 ns** |      **44.00** | **No**       |          **-** | **0.0229** |   **4,686 B** | **0.0002** | **0.0002** |         **-** |
| **CreateOptimizedHttpClient(HttpClientOptions?)** | **210.4 ns** | **3.78 ns** | **4.50 ns** | **0.98 ns** | **196.8 ns** | **209.1 ns** | **211.9 ns** | **213.0 ns** | **215.8 ns** | **4,751,764.0** |       **10.01 ns** |      **21.00** | **No**       |          **-** | **0.0162** |   **4,676 B** | **0.0005** | **0.0005** |     **800 B** |
