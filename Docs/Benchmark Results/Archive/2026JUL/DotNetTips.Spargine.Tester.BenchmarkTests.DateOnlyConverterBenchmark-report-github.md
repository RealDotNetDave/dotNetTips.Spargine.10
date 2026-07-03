```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7291/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.204
  [Host]     : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=JSON  

```
| Method | Mean     | Error   | StdDev  | StdErr  | Min      | Q1       | Median   | Q3       | Max      | Op/s        | CI99.9% Margin | Iterations | Baseline | Code Size | Exceptions | Gen0   | Allocated |
|------- |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|--------- |----------:|-----------:|-------:|----------:|
| **Read**   | **170.9 ns** | **0.85 ns** | **0.79 ns** | **0.20 ns** | **169.7 ns** | **170.3 ns** | **170.8 ns** | **171.4 ns** | **172.3 ns** | **5,852,317.5** |       **7.398 ns** |      **15.00** | **No**       |   **2,489 B** |          **-** | **0.0014** |      **48 B** |
| **Write**  | **123.5 ns** | **1.31 ns** | **1.16 ns** | **0.31 ns** | **121.1 ns** | **122.7 ns** | **123.8 ns** | **124.2 ns** | **125.5 ns** | **8,099,361.9** |       **6.845 ns** |      **14.00** | **No**       |   **4,852 B** |          **-** | **0.0060** |     **184 B** |
