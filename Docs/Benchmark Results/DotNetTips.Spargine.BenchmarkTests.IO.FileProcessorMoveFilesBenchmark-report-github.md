```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7548/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.302
  [Host]     : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=IO  

```
| Method    | Mean             | Error          | StdDev         | StdErr       | Min              | Q1               | Median           | Q3               | Max              | Op/s  | CI99.9% Margin | Iterations | Baseline | Exceptions | Code Size | Allocated |
|---------- |-----------------:|---------------:|---------------:|-------------:|-----------------:|-----------------:|-----------------:|-----------------:|-----------------:|------:|---------------:|-----------:|--------- |-----------:|----------:|----------:|
| MoveFiles | 177,140,615.4 ns | 2,294,664.5 ns | 1,916,148.7 ns | 531,444.0 ns | 173,761,400.0 ns | 175,776,800.0 ns | 177,341,800.0 ns | 178,387,300.0 ns | 180,879,300.0 ns | 5.645 |  -265,715.5 ns |      13.00 | No       |          - |     756 B | 224.09 KB |
