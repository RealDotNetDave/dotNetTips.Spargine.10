```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7725/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=JSON  

```
| Method | Mean     | Error   | StdDev  | StdErr  | Min      | Q1       | Median   | Q3       | Max      | Op/s        | CI99.9% Margin | Iterations | Baseline | Gen0   | Exceptions | Code Size | Allocated |
|------- |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|--------- |-------:|-----------:|----------:|----------:|
| **Read**   | **174.0 ns** | **0.75 ns** | **0.70 ns** | **0.18 ns** | **172.6 ns** | **173.5 ns** | **173.9 ns** | **174.5 ns** | **175.0 ns** | **5,748,529.1** |       **7.409 ns** |      **15.00** | **No**       | **0.0014** |          **-** |   **2,545 B** |      **48 B** |
| **Write**  | **127.2 ns** | **1.26 ns** | **1.18 ns** | **0.30 ns** | **125.3 ns** | **126.5 ns** | **126.8 ns** | **128.1 ns** | **129.6 ns** | **7,862,323.3** |       **7.348 ns** |      **15.00** | **No**       | **0.0060** |          **-** |   **4,692 B** |     **184 B** |
