```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7184/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=JSON  

```
| Method | Mean     | Error   | StdDev  | StdErr  | Min      | Q1       | Median   | Q3       | Max      | Op/s        | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Code Size |
|------- |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|----------:|
| **Read**   | **239.5 ns** | **1.82 ns** | **1.70 ns** | **0.44 ns** | **237.1 ns** | **238.2 ns** | **239.2 ns** | **240.6 ns** | **242.5 ns** | **4,174,621.7** |       **7.281 ns** |      **15.00** |    **1.601** |  **2.000** |   **0.2734** |    **2** | *****            | **No**       |          **-** |   **2,712 B** |
| **Write**  | **200.8 ns** | **1.59 ns** | **1.49 ns** | **0.38 ns** | **198.4 ns** | **199.9 ns** | **200.9 ns** | **201.8 ns** | **203.2 ns** | **4,979,011.8** |       **7.308 ns** |      **15.00** |    **1.826** |  **2.000** |  **-0.0036** |    **1** | *****            | **No**       |          **-** |   **4,734 B** |
