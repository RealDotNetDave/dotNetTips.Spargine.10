```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7725/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=Strings  

```
| Method                                      | Length | Mean     | Error   | StdDev  | StdErr  | Min      | Q1       | Median   | Q3       | Max      | Op/s        | CI99.9% Margin | Iterations | Ratio | Baseline | Exceptions | Code Size | Gen0   | Allocated | Alloc Ratio |
|-------------------------------------------- |------- |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|------:|--------- |-----------:|----------:|-------:|----------:|------------:|
| &#39;GenerateWord: MIN AND MAX CHAR (baseline)&#39; | 10     | 123.9 ns | 0.53 ns | 0.47 ns | 0.12 ns | 123.1 ns | 123.7 ns | 124.0 ns | 124.2 ns | 124.7 ns | 8,067,778.6 |       6.938 ns |      14.00 |  1.00 | Yes      |          - |   1,189 B | 0.0014 |      48 B |        1.00 |
|                                             |        |          |         |         |         |          |          |          |          |          |             |                |            |       |          |            |           |        |           |             |
| &#39;GenerateWord: MIN AND MAX CHAR (baseline)&#39; | 50     | 296.8 ns | 2.27 ns | 2.13 ns | 0.55 ns | 293.9 ns | 295.5 ns | 296.0 ns | 298.5 ns | 300.6 ns | 3,368,773.0 |       7.226 ns |      15.00 |  1.00 | Yes      |          - |   1,189 B | 0.0038 |     128 B |        1.00 |
|                                             |        |          |         |         |         |          |          |          |          |          |             |                |            |       |          |            |           |        |           |             |
| &#39;GenerateWord: MIN AND MAX CHAR (baseline)&#39; | 100    | 511.8 ns | 3.78 ns | 3.54 ns | 0.91 ns | 507.3 ns | 509.2 ns | 511.7 ns | 513.4 ns | 519.2 ns | 1,953,966.4 |       7.043 ns |      15.00 |  1.00 | Yes      |          - |   1,189 B | 0.0105 |     224 B |        1.00 |
