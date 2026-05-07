```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7184/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=Collections  

```
| Method         | Mean      | Error    | StdDev   | StdErr   | Min       | Q1        | Median    | Q3        | Max       | Op/s         | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Code Size |
|--------------- |----------:|---------:|---------:|---------:|----------:|----------:|----------:|----------:|----------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|----------:|
| **GetDescription** |  **15.07 ns** | **0.098 ns** | **0.087 ns** | **0.023 ns** |  **14.94 ns** |  **15.04 ns** |  **15.07 ns** |  **15.13 ns** |  **15.23 ns** | **66,339,411.2** |       **6.988 ns** |      **14.00** |    **1.918** |  **2.000** |  **-0.0118** |    **1** | *****            | **No**       |          **-** |   **2,314 B** |
| **GetItems**       | **344.32 ns** | **1.355 ns** | **1.268 ns** | **0.327 ns** | **342.28 ns** | **343.39 ns** | **344.37 ns** | **345.14 ns** | **346.80 ns** |  **2,904,273.6** |       **7.336 ns** |      **15.00** |    **2.018** |  **2.000** |   **0.0940** |    **2** | *****            | **No**       |          **-** |   **3,779 B** |
