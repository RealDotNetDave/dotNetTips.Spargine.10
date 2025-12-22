```

BenchmarkDotNet v0.15.6, Windows 10 (10.0.19045.6691/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.101
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=**NEW**  

```
| Method  | Mean       | Error    | StdDev   | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s      | CI99.9% Margin | Iterations | Rank | Baseline | Completed Work Items | Lock Contentions | Code Size | Exceptions | Allocated |
|-------- |-----------:|---------:|---------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------------:|-----------:|-----:|--------- |---------------------:|-----------------:|----------:|-----------:|----------:|
| ToWords | 4,589.1 ns | 37.16 ns | 34.76 ns | 8.98 ns | 4,545.6 ns | 4,556.1 ns | 4,586.3 ns | 4,622.0 ns | 4,638.5 ns | 217,909.3 |       3.012 ns |      15.00 |    1 | No       |                    - |                - |  26,607 B |          - |     200 B |
