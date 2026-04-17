```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7058/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.201
  [Host]     : .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  

```
| Method                              | Mean         | Error    | StdDev   | StdErr   | Min          | Q1           | Median       | Q3           | Max          | Op/s    | CI99.9% Margin | Iterations | Rank | Baseline | Exceptions |
|------------------------------------ |-------------:|---------:|---------:|---------:|-------------:|-------------:|-------------:|-------------:|-------------:|--------:|---------------:|-----------:|-----:|--------- |-----------:|
| GenerateMarkdownDocumentForAssembly | 172,358.1 ns | 819.4 ns | 766.5 ns | 197.9 ns | 171,197.8 ns | 171,843.4 ns | 172,302.4 ns | 172,904.6 ns | 174,025.6 ns | 5,801.9 |      -91.45 ns |      15.00 |    1 | No       |          - |
