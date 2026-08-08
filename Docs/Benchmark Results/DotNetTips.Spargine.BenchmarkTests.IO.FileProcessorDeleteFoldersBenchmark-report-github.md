```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7548/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.302
  [Host]     : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=IO  

```
| Method        | Mean           | Error       | StdDev       | StdErr      | Median         | Min            | Q1             | Q3             | Max            | Op/s  | CI99.9% Margin | Iterations | Baseline | Exceptions | Allocated |
|-------------- |---------------:|------------:|-------------:|------------:|---------------:|---------------:|---------------:|---------------:|---------------:|------:|---------------:|-----------:|--------- |-----------:|----------:|
| DeleteFolders | 1,978,363.1 ns | 63,104.0 ns | 169,524.9 ns | 18,496.7 ns | 1,921,550.0 ns | 1,816,400.0 ns | 1,872,025.0 ns | 2,002,375.0 ns | 2,588,000.0 ns | 505.5 |    -9,206.3 ns |      84.00 | No       |          - |   16.2 KB |
