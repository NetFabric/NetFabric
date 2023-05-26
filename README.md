# NetFabric

Defines classes and structs common to other NetFabric projects.

## Benchmarks

``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.3030/22H2/2022Update)
Intel Core i7-7567U CPU 3.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=7.0.400-preview.23225.8
  [Host]     : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2


```
|                    Method | Count |          Mean |       Error |      StdDev |        Median |         Ratio | RatioSD |   Gen0 | Allocated | Alloc Ratio |
|-------------------------- |------ |--------------:|------------:|------------:|--------------:|--------------:|--------:|-------:|----------:|------------:|
|              **ForEachArray** |     **0** |     **0.2570 ns** |   **0.0371 ns** |   **0.0455 ns** |     **0.2407 ns** |      **baseline** |        **** |      **-** |         **-** |          **NA** |
|     ForReadOnlyCollection |     0 |     0.5677 ns |   0.0267 ns |   0.0208 ns |     0.5568 ns |  2.12x slower |   0.32x |      - |         - |          NA |
| ForEachReadOnlyCollection |     0 |     0.0783 ns |   0.0364 ns |   0.0735 ns |     0.0481 ns |  5.77x faster |   9.48x |      - |         - |          NA |
|         ForEachEnumerable |     0 |    13.7499 ns |   0.2908 ns |   0.2578 ns |    13.7559 ns | 52.55x slower |   8.17x | 0.0153 |      32 B |          NA |
|                           |       |               |             |             |               |               |         |        |           |             |
|              **ForEachArray** |    **10** |     **3.3819 ns** |   **0.1790 ns** |   **0.4899 ns** |     **3.1397 ns** |      **baseline** |        **** |      **-** |         **-** |          **NA** |
|     ForReadOnlyCollection |    10 |     7.4508 ns |   0.1754 ns |   0.4743 ns |     7.2265 ns |  2.24x slower |   0.33x |      - |         - |          NA |
| ForEachReadOnlyCollection |    10 |     3.6047 ns |   0.0940 ns |   0.0734 ns |     3.5878 ns |  1.12x slower |   0.10x |      - |         - |          NA |
|         ForEachEnumerable |    10 |    84.9057 ns |   1.5447 ns |   3.8181 ns |    83.5306 ns | 25.46x slower |   3.50x | 0.0153 |      32 B |          NA |
|                           |       |               |             |             |               |               |         |        |           |             |
|              **ForEachArray** |  **1000** |   **417.4478 ns** |   **7.6841 ns** |   **7.5468 ns** |   **414.6732 ns** |      **baseline** |        **** |      **-** |         **-** |          **NA** |
|     ForReadOnlyCollection |  1000 |   561.4730 ns |  10.4200 ns |  27.6323 ns |   548.1369 ns |  1.39x slower |   0.10x |      - |         - |          NA |
| ForEachReadOnlyCollection |  1000 |   535.1716 ns |   3.6699 ns |   3.2533 ns |   535.3654 ns |  1.28x slower |   0.03x |      - |         - |          NA |
|         ForEachEnumerable |  1000 | 6,411.1701 ns | 103.4017 ns | 119.0776 ns | 6,395.2068 ns | 15.39x slower |   0.39x | 0.0153 |      32 B |          NA |
