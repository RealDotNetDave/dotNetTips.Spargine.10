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
| **Read**   | **237.4 ns** | **1.11 ns** | **1.04 ns** | **0.27 ns** | **235.6 ns** | **236.9 ns** | **237.3 ns** | **238.0 ns** | **238.9 ns** | **4,212,644.3** |       **7.366 ns** |      **15.00** |    **1.855** |  **2.000** |  **-0.1716** |    **2** | *****            | **No**       |          **-** |   **2,656 B** |
| **Write**  | **196.7 ns** | **1.66 ns** | **1.55 ns** | **0.40 ns** | **194.5 ns** | **195.6 ns** | **196.5 ns** | **197.6 ns** | **199.9 ns** | **5,083,161.5** |       **7.300 ns** |      **15.00** |    **2.130** |  **2.000** |   **0.6086** |    **1** | *****            | **No**       |          **-** |   **4,686 B** |
