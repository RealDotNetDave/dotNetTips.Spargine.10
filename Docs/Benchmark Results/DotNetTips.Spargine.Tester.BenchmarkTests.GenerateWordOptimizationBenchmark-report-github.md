```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7807/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.402
  [Host]     : .NET 10.0.13 (10.0.13, 10.0.1326.50504), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.13 (10.0.13, 10.0.1326.50504), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=Strings  

```
| Method                                      | Length | Mean     | Error   | StdDev  | StdErr  | Min      | Q1       | Median   | Q3       | Max      | Op/s        | CI99.9% Margin | Iterations | Ratio | Baseline | Gen0   | Exceptions | Code Size | Allocated | Alloc Ratio |
|-------------------------------------------- |------- |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|------:|--------- |-------:|-----------:|----------:|----------:|------------:|
| &#39;GenerateWord: MIN AND MAX CHAR (baseline)&#39; | 10     | 123.6 ns | 0.50 ns | 0.44 ns | 0.12 ns | 123.0 ns | 123.4 ns | 123.5 ns | 123.8 ns | 124.6 ns | 8,090,102.2 |       6.941 ns |      14.00 |  1.00 | Yes      | 0.0014 |          - |   1,189 B |      48 B |        1.00 |
|                                             |        |          |         |         |         |          |          |          |          |          |             |                |            |       |          |        |            |           |           |             |
| &#39;GenerateWord: MIN AND MAX CHAR (baseline)&#39; | 50     | 290.3 ns | 3.20 ns | 2.83 ns | 0.76 ns | 287.3 ns | 287.7 ns | 289.6 ns | 292.3 ns | 295.8 ns | 3,444,605.2 |       6.621 ns |      14.00 |  1.00 | Yes      | 0.0038 |          - |   1,189 B |     128 B |        1.00 |
|                                             |        |          |         |         |         |          |          |          |          |          |             |                |            |       |          |        |            |           |           |             |
| &#39;GenerateWord: MIN AND MAX CHAR (baseline)&#39; | 100    | 505.4 ns | 4.56 ns | 4.05 ns | 1.08 ns | 499.4 ns | 502.2 ns | 505.2 ns | 507.8 ns | 512.8 ns | 1,978,510.7 |       6.459 ns |      14.00 |  1.00 | Yes      | 0.0067 |          - |   1,189 B |     224 B |        1.00 |
