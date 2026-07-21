```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7548/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.204
  [Host]     : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=Encryption  

```
| Method           | Mean       | Error   | StdDev  | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s      | CI99.9% Margin | Iterations | Baseline | Exceptions | Gen0   | Allocated |
|----------------- |-----------:|--------:|--------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------------:|-----------:|--------- |-----------:|-------:|----------:|
| GeneratePassword | 1,134.5 ns | 4.51 ns | 4.21 ns | 1.09 ns | 1,128.1 ns | 1,131.6 ns | 1,133.0 ns | 1,137.1 ns | 1,143.4 ns | 881,478.5 |       6.956 ns |      15.00 | No       |          - | 0.0057 |     176 B |
