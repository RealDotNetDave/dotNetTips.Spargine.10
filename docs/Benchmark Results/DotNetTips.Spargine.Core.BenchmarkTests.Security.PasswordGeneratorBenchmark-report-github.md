```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.6937/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.103
  [Host]     : .NET 10.0.3 (10.0.3, 10.0.326.7603), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.3 (10.0.3, 10.0.326.7603), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=Encryption,**NEW**  

```
| Method           | Mean       | Error   | StdDev  | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s      | CI99.9% Margin | Iterations | Rank | Baseline | Completed Work Items | Lock Contentions | Gen0   | Exceptions | Allocated |
|----------------- |-----------:|--------:|--------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------------:|-----------:|-----:|--------- |---------------------:|-----------------:|-------:|-----------:|----------:|
| GeneratePassword | 1,134.0 ns | 7.80 ns | 6.91 ns | 1.85 ns | 1,122.2 ns | 1,130.1 ns | 1,133.7 ns | 1,138.7 ns | 1,147.5 ns | 881,804.6 |       6.077 ns |      14.00 |    1 | No       |                    - |                - | 0.0057 |          - |     176 B |
