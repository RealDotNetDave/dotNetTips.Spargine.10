```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7548/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.302
  [Host]     : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=Serialization  

```
| Method          | Mean | Error | StdErr | StdDev | Min | Q1 | Median | Q3 | Max | Op/s | CI99.9% Margin | Iterations | Baseline |
|---------------- |-----:|------:|-------:|-------:|----:|---:|-------:|---:|----:|-----:|---------------:|-----------:|--------- |
| FromMessagePack |   NA |    NA |     NA |     NA |  NA | NA |     NA | NA |  NA |   NA |             NA |         NA | No       |

Benchmarks with issues:
  MessagePackExtensionsBenchmark.FromMessagePack: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True)
