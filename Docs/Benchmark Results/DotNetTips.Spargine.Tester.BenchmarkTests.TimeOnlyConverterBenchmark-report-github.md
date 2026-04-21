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
| **Read**   | **237.5 ns** | **1.78 ns** | **1.57 ns** | **0.42 ns** | **234.7 ns** | **236.8 ns** | **237.6 ns** | **238.4 ns** | **240.7 ns** | **4,209,797.7** |       **6.790 ns** |      **14.00** |    **2.403** |  **2.000** |  **-0.0274** |    **2** | *****            | **No**       |          **-** |   **2,728 B** |
| **Write**  | **198.9 ns** | **2.30 ns** | **2.15 ns** | **0.56 ns** | **195.7 ns** | **197.6 ns** | **198.5 ns** | **199.7 ns** | **202.6 ns** | **5,026,810.1** |       **7.222 ns** |      **15.00** |    **2.097** |  **2.000** |   **0.5776** |    **1** | *****            | **No**       |          **-** |   **4,727 B** |
