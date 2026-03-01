```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.6937/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.103
  [Host]     : .NET 10.0.3 (10.0.3, 10.0.326.7603), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.3 (10.0.3, 10.0.326.7603), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  

```
| Method                              | Mean         | Error    | StdDev   | StdErr   | Min          | Q1           | Median       | Q3           | Max          | Op/s    | CI99.9% Margin | Iterations | Rank | Baseline | Exceptions | Completed Work Items | Lock Contentions | Gen0   | Allocated |
|------------------------------------ |-------------:|---------:|---------:|---------:|-------------:|-------------:|-------------:|-------------:|-------------:|--------:|---------------:|-----------:|-----:|--------- |-----------:|---------------------:|-----------------:|-------:|----------:|
| GenerateMarkdownDocumentForAssembly | 163,439.2 ns | 862.2 ns | 720.0 ns | 199.7 ns | 161,923.0 ns | 163,084.9 ns | 163,760.7 ns | 163,816.1 ns | 164,484.4 ns | 6,118.5 |      -93.35 ns |      13.00 |    1 | No       |          - |                    - |                - | 3.9063 | 122.46 KB |
