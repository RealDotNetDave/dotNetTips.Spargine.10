```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.6691/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.101
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  

```
| Method                              | Mean        | Error      | StdDev     | StdErr   | Min         | Q1          | Median      | Q3          | Max         | Op/s     | CI99.9% Margin | Iterations | Rank | Baseline | Gen0   | Exceptions | Completed Work Items | Lock Contentions | Allocated |
|------------------------------------ |------------:|-----------:|-----------:|---------:|------------:|------------:|------------:|------------:|------------:|---------:|---------------:|-----------:|-----:|--------- |-------:|-----------:|---------------------:|-----------------:|----------:|
| GenerateMarkdownDocumentForAssembly | 78,451.2 ns | 1,242.7 ns | 1,101.6 ns | 294.4 ns | 76,436.8 ns | 78,041.8 ns | 78,728.9 ns | 78,873.1 ns | 80,123.2 ns | 12,746.8 |      -140.2 ns |      14.00 |    1 | No       | 0.9766 |          - |                    - |                - |  32.59 KB |
