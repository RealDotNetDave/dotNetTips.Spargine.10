```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7725/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=IO  

```
| Method        | Mean           | Error        | StdDev       | StdErr      | Median         | Min            | Q1             | Q3             | Max            | Op/s  | CI99.9% Margin | Iterations | Baseline | Exceptions | Allocated |
|-------------- |---------------:|-------------:|-------------:|------------:|---------------:|---------------:|---------------:|---------------:|---------------:|------:|---------------:|-----------:|--------- |-----------:|----------:|
| DeleteFolders | 2,228,658.1 ns | 153,690.4 ns | 450,747.3 ns | 45,301.8 ns | 2,001,450.0 ns | 1,800,850.0 ns | 1,917,750.0 ns | 2,630,400.0 ns | 3,705,450.0 ns | 448.7 |   -22,601.4 ns |      99.00 | No       |          - |   16.2 KB |
