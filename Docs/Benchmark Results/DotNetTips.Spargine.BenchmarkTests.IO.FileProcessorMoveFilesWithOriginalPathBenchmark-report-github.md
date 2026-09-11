```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7725/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=IO  

```
| Method                    | Mean                | Error              | StdDev              | StdErr             | Min             | Q1              | Median              | Q3                  | Max                 | Op/s   | CI99.9% Margin    | Iterations | Baseline | Code Size | Gen0      | Exceptions | Allocated |
|-------------------------- |--------------------:|-------------------:|--------------------:|-------------------:|----------------:|----------------:|--------------------:|--------------------:|--------------------:|-------:|------------------:|-----------:|--------- |----------:|----------:|-----------:|----------:|
| MoveFilesWithOriginalPath | 20,837,498,930.0 ns | 5,523,337,618.5 ns | 16,285,686,769.7 ns | 1,628,568,677.0 ns | 82,991,000.0 ns | 91,766,775.0 ns | 22,067,296,650.0 ns | 34,184,252,575.0 ns | 48,554,126,500.0 ns | 0.0480 | -814,284,288.5 ns |      100.0 | No       |  11,747 B | 1000.0000 |   256.0000 | 128.48 MB |
