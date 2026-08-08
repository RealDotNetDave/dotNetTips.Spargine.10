```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7548/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.302
  [Host]     : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=IO  

```
| Method   | Mean         | Error       | StdDev      | StdErr      | Median       | Min          | Q1           | Q3           | Max            | Op/s    | CI99.9% Margin | Iterations | Baseline | Exceptions | Code Size | Allocated |
|--------- |-------------:|------------:|------------:|------------:|-------------:|-------------:|-------------:|-------------:|---------------:|--------:|---------------:|-----------:|--------- |-----------:|----------:|----------:|
| MoveFile | 919,318.4 ns | 34,286.4 ns | 93,858.5 ns | 10,062.7 ns | 885,500.0 ns | 834,000.0 ns | 860,450.0 ns | 923,750.0 ns | 1,209,300.0 ns | 1,087.8 |    -4,987.8 ns |      87.00 | No       |          - |     580 B |     696 B |
