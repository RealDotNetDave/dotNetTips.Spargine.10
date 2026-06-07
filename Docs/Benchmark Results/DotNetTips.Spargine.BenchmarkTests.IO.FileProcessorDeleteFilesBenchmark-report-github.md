```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7291/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.204
  [Host]     : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=**NEW**,IO  

```
| Method      | Mean           | Error       | StdDev       | StdErr      | Min            | Q1             | Median         | Q3             | Max            | Op/s  | CI99.9% Margin | Iterations | Baseline | Exceptions | Code Size | Allocated |
|------------ |---------------:|------------:|-------------:|------------:|---------------:|---------------:|---------------:|---------------:|---------------:|------:|---------------:|-----------:|--------- |-----------:|----------:|----------:|
| DeleteFiles | 4,155,285.1 ns | 77,754.9 ns | 195,071.9 ns | 22,676.6 ns | 3,894,450.0 ns | 4,022,800.0 ns | 4,097,050.0 ns | 4,236,975.0 ns | 4,699,850.0 ns | 240.7 |   -11,301.3 ns |      74.00 | No       |          - |   9,605 B |   3.23 KB |
