```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7548/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.302
  [Host]     : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  

```
| Method              | Mean       | Error    | StdDev   | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s      | CI99.9% Margin | Iterations | Return Value                                                                                           | Baseline | Gen0   | Exceptions | Allocated |
|-------------------- |-----------:|---------:|---------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------------:|-----------:|------------------------------------------------------------------------------------------------------- |--------- |-------:|-----------:|----------:|
| **BuildHmacBarcode**    | **2,305.7 ns** | **10.75 ns** |  **9.53 ns** | **2.55 ns** | **2,294.8 ns** | **2,300.3 ns** | **2,302.0 ns** | **2,307.3 ns** | **2,323.9 ns** | **433,704.6** |       **5.727 ns** |      **14.00** | **v=1|tid=TICKET-123456|pid=PERF-123456|e=1786063971|iss=dotNetTips|alg=H256|kid=k1|sig=YMQZ2SN4QP007HCC** | **No**       | **0.0381** |          **-** |   **1.19 KB** |
| **ValidateHmacBarcode** | **3,065.0 ns** | **12.89 ns** | **12.06 ns** | **3.11 ns** | **3,050.3 ns** | **3,055.6 ns** | **3,060.2 ns** | **3,073.7 ns** | **3,091.1 ns** | **326,260.0** |       **5.943 ns** |      **15.00** | **True**                                                                                                   | **No**       | **0.0839** |          **-** |   **2.57 KB** |
