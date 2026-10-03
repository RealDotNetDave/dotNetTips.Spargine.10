```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7725/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=Strings  

```
| Method                                      | Length | Mean     | Error   | StdDev  | StdErr  | Min      | Q1       | Median   | Q3       | Max      | Op/s        | CI99.9% Margin | Iterations | Ratio | Baseline | Exceptions | Code Size | Gen0   | Gen1   | Gen2   | Allocated | Alloc Ratio |
|-------------------------------------------- |------- |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|------:|--------- |-----------:|----------:|-------:|-------:|-------:|----------:|------------:|
| &#39;GenerateWord: MIN AND MAX CHAR (baseline)&#39; | 10     | 127.4 ns | 0.45 ns | 0.40 ns | 0.11 ns | 126.8 ns | 127.1 ns | 127.4 ns | 127.7 ns | 128.1 ns | 7,848,789.6 |       6.947 ns |      14.00 |  1.00 | Yes      |          - |   1,189 B | 0.0014 |      - |      - |      48 B |        1.00 |
|                                             |        |          |         |         |         |          |          |          |          |          |             |                |            |       |          |            |           |        |        |        |           |             |
| &#39;GenerateWord: MIN AND MAX CHAR (baseline)&#39; | 50     | 290.8 ns | 2.52 ns | 2.36 ns | 0.61 ns | 287.3 ns | 289.2 ns | 290.5 ns | 292.3 ns | 295.3 ns | 3,438,846.3 |       7.195 ns |      15.00 |  1.00 | Yes      |          - |   1,189 B | 0.0038 |      - |      - |     128 B |        1.00 |
|                                             |        |          |         |         |         |          |          |          |          |          |             |                |            |       |          |            |           |        |        |        |           |             |
| &#39;GenerateWord: MIN AND MAX CHAR (baseline)&#39; | 100    | 512.6 ns | 3.22 ns | 2.69 ns | 0.75 ns | 508.1 ns | 510.8 ns | 513.1 ns | 513.6 ns | 518.6 ns | 1,950,900.9 |       6.127 ns |      13.00 |  1.00 | Yes      |          - |   1,189 B | 0.0086 | 0.0010 | 0.0010 |         - |          NA |
