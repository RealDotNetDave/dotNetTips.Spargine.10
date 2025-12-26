```

BenchmarkDotNet v0.15.6, Windows 10 (10.0.19045.6691/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.101
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=**NEW**  

```
| Method  | Mean       | Error    | StdDev   | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s      | CI99.9% Margin | Iterations | Rank | Baseline | Code Size | Exceptions | Completed Work Items | Lock Contentions | Allocated |
|-------- |-----------:|---------:|---------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------------:|-----------:|-----:|--------- |----------:|-----------:|---------------------:|-----------------:|----------:|
| ToWords | 4,566.4 ns | 34.40 ns | 32.18 ns | 8.31 ns | 4,524.8 ns | 4,543.5 ns | 4,560.6 ns | 4,585.2 ns | 4,640.8 ns | 218,990.2 |       3.346 ns |      15.00 |    1 | No       |  26,627 B |          - |                    - |                - |     200 B |
