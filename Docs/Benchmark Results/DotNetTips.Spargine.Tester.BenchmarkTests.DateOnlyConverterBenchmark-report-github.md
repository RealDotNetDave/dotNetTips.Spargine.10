```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7548/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.204
  [Host]     : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=JSON  

```
| Method | Mean     | Error   | StdDev  | StdErr  | Min      | Q1       | Median   | Q3       | Max      | Op/s        | CI99.9% Margin | Iterations | Baseline | Code Size | Exceptions | Gen0   | Allocated |
|------- |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|--------- |----------:|-----------:|-------:|----------:|
| **Read**   | **165.3 ns** | **0.51 ns** | **0.43 ns** | **0.12 ns** | **164.3 ns** | **165.2 ns** | **165.3 ns** | **165.6 ns** | **166.0 ns** | **6,047,981.5** |       **6.441 ns** |      **13.00** | **No**       |   **2,390 B** |          **-** | **0.0010** |      **48 B** |
| **Write**  | **121.9 ns** | **2.14 ns** | **1.90 ns** | **0.51 ns** | **119.1 ns** | **120.7 ns** | **121.7 ns** | **122.9 ns** | **125.2 ns** | **8,204,928.1** |       **6.747 ns** |      **14.00** | **No**       |   **4,704 B** |          **-** | **0.0060** |     **184 B** |
