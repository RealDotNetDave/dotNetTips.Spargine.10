```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7417/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.204
  [Host]     : .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=**NEW**,IO  

```
| Method    | Mean             | Error          | StdDev         | StdErr       | Min              | Q1               | Median           | Q3               | Max              | Op/s  | CI99.9% Margin | Iterations | Baseline | Code Size | Exceptions | Allocated |
|---------- |-----------------:|---------------:|---------------:|-------------:|-----------------:|-----------------:|-----------------:|-----------------:|-----------------:|------:|---------------:|-----------:|--------- |----------:|-----------:|----------:|
| MoveFiles | 169,871,521.4 ns | 2,705,754.7 ns | 2,398,581.0 ns | 641,047.7 ns | 167,082,900.0 ns | 167,730,875.0 ns | 169,453,950.0 ns | 171,580,250.0 ns | 174,685,000.0 ns | 5.887 |  -320,516.9 ns |      14.00 | No       |     756 B |          - | 224.09 KB |
