```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7725/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=Database  

```
| Method                         | Mean       | Error    | StdDev   | StdErr   | Min        | Q1         | Median     | Q3         | Max        | Op/s      | CI99.9% Margin | Iterations | Baseline | Exceptions | Gen0   | Allocated |
|------------------------------- |-----------:|---------:|---------:|---------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------------:|-----------:|--------- |-----------:|-------:|----------:|
| **RegisterEnumAsStringConverters** | **6,607.3 ns** | **58.84 ns** | **55.04 ns** | **14.21 ns** | **6,531.5 ns** | **6,574.0 ns** | **6,603.1 ns** | **6,633.3 ns** | **6,720.0 ns** | **151,348.8** |      **0.3942 ns** |      **15.00** | **No**       |          **-** | **0.3357** |  **10.53 KB** |
| **RegisterGuidAsStringConverters** | **6,199.5 ns** | **32.71 ns** | **29.00 ns** |  **7.75 ns** | **6,149.5 ns** | **6,183.0 ns** | **6,199.3 ns** | **6,221.0 ns** | **6,237.5 ns** | **161,302.9** |      **3.1249 ns** |      **14.00** | **No**       |          **-** | **0.3357** |  **10.45 KB** |
