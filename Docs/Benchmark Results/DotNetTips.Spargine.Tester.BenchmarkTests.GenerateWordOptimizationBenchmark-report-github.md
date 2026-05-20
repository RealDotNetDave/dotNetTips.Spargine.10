```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7291/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.204
  [Host]     : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=Strings  

```
| Method                                      | Length | Mean     | Error   | StdDev  | StdErr  | Min      | Q1       | Median   | Q3       | Max      | Op/s        | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Ratio | MannWhitney(10%) | Rank | LogicalGroup                                                                   | Baseline | Gen0   | Exceptions | Code Size | Allocated | Alloc Ratio |
|-------------------------------------------- |------- |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|---------:|-------:|---------:|------:|----------------- |-----:|------------------------------------------------------------------------------- |--------- |-------:|-----------:|----------:|----------:|------------:|
| &#39;GenerateWord: MIN AND MAX CHAR (baseline)&#39; | 10     | 122.9 ns | 0.96 ns | 0.75 ns | 0.22 ns | 121.7 ns | 122.4 ns | 122.8 ns | 123.6 ns | 123.9 ns | 8,135,630.2 |       5.892 ns |      12.00 |    1.494 |  2.000 |  -0.2156 |  1.00 | Baseline         |    1 | [Length=10]-Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True)  | Yes      | 0.0014 |          - |   1,186 B |      48 B |        1.00 |
|                                             |        |          |         |         |         |          |          |          |          |          |             |                |            |          |        |          |       |                  |      |                                                                                |          |        |            |           |           |             |
| &#39;GenerateWord: MIN AND MAX CHAR (baseline)&#39; | 100    | 505.4 ns | 4.61 ns | 4.31 ns | 1.11 ns | 500.5 ns | 502.5 ns | 503.7 ns | 508.1 ns | 513.9 ns | 1,978,571.7 |       6.943 ns |      15.00 |    2.234 |  2.000 |   0.6990 |  1.00 | Baseline         |    1 | [Length=100]-Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True) | Yes      | 0.0105 |          - |   1,198 B |     224 B |        1.00 |
