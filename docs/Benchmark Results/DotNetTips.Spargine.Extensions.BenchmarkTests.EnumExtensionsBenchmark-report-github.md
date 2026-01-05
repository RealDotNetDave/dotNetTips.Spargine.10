```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.6691/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.101
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=Collections  

```
| Method         | Mean      | Error    | StdDev   | StdErr   | Min       | Q1        | Median    | Q3        | Max       | Op/s         | CI99.9% Margin | Iterations | Rank | Baseline | Completed Work Items | Lock Contentions | Gen0   | Code Size | Exceptions | Gen1   | Gen2   | Allocated |
|--------------- |----------:|---------:|---------:|---------:|----------:|----------:|----------:|----------:|----------:|-------------:|---------------:|-----------:|-----:|--------- |---------------------:|-----------------:|-------:|----------:|-----------:|-------:|-------:|----------:|
| **GetDescription** |  **14.71 ns** | **0.207 ns** | **0.194 ns** | **0.050 ns** |  **14.39 ns** |  **14.58 ns** |  **14.77 ns** |  **14.88 ns** |  **14.95 ns** | **67,979,058.5** |       **7.475 ns** |      **15.00** |    **1** | **No**       |                    **-** |                **-** | **0.0008** |   **2,361 B** |          **-** |      **-** |      **-** |      **24 B** |
| **GetItems**       | **344.15 ns** | **3.486 ns** | **3.261 ns** | **0.842 ns** | **340.51 ns** | **341.69 ns** | **343.55 ns** | **346.14 ns** | **351.32 ns** |  **2,905,736.7** |       **7.079 ns** |      **15.00** |    **2** | **No**       |                    **-** |                **-** | **0.0262** |   **3,793 B** |          **-** | **0.0010** | **0.0010** |     **760 B** |
