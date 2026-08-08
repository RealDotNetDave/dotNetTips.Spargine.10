```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7548/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.302
  [Host]     : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=IO  

```
| Method     | Mean         | Error       | StdDev      | StdErr     | Min          | Q1           | Median       | Q3           | Max          | Op/s    | CI99.9% Margin | Iterations | Baseline | Code Size | Exceptions | Allocated |
|----------- |-------------:|------------:|------------:|-----------:|-------------:|-------------:|-------------:|-------------:|-------------:|--------:|---------------:|-----------:|--------- |----------:|-----------:|----------:|
| DeleteFile | 404,190.7 ns | 20,191.1 ns | 54,931.4 ns | 5,923.4 ns | 299,950.0 ns | 369,250.0 ns | 394,500.0 ns | 422,650.0 ns | 592,650.0 ns | 2,474.1 |    -2,918.7 ns |      86.00 | No       |     124 B |          - |     192 B |
