```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7184/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=**NEW**,IO  

```
| Method         | Mean            | Error        | StdDev         | StdErr       | Min             | Q1              | Median          | Q3              | Max             | Op/s  | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Code Size | Allocated |
|--------------- |----------------:|-------------:|---------------:|-------------:|----------------:|----------------:|----------------:|----------------:|----------------:|------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|----------:|----------:|
| DeleteAllFiles | 35,503,760.3 ns | 704,917.5 ns | 1,033,259.0 ns | 191,871.4 ns | 34,152,350.0 ns | 34,735,150.0 ns | 35,400,450.0 ns | 35,881,850.0 ns | 38,858,250.0 ns | 28.17 |   -95,921.2 ns |      29.00 |    4.794 |  2.000 |    1.248 |    1 | *            | No       |          - |     274 B |  10.37 KB |
