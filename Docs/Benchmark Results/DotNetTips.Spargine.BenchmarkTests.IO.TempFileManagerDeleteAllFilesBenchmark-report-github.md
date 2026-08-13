```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7548/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.302
  [Host]     : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=IO  

```
| Method         | FileCount | Mean             | Error          | StdDev         | StdErr       | Median           | Min              | Q1               | Q3               | Max              | Op/s    | CI99.9% Margin | Iterations | Baseline | Exceptions | Allocated |
|--------------- |---------- |-----------------:|---------------:|---------------:|-------------:|-----------------:|-----------------:|-----------------:|-----------------:|-----------------:|--------:|---------------:|-----------:|--------- |-----------:|----------:|
| DeleteAllFiles | 10        |   1,933,835.4 ns |   112,084.8 ns |   323,390.3 ns |  33,005.9 ns |   1,817,800.0 ns |   1,536,700.0 ns |   1,686,850.0 ns |   2,097,025.0 ns |   2,791,700.0 ns | 517.107 |   -16,454.9 ns |      96.00 | No       |          - |   8.84 KB |
| DeleteAllFiles | 100       |  13,515,070.4 ns |   266,937.0 ns |   374,208.5 ns |  72,016.5 ns |  13,386,200.0 ns |  13,093,300.0 ns |  13,301,850.0 ns |  13,676,050.0 ns |  14,479,800.0 ns |  73.991 |   -35,994.7 ns |      27.00 | No       |          - |  10.95 KB |
| DeleteAllFiles | 1000      | 137,960,642.9 ns | 2,753,442.0 ns | 2,440,854.6 ns | 652,345.8 ns | 138,063,900.0 ns | 133,851,050.0 ns | 136,653,300.0 ns | 138,914,550.0 ns | 143,722,150.0 ns |   7.248 |  -326,165.9 ns |      14.00 | No       |          - |  32.02 KB |
