# NetFabric

Defines classes and structs common to the other NetFabric projects.

## Throw

Defines a set of static methods to throw exceptions.

Methods that throw exceptions cannot be inlined by the JIT compiler. Only if thrown within a called method.
Using the methods in this class allows exceptions to be thrown and still let the method be a candidate to be inlined.

```csharp
// an example method that uses Throw
public static bool AssertIsPositive<T>(T? value) where T : INumber<T>
	=> value >= T.Zero ? value : Throw.ArgumentNullException<bool>(nameof(value));
```

