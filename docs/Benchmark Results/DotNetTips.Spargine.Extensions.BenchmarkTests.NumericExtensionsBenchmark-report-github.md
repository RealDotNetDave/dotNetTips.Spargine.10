```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7058/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.201
  [Host]     : .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=**NEW**  

```
| Method  | Mean       | Error    | StdDev   | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s      | CI99.9% Margin | Iterations | Rank | Baseline | Code Size | Exceptions |
|-------- |-----------:|---------:|---------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------------:|-----------:|-----:|--------- |----------:|-----------:|
| ToWords | 4,743.2 ns | 16.10 ns | 14.28 ns | 3.82 ns | 4,719.3 ns | 4,733.8 ns | 4,744.4 ns | 4,750.8 ns | 4,767.4 ns | 210,827.0 |       5.092 ns |      14.00 |    1 | No       |  26,520 B |          - |
