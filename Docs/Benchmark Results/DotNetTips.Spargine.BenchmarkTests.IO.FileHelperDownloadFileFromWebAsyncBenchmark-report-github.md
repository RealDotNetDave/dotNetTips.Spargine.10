```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7548/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.302
  [Host]     : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=IO  

```
| Method                   | Mean           | Error       | StdDev       | StdErr      | Min            | Q1             | Median         | Q3             | Max            | Op/s  | CI99.9% Margin | Iterations | Baseline | Exceptions | Code Size | Allocated |
|------------------------- |---------------:|------------:|-------------:|------------:|---------------:|---------------:|---------------:|---------------:|---------------:|------:|---------------:|-----------:|--------- |-----------:|----------:|----------:|
| DownloadFileFromWebAsync | 1,176,288.9 ns | 39,918.8 ns | 105,162.1 ns | 11,684.7 ns | 1,040,700.0 ns | 1,100,500.0 ns | 1,145,600.0 ns | 1,219,800.0 ns | 1,498,300.0 ns | 850.1 |    -5,801.8 ns |      81.00 | No       |          - |     296 B |  89.84 KB |
