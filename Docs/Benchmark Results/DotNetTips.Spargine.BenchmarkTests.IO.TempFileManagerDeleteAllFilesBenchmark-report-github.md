```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7725/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=IO  

```
| Method         | FileCount | Mean             | Error          | StdDev         | StdErr       | Min              | Q1               | Median           | Q3               | Max              | Op/s    | CI99.9% Margin | Iterations | Baseline | Exceptions | Allocated |
|--------------- |---------- |-----------------:|---------------:|---------------:|-------------:|-----------------:|-----------------:|-----------------:|-----------------:|-----------------:|--------:|---------------:|-----------:|--------- |-----------:|----------:|
| DeleteAllFiles | 10        |   1,681,157.4 ns |    33,373.6 ns |    65,092.7 ns |   9,494.7 ns |   1,534,200.0 ns |   1,636,950.0 ns |   1,686,600.0 ns |   1,727,700.0 ns |   1,808,200.0 ns | 594.828 |    -4,723.9 ns |      47.00 | No       |          - |   8.84 KB |
| DeleteAllFiles | 100       |  13,706,292.9 ns |   260,146.2 ns |   230,612.8 ns |  61,633.9 ns |  13,233,550.0 ns |  13,579,575.0 ns |  13,744,950.0 ns |  13,843,675.0 ns |  14,070,950.0 ns |  72.959 |   -30,809.9 ns |      14.00 | No       |          - |  10.95 KB |
| DeleteAllFiles | 1000      | 138,808,070.8 ns | 2,741,824.5 ns | 3,565,146.6 ns | 727,732.5 ns | 134,443,850.0 ns | 136,212,425.0 ns | 138,246,350.0 ns | 140,164,875.0 ns | 148,033,750.0 ns |   7.204 |  -363,854.3 ns |      24.00 | No       |          - |  32.04 KB |
