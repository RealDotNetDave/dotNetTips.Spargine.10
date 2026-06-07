```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7291/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.204
  [Host]     : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=JSON  

```
| Method | Mean     | Error   | StdDev  | StdErr  | Min      | Q1       | Median   | Q3       | Max      | Op/s        | CI99.9% Margin | Iterations | Baseline | Exceptions | Gen0   | Code Size | Allocated |
|------- |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|--------- |-----------:|-------:|----------:|----------:|
| **Read**   | **240.9 ns** | **2.05 ns** | **1.91 ns** | **0.49 ns** | **237.8 ns** | **239.5 ns** | **241.3 ns** | **241.8 ns** | **244.9 ns** | **4,151,841.2** |       **7.253 ns** |      **15.00** | **No**       |          **-** | **0.0014** |   **2,656 B** |      **48 B** |
| **Write**  | **200.2 ns** | **1.62 ns** | **1.52 ns** | **0.39 ns** | **197.8 ns** | **198.9 ns** | **199.9 ns** | **201.5 ns** | **202.9 ns** | **4,995,755.9** |       **7.304 ns** |      **15.00** | **No**       |          **-** | **0.0060** |   **4,679 B** |     **184 B** |
