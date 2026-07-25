```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7548/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.204
  [Host]     : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=Database  

```
| Method                         | Mean       | Error    | StdDev   | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s      | CI99.9% Margin | Iterations | Baseline | Exceptions | Gen0   | Gen1   | Gen2   | Allocated |
|------------------------------- |-----------:|---------:|---------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------------:|-----------:|--------- |-----------:|-------:|-------:|-------:|----------:|
| **RegisterEnumAsStringConverters** | **6,765.6 ns** | **18.56 ns** | **17.36 ns** | **4.48 ns** | **6,730.1 ns** | **6,756.3 ns** | **6,761.3 ns** | **6,778.7 ns** | **6,799.3 ns** | **147,806.6** |       **5.258 ns** |      **15.00** | **No**       |          **-** | **0.3586** | **0.0153** | **0.0153** |  **10.52 KB** |
| **RegisterGuidAsStringConverters** | **6,429.8 ns** | **36.69 ns** | **32.52 ns** | **8.69 ns** | **6,369.0 ns** | **6,408.0 ns** | **6,417.9 ns** | **6,459.2 ns** | **6,470.8 ns** | **155,526.4** |       **2.654 ns** |      **14.00** | **No**       |          **-** | **0.3357** |      **-** |      **-** |  **10.52 KB** |
