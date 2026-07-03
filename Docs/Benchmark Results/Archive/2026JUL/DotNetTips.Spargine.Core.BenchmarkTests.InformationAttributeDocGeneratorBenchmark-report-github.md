```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7291/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.204
  [Host]     : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  

```
| Method                              | Mean         | Error      | StdDev     | StdErr   | Min          | Q1           | Median       | Q3           | Max          | Op/s    | CI99.9% Margin | Iterations | Baseline | Gen0   | Exceptions | Allocated |
|------------------------------------ |-------------:|-----------:|-----------:|---------:|-------------:|-------------:|-------------:|-------------:|-------------:|--------:|---------------:|-----------:|--------- |-------:|-----------:|----------:|
| GenerateMarkdownDocumentForAssembly | 248,693.0 ns | 2,557.4 ns | 2,392.2 ns | 617.7 ns | 245,016.4 ns | 247,000.3 ns | 249,016.5 ns | 249,869.9 ns | 253,810.9 ns | 4,021.0 |      -301.3 ns |      15.00 | No       | 4.8828 |          - | 167.51 KB |
