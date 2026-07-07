```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7417/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.204
  [Host]     : .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=Encryption  

```
| Method           | Mean       | Error   | StdDev  | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s      | CI99.9% Margin | Iterations | Baseline | Exceptions | Gen0   | Allocated |
|----------------- |-----------:|--------:|--------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------------:|-----------:|--------- |-----------:|-------:|----------:|
| GeneratePassword | 1,137.2 ns | 4.77 ns | 4.23 ns | 1.13 ns | 1,127.5 ns | 1,135.1 ns | 1,137.3 ns | 1,140.2 ns | 1,143.6 ns | 879,314.8 |       6.435 ns |      14.00 | No       |          - | 0.0057 |     176 B |
