using BenchmarkDotNet.Attributes;

namespace NetFabric.Benchmarks;

public class ReadOnlyCollectionTests
{
    public readonly record struct TestValueType(int Value);

    TestValueType[]? array;
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

    [Benchmark()]
    public int ForReadOnlyCollection()
    {
        var source = collection;
        var sum = 0;
        for (var index = 0; index < source!.Count; index++)
            sum += source![index].Value;
        return sum;
    }

    [Benchmark()]
    public int ForEachReadOnlyCollection()
    {
        var sum = 0;
        foreach (ref readonly var value in collection!)
            sum += value.Value;
        return sum;
    }

    [Benchmark()]
    public int ForEachEnumerable()
    {
        var sum = 0;
        foreach (var value in (IEnumerable<TestValueType>)collection!)
            sum += value.Value;
        return sum;
    }
}
