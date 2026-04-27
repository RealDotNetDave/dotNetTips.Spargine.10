```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7184/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=Collections  

```
| Method         | Mean      | Error    | StdDev   | StdErr   | Min       | Q1        | Median    | Q3        | Max       | Op/s         | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Exceptions |
|--------------- |----------:|---------:|---------:|---------:|----------:|----------:|----------:|----------:|----------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|-----------:|
| **GetDescription** |  **14.77 ns** | **0.150 ns** | **0.140 ns** | **0.036 ns** |  **14.56 ns** |  **14.68 ns** |  **14.76 ns** |  **14.88 ns** |  **14.98 ns** | **67,725,734.4** |       **7.482 ns** |      **15.00** |    **1.711** |  **2.000** |  **-0.0350** |    **1** | *****            | **No**       |   **2,314 B** |          **-** |
| **GetItems**       | **337.47 ns** | **1.523 ns** | **1.424 ns** | **0.368 ns** | **334.21 ns** | **336.88 ns** | **337.63 ns** | **338.41 ns** | **339.89 ns** |  **2,963,209.4** |       **7.316 ns** |      **15.00** |    **2.777** |  **2.000** |  **-0.6036** |    **2** | *****            | **No**       |   **3,779 B** |          **-** |
