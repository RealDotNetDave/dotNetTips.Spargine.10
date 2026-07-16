```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7548/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.204
  [Host]     : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=Strings  

```
| Method                                      | Length | Mean     | Error   | StdDev  | StdErr  | Min      | Q1       | Median   | Q3       | Max      | Op/s        | CI99.9% Margin | Iterations | Ratio | Baseline | Gen0   | Code Size | Exceptions | Allocated | Alloc Ratio |
|-------------------------------------------- |------- |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|------:|--------- |-------:|----------:|-----------:|----------:|------------:|
| &#39;GenerateWord: MIN AND MAX CHAR (baseline)&#39; | 10     | 128.2 ns | 1.16 ns | 1.03 ns | 0.28 ns | 127.0 ns | 127.4 ns | 127.8 ns | 128.7 ns | 130.2 ns | 7,802,059.8 |       6.862 ns |      14.00 |  1.00 | Yes      | 0.0014 |   1,189 B |          - |      48 B |        1.00 |
|                                             |        |          |         |         |         |          |          |          |          |          |             |                |            |       |          |        |           |            |           |             |
| &#39;GenerateWord: MIN AND MAX CHAR (baseline)&#39; | 50     | 300.5 ns | 2.72 ns | 2.54 ns | 0.66 ns | 296.8 ns | 298.7 ns | 299.4 ns | 302.1 ns | 306.8 ns | 3,328,106.2 |       7.172 ns |      15.00 |  1.00 | Yes      | 0.0029 |   1,189 B |          - |     128 B |        1.00 |
|                                             |        |          |         |         |         |          |          |          |          |          |             |                |            |       |          |        |           |            |           |             |
| &#39;GenerateWord: MIN AND MAX CHAR (baseline)&#39; | 100    | 503.1 ns | 2.10 ns | 1.76 ns | 0.49 ns | 501.0 ns | 501.6 ns | 503.0 ns | 503.6 ns | 507.3 ns | 1,987,651.1 |       6.256 ns |      13.00 |  1.00 | Yes      | 0.0067 |   1,198 B |          - |     224 B |        1.00 |
