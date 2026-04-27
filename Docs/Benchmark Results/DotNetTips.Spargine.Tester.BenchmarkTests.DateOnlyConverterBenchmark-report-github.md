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
| **Read**   | **169.3 ns** | **0.62 ns** | **0.58 ns** | **0.15 ns** | **168.3 ns** | **168.9 ns** | **169.3 ns** | **169.7 ns** | **170.6 ns** | **5,905,814.6** |       **7.425 ns** |      **15.00** |    **2.665** |  **2.000** |   **0.4543** |    **2** | *****            | **No**       |   **2,517 B** |          **-** |
| **Write**  | **123.5 ns** | **1.38 ns** | **1.29 ns** | **0.33 ns** | **121.7 ns** | **122.5 ns** | **123.2 ns** | **124.5 ns** | **126.0 ns** | **8,100,001.4** |       **7.334 ns** |      **15.00** |    **1.771** |  **2.000** |   **0.2203** |    **1** | *****            | **No**       |   **4,899 B** |          **-** |
