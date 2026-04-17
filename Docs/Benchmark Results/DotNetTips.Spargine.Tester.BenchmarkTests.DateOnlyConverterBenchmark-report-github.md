```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7058/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.201
  [Host]     : .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=JSON,**NEW**  

```
| Method | Mean     | Error   | StdDev  | StdErr  | Min      | Q1       | Median   | Q3       | Max      | Op/s        | CI99.9% Margin | Iterations | Rank | Baseline | Exceptions | Code Size |
|------- |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|-----:|--------- |-----------:|----------:|
| **Read**   | **165.5 ns** | **0.62 ns** | **0.58 ns** | **0.15 ns** | **164.8 ns** | **165.2 ns** | **165.4 ns** | **165.9 ns** | **166.5 ns** | **6,040,963.4** |       **7.425 ns** |      **15.00** |    **2** | **No**       |          **-** |   **2,698 B** |
| **Write**  | **122.5 ns** | **0.81 ns** | **0.75 ns** | **0.19 ns** | **121.3 ns** | **122.0 ns** | **122.7 ns** | **123.0 ns** | **123.7 ns** | **8,165,263.2** |       **7.403 ns** |      **15.00** |    **1** | **No**       |          **-** |   **4,899 B** |
