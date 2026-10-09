```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7725/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=LOGGING  

```
| Method           | Mean     | Error   | StdDev  | StdErr  | Min      | Q1       | Median   | Q3       | Max      | Op/s        | CI99.9% Margin | Iterations | Baseline | Gen0   | Exceptions | Code Size | Gen1   | Gen2   | Allocated |
|----------------- |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|--------- |-------:|-----------:|----------:|-------:|-------:|----------:|
| **AddTagsIfPresent** | **227.6 ns** | **3.78 ns** | **3.35 ns** | **0.89 ns** | **221.0 ns** | **225.2 ns** | **228.0 ns** | **228.9 ns** | **233.2 ns** | **4,393,946.4** |       **6.553 ns** |      **14.00** | **No**       | **0.0184** |          **-** |   **3,260 B** | **0.0002** | **0.0002** |         **-** |
| **SetStatusIfError** | **157.8 ns** | **3.08 ns** | **3.79 ns** | **0.81 ns** | **151.7 ns** | **155.2 ns** | **157.6 ns** | **160.3 ns** | **165.0 ns** | **6,335,847.4** |      **10.596 ns** |      **22.00** | **No**       | **0.0193** |          **-** |   **2,880 B** | **0.0002** | **0.0002** |         **-** |
