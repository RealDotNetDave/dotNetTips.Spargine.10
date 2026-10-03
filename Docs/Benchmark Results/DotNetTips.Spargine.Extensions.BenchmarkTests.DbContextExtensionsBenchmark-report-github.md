```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7725/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  Job-JZFTPE : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
InvocationCount=1  UnrollFactor=1  Categories=Database  

```
| Method                                | Mean           | Error       | StdDev      | StdErr      | Min            | Q1             | Median         | Q3             | Max            | Op/s    | CI99.9% Margin | Iterations | Baseline | Code Size | Exceptions | Allocated |
|-------------------------------------- |---------------:|------------:|------------:|------------:|---------------:|---------------:|---------------:|---------------:|---------------:|--------:|---------------:|-----------:|--------- |----------:|-----------:|----------:|
| **&#39;GetRecordCountAsync: no predicate&#39;**   |   **265,837.6 ns** |  **7,023.4 ns** | **19,461.9 ns** |  **2,063.0 ns** |   **215,850.0 ns** |   **252,150.0 ns** |   **265,350.0 ns** |   **277,750.0 ns** |   **321,850.0 ns** | **3,761.7** |      **-987.0 ns** |      **89.00** | **No**       |     **296 B** |          **-** |   **7.23 KB** |
| **&#39;GetRecordCountAsync: with predicate&#39;** |   **361,278.4 ns** | **12,496.1 ns** | **34,418.0 ns** |  **3,669.0 ns** |   **297,150.0 ns** |   **335,600.0 ns** |   **360,750.0 ns** |   **382,950.0 ns** |   **446,150.0 ns** | **2,767.9** |    **-1,790.5 ns** |      **88.00** | **No**       |     **296 B** |          **-** |   **6.27 KB** |
| **&#39;HasRecordsAsync: no predicate&#39;**       |   **291,714.1 ns** |  **8,844.1 ns** | **23,910.6 ns** |  **2,593.5 ns** |   **237,500.0 ns** |   **279,700.0 ns** |   **292,400.0 ns** |   **304,900.0 ns** |   **354,800.0 ns** | **3,428.0** |    **-1,254.2 ns** |      **85.00** | **No**       |     **296 B** |          **-** |   **4.73 KB** |
| **&#39;HasRecordsAsync: with predicate&#39;**     |   **368,368.2 ns** | **12,862.3 ns** | **34,773.9 ns** |  **3,771.8 ns** |   **303,200.0 ns** |   **343,500.0 ns** |   **373,200.0 ns** |   **389,200.0 ns** |   **453,900.0 ns** | **2,714.7** |    **-1,843.4 ns** |      **85.00** | **No**       |     **296 B** |          **-** |   **6.29 KB** |
| **AddAndSaveAsync**                       | **2,065,644.3 ns** | **39,988.5 ns** | **65,702.2 ns** | **11,105.7 ns** | **1,959,150.0 ns** | **2,025,400.0 ns** | **2,052,850.0 ns** | **2,084,950.0 ns** | **2,263,850.0 ns** |   **484.1** |    **-5,535.4 ns** |      **35.00** | **No**       |     **296 B** |          **-** | **122.92 KB** |
| **DeleteAndSaveAsync**                    |             **NA** |          **NA** |          **NA** |          **NA** |             **NA** |             **NA** |             **NA** |             **NA** |             **NA** |      **NA** |             **NA** |         **NA** | **No**       |        **NA** |         **NA** |        **NA** |

Benchmarks with issues:
  DbContextExtensionsBenchmark.DeleteAndSaveAsync: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1)
