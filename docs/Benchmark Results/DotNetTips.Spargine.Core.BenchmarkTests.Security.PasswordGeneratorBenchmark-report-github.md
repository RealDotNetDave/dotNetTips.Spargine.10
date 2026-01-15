```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.6691/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.102
  [Host]     : .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=Encryption,**NEW**  

```
| Method           | Mean       | Error   | StdDev  | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s      | CI99.9% Margin | Iterations | Rank | Baseline | Exceptions | Completed Work Items | Lock Contentions | Gen0   | Allocated |
|----------------- |-----------:|--------:|--------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------------:|-----------:|-----:|--------- |-----------:|---------------------:|-----------------:|-------:|----------:|
| GeneratePassword | 1,136.3 ns | 9.75 ns | 8.64 ns | 2.31 ns | 1,128.3 ns | 1,130.0 ns | 1,134.2 ns | 1,137.4 ns | 1,155.3 ns | 880,036.0 |       5.846 ns |      14.00 |    1 | No       |          - |                    - |                - | 0.0057 |     176 B |
