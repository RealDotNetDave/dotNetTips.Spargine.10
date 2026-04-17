```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7058/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.201
  [Host]     : .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=Collections  

```
| Method         | Mean      | Error    | StdDev   | StdErr   | Min       | Q1        | Median    | Q3        | Max       | Op/s         | CI99.9% Margin | Iterations | Rank | Baseline | Code Size | Exceptions |
|--------------- |----------:|---------:|---------:|---------:|----------:|----------:|----------:|----------:|----------:|-------------:|---------------:|-----------:|-----:|--------- |----------:|-----------:|
| **GetDescription** |  **15.25 ns** | **0.098 ns** | **0.092 ns** | **0.024 ns** |  **15.10 ns** |  **15.21 ns** |  **15.24 ns** |  **15.32 ns** |  **15.43 ns** | **65,562,804.8** |       **7.488 ns** |      **15.00** |    **1** | **No**       |   **2,314 B** |          **-** |
| **GetItems**       | **337.68 ns** | **1.666 ns** | **1.558 ns** | **0.402 ns** | **335.09 ns** | **336.53 ns** | **337.79 ns** | **338.42 ns** | **340.87 ns** |  **2,961,352.5** |       **7.299 ns** |      **15.00** |    **2** | **No**       |   **3,779 B** |          **-** |
