using BenchmarkDotNet.Attributes;

namespace NetFabric.Benchmarks;

public class ConversionBenchmarks
{
    [Params(1_000)]
    public int Count { get; set; }

    [Benchmark(Baseline = true)]
    public float Checked()
    {
        var sum = 0.0f;
        for (var count = 0; count < Count; count++)
            sum += float.CreateChecked(1.0);
        return sum;
    }

    [Benchmark]
    public float Saturating()
    {
        var sum = 0.0f;
        for (var count = 0; count < Count; count++)
            sum += float.CreateSaturating(1.0);
        return sum;
    }

    [Benchmark]
    public float Truncating()
    {
        var sum = 0.0f;
        for (var count = 0; count < Count; count++)
            sum += float.CreateTruncating(1.0);
        return sum;
    }
}
