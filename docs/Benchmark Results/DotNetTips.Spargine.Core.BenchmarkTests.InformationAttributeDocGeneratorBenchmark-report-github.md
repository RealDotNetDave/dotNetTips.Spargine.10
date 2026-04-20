```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7184/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.202
  [Host]     : .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  

```
| Method                              | Mean         | Error      | StdDev     | StdErr   | Min          | Q1           | Median       | Q3           | Max          | Op/s    | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions |
|------------------------------------ |-------------:|-----------:|-----------:|---------:|-------------:|-------------:|-------------:|-------------:|-------------:|--------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|
| GenerateMarkdownDocumentForAssembly | 232,515.1 ns | 1,556.9 ns | 1,456.4 ns | 376.0 ns | 230,016.9 ns | 231,652.1 ns | 232,185.3 ns | 233,269.3 ns | 235,693.1 ns | 4,300.8 |      -180.5 ns |      15.00 |    2.697 |  2.000 |   0.5259 |    1 | *            | No       |          - |
