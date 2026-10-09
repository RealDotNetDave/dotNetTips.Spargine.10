```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7725/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  

```
| Method              | Mean       | Error   | StdDev  | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s      | CI99.9% Margin | Iterations | Return Value                                                                                           | Baseline | Exceptions | Gen0   | Allocated |
|-------------------- |-----------:|--------:|--------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------------:|-----------:|------------------------------------------------------------------------------------------------------- |--------- |-----------:|-------:|----------:|
| **BuildHmacBarcode**    | **2,356.3 ns** | **8.47 ns** | **7.07 ns** | **1.96 ns** | **2,347.6 ns** | **2,350.8 ns** | **2,353.3 ns** | **2,360.3 ns** | **2,369.1 ns** | **424,396.4** |       **5.519 ns** |      **13.00** | **v=1|tid=TICKET-123456|pid=PERF-123456|e=1791164607|iss=dotNetTips|alg=H256|kid=k1|sig=F3KQEHKSQA66HD2C** | **No**       |          **-** | **0.0381** |   **1.19 KB** |
| **ValidateHmacBarcode** | **2,976.4 ns** | **8.85 ns** | **7.39 ns** | **2.05 ns** | **2,966.6 ns** | **2,971.6 ns** | **2,972.9 ns** | **2,983.8 ns** | **2,989.8 ns** | **335,981.5** |       **5.476 ns** |      **13.00** | **True**                                                                                                   | **No**       |          **-** | **0.0801** |    **2.5 KB** |
