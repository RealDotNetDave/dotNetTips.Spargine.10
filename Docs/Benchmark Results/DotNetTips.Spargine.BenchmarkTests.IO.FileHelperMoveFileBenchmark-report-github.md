```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7291/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.204
  [Host]     : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=**NEW**,IO  

```
| Method   | Mean         | Error       | StdDev      | StdErr     | Min          | Q1           | Median       | Q3           | Max          | Op/s    | CI99.9% Margin | Iterations | Baseline | Exceptions | Code Size | Allocated |
|--------- |-------------:|------------:|------------:|-----------:|-------------:|-------------:|-------------:|-------------:|-------------:|--------:|---------------:|-----------:|--------- |-----------:|----------:|----------:|
| MoveFile | 888,413.3 ns | 16,961.8 ns | 15,866.1 ns | 4,096.6 ns | 864,700.0 ns | 876,450.0 ns | 886,500.0 ns | 896,650.0 ns | 918,100.0 ns | 1,125.6 |    -2,040.8 ns |      15.00 | No       |          - |     604 B |     696 B |
