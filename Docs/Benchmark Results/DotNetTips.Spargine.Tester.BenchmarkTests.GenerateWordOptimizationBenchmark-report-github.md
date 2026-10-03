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
| &#39;GenerateWord: MIN AND MAX CHAR (baseline)&#39; | 10     | 126.1 ns | 0.53 ns | 0.44 ns | 0.12 ns | 125.4 ns | 125.8 ns | 126.1 ns | 126.4 ns | 126.9 ns | 7,928,776.6 |       6.439 ns |      13.00 |  1.00 | Yes      |          - |   1,189 B | 0.0014 |      48 B |        1.00 |
|                                             |        |          |         |         |         |          |          |          |          |          |             |                |            |       |          |            |           |        |           |             |
| &#39;GenerateWord: MIN AND MAX CHAR (baseline)&#39; | 50     | 274.0 ns | 1.29 ns | 1.08 ns | 0.30 ns | 272.3 ns | 273.3 ns | 274.0 ns | 274.8 ns | 275.8 ns | 3,649,521.3 |       6.350 ns |      13.00 |  1.00 | Yes      |          - |   1,001 B | 0.0038 |     128 B |        1.00 |
|                                             |        |          |         |         |         |          |          |          |          |          |             |                |            |       |          |            |           |        |           |             |
| &#39;GenerateWord: MIN AND MAX CHAR (baseline)&#39; | 100    | 512.2 ns | 2.75 ns | 2.57 ns | 0.66 ns | 508.4 ns | 510.0 ns | 512.4 ns | 513.9 ns | 516.3 ns | 1,952,452.9 |       7.168 ns |      15.00 |  1.00 | Yes      |          - |   1,189 B | 0.0067 |     224 B |        1.00 |
