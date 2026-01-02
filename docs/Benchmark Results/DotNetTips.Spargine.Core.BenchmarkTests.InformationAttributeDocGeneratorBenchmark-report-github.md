```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.6691/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.101
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  

```
| Method                              | Mean        | Error    | StdDev   | StdErr   | Min         | Q1          | Median      | Q3          | Max         | Op/s     | CI99.9% Margin | Iterations | Rank | Baseline | Exceptions | Completed Work Items | Lock Contentions | Gen0   | Allocated |
|------------------------------------ |------------:|---------:|---------:|---------:|------------:|------------:|------------:|------------:|------------:|---------:|---------------:|-----------:|-----:|--------- |-----------:|---------------------:|-----------------:|-------:|----------:|
| GenerateMarkdownDocumentForAssembly | 70,977.9 ns | 375.3 ns | 313.4 ns | 86.92 ns | 70,465.9 ns | 70,789.1 ns | 70,874.9 ns | 71,171.3 ns | 71,524.8 ns | 14,088.9 |      -36.96 ns |      13.00 |    1 | No       |          - |                    - |                - | 0.9766 |  32.19 KB |
