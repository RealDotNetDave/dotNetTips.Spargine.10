```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7725/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  

```
| Method                              | Mean           | Error       | StdDev      | StdErr      | Min            | Q1             | Median         | Q3             | Max            | Op/s  | CI99.9% Margin | Iterations | Baseline | Gen0    | Exceptions | Gen1   | Gen2   | Allocated |
|------------------------------------ |---------------:|------------:|------------:|------------:|---------------:|---------------:|---------------:|---------------:|---------------:|------:|---------------:|-----------:|--------- |--------:|-----------:|-------:|-------:|----------:|
| GenerateMarkdownDocumentForAssembly | 2,172,804.4 ns | 42,520.2 ns | 48,966.3 ns | 10,949.2 ns | 2,113,400.8 ns | 2,129,480.7 ns | 2,159,938.7 ns | 2,217,310.5 ns | 2,253,939.1 ns | 460.2 |    -5,464.6 ns |      20.00 | No       | 39.0625 |          - | 7.8125 | 7.8125 |    1.3 MB |
