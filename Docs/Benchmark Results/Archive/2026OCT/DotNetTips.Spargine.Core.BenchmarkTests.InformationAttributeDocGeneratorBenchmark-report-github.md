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
| GenerateMarkdownDocumentForAssembly | 2,230,678.1 ns | 43,002.8 ns | 49,522.0 ns | 11,073.5 ns | 2,174,132.8 ns | 2,197,791.6 ns | 2,203,651.6 ns | 2,247,234.4 ns | 2,327,871.1 ns | 448.3 |    -5,526.7 ns |      20.00 | No       | 39.0625 |          - | 7.8125 | 7.8125 |   1.35 MB |
