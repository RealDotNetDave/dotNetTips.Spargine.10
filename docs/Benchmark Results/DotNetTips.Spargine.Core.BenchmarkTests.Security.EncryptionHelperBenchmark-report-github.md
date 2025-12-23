```

BenchmarkDotNet v0.15.6, Windows 10 (10.0.19045.6691/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.101
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  

```
| Method            | Categories         | Mean       | Error    | StdDev   | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s        | CI99.9% Margin | Iterations | Rank | Baseline | Gen0   | Exceptions | Completed Work Items | Lock Contentions | Code Size | Gen1   | Allocated |
|------------------ |------------------- |-----------:|---------:|---------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|------------:|---------------:|-----------:|-----:|--------- |-------:|-----------:|---------------------:|-----------------:|----------:|-------:|----------:|
| **AesDecrypt**        | **Encryption**         | **4,242.6 ns** | **17.01 ns** | **15.07 ns** | **4.03 ns** | **4,218.8 ns** | **4,230.3 ns** | **4,240.9 ns** | **4,255.2 ns** | **4,265.3 ns** |   **235,707.0** |       **4.986 ns** |      **14.00** |    **4** | **No**       | **0.4654** |          **-** |                    **-** |                **-** |        **NA** | **0.0076** |   **14096 B** |
| **AesEncrypt**        | **Encryption**         | **3,571.4 ns** | **23.13 ns** | **20.50 ns** | **5.48 ns** | **3,541.3 ns** | **3,556.8 ns** | **3,565.3 ns** | **3,578.7 ns** | **3,607.2 ns** |   **280,004.9** |       **4.261 ns** |      **14.00** |    **3** | **No**       | **0.4158** |          **-** |                    **-** |                **-** |        **NA** | **0.0114** |   **12672 B** |
| **AesGcmDecrypt**     | **Encryption**         | **3,075.3 ns** | **26.29 ns** | **24.59 ns** | **6.35 ns** | **3,032.8 ns** | **3,060.0 ns** | **3,073.6 ns** | **3,091.0 ns** | **3,132.7 ns** |   **325,172.0** |       **4.325 ns** |      **15.00** |    **2** | **No**       | **0.0381** |          **-** |                    **-** |                **-** |        **NA** |      **-** |    **4032 B** |
| **AesGcmEncrypt**     | **Encryption**         |         **NA** |       **NA** |       **NA** |      **NA** |         **NA** |         **NA** |         **NA** |         **NA** |         **NA** |          **NA** |             **NA** |         **NA** |    **?** | **No**       |     **NA** |         **NA** |                   **NA** |               **NA** |        **NA** |     **NA** |        **NA** |
| **GenerateRandomKey** | ****NEW**,Encryption** |   **183.7 ns** |  **1.87 ns** |  **1.75 ns** | **0.45 ns** |   **180.9 ns** |   **182.4 ns** |   **183.3 ns** |   **185.0 ns** |   **187.2 ns** | **5,443,728.7** |       **7.274 ns** |      **15.00** |    **1** | **No**       | **0.0026** |          **-** |                    **-** |                **-** |     **789 B** |      **-** |      **80 B** |

Benchmarks with issues:
  EncryptionHelperBenchmark.AesGcmEncrypt: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True)
