```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7417/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.204
  [Host]     : .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=Strings  

```
| Method                                      | Length | Mean     | Error   | StdDev  | StdErr  | Min      | Q1       | Median   | Q3       | Max      | Op/s        | CI99.9% Margin | Iterations | Ratio | Baseline | Exceptions | Code Size | Gen0   | Allocated | Alloc Ratio |
|-------------------------------------------- |------- |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|------:|--------- |-----------:|----------:|-------:|----------:|------------:|
| &#39;GenerateWord: MIN AND MAX CHAR (baseline)&#39; | 10     | 127.8 ns | 0.46 ns | 0.38 ns | 0.11 ns | 127.1 ns | 127.6 ns | 127.8 ns | 128.0 ns | 128.5 ns | 7,825,282.1 |       6.447 ns |      13.00 |  1.00 | Yes      |          - |   1,186 B | 0.0014 |      48 B |        1.00 |
|                                             |        |          |         |         |         |          |          |          |          |          |             |                |            |       |          |            |           |        |           |             |
| &#39;GenerateWord: MIN AND MAX CHAR (baseline)&#39; | 50     | 310.4 ns | 0.38 ns | 0.33 ns | 0.09 ns | 309.8 ns | 310.1 ns | 310.4 ns | 310.6 ns | 310.8 ns | 3,222,130.3 |       6.955 ns |      14.00 |  1.00 | Yes      |          - |   1,189 B | 0.0038 |     128 B |        1.00 |
|                                             |        |          |         |         |         |          |          |          |          |          |             |                |            |       |          |            |           |        |           |             |
| &#39;GenerateWord: MIN AND MAX CHAR (baseline)&#39; | 100    | 537.0 ns | 1.29 ns | 1.14 ns | 0.31 ns | 535.7 ns | 536.0 ns | 537.0 ns | 538.2 ns | 538.7 ns | 1,862,078.1 |       6.847 ns |      14.00 |  1.00 | Yes      |          - |   1,189 B | 0.0067 |     224 B |        1.00 |
