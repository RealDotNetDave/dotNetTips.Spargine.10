```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7184/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=**NEW**,IO  

```
| Method         | Mean            | Error        | StdDev       | StdErr      | Min             | Q1              | Median          | Q3              | Max             | Op/s  | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Exceptions | Allocated |
|--------------- |----------------:|-------------:|-------------:|------------:|----------------:|----------------:|----------------:|----------------:|----------------:|------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|-----------:|----------:|
| DeleteAllFiles | 34,214,143.3 ns | 358,920.7 ns | 335,734.7 ns | 86,686.3 ns | 33,498,450.0 ns | 34,008,900.0 ns | 34,286,750.0 ns | 34,454,500.0 ns | 34,626,850.0 ns | 29.23 |   -43,335.7 ns |      15.00 |    2.236 |  2.000 |  -0.7145 |    1 | *            | No       |     244 B |          - |  10.37 KB |
