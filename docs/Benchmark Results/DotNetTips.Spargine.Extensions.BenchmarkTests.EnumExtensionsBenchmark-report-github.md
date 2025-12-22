```

BenchmarkDotNet v0.15.6, Windows 10 (10.0.19045.6691/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.101
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=Collections  

```
| Method         | Mean      | Error    | StdDev   | StdErr   | Min       | Q1        | Median    | Q3        | Max       | Op/s         | CI99.9% Margin | Iterations | Rank | Baseline | Completed Work Items | Lock Contentions | Gen0   | Exceptions | Code Size | Gen1   | Gen2   | Allocated |
|--------------- |----------:|---------:|---------:|---------:|----------:|----------:|----------:|----------:|----------:|-------------:|---------------:|-----------:|-----:|--------- |---------------------:|-----------------:|-------:|-----------:|----------:|-------:|-------:|----------:|
| **GetDescription** |  **15.82 ns** | **0.187 ns** | **0.175 ns** | **0.045 ns** |  **15.54 ns** |  **15.72 ns** |  **15.82 ns** |  **15.96 ns** |  **16.08 ns** | **63,196,000.2** |       **7.477 ns** |      **15.00** |    **1** | **No**       |                    **-** |                **-** | **0.0007** |          **-** |   **2,361 B** |      **-** |      **-** |      **24 B** |
| **GetItems**       | **346.54 ns** | **1.976 ns** | **1.650 ns** | **0.458 ns** | **343.57 ns** | **346.05 ns** | **346.74 ns** | **347.40 ns** | **349.85 ns** |  **2,885,682.2** |       **6.271 ns** |      **13.00** |    **2** | **No**       |                    **-** |                **-** | **0.0262** |          **-** |   **3,793 B** | **0.0010** | **0.0010** |     **760 B** |
