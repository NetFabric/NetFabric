using BenchmarkDotNet.Attributes;

namespace NetFabric.Benchmarks;

public class ReadOnlyCollectionBenchmarks
{
    public readonly record struct TestValueType(int Value);

    TestValueType[]? array;
    IEnumerable<TestValueType>? arrayAsEnumerable;
    ReadOnlyMemory<TestValueType>? memory;
    ReadOnlyCollection<TestValueType>? collection;

    [Params(0, 10, 1_000)]
    public int Count { get; set; }

    [GlobalSetup]
    public void GlobalSetup()
    {
        array = Enumerable
            .Range(0, Count)
            .Select(value => new TestValueType(value))
            .ToArray();
        arrayAsEnumerable = array;
        memory = array;
        collection = new(array);
    }

    [Benchmark(Baseline = true)]
    public int ForEachArray()
    {
        var sum = 0;
        foreach(var value in array!)
            sum += value.Value;
        return sum;
    }

    [Benchmark]
    public int ForEachArrayAsEnumerable()
    {
        var sum = 0;
        foreach (var value in arrayAsEnumerable!)
            sum += value.Value;
        return sum;
    }

    [Benchmark]
    public int ForEachMemory()
    {
        var sum = 0;
        foreach (var value in memory!.Value.Span)
            sum += value.Value;
        return sum;
    }

    [Benchmark]
    public int ForReadOnlyCollection()
    {
        var source = collection;
        var sum = 0;
        for (var index = 0; index < source!.Count; index++)
            sum += source![index].Value;
        return sum;
    }

    [Benchmark]
    public int ForEachReadOnlyCollection()
    {
        var sum = 0;
        foreach (ref readonly var value in collection!)
            sum += value.Value;
        return sum;
    }

    [Benchmark]
    public int ForEachReadOnlyCollectionAsEnumerable()
    {
        var sum = 0;
        foreach (var value in (IEnumerable<TestValueType>)collection!)
            sum += value.Value;
        return sum;
    }
}
