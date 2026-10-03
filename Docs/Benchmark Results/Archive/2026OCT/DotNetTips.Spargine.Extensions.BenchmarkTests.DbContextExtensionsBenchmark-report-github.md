```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7725/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=Database  

```
| Method                                | Mean           | Error       | StdDev       | StdErr      | Median         | Min            | Q1             | Q3             | Max            | Op/s    | CI99.9% Margin | Iterations | Baseline | Exceptions | Code Size | Allocated |
|-------------------------------------- |---------------:|------------:|-------------:|------------:|---------------:|---------------:|---------------:|---------------:|---------------:|--------:|---------------:|-----------:|--------- |-----------:|----------:|----------:|
| **&#39;GetRecordCountAsync: no predicate&#39;**   |   **271,767.1 ns** | **11,643.7 ns** |  **30,877.3 ns** |  **3,409.8 ns** |   **276,400.0 ns** |   **202,400.0 ns** |   **254,950.0 ns** |   **289,475.0 ns** |   **356,300.0 ns** | **3,679.6** |    **-1,663.9 ns** |      **82.00** | **No**       |          **-** |     **296 B** |   **7.23 KB** |
| **&#39;GetRecordCountAsync: with predicate&#39;** |   **371,024.4 ns** | **13,034.7 ns** |  **35,462.0 ns** |  **3,824.0 ns** |   **370,350.0 ns** |   **300,350.0 ns** |   **347,350.0 ns** |   **395,250.0 ns** |   **472,550.0 ns** | **2,695.2** |    **-1,869.0 ns** |      **86.00** | **No**       |          **-** |     **296 B** |   **6.27 KB** |
| **&#39;HasRecordsAsync: no predicate&#39;**       |   **297,925.9 ns** | **10,151.7 ns** |  **27,790.2 ns** |  **2,979.4 ns** |   **296,650.0 ns** |   **242,150.0 ns** |   **282,300.0 ns** |   **314,350.0 ns** |   **365,850.0 ns** | **3,356.5** |    **-1,446.2 ns** |      **87.00** | **No**       |          **-** |     **296 B** |   **4.73 KB** |
| **&#39;HasRecordsAsync: with predicate&#39;**     |   **361,086.9 ns** | **12,863.4 ns** |  **34,556.7 ns** |  **3,770.4 ns** |   **365,600.0 ns** |   **291,300.0 ns** |   **335,650.0 ns** |   **382,750.0 ns** |   **459,100.0 ns** | **2,769.4** |    **-1,843.2 ns** |      **84.00** | **No**       |          **-** |     **296 B** |   **6.29 KB** |
| **AddAndSaveAsync**                       | **2,142,181.8 ns** | **65,949.5 ns** | **181,644.1 ns** | **19,363.3 ns** | **2,085,550.0 ns** | **1,910,550.0 ns** | **2,020,400.0 ns** | **2,196,750.0 ns** | **2,713,750.0 ns** |   **466.8** |    **-9,637.7 ns** |      **88.00** | **No**       |          **-** |     **296 B** | **122.92 KB** |
| **DeleteAndSaveAsync**                    |             **NA** |          **NA** |           **NA** |          **NA** |             **NA** |             **NA** |             **NA** |             **NA** |             **NA** |      **NA** |             **NA** |         **NA** | **No**       |         **NA** |        **NA** |        **NA** |

Benchmarks with issues:
  DbContextExtensionsBenchmark.DeleteAndSaveAsync: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1)
