```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.6809/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.102
  [Host]     : .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  

```
| Method                              | Mean         | Error      | StdDev     | StdErr   | Min          | Q1           | Median       | Q3           | Max          | Op/s    | CI99.9% Margin | Iterations | Rank | Baseline | Exceptions | Completed Work Items | Lock Contentions | Gen0   | Allocated |
|------------------------------------ |-------------:|-----------:|-----------:|---------:|-------------:|-------------:|-------------:|-------------:|-------------:|--------:|---------------:|-----------:|-----:|--------- |-----------:|---------------------:|-----------------:|-------:|----------:|
| GenerateMarkdownDocumentForAssembly | 158,806.6 ns | 1,379.2 ns | 1,076.8 ns | 310.8 ns | 157,527.7 ns | 158,239.0 ns | 158,584.3 ns | 159,119.0 ns | 161,569.5 ns | 6,297.0 |      -149.4 ns |      12.00 |    1 | No       |          - |                    - |                - | 3.9063 | 120.38 KB |
