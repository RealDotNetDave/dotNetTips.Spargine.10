```

BenchmarkDotNet v0.15.6, Windows 10 (10.0.19045.6691/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.101
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=**FOR COMPARISON**  

```
| Method         | Mean      | Error     | StdDev    | StdErr    | Min       | Q1        | Median    | Q3        | Max       | Op/s             | CI99.9% Margin | Iterations | Rank | Baseline | Exceptions | Completed Work Items | Lock Contentions | Code Size | Allocated |
|--------------- |----------:|----------:|----------:|----------:|----------:|----------:|----------:|----------:|----------:|-----------------:|---------------:|-----------:|-----:|--------- |-----------:|---------------------:|-----------------:|----------:|----------:|
| &#39;Equals: Guid&#39; | 0.0180 ns | 0.0104 ns | 0.0097 ns | 0.0025 ns | 0.0014 ns | 0.0145 ns | 0.0164 ns | 0.0244 ns | 0.0375 ns | 55,662,824,605.1 |       7.499 ns |      15.00 |    1 | No       |          - |                    - |                - |      39 B |         - |
