```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7725/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=IO  

```
| Method   | Mean         | Error       | StdDev       | StdErr      | Median       | Min          | Q1           | Q3           | Max            | Op/s    | CI99.9% Margin | Iterations | Baseline | Code Size | Exceptions | Allocated |
|--------- |-------------:|------------:|-------------:|------------:|-------------:|-------------:|-------------:|-------------:|---------------:|--------:|---------------:|-----------:|--------- |----------:|-----------:|----------:|
| MoveFile | 911,073.3 ns | 39,210.8 ns | 106,675.9 ns | 11,503.2 ns | 869,750.0 ns | 795,300.0 ns | 847,000.0 ns | 924,000.0 ns | 1,257,600.0 ns | 1,097.6 |    -5,708.6 ns |      86.00 | No       |     580 B |          - |     696 B |
