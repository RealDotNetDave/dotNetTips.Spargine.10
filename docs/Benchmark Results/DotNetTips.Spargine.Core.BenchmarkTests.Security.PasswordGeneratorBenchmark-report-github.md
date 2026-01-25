```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.6809/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.102
  [Host]     : .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=Encryption,**NEW**  

```
| Method           | Mean       | Error    | StdDev   | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s      | CI99.9% Margin | Iterations | Rank | Baseline | Gen0   | Completed Work Items | Lock Contentions | Exceptions | Allocated |
|----------------- |-----------:|---------:|---------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------------:|-----------:|-----:|--------- |-------:|---------------------:|-----------------:|-----------:|----------:|
| GeneratePassword | 1,125.2 ns | 12.54 ns | 11.73 ns | 3.03 ns | 1,104.8 ns | 1,116.9 ns | 1,128.0 ns | 1,131.7 ns | 1,142.0 ns | 888,757.2 |       5.986 ns |      15.00 |    1 | No       | 0.0057 |                    - |                - |          - |     176 B |
