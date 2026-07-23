```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7548/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.204
  [Host]     : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=Database  

```
| Method                                | Mean           | Error       | StdDev       | StdErr      | Median         | Min            | Q1             | Q3             | Max            | Op/s    | CI99.9% Margin | Iterations | Baseline | Exceptions | Code Size | Allocated |
|-------------------------------------- |---------------:|------------:|-------------:|------------:|---------------:|---------------:|---------------:|---------------:|---------------:|--------:|---------------:|-----------:|--------- |-----------:|----------:|----------:|
| **&#39;GetRecordCountAsync: no predicate&#39;**   |   **278,625.6 ns** | **16,019.8 ns** |  **42,482.2 ns** |  **4,691.4 ns** |   **273,700.0 ns** |   **213,400.0 ns** |   **258,750.0 ns** |   **289,525.0 ns** |   **427,400.0 ns** | **3,589.0** |    **-2,304.7 ns** |      **82.00** | **No**       |          **-** |     **296 B** |   **7.23 KB** |
| **&#39;GetRecordCountAsync: with predicate&#39;** |   **361,069.3 ns** | **11,814.4 ns** |  **32,540.3 ns** |  **3,468.8 ns** |   **362,700.0 ns** |   **286,900.0 ns** |   **341,000.0 ns** |   **380,925.0 ns** |   **455,800.0 ns** | **2,769.6** |    **-1,690.4 ns** |      **88.00** | **No**       |          **-** |     **296 B** |   **6.27 KB** |
| **&#39;HasRecordsAsync: no predicate&#39;**       |   **286,607.1 ns** |  **9,373.2 ns** |  **25,180.4 ns** |  **2,747.4 ns** |   **288,200.0 ns** |   **234,500.0 ns** |   **274,775.0 ns** |   **301,725.0 ns** |   **354,700.0 ns** | **3,489.1** |    **-1,331.7 ns** |      **84.00** | **No**       |          **-** |     **296 B** |   **4.73 KB** |
| **&#39;HasRecordsAsync: with predicate&#39;**     |   **370,578.7 ns** | **13,431.6 ns** |  **36,768.7 ns** |  **3,942.0 ns** |   **369,850.0 ns** |   **296,950.0 ns** |   **350,350.0 ns** |   **388,000.0 ns** |   **471,750.0 ns** | **2,698.5** |    **-1,927.5 ns** |      **87.00** | **No**       |          **-** |     **296 B** |   **6.29 KB** |
| **AddAndSaveAsync**                       | **2,185,364.8 ns** | **76,986.2 ns** | **212,042.4 ns** | **22,603.8 ns** | **2,112,550.0 ns** | **1,929,750.0 ns** | **2,059,400.0 ns** | **2,227,350.0 ns** | **2,852,850.0 ns** |   **457.6** |   **-11,257.9 ns** |      **88.00** | **No**       |          **-** |     **296 B** | **122.92 KB** |
| **DeleteAndSaveAsync**                    |             **NA** |          **NA** |           **NA** |          **NA** |             **NA** |             **NA** |             **NA** |             **NA** |             **NA** |      **NA** |             **NA** |         **NA** | **No**       |         **NA** |        **NA** |        **NA** |

Benchmarks with issues:
  DbContextExtensionsBenchmark.DeleteAndSaveAsync: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1)
