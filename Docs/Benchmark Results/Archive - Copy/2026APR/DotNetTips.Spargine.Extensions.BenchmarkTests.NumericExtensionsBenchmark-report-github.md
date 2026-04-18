```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7058/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.104
  [Host]     : .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=**NEW**  

```
| Method  | Mean       | Error    | StdDev   | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s      | CI99.9% Margin | Iterations | Rank | Baseline | Code Size | Completed Work Items | Lock Contentions | Exceptions | Allocated |
|-------- |-----------:|---------:|---------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------------:|-----------:|-----:|--------- |----------:|---------------------:|-----------------:|-----------:|----------:|
| ToWords | 4,727.1 ns | 27.67 ns | 24.53 ns | 6.56 ns | 4,673.6 ns | 4,714.0 ns | 4,727.1 ns | 4,738.4 ns | 4,771.6 ns | 211,547.5 |       3.722 ns |      14.00 |    1 | No       |  26,401 B |                    - |                - |          - |     200 B |
