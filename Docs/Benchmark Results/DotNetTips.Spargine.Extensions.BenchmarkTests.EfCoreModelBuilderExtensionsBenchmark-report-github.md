```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7548/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.302
  [Host]     : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=Database  

```
| Method                         | Mean       | Error    | StdDev   | StdErr   | Min        | Q1         | Median     | Q3         | Max        | Op/s      | CI99.9% Margin | Iterations | Baseline | Exceptions | Gen0   | Gen1   | Gen2   | Allocated |
|------------------------------- |-----------:|---------:|---------:|---------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------------:|-----------:|--------- |-----------:|-------:|-------:|-------:|----------:|
| **RegisterEnumAsStringConverters** | **6,794.2 ns** | **98.74 ns** | **87.53 ns** | **23.39 ns** | **6,698.6 ns** | **6,742.9 ns** | **6,756.6 ns** | **6,810.8 ns** | **6,993.2 ns** | **147,184.2** |      **-4.696 ns** |      **14.00** | **No**       |          **-** | **0.3738** | **0.0153** | **0.0153** |  **10.52 KB** |
| **RegisterGuidAsStringConverters** | **6,600.6 ns** | **36.04 ns** | **33.71 ns** |  **8.70 ns** | **6,551.6 ns** | **6,570.2 ns** | **6,599.2 ns** | **6,625.7 ns** | **6,666.3 ns** | **151,500.8** |       **3.148 ns** |      **15.00** | **No**       |          **-** | **0.3357** |      **-** |      **-** |  **10.52 KB** |
