```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.6937/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.103
  [Host]     : .NET 10.0.3 (10.0.3, 10.0.326.7603), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.3 (10.0.3, 10.0.326.7603), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  

```
| Method                              | Mean         | Error      | StdDev     | StdErr   | Min          | Q1           | Median       | Q3           | Max          | Op/s    | CI99.9% Margin | Iterations | Rank | Baseline | Completed Work Items | Lock Contentions | Gen0   | Exceptions | Allocated |
|------------------------------------ |-------------:|-----------:|-----------:|---------:|-------------:|-------------:|-------------:|-------------:|-------------:|--------:|---------------:|-----------:|-----:|--------- |---------------------:|-----------------:|-------:|-----------:|----------:|
| GenerateMarkdownDocumentForAssembly | 166,697.7 ns | 1,266.5 ns | 1,122.7 ns | 300.1 ns | 164,707.9 ns | 166,153.7 ns | 166,405.5 ns | 167,391.4 ns | 168,897.5 ns | 5,998.9 |      -143.0 ns |      14.00 |    1 | No       |                    - |                - | 3.9063 |          - | 122.46 KB |
