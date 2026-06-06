```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7291/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.204
  [Host]     : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  

```
| Method                                                | Categories                    | Mean      | Error     | StdDev    | StdErr    | Min       | Q1        | Median    | Q3        | Max       | Op/s          | CI99.9% Margin | Iterations | Baseline | Exceptions | Gen0   | Code Size | Allocated |
|------------------------------------------------------ |------------------------------ |----------:|----------:|----------:|----------:|----------:|----------:|----------:|----------:|----------:|--------------:|---------------:|-----------:|--------- |-----------:|-------:|----------:|----------:|
| **&#39;Validating Collection: No Validation&#39;**                | **Validation,**FOR COMPARISON**** |  **2.039 ns** | **0.0289 ns** | **0.0271 ns** | **0.0070 ns** |  **1.996 ns** |  **2.010 ns** |  **2.046 ns** |  **2.055 ns** |  **2.078 ns** | **490,436,734.7** |       **7.497 ns** |      **15.00** | **No**       |          **-** |      **-** |      **47 B** |         **-** |
| **&#39;Validating Collection: Validation + Inlining&#39;**        | **Validation**                    |  **3.556 ns** | **0.0137 ns** | **0.0121 ns** | **0.0032 ns** |  **3.533 ns** |  **3.551 ns** |  **3.557 ns** |  **3.563 ns** |  **3.580 ns** | **281,238,993.8** |       **6.998 ns** |      **14.00** | **No**       |          **-** |      **-** |     **436 B** |         **-** |
| **&#39;Validating Collection: Validation&#39;**                   | **Validation**                    |  **3.480 ns** | **0.0242 ns** | **0.0226 ns** | **0.0058 ns** |  **3.428 ns** |  **3.474 ns** |  **3.484 ns** |  **3.498 ns** |  **3.509 ns** | **287,373,627.1** |       **7.497 ns** |      **15.00** | **No**       |          **-** |      **-** |     **437 B** |         **-** |
| **&#39;Validating Empty/Null String: No Validation&#39;**         | **Validation,**FOR COMPARISON**** |  **1.740 ns** | **0.0187 ns** | **0.0165 ns** | **0.0044 ns** |  **1.705 ns** |  **1.740 ns** |  **1.746 ns** |  **1.750 ns** |  **1.757 ns** | **574,872,057.4** |       **6.998 ns** |      **14.00** | **No**       |          **-** |      **-** |      **50 B** |         **-** |
| **&#39;Validating Empty/Null String: Validation + Inlining&#39;** | **Validation,**FOR COMPARISON**** |  **1.545 ns** | **0.0153 ns** | **0.0136 ns** | **0.0036 ns** |  **1.529 ns** |  **1.538 ns** |  **1.542 ns** |  **1.552 ns** |  **1.575 ns** | **647,052,990.1** |       **6.998 ns** |      **14.00** | **No**       |          **-** |      **-** |      **57 B** |         **-** |
| **&#39;Validating Empty/Null String: Validation&#39;**            | **Validation,**FOR COMPARISON**** |  **1.676 ns** | **0.0194 ns** | **0.0181 ns** | **0.0047 ns** |  **1.634 ns** |  **1.677 ns** |  **1.682 ns** |  **1.688 ns** |  **1.695 ns** | **596,530,385.1** |       **7.498 ns** |      **15.00** | **No**       |          **-** |      **-** |      **57 B** |         **-** |
| **ArgumentDefined**                                       | **Validation**                    | **19.537 ns** | **0.2074 ns** | **0.1940 ns** | **0.0501 ns** | **19.297 ns** | **19.407 ns** | **19.478 ns** | **19.620 ns** | **19.912 ns** |  **51,185,577.0** |       **7.475 ns** |      **15.00** | **No**       |          **-** | **0.0008** |   **2,291 B** |      **24 B** |
