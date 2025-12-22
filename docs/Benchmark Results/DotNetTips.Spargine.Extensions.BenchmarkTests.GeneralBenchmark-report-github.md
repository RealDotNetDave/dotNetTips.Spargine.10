```

BenchmarkDotNet v0.15.6, Windows 10 (10.0.19045.6691/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.101
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=**FOR COMPARISON**  

```
| Method         | Mean      | Error     | StdDev    | StdErr    | Min       | Q1        | Median    | Q3        | Max       | Op/s            | CI99.9% Margin | Iterations | Rank | Baseline | Completed Work Items | Lock Contentions | Exceptions | Code Size | Allocated |
|--------------- |----------:|----------:|----------:|----------:|----------:|----------:|----------:|----------:|----------:|----------------:|---------------:|-----------:|-----:|--------- |---------------------:|-----------------:|-----------:|----------:|----------:|
| &#39;Equals: Guid&#39; | 0.2525 ns | 0.0080 ns | 0.0067 ns | 0.0019 ns | 0.2409 ns | 0.2491 ns | 0.2543 ns | 0.2568 ns | 0.2654 ns | 3,959,863,427.0 |       6.499 ns |      13.00 |    1 | No       |                    - |                - |          - |      39 B |         - |
