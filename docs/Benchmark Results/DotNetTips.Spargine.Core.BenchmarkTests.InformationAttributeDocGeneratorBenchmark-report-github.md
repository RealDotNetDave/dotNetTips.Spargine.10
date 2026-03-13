```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7058/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.104
  [Host]     : .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  

```
| Method                              | Mean         | Error      | StdDev     | StdErr   | Min          | Q1           | Median       | Q3           | Max          | Op/s    | CI99.9% Margin | Iterations | Rank | Baseline | Exceptions | Completed Work Items | Lock Contentions | Gen0   | Allocated |
|------------------------------------ |-------------:|-----------:|-----------:|---------:|-------------:|-------------:|-------------:|-------------:|-------------:|--------:|---------------:|-----------:|-----:|--------- |-----------:|---------------------:|-----------------:|-------:|----------:|
| GenerateMarkdownDocumentForAssembly | 168,473.2 ns | 1,810.3 ns | 1,604.8 ns | 428.9 ns | 166,339.3 ns | 167,738.8 ns | 168,171.9 ns | 169,008.5 ns | 172,000.4 ns | 5,935.7 |      -207.5 ns |      14.00 |    1 | No       |          - |                    - |                - | 3.9063 | 122.46 KB |
