```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7725/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=JSON  

```
| Method | Mean     | Error   | StdDev  | StdErr  | Min      | Q1       | Median   | Q3       | Max      | Op/s        | CI99.9% Margin | Iterations | Baseline | Gen0   | Exceptions | Code Size | Allocated |
|------- |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|--------- |-------:|-----------:|----------:|----------:|
| **Read**   | **163.4 ns** | **0.61 ns** | **0.51 ns** | **0.14 ns** | **162.5 ns** | **163.0 ns** | **163.4 ns** | **163.8 ns** | **164.3 ns** | **6,119,384.2** |       **6.430 ns** |      **13.00** | **No**       | **0.0014** |          **-** |   **2,562 B** |      **48 B** |
| **Write**  | **122.2 ns** | **1.09 ns** | **0.97 ns** | **0.26 ns** | **121.0 ns** | **121.5 ns** | **121.7 ns** | **123.2 ns** | **123.9 ns** | **8,180,383.1** |       **6.871 ns** |      **14.00** | **No**       | **0.0060** |          **-** |   **4,692 B** |     **184 B** |
