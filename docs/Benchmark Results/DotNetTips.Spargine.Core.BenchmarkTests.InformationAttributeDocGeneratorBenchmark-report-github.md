```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7058/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.104
  [Host]     : .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  

```
| Method                              | Mean         | Error      | StdDev     | StdErr   | Min          | Q1           | Median       | Q3           | Max          | Op/s    | CI99.9% Margin | Iterations | Rank | Baseline | Gen0   | Completed Work Items | Lock Contentions | Exceptions | Allocated |
|------------------------------------ |-------------:|-----------:|-----------:|---------:|-------------:|-------------:|-------------:|-------------:|-------------:|--------:|---------------:|-----------:|-----:|--------- |-------:|---------------------:|-----------------:|-----------:|----------:|
| GenerateMarkdownDocumentForAssembly | 168,026.3 ns | 1,103.6 ns | 1,032.3 ns | 266.5 ns | 166,630.6 ns | 167,041.6 ns | 168,152.3 ns | 168,645.5 ns | 169,928.4 ns | 5,951.5 |      -125.8 ns |      15.00 |    1 | No       | 3.9063 |                    - |                - |          - | 121.94 KB |
