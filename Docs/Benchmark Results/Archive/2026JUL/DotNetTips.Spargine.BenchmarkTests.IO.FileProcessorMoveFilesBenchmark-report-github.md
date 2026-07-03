```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7291/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.204
  [Host]     : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=**NEW**,IO  

```
| Method    | Mean             | Error          | StdDev         | StdErr       | Min              | Q1               | Median           | Q3               | Max              | Op/s  | CI99.9% Margin | Iterations | Baseline | Exceptions | Allocated |
|---------- |-----------------:|---------------:|---------------:|-------------:|-----------------:|-----------------:|-----------------:|-----------------:|-----------------:|------:|---------------:|-----------:|--------- |-----------:|----------:|
| MoveFiles | 172,308,064.3 ns | 2,016,351.4 ns | 1,787,443.0 ns | 477,714.2 ns | 169,803,500.0 ns | 170,959,450.0 ns | 171,701,350.0 ns | 173,560,075.0 ns | 175,150,400.0 ns | 5.804 |  -238,850.1 ns |      14.00 | No       |          - | 224.09 KB |
