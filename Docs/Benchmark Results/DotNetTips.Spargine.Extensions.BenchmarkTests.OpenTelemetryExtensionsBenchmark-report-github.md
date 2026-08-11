```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7548/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.302
  [Host]     : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=LOGGING  

```
| Method           | Mean     | Error   | StdDev  | StdErr  | Min      | Q1       | Median   | Q3       | Max      | Op/s        | CI99.9% Margin | Iterations | Baseline | Code Size | Exceptions | Gen0   | Gen1   | Gen2   | Allocated |
|----------------- |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|--------- |----------:|-----------:|-------:|-------:|-------:|----------:|
| **AddTagsIfPresent** | **234.8 ns** | **2.58 ns** | **2.15 ns** | **0.60 ns** | **231.9 ns** | **233.0 ns** | **234.5 ns** | **236.3 ns** | **238.3 ns** | **4,258,068.6** |       **6.201 ns** |      **13.00** | **No**       |   **3,352 B** |          **-** | **0.0057** |      **-** |      **-** |     **568 B** |
| **SetStatusIfError** | **161.5 ns** | **3.25 ns** | **3.86 ns** | **0.84 ns** | **155.8 ns** | **158.8 ns** | **160.6 ns** | **163.5 ns** | **170.5 ns** | **6,193,493.3** |      **10.078 ns** |      **21.00** | **No**       |   **2,877 B** |          **-** | **0.0196** | **0.0002** | **0.0002** |         **-** |
