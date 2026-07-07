```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7417/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.204
  [Host]     : .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  

```
| Method                              | Mean         | Error      | StdDev     | StdErr   | Min          | Q1           | Median       | Q3           | Max          | Op/s    | CI99.9% Margin | Iterations | Baseline | Exceptions | Gen0   | Allocated |
|------------------------------------ |-------------:|-----------:|-----------:|---------:|-------------:|-------------:|-------------:|-------------:|-------------:|--------:|---------------:|-----------:|--------- |-----------:|-------:|----------:|
| GenerateMarkdownDocumentForAssembly | 239,247.4 ns | 1,427.2 ns | 1,265.1 ns | 338.1 ns | 237,372.9 ns | 238,263.2 ns | 238,904.0 ns | 240,160.2 ns | 241,212.8 ns | 4,179.8 |      -162.1 ns |      14.00 | No       |          - | 4.8828 | 167.54 KB |
