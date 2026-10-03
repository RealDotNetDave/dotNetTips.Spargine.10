```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7725/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=IO  

```
| Method         | FileCount | Mean             | Error          | StdDev         | StdErr       | Min              | Q1               | Median           | Q3               | Max              | Op/s    | CI99.9% Margin | Iterations | Baseline | Exceptions | Code Size | Allocated |
|--------------- |---------- |-----------------:|---------------:|---------------:|-------------:|-----------------:|-----------------:|-----------------:|-----------------:|-----------------:|--------:|---------------:|-----------:|--------- |-----------:|----------:|----------:|
| DeleteAllFiles | 10        |   1,697,172.4 ns |    48,639.1 ns |   131,498.6 ns |  14,263.0 ns |   1,493,550.0 ns |   1,610,850.0 ns |   1,684,450.0 ns |   1,754,850.0 ns |   2,157,750.0 ns | 589.215 |    -7,089.0 ns |      85.00 | No       |          - |   8,746 B |   8.81 KB |
| DeleteAllFiles | 100       |  13,835,223.5 ns |   275,182.7 ns |   444,368.8 ns |  76,208.6 ns |  13,189,000.0 ns |  13,501,925.0 ns |  13,753,000.0 ns |  14,070,725.0 ns |  14,940,800.0 ns |  72.279 |   -38,087.3 ns |      34.00 | No       |          - |        NA |  10.95 KB |
| DeleteAllFiles | 1000      | 139,165,778.1 ns | 2,261,609.3 ns | 3,521,053.5 ns | 622,440.2 ns | 133,622,150.0 ns | 137,117,225.0 ns | 138,423,200.0 ns | 141,244,350.0 ns | 150,393,250.0 ns |   7.186 |  -311,204.1 ns |      32.00 | No       |          - |        NA |  32.02 KB |
