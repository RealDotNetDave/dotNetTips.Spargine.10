```

BenchmarkDotNet v0.15.6, Windows 10 (10.0.19045.6691/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.101
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  

```
| Method                              | Mean        | Error      | StdDev   | StdErr   | Min         | Q1          | Median      | Q3          | Max         | Op/s     | CI99.9% Margin | Iterations | Rank | Baseline | Exceptions | Completed Work Items | Lock Contentions | Gen0   | Allocated |
|------------------------------------ |------------:|-----------:|---------:|---------:|------------:|------------:|------------:|------------:|------------:|---------:|---------------:|-----------:|-----:|--------- |-----------:|---------------------:|-----------------:|-------:|----------:|
| GenerateMarkdownDocumentForAssembly | 51,708.4 ns | 1,009.7 ns | 944.5 ns | 243.9 ns | 50,619.6 ns | 51,007.2 ns | 51,581.4 ns | 52,117.7 ns | 53,849.5 ns | 19,339.2 |      -114.4 ns |      15.00 |    1 | No       |          - |                    - |                - | 0.7324 |  23.65 KB |
