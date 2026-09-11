```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7725/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=IO  

```
| Method    | Mean             | Error          | StdDev         | StdErr       | Min              | Q1               | Median           | Q3               | Max              | Op/s  | CI99.9% Margin | Iterations | Baseline | Code Size | Exceptions | Allocated |
|---------- |-----------------:|---------------:|---------------:|-------------:|-----------------:|-----------------:|-----------------:|-----------------:|-----------------:|------:|---------------:|-----------:|--------- |----------:|-----------:|----------:|
| MoveFiles | 178,140,064.3 ns | 1,942,789.5 ns | 1,722,232.3 ns | 460,285.9 ns | 174,952,350.0 ns | 177,070,775.0 ns | 178,771,250.0 ns | 179,056,225.0 ns | 180,359,350.0 ns | 5.614 |  -230,136.0 ns |      14.00 | No       |     756 B |          - | 224.09 KB |
