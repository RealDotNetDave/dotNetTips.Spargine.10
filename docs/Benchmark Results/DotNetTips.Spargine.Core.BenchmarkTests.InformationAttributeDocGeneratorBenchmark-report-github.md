```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7184/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  

```
| Method                              | Mean         | Error      | StdDev     | StdErr   | Min          | Q1           | Median       | Q3           | Max          | Op/s    | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions |
|------------------------------------ |-------------:|-----------:|-----------:|---------:|-------------:|-------------:|-------------:|-------------:|-------------:|--------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|
| GenerateMarkdownDocumentForAssembly | 494,555.9 ns | 2,057.0 ns | 1,924.1 ns | 496.8 ns | 491,091.8 ns | 493,314.4 ns | 494,571.9 ns | 495,748.0 ns | 497,924.0 ns | 2,022.0 |      -240.9 ns |      15.00 |    1.944 |  2.000 |  -0.0558 |    1 | *            | No       |          - |
