```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.6809/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.102
  [Host]     : .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=**NEW**  

```
| Method  | Mean       | Error    | StdDev   | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s      | CI99.9% Margin | Iterations | Rank | Baseline | Exceptions | Code Size | Completed Work Items | Lock Contentions | Allocated |
|-------- |-----------:|---------:|---------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------------:|-----------:|-----:|--------- |-----------:|----------:|---------------------:|-----------------:|----------:|
| ToWords | 4,540.1 ns | 21.39 ns | 20.01 ns | 5.17 ns | 4,493.4 ns | 4,529.5 ns | 4,539.6 ns | 4,552.9 ns | 4,569.2 ns | 220,258.6 |       4.917 ns |      15.00 |    1 | No       |          - |  26,629 B |                    - |                - |     200 B |
