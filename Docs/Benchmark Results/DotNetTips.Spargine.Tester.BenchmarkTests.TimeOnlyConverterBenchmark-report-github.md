```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7725/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=JSON  

```
| Method | Mean     | Error   | StdDev  | StdErr  | Min      | Q1       | Median   | Q3       | Max      | Op/s        | CI99.9% Margin | Iterations | Baseline | Code Size | Gen0   | Exceptions | Allocated |
|------- |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|--------- |----------:|-------:|-----------:|----------:|
| **Read**   | **237.4 ns** | **0.85 ns** | **0.80 ns** | **0.21 ns** | **236.6 ns** | **236.8 ns** | **236.9 ns** | **238.1 ns** | **238.9 ns** | **4,212,050.2** |       **7.397 ns** |      **15.00** | **No**       |   **2,402 B** | **0.0014** |          **-** |      **48 B** |
| **Write**  | **196.0 ns** | **1.14 ns** | **1.01 ns** | **0.27 ns** | **194.6 ns** | **195.5 ns** | **195.7 ns** | **196.4 ns** | **198.3 ns** | **5,102,503.4** |       **6.865 ns** |      **14.00** | **No**       |   **4,530 B** | **0.0060** |          **-** |     **184 B** |
