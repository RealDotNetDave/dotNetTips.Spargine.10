```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7291/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.204
  [Host]     : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=Strings  

```
| Method                                      | Length | Mean     | Error   | StdDev  | StdErr  | Min      | Q1       | Median   | Q3       | Max      | Op/s        | CI99.9% Margin | Iterations | Ratio | Baseline | Gen0   | Code Size | Exceptions | Allocated | Alloc Ratio |
|-------------------------------------------- |------- |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|------:|--------- |-------:|----------:|-----------:|----------:|------------:|
| &#39;GenerateWord: MIN AND MAX CHAR (baseline)&#39; | 10     | 124.5 ns | 0.53 ns | 0.47 ns | 0.13 ns | 123.8 ns | 124.0 ns | 124.4 ns | 124.8 ns | 125.3 ns | 8,034,057.5 |       6.937 ns |      14.00 |  1.00 | Yes      | 0.0014 |   1,186 B |          - |      48 B |        1.00 |
|                                             |        |          |         |         |         |          |          |          |          |          |             |                |            |       |          |        |           |            |           |             |
| &#39;GenerateWord: MIN AND MAX CHAR (baseline)&#39; | 50     | 291.5 ns | 2.34 ns | 2.19 ns | 0.56 ns | 289.0 ns | 290.0 ns | 290.9 ns | 292.4 ns | 295.8 ns | 3,430,029.7 |       7.218 ns |      15.00 |  1.00 | Yes      | 0.0038 |   1,189 B |          - |     128 B |        1.00 |
|                                             |        |          |         |         |         |          |          |          |          |          |             |                |            |       |          |        |           |            |           |             |
| &#39;GenerateWord: MIN AND MAX CHAR (baseline)&#39; | 100    | 504.4 ns | 4.46 ns | 4.17 ns | 1.08 ns | 499.2 ns | 500.0 ns | 505.1 ns | 507.1 ns | 511.4 ns | 1,982,512.2 |       6.961 ns |      15.00 |  1.00 | Yes      | 0.0105 |   1,189 B |          - |     224 B |        1.00 |
