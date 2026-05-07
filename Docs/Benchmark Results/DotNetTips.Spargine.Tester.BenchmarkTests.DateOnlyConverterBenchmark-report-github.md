```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7184/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=JSON  

```
| Method | Mean     | Error   | StdDev  | StdErr  | Min      | Q1       | Median   | Q3       | Max      | Op/s        | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Exceptions |
|------- |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|-----------:|
| **Read**   | **163.9 ns** | **0.71 ns** | **0.63 ns** | **0.17 ns** | **162.4 ns** | **163.5 ns** | **164.0 ns** | **164.1 ns** | **164.9 ns** | **6,103,068.4** |       **6.916 ns** |      **14.00** |    **2.879** |  **2.000** |  **-0.5104** |    **2** | *****            | **No**       |   **2,647 B** |          **-** |
| **Write**  | **124.7 ns** | **1.09 ns** | **1.02 ns** | **0.26 ns** | **123.4 ns** | **123.8 ns** | **124.5 ns** | **125.8 ns** | **126.5 ns** | **8,016,061.8** |       **7.368 ns** |      **15.00** |    **1.378** |  **2.000** |   **0.1571** |    **1** | *****            | **No**       |   **4,863 B** |          **-** |
