```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7184/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.202
  [Host]     : .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=Collections  

```
| Method         | Mean      | Error    | StdDev   | StdErr   | Min       | Q1        | Median    | Q3        | Max       | Op/s         | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Exceptions |
|--------------- |----------:|---------:|---------:|---------:|----------:|----------:|----------:|----------:|----------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|-----------:|
| **GetDescription** |  **17.31 ns** | **0.114 ns** | **0.107 ns** | **0.028 ns** |  **17.15 ns** |  **17.24 ns** |  **17.32 ns** |  **17.37 ns** |  **17.54 ns** | **57,771,315.5** |       **7.486 ns** |      **15.00** |    **2.455** |  **2.000** |   **0.2030** |    **1** | *****            | **No**       |   **2,314 B** |          **-** |
| **GetItems**       | **338.82 ns** | **3.003 ns** | **2.809 ns** | **0.725 ns** | **333.95 ns** | **337.29 ns** | **338.80 ns** | **340.27 ns** | **343.28 ns** |  **2,951,463.0** |       **7.137 ns** |      **15.00** |    **1.896** |  **2.000** |   **0.0659** |    **2** | *****            | **No**       |   **3,779 B** |          **-** |
