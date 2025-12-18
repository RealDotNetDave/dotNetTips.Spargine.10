```

BenchmarkDotNet v0.15.6, Windows 10 (10.0.19045.6691/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.101
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  

```
| Method                              | Mean        | Error    | StdDev   | StdErr   | Min         | Q1          | Median      | Q3          | Max         | Op/s     | CI99.9% Margin | Iterations | Rank | Baseline | Gen0   | Exceptions | Completed Work Items | Lock Contentions | Allocated |
|------------------------------------ |------------:|---------:|---------:|---------:|------------:|------------:|------------:|------------:|------------:|---------:|---------------:|-----------:|-----:|--------- |-------:|-----------:|---------------------:|-----------------:|----------:|
| GenerateMarkdownDocumentForAssembly | 50,669.4 ns | 415.3 ns | 388.5 ns | 100.3 ns | 49,871.7 ns | 50,396.0 ns | 50,766.5 ns | 50,944.2 ns | 51,088.9 ns | 19,735.8 |      -42.65 ns |      15.00 |    1 | No       | 0.7324 |          - |                    - |                - |  23.65 KB |
