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
| GenerateMarkdownDocumentForAssembly | 50,822.7 ns | 416.1 ns | 389.2 ns | 100.5 ns | 50,274.7 ns | 50,542.5 ns | 50,703.4 ns | 51,146.8 ns | 51,650.5 ns | 19,676.2 |      -42.75 ns |      15.00 |    1 | No       | 0.7324 |          - |                    - |                - |  23.64 KB |
