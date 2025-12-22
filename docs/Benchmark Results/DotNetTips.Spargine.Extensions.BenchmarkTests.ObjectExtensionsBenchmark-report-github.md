```

BenchmarkDotNet v0.15.6, Windows 10 (10.0.19045.6691/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.101
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  

```
| Method                                  | Mean        | Error     | StdDev    | StdErr    | Min         | Q1          | Median      | Q3          | Max         | Op/s         | CI99.9% Margin | Iterations | Rank | Baseline | Gen0   | Code Size | Exceptions | Completed Work Items | Lock Contentions | Gen1   | Gen2   | Allocated |
|---------------------------------------- |------------:|----------:|----------:|----------:|------------:|------------:|------------:|------------:|------------:|-------------:|---------------:|-----------:|-----:|--------- |-------:|----------:|-----------:|---------------------:|-----------------:|-------:|-------:|----------:|
| **&#39;Clone: PersonRecord*&#39;**                  |    **23.39 ns** |  **0.192 ns** |  **0.180 ns** |  **0.046 ns** |    **23.08 ns** |    **23.26 ns** |    **23.43 ns** |    **23.49 ns** |    **23.77 ns** | **42,753,856.2** |      **7.4768 ns** |      **15.00** |    **1** | **No**       | **0.0021** |     **188 B** |          **-** |                    **-** |                **-** | **0.0001** | **0.0001** |      **96 B** |
| **&#39;ComputeSha256Hash: Person-ref&#39;**         | **6,054.97 ns** | **78.783 ns** | **73.694 ns** | **19.028 ns** | **5,945.43 ns** | **6,007.31 ns** | **6,041.48 ns** | **6,085.80 ns** | **6,192.17 ns** |    **165,153.6** |     **-2.0138 ns** |      **15.00** |    **2** | **No**       | **0.1068** |  **19,359 B** |          **-** |                    **-** |                **-** |      **-** |      **-** |    **3632 B** |
| **&#39;ComputeSha256Hash: PersonRecord&#39;**       | **6,076.28 ns** | **57.783 ns** | **54.050 ns** | **13.956 ns** | **5,987.29 ns** | **6,041.60 ns** | **6,075.15 ns** | **6,105.41 ns** | **6,192.76 ns** |    **164,574.2** |      **0.5221 ns** |      **15.00** |    **2** | **No**       | **0.1221** |  **19,105 B** |          **-** |                    **-** |                **-** |      **-** |      **-** |    **3704 B** |
| **&#39;PersonRecord: Duplication with new ID&#39;** |          **NA** |        **NA** |        **NA** |        **NA** |          **NA** |          **NA** |          **NA** |          **NA** |          **NA** |           **NA** |             **NA** |         **NA** |    **?** | **No**       |     **NA** |        **NA** |         **NA** |                   **NA** |               **NA** |     **NA** |     **NA** |        **NA** |

Benchmarks with issues:
  ObjectExtensionsBenchmark.'PersonRecord: Duplication with new ID': Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True)
