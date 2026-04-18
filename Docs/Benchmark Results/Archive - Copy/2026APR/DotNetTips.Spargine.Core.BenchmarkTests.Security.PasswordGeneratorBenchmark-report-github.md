```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7058/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.104
  [Host]     : .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=Encryption,**NEW**  

```
| Method           | Mean       | Error   | StdDev  | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s      | CI99.9% Margin | Iterations | Rank | Baseline | Completed Work Items | Lock Contentions | Gen0   | Exceptions | Allocated |
|----------------- |-----------:|--------:|--------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------------:|-----------:|-----:|--------- |---------------------:|-----------------:|-------:|-----------:|----------:|
| GeneratePassword | 1,152.0 ns | 2.99 ns | 2.65 ns | 0.71 ns | 1,147.3 ns | 1,150.9 ns | 1,152.2 ns | 1,153.4 ns | 1,157.4 ns | 868,025.8 |       6.646 ns |      14.00 |    1 | No       |                    - |                - | 0.0057 |          - |     176 B |
