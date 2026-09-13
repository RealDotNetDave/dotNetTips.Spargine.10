```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7725/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=Encryption  

```
| Method           | Mean       | Error   | StdDev  | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s      | CI99.9% Margin | Iterations | Baseline | Gen0   | Exceptions | Allocated |
|----------------- |-----------:|--------:|--------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------------:|-----------:|--------- |-------:|-----------:|----------:|
| GeneratePassword | 1,135.2 ns | 4.06 ns | 3.79 ns | 0.98 ns | 1,129.7 ns | 1,132.4 ns | 1,135.0 ns | 1,136.7 ns | 1,142.2 ns | 880,928.1 |       7.010 ns |      15.00 | No       | 0.0057 |          - |     176 B |
