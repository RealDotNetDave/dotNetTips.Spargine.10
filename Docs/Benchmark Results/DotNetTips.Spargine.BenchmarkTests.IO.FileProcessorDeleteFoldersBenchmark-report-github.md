```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7725/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=IO  

```
| Method        | Mean           | Error       | StdDev       | StdErr      | Median         | Min            | Q1             | Q3             | Max            | Op/s  | CI99.9% Margin | Iterations | Baseline | Exceptions | Allocated |
|-------------- |---------------:|------------:|-------------:|------------:|---------------:|---------------:|---------------:|---------------:|---------------:|------:|---------------:|-----------:|--------- |-----------:|----------:|
| DeleteFolders | 2,079,888.1 ns | 74,372.7 ns | 199,797.4 ns | 21,799.7 ns | 2,001,100.0 ns | 1,893,700.0 ns | 1,967,375.0 ns | 2,114,825.0 ns | 2,771,800.0 ns | 480.8 |   -10,857.8 ns |      84.00 | No       |          - |   16.2 KB |
