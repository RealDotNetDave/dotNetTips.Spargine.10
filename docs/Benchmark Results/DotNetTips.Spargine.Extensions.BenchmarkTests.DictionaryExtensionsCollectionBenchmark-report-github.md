```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7291/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.204
  [Host] : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=Collections  

```
| Method                       | Count | Mean | Error | StdErr | StdDev | Min | Q1 | Median | Q3 | Max | Op/s | CI99.9% Margin | Iterations | Baseline |
|----------------------------- |------ |-----:|------:|-------:|-------:|----:|---:|-------:|---:|----:|-----:|---------------:|-----------:|--------- |
| &#39;IsNotEmpty: With Predicate&#39; | 64    |   NA |    NA |     NA |     NA |  NA | NA |     NA | NA |  NA |   NA |             NA |         NA | No       |

Benchmarks with issues:
  DictionaryExtensionsCollectionBenchmark.'IsNotEmpty: With Predicate': Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True) [Count=64]
