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
| **Read**   | **164.6 ns** | **0.52 ns** | **0.46 ns** | **0.12 ns** | **164.2 ns** | **164.3 ns** | **164.4 ns** | **164.7 ns** | **165.5 ns** | **6,075,379.7** |       **6.938 ns** |      **14.00** |    **2.415** |  **2.000** |   **1.0344** |    **2** | *****            | **No**       |   **2,650 B** |          **-** |
| **Write**  | **127.3 ns** | **2.57 ns** | **2.28 ns** | **0.61 ns** | **123.2 ns** | **126.4 ns** | **127.5 ns** | **128.3 ns** | **131.1 ns** | **7,856,461.3** |       **6.696 ns** |      **14.00** |    **2.190** |  **2.000** |  **-0.2334** |    **1** | *****            | **No**       |   **4,851 B** |          **-** |
