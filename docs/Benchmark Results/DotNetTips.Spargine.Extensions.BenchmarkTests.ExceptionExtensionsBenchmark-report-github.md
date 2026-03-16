```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7058/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.104
  [Host] : .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  

```
| Method         | Mean | Error | StdErr | StdDev | Min | Q1 | Median | Q3 | Max | Op/s | CI99.9% Margin | Iterations | Rank | Baseline |
|--------------- |-----:|------:|-------:|-------:|----:|---:|-------:|---:|----:|-----:|---------------:|-----------:|-----:|--------- |
| GetAllMessages |   NA |    NA |     NA |     NA |  NA | NA |     NA | NA |  NA |   NA |             NA |         NA |    ? | No       |

Benchmarks with issues:
  ExceptionExtensionsBenchmark.GetAllMessages: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True)
