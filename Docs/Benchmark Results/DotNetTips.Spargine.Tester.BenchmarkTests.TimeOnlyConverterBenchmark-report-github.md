```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7548/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.204
  [Host]     : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=JSON  

```
| Method | Mean     | Error   | StdDev  | StdErr  | Min      | Q1       | Median   | Q3       | Max      | Op/s        | CI99.9% Margin | Iterations | Baseline | Exceptions | Gen0   | Code Size | Allocated |
|------- |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|--------- |-----------:|-------:|----------:|----------:|
| **Read**   | **237.4 ns** | **0.56 ns** | **0.47 ns** | **0.13 ns** | **236.2 ns** | **237.4 ns** | **237.6 ns** | **237.7 ns** | **237.7 ns** | **4,212,471.8** |       **6.435 ns** |      **13.00** | **No**       |          **-** | **0.0014** |   **2,421 B** |      **48 B** |
| **Write**  | **201.6 ns** | **1.75 ns** | **1.55 ns** | **0.41 ns** | **198.5 ns** | **200.9 ns** | **201.8 ns** | **202.6 ns** | **204.2 ns** | **4,959,702.8** |       **6.793 ns** |      **14.00** | **No**       |          **-** | **0.0052** |   **4,530 B** |     **184 B** |
