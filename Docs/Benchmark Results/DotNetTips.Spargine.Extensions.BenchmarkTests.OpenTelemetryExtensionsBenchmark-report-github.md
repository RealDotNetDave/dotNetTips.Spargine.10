```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7725/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=LOGGING  

```
| Method           | Mean     | Error   | StdDev  | StdErr  | Min      | Q1       | Median   | Q3       | Max      | Op/s        | CI99.9% Margin | Iterations | Baseline | Code Size | Exceptions | Gen0   | Gen1   | Gen2   | Allocated |
|----------------- |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|--------- |----------:|-----------:|-------:|-------:|-------:|----------:|
| **AddTagsIfPresent** | **221.3 ns** | **3.98 ns** | **3.72 ns** | **0.96 ns** | **216.3 ns** | **219.2 ns** | **220.2 ns** | **222.4 ns** | **228.7 ns** | **4,519,129.5** |       **7.019 ns** |      **15.00** | **No**       |   **3,260 B** |          **-** | **0.0188** | **0.0007** | **0.0007** |         **-** |
| **SetStatusIfError** | **157.5 ns** | **2.59 ns** | **2.42 ns** | **0.63 ns** | **154.4 ns** | **155.5 ns** | **157.0 ns** | **159.0 ns** | **162.8 ns** | **6,350,108.7** |       **7.187 ns** |      **15.00** | **No**       |   **2,878 B** |          **-** | **0.0143** | **0.0005** | **0.0005** |     **416 B** |
