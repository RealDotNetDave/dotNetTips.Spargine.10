```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7058/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.201
  [Host]     : .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=Encryption,**NEW**  

```
| Method           | Mean       | Error   | StdDev  | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s      | CI99.9% Margin | Iterations | Rank | Baseline | Exceptions |
|----------------- |-----------:|--------:|--------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------------:|-----------:|-----:|--------- |-----------:|
| GeneratePassword | 1,156.7 ns | 2.97 ns | 2.77 ns | 0.72 ns | 1,151.7 ns | 1,154.4 ns | 1,157.0 ns | 1,159.1 ns | 1,160.5 ns | 864,496.8 |       7.142 ns |      15.00 |    1 | No       |          - |
