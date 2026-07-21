```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7548/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.204
  [Host]     : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  

```
| Method                              | Mean         | Error      | StdDev     | StdErr   | Min          | Q1           | Median       | Q3           | Max          | Op/s    | CI99.9% Margin | Iterations | Baseline | Exceptions | Gen0   | Allocated |
|------------------------------------ |-------------:|-----------:|-----------:|---------:|-------------:|-------------:|-------------:|-------------:|-------------:|--------:|---------------:|-----------:|--------- |-----------:|-------:|----------:|
| GenerateMarkdownDocumentForAssembly | 232,044.2 ns | 1,370.0 ns | 1,281.5 ns | 330.9 ns | 230,005.2 ns | 230,976.3 ns | 232,350.5 ns | 233,137.7 ns | 233,884.8 ns | 4,309.5 |      -157.9 ns |      15.00 | No       |          - | 4.8828 | 167.59 KB |
