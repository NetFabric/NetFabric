# NetFabric

Defines classes and structs common to the other NetFabric projects.

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

