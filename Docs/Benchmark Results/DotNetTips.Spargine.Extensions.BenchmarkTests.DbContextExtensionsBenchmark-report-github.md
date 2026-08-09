```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7548/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.302
  [Host]     : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=Database  

```
| Method                                | Mean           | Error        | StdDev       | StdErr      | Median         | Min            | Q1             | Q3             | Max            | Op/s    | CI99.9% Margin | Iterations | Baseline | Exceptions | Code Size | Allocated |
|-------------------------------------- |---------------:|-------------:|-------------:|------------:|---------------:|---------------:|---------------:|---------------:|---------------:|--------:|---------------:|-----------:|--------- |-----------:|----------:|----------:|
| **&#39;GetRecordCountAsync: no predicate&#39;**   |   **271,113.1 ns** |   **9,774.0 ns** |  **26,257.2 ns** |  **2,864.9 ns** |   **271,750.0 ns** |   **219,700.0 ns** |   **259,400.0 ns** |   **282,350.0 ns** |   **334,200.0 ns** | **3,688.5** |    **-1,390.4 ns** |      **84.00** | **No**       |          **-** |     **296 B** |   **7.23 KB** |
| **&#39;GetRecordCountAsync: with predicate&#39;** |   **368,583.9 ns** |  **14,500.5 ns** |  **39,694.9 ns** |  **4,255.7 ns** |   **366,400.0 ns** |   **303,300.0 ns** |   **348,500.0 ns** |   **389,400.0 ns** |   **489,000.0 ns** | **2,713.1** |    **-2,084.4 ns** |      **87.00** | **No**       |          **-** |     **296 B** |   **6.27 KB** |
| **&#39;HasRecordsAsync: no predicate&#39;**       |   **288,158.0 ns** |  **10,136.7 ns** |  **27,919.5 ns** |  **2,976.2 ns** |   **289,950.0 ns** |   **232,550.0 ns** |   **273,475.0 ns** |   **302,000.0 ns** |   **361,250.0 ns** | **3,470.3** |    **-1,444.1 ns** |      **88.00** | **No**       |          **-** |     **296 B** |   **4.73 KB** |
| **&#39;HasRecordsAsync: with predicate&#39;**     |   **368,646.9 ns** |  **14,494.7 ns** |  **38,184.8 ns** |  **4,242.8 ns** |   **369,000.0 ns** |   **303,600.0 ns** |   **347,500.0 ns** |   **387,200.0 ns** |   **492,500.0 ns** | **2,712.6** |    **-2,080.9 ns** |      **81.00** | **No**       |          **-** |     **296 B** |   **6.29 KB** |
| **AddAndSaveAsync**                       | **2,429,894.4 ns** | **136,701.4 ns** | **400,921.5 ns** | **40,294.1 ns** | **2,319,250.0 ns** | **1,958,750.0 ns** | **2,100,950.0 ns** | **2,636,450.0 ns** | **3,502,350.0 ns** |   **411.5** |   **-20,097.6 ns** |      **99.00** | **No**       |          **-** |     **224 B** | **122.92 KB** |
| **DeleteAndSaveAsync**                    |             **NA** |           **NA** |           **NA** |          **NA** |             **NA** |             **NA** |             **NA** |             **NA** |             **NA** |      **NA** |             **NA** |         **NA** | **No**       |         **NA** |        **NA** |        **NA** |

Benchmarks with issues:
  DbContextExtensionsBenchmark.DeleteAndSaveAsync: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1)
