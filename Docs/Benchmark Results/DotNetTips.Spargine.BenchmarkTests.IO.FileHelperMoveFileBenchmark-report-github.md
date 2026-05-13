```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7184/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=**NEW**,IO  

```
| Method   | Mean         | Error       | StdDev      | StdErr     | Min          | Q1           | Median       | Q3           | Max            | Op/s    | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Exceptions | Allocated |
|--------- |-------------:|------------:|------------:|-----------:|-------------:|-------------:|-------------:|-------------:|---------------:|--------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|-----------:|----------:|
| MoveFile | 932,533.0 ns | 18,514.3 ns | 36,110.6 ns | 5,267.3 ns | 851,650.0 ns | 914,700.0 ns | 925,350.0 ns | 948,850.0 ns | 1,028,350.0 ns | 1,072.3 |    -2,610.1 ns |      47.00 |    3.090 |  2.000 |   0.4267 |    1 | *            | No       |     604 B |          - |     696 B |
