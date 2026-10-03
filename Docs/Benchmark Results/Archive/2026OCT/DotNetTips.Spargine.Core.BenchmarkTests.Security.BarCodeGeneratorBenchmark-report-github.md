```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7725/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  

```
| Method              | Mean       | Error    | StdDev   | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s      | CI99.9% Margin | Iterations | Return Value                                                                                           | Baseline | Gen0   | Exceptions | Allocated |
|-------------------- |-----------:|---------:|---------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------------:|-----------:|------------------------------------------------------------------------------------------------------- |--------- |-------:|-----------:|----------:|
| **BuildHmacBarcode**    | **2,338.8 ns** | **20.91 ns** | **19.56 ns** | **5.05 ns** | **2,302.1 ns** | **2,325.6 ns** | **2,343.7 ns** | **2,353.6 ns** | **2,361.4 ns** | **427,566.0** |       **4.974 ns** |      **15.00** | **v=1|tid=TICKET-123456|pid=PERF-123456|e=1789262719|iss=dotNetTips|alg=H256|kid=k1|sig=XBSMDMMYH9EBQWHP** | **No**       | **0.0381** |          **-** |   **1.19 KB** |
| **ValidateHmacBarcode** | **3,085.9 ns** | **35.39 ns** | **33.11 ns** | **8.55 ns** | **3,029.7 ns** | **3,060.3 ns** | **3,087.8 ns** | **3,112.6 ns** | **3,139.9 ns** | **324,059.4** |       **3.226 ns** |      **15.00** | **True**                                                                                                   | **No**       | **0.0839** |          **-** |   **2.57 KB** |
