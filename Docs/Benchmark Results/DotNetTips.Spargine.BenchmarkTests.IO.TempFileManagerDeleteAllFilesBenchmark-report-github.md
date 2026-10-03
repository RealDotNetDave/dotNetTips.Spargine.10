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
| DeleteAllFiles | 10        |   2,241,120.4 ns |   155,064.9 ns |   452,331.6 ns |  45,692.4 ns |   1,661,150.0 ns |   1,781,550.0 ns |   2,241,150.0 ns |   2,544,000.0 ns |   3,491,350.0 ns | 446.205 |   -22,797.2 ns |      98.00 | No       |          - |   8,280 B |   8.81 KB |
| DeleteAllFiles | 100       |  14,300,015.8 ns |   270,925.3 ns |   301,132.7 ns |  69,084.6 ns |  13,759,300.0 ns |  14,102,450.0 ns |  14,339,600.0 ns |  14,514,600.0 ns |  14,911,000.0 ns |  69.930 |   -34,532.8 ns |      19.00 | No       |          - |        NA |  10.95 KB |
| DeleteAllFiles | 1000      | 143,178,386.7 ns | 2,799,480.5 ns | 2,618,635.8 ns | 676,128.9 ns | 138,593,900.0 ns | 141,535,250.0 ns | 143,165,300.0 ns | 144,587,450.0 ns | 148,130,500.0 ns |   6.984 |  -338,056.9 ns |      15.00 | No       |          - |        NA |  32.02 KB |
