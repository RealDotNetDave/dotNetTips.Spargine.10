```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7058/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.104
  [Host]     : .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=Encryption,**NEW**  

```
| Method           | Mean       | Error    | StdDev   | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s      | CI99.9% Margin | Iterations | Rank | Baseline | Gen0   | Completed Work Items | Lock Contentions | Exceptions | Allocated |
|----------------- |-----------:|---------:|---------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------------:|-----------:|-----:|--------- |-------:|---------------------:|-----------------:|-----------:|----------:|
| GeneratePassword | 1,138.0 ns | 13.23 ns | 12.38 ns | 3.20 ns | 1,118.8 ns | 1,130.2 ns | 1,139.5 ns | 1,142.4 ns | 1,160.0 ns | 878,744.8 |       5.902 ns |      15.00 |    1 | No       | 0.0057 |                    - |                - |          - |     176 B |
