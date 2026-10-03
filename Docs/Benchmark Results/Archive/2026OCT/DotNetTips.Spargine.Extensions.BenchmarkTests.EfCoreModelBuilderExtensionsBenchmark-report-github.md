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
| **RegisterEnumAsStringConverters** | **6,643.4 ns** | **37.69 ns** | **35.25 ns** |  **9.10 ns** | **6,594.6 ns** | **6,615.9 ns** | **6,640.2 ns** | **6,665.3 ns** | **6,719.9 ns** | **150,525.6** |      **2.9490 ns** |      **15.00** | **No**       |          **-** | **0.3357** |  **10.52 KB** |
| **RegisterGuidAsStringConverters** | **6,421.6 ns** | **54.24 ns** | **50.74 ns** | **13.10 ns** | **6,348.0 ns** | **6,386.6 ns** | **6,413.6 ns** | **6,447.0 ns** | **6,534.1 ns** | **155,723.2** |      **0.9500 ns** |      **15.00** | **No**       |          **-** | **0.3357** |  **10.52 KB** |
