```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7417/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.204
  [Host]     : .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=**NEW**,IO  

```
| Method         | Mean            | Error        | StdDev       | StdErr       | Min             | Q1              | Median          | Q3              | Max             | Op/s  | CI99.9% Margin | Iterations | Baseline | Code Size | Exceptions | Allocated |
|--------------- |----------------:|-------------:|-------------:|-------------:|----------------:|----------------:|----------------:|----------------:|----------------:|------:|---------------:|-----------:|--------- |----------:|-----------:|----------:|
| DeleteAllFiles | 34,186,138.5 ns | 593,698.6 ns | 495,765.2 ns | 137,500.5 ns | 33,450,200.0 ns | 33,822,800.0 ns | 34,101,900.0 ns | 34,421,700.0 ns | 35,030,100.0 ns | 29.25 |   -68,743.8 ns |      13.00 | No       |     248 B |          - |   6.13 KB |
