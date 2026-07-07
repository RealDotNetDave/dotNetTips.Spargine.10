```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7417/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.204
  [Host]     : .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=JSON  

```
| Method | Mean     | Error   | StdDev  | StdErr  | Min      | Q1       | Median   | Q3       | Max      | Op/s        | CI99.9% Margin | Iterations | Baseline | Code Size | Gen0   | Exceptions | Allocated |
|------- |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|--------- |----------:|-------:|-----------:|----------:|
| **Read**   | **236.5 ns** | **1.70 ns** | **1.50 ns** | **0.40 ns** | **234.2 ns** | **235.4 ns** | **236.1 ns** | **237.7 ns** | **239.0 ns** | **4,228,566.4** |       **6.799 ns** |      **14.00** | **No**       |   **2,656 B** | **0.0014** |          **-** |      **48 B** |
| **Write**  | **197.3 ns** | **3.40 ns** | **3.18 ns** | **0.82 ns** | **193.1 ns** | **194.9 ns** | **197.4 ns** | **198.1 ns** | **204.1 ns** | **5,069,125.5** |       **7.089 ns** |      **15.00** | **No**       |   **4,686 B** | **0.0060** |          **-** |     **184 B** |
