# NetFabric

Defines classes and structs common to other NetFabric projects.

## Throw

Defines a set of static methods to throw exceptions.

Methods that throw exceptions cannot be inlined by the JIT compiler. Only if thrown within a called method.
Using the methods in this class allows exceptions to be thrown and still let the method be a candidate to be inlined.

```csharp
[MethodImpl(MethodImplOptions.AggressiveInlining)]
public static ReadOnlyListWrapper<T> AsReadOnlyList<T>(T[] source)
    => source switch
    {
        null => Throw.ArgumentNullException<ReadOnlyListWrapper<T>>(nameof(source)),
        _ => new ReadOnlyListWrapper<T>(source)
    };
```

## Credits

The following open-source projects are used to build and test this project:

- [.NET](https://github.com/dotnet)
- [BenchmarkDotNet](https://github.com/dotnet/BenchmarkDotNet)
- [coverlet](https://github.com/coverlet-coverage/coverlet)
- [NetFabric.Assertive](https://github.com/NetFabric/NetFabric.Assertive)
- [NetFabric.Hyperlinq.Analyzer](https://github.com/NetFabric/NetFabric.Hyperlinq.Analyzer)
- [xUnit](https://github.com/xunit/xunit)

## License

This project is licensed under the MIT license. See the [LICENSE](LICENSE) file for more info.