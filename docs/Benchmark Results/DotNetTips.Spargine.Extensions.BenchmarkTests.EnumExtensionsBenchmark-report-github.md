```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7058/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.104
  [Host]     : .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=Collections  

```
| Method         | Mean      | Error    | StdDev   | StdErr   | Min       | Q1        | Median    | Q3        | Max       | Op/s         | CI99.9% Margin | Iterations | Rank | Baseline | Exceptions | Completed Work Items | Lock Contentions | Code Size | Gen0   | Gen1   | Gen2   | Allocated |
|--------------- |----------:|---------:|---------:|---------:|----------:|----------:|----------:|----------:|----------:|-------------:|---------------:|-----------:|-----:|--------- |-----------:|---------------------:|-----------------:|----------:|-------:|-------:|-------:|----------:|
| **GetDescription** |  **15.00 ns** | **0.184 ns** | **0.172 ns** | **0.044 ns** |  **14.70 ns** |  **14.90 ns** |  **14.99 ns** |  **15.09 ns** |  **15.29 ns** | **66,671,604.1** |       **7.478 ns** |      **15.00** |    **1** | **No**       |          **-** |                    **-** |                **-** |   **2,356 B** | **0.0008** |      **-** |      **-** |      **24 B** |
| **GetItems**       | **340.66 ns** | **2.192 ns** | **2.050 ns** | **0.529 ns** | **336.60 ns** | **339.25 ns** | **341.10 ns** | **342.15 ns** | **343.29 ns** |  **2,935,484.0** |       **7.235 ns** |      **15.00** |    **2** | **No**       |          **-** |                    **-** |                **-** |   **3,808 B** | **0.0262** | **0.0010** | **0.0010** |     **760 B** |
