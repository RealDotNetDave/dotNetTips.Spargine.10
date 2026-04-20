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
| **Read**   | **166.9 ns** | **0.71 ns** | **0.66 ns** | **0.17 ns** | **166.0 ns** | **166.5 ns** | **166.7 ns** | **167.6 ns** | **168.0 ns** | **5,990,958.3** |       **7.415 ns** |      **15.00** |    **1.583** |  **2.000** |   **0.4057** |    **2** | *****            | **No**       |          **-** |   **2,659 B** |
| **Write**  | **120.5 ns** | **0.85 ns** | **0.71 ns** | **0.20 ns** | **118.9 ns** | **120.0 ns** | **120.5 ns** | **120.8 ns** | **121.8 ns** | **8,301,640.1** |       **6.402 ns** |      **13.00** |    **3.088** |  **2.000** |  **-0.3488** |    **1** | *****            | **No**       |          **-** |   **4,899 B** |
