```

BenchmarkDotNet v0.15.2, Windows 10 (10.0.19045.6332/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.100-rc.1.25451.107
  [Host]     : .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
  Job-PSYKRA : .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests.Security  Categories=**NEW**  

```
| Method      | Mean     | Error     | StdDev    | StdErr    | Min      | Q1       | Median   | Q3       | Max      | Op/s          | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Completed Work Items | Lock Contentions | Code Size | Allocated |
|------------ |---------:|----------:|----------:|----------:|---------:|---------:|---------:|---------:|---------:|--------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|---------------------:|-----------------:|----------:|----------:|
| **GetHashCode** | **5.303 ns** | **0.0191 ns** | **0.0169 ns** | **0.0045 ns** | **5.268 ns** | **5.295 ns** | **5.306 ns** | **5.314 ns** | **5.322 ns** | **188,581,417.3** |       **6.998 ns** |      **14.00** |    **2.205** |  **2.000** |  **-0.6695** |    **2** | *****            | **No**       |          **-** |                    **-** |                **-** |     **458 B** |         **-** |
| **NewUlid**     | **2.148 ns** | **0.0250 ns** | **0.0234 ns** | **0.0060 ns** | **2.123 ns** | **2.132 ns** | **2.140 ns** | **2.163 ns** | **2.193 ns** | **465,548,884.9** |       **7.497 ns** |      **15.00** |    **2.044** |  **2.000** |   **0.7228** |    **1** | *****            | **No**       |          **-** |                    **-** |                **-** |     **179 B** |         **-** |
