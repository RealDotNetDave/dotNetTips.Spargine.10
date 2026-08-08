```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7548/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.302
  [Host]     : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=Strings  

```
| Method                                      | Length | Mean     | Error   | StdDev  | StdErr  | Min      | Q1       | Median   | Q3       | Max      | Op/s        | CI99.9% Margin | Iterations | Ratio | Baseline | Gen0   | Code Size | Exceptions | Allocated | Alloc Ratio |
|-------------------------------------------- |------- |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|------:|--------- |-------:|----------:|-----------:|----------:|------------:|
| &#39;GenerateWord: MIN AND MAX CHAR (baseline)&#39; | 10     | 123.2 ns | 0.61 ns | 0.57 ns | 0.15 ns | 122.4 ns | 122.8 ns | 123.1 ns | 123.6 ns | 124.3 ns | 8,116,985.8 |       7.427 ns |      15.00 |  1.00 | Yes      | 0.0014 |   1,186 B |          - |      48 B |        1.00 |
|                                             |        |          |         |         |         |          |          |          |          |          |             |                |            |       |          |        |           |            |           |             |
| &#39;GenerateWord: MIN AND MAX CHAR (baseline)&#39; | 50     | 294.8 ns | 2.16 ns | 1.91 ns | 0.51 ns | 291.7 ns | 293.4 ns | 294.9 ns | 295.6 ns | 298.4 ns | 3,391,612.0 |       6.744 ns |      14.00 |  1.00 | Yes      | 0.0038 |   1,189 B |          - |     128 B |        1.00 |
|                                             |        |          |         |         |         |          |          |          |          |          |             |                |            |       |          |        |           |            |           |             |
| &#39;GenerateWord: MIN AND MAX CHAR (baseline)&#39; | 100    | 508.4 ns | 2.20 ns | 1.83 ns | 0.51 ns | 505.5 ns | 507.4 ns | 507.6 ns | 509.8 ns | 512.0 ns | 1,967,055.9 |       6.246 ns |      13.00 |  1.00 | Yes      | 0.0067 |   1,189 B |          - |     224 B |        1.00 |
