```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7548/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.302
  [Host]     : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=JSON  

```
| Method | Mean     | Error   | StdDev  | StdErr  | Min      | Q1       | Median   | Q3       | Max      | Op/s        | CI99.9% Margin | Iterations | Baseline | Exceptions | Gen0   | Code Size | Allocated |
|------- |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|--------- |-----------:|-------:|----------:|----------:|
| **Read**   | **240.1 ns** | **1.54 ns** | **1.44 ns** | **0.37 ns** | **237.3 ns** | **239.4 ns** | **240.7 ns** | **241.1 ns** | **241.8 ns** | **4,164,934.5** |       **7.314 ns** |      **15.00** | **No**       |          **-** | **0.0010** |   **2,559 B** |      **48 B** |
| **Write**  | **194.1 ns** | **1.47 ns** | **1.38 ns** | **0.36 ns** | **191.8 ns** | **193.1 ns** | **194.3 ns** | **194.8 ns** | **196.7 ns** | **5,151,289.9** |       **7.322 ns** |      **15.00** | **No**       |          **-** | **0.0057** |   **4,530 B** |     **184 B** |
