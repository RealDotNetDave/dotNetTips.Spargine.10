```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7184/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=**NEW**,IO  

```
| Method                    | Mean                | Error              | StdDev              | StdErr             | Min              | Q1               | Median              | Q3                  | Max                 | Op/s   | CI99.9% Margin    | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Gen0      | Exceptions | Code Size | Allocated |
|-------------------------- |--------------------:|-------------------:|--------------------:|-------------------:|-----------------:|-----------------:|--------------------:|--------------------:|--------------------:|-------:|------------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|-----------:|----------:|----------:|
| MoveFilesWithOriginalPath | 20,313,582,731.0 ns | 5,435,070,778.1 ns | 16,025,429,980.2 ns | 1,602,542,998.0 ns | 129,392,550.0 ns | 144,146,975.0 ns | 21,046,405,150.0 ns | 33,683,401,625.0 ns | 47,852,983,150.0 ns | 0.0492 | -801,271,449.0 ns |      100.0 |    1.657 |  3.484 |   0.0096 |    1 | *            | No       | 1000.0000 |   256.0000 |  14,287 B | 160.39 MB |
