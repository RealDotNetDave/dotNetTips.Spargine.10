```

BenchmarkDotNet v0.15.6, Windows 10 (10.0.19045.6691/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.101
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=Collections  

```
| Method         | Mean      | Error    | StdDev   | StdErr   | Min       | Q1        | Median    | Q3        | Max       | Op/s         | CI99.9% Margin | Iterations | Rank | Baseline | Completed Work Items | Lock Contentions | Code Size | Exceptions | Gen0   | Gen1   | Gen2   | Allocated |
|--------------- |----------:|---------:|---------:|---------:|----------:|----------:|----------:|----------:|----------:|-------------:|---------------:|-----------:|-----:|--------- |---------------------:|-----------------:|----------:|-----------:|-------:|-------:|-------:|----------:|
| **GetDescription** |  **14.58 ns** | **0.151 ns** | **0.141 ns** | **0.036 ns** |  **14.36 ns** |  **14.43 ns** |  **14.62 ns** |  **14.65 ns** |  **14.80 ns** | **68,610,594.4** |       **7.482 ns** |      **15.00** |    **1** | **No**       |                    **-** |                **-** |   **2,361 B** |          **-** | **0.0008** |      **-** |      **-** |      **24 B** |
| **GetItems**       | **300.13 ns** | **2.569 ns** | **2.403 ns** | **0.620 ns** | **296.58 ns** | **298.91 ns** | **299.88 ns** | **301.34 ns** | **304.49 ns** |  **3,331,873.1** |       **7.190 ns** |      **15.00** |    **2** | **No**       |                    **-** |                **-** |   **3,315 B** |          **-** | **0.0196** | **0.0010** | **0.0010** |     **608 B** |
