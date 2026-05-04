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
| **GetDescription** |  **15.00 ns** | **0.172 ns** | **0.161 ns** | **0.042 ns** |  **14.71 ns** |  **14.87 ns** |  **15.03 ns** |  **15.14 ns** |  **15.22 ns** | **66,661,431.6** |       **7.479 ns** |      **15.00** |    **1.522** |  **2.000** |  **-0.1525** |    **1** | *****            | **No**       |   **2,314 B** |          **-** |
| **GetItems**       | **340.88 ns** | **1.708 ns** | **1.515 ns** | **0.405 ns** | **338.29 ns** | **340.26 ns** | **340.86 ns** | **341.58 ns** | **344.19 ns** |  **2,933,561.6** |       **6.798 ns** |      **14.00** |    **2.766** |  **2.000** |   **0.2398** |    **2** | *****            | **No**       |   **3,779 B** |          **-** |
