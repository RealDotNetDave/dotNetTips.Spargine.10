```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7725/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=LOGGING  

```
| Method           | Mean     | Error   | StdDev  | StdErr  | Min      | Q1       | Median   | Q3       | Max      | Op/s        | CI99.9% Margin | Iterations | Baseline | Gen0   | Exceptions | Code Size | Allocated |
|----------------- |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|--------- |-------:|-----------:|----------:|----------:|
| **AddTagsIfPresent** | **237.2 ns** | **4.27 ns** | **3.57 ns** | **0.99 ns** | **230.1 ns** | **236.7 ns** | **238.0 ns** | **240.5 ns** | **241.2 ns** | **4,215,986.5** |       **6.005 ns** |      **13.00** | **No**       | **0.0188** |          **-** |   **3,345 B** |     **568 B** |
| **SetStatusIfError** | **162.7 ns** | **2.44 ns** | **2.17 ns** | **0.58 ns** | **160.0 ns** | **161.1 ns** | **162.1 ns** | **164.0 ns** | **166.7 ns** | **6,145,897.4** |       **6.711 ns** |      **14.00** | **No**       | **0.0138** |          **-** |   **2,880 B** |     **416 B** |
