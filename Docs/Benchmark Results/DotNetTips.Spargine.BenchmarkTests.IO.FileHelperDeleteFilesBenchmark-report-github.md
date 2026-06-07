```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7291/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.204
  [Host]     : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=**NEW**,IO  

```
| Method      | Mean            | Error        | StdDev       | StdErr       | Min             | Q1              | Median          | Q3              | Max             | Op/s  | CI99.9% Margin | Iterations | Baseline | Exceptions | Allocated |
|------------ |----------------:|-------------:|-------------:|-------------:|----------------:|----------------:|----------------:|----------------:|----------------:|------:|---------------:|-----------:|--------- |-----------:|----------:|
| DeleteFiles | 40,150,516.7 ns | 707,209.3 ns | 841,882.4 ns | 183,713.8 ns | 38,385,950.0 ns | 39,619,450.0 ns | 40,229,250.0 ns | 40,707,950.0 ns | 41,547,650.0 ns | 24.91 |   -91,846.4 ns |      21.00 | No       |          - |   4.13 KB |
