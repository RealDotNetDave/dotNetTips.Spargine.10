```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7184/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.202
  [Host]     : .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=JSON  

```
| Method | Mean     | Error   | StdDev  | StdErr  | Min      | Q1       | Median   | Q3       | Max      | Op/s        | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Exceptions |
|------- |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|-----------:|
| **Read**   | **166.6 ns** | **0.99 ns** | **0.93 ns** | **0.24 ns** | **165.2 ns** | **165.8 ns** | **166.5 ns** | **167.4 ns** | **168.1 ns** | **6,003,584.1** |       **7.380 ns** |      **15.00** |    **1.492** |  **2.000** |   **0.1208** |    **2** | *****            | **No**       |   **2,415 B** |          **-** |
| **Write**  | **123.2 ns** | **1.29 ns** | **1.14 ns** | **0.31 ns** | **121.1 ns** | **122.5 ns** | **123.4 ns** | **123.9 ns** | **125.1 ns** | **8,114,586.0** |       **6.847 ns** |      **14.00** |    **2.005** |  **2.000** |   **0.0037** |    **1** | *****            | **No**       |   **4,911 B** |          **-** |
