```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.6809/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.102
  [Host]     : .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3
  Job-PSYKRA : .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3

EvaluateOverhead=True  Runtime=.NET 10.0  Server=True  
Categories=Collections  

```
| Method           | Count | Mean         | Error       | StdDev      | StdErr      | Min          | Q1           | Median       | Q3           | Max          | Op/s      | CI99.9% Margin | Iterations | Rank | Baseline | Exceptions | Completed Work Items | Lock Contentions | Code Size | Allocated |
|----------------- |------ |-------------:|------------:|------------:|------------:|-------------:|-------------:|-------------:|-------------:|-------------:|----------:|---------------:|-----------:|-----:|--------- |-----------:|---------------------:|-----------------:|----------:|----------:|
| GenerateHashCode | 64    |   1,702.3 ns |     9.81 ns |     9.18 ns |     2.37 ns |   1,684.6 ns |   1,696.0 ns |   1,702.5 ns |   1,707.5 ns |   1,717.4 ns | 587,423.6 |       6.315 ns |      15.00 |    1 | No       |          - |                    - |                - |   1,461 B |      40 B |
| GenerateHashCode | 128   |   3,676.9 ns |    24.22 ns |    22.65 ns |     5.85 ns |   3,638.8 ns |   3,660.9 ns |   3,675.5 ns |   3,692.6 ns |   3,719.3 ns | 271,971.3 |       4.576 ns |      15.00 |    2 | No       |          - |                    - |                - |   1,461 B |      40 B |
| GenerateHashCode | 256   |   7,977.3 ns |    81.21 ns |    71.99 ns |    19.24 ns |   7,889.5 ns |   7,920.8 ns |   7,978.5 ns |   7,999.2 ns |   8,139.4 ns | 125,354.9 |      -2.620 ns |      14.00 |    3 | No       |          - |                    - |                - |   1,461 B |      40 B |
| GenerateHashCode | 512   |  17,466.4 ns |   118.32 ns |   104.88 ns |    28.03 ns |  17,297.9 ns |  17,400.9 ns |  17,452.0 ns |  17,543.4 ns |  17,684.1 ns |  57,252.8 |      -7.016 ns |      14.00 |    4 | No       |          - |                    - |                - |   1,461 B |      40 B |
| GenerateHashCode | 1024  |  42,631.9 ns |   470.50 ns |   440.11 ns |   113.64 ns |  41,957.5 ns |  42,317.8 ns |  42,611.7 ns |  42,910.1 ns |  43,331.0 ns |  23,456.6 |     -49.318 ns |      15.00 |    5 | No       |          - |                    - |                - |   1,456 B |      40 B |
| GenerateHashCode | 2048  |  90,714.3 ns | 1,080.27 ns | 1,010.49 ns |   260.91 ns |  89,043.7 ns |  89,964.5 ns |  90,909.9 ns |  91,300.2 ns |  92,675.5 ns |  11,023.6 |    -122.954 ns |      15.00 |    6 | No       |          - |                    - |                - |   1,456 B |      40 B |
| GenerateHashCode | 4096  | 184,100.1 ns | 2,298.94 ns | 2,150.43 ns |   555.24 ns | 180,854.9 ns | 182,523.8 ns | 184,191.7 ns | 185,238.2 ns | 187,917.7 ns |   5,431.8 |    -270.119 ns |      15.00 |    7 | No       |          - |                    - |                - |   1,456 B |      40 B |
| GenerateHashCode | 8192  | 383,118.2 ns | 6,436.40 ns | 6,020.61 ns | 1,554.52 ns | 372,744.4 ns | 380,313.9 ns | 382,169.7 ns | 387,610.6 ns | 392,788.2 ns |   2,610.2 |    -769.758 ns |      15.00 |    8 | No       |          - |                    - |                - |   1,456 B |      40 B |
