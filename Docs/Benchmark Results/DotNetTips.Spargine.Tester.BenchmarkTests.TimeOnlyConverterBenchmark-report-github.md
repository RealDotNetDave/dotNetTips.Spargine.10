```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7184/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.202
  [Host]     : .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=JSON  

```
| Method | Mean     | Error   | StdDev  | StdErr  | Min      | Q1       | Median   | Q3       | Max      | Op/s        | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Code Size |
|------- |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|----------:|
| **Read**   | **237.7 ns** | **1.25 ns** | **1.17 ns** | **0.30 ns** | **236.2 ns** | **236.8 ns** | **237.9 ns** | **238.3 ns** | **240.1 ns** | **4,206,890.1** |       **7.349 ns** |      **15.00** |    **2.112** |  **2.000** |   **0.3710** |    **2** | *****            | **No**       |          **-** |   **2,709 B** |
| **Write**  | **198.7 ns** | **1.20 ns** | **1.12 ns** | **0.29 ns** | **196.2 ns** | **198.1 ns** | **198.6 ns** | **199.7 ns** | **200.2 ns** | **5,032,319.5** |       **7.355 ns** |      **15.00** |    **2.306** |  **2.000** |  **-0.3999** |    **1** | *****            | **No**       |          **-** |   **4,727 B** |
