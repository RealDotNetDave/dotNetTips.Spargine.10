```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.6691/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.101
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=Encryption,**NEW**  

```
| Method           | Mean       | Error    | StdDev   | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s      | CI99.9% Margin | Iterations | Rank | Baseline | Gen0   | Completed Work Items | Lock Contentions | Exceptions | Allocated |
|----------------- |-----------:|---------:|---------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------------:|-----------:|-----:|--------- |-------:|---------------------:|-----------------:|-----------:|----------:|
| GeneratePassword | 2,176.8 ns | 12.60 ns | 11.78 ns | 3.04 ns | 2,156.6 ns | 2,169.2 ns | 2,178.6 ns | 2,183.0 ns | 2,199.9 ns | 459,397.9 |       5.979 ns |      15.00 |    1 | No       | 0.0038 |                    - |                - |          - |     176 B |
