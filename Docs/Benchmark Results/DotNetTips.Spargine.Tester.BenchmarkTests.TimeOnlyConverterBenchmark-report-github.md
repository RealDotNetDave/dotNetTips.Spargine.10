```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7184/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=JSON  

```
| Method | Mean     | Error   | StdDev  | StdErr  | Min      | Q1       | Median   | Q3       | Max      | Op/s        | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Code Size |
|------- |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|----------:|
| **Read**   | **235.5 ns** | **0.96 ns** | **0.80 ns** | **0.22 ns** | **234.0 ns** | **234.9 ns** | **235.5 ns** | **236.0 ns** | **237.1 ns** | **4,246,099.2** |       **6.388 ns** |      **13.00** |    **2.447** |  **2.000** |   **0.0474** |    **2** | *****            | **No**       |          **-** |   **2,664 B** |
| **Write**  | **197.9 ns** | **1.74 ns** | **1.63 ns** | **0.42 ns** | **194.5 ns** | **197.4 ns** | **198.0 ns** | **198.9 ns** | **200.2 ns** | **5,054,232.6** |       **7.290 ns** |      **15.00** |    **2.743** |  **2.000** |  **-0.7992** |    **1** | *****            | **No**       |          **-** |   **4,686 B** |
