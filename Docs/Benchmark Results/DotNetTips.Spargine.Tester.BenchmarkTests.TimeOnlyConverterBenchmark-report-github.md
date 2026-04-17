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
| **Read**   | **241.4 ns** | **1.69 ns** | **1.58 ns** | **0.41 ns** | **239.1 ns** | **240.3 ns** | **241.4 ns** | **242.2 ns** | **245.1 ns** | **4,142,745.0** |       **7.295 ns** |      **15.00** |    **2** | **No**       |          **-** |   **2,712 B** |
| **Write**  | **203.1 ns** | **1.90 ns** | **1.78 ns** | **0.46 ns** | **198.9 ns** | **202.3 ns** | **203.4 ns** | **204.2 ns** | **205.6 ns** | **4,923,687.9** |       **7.270 ns** |      **15.00** |    **1** | **No**       |          **-** |   **4,734 B** |
