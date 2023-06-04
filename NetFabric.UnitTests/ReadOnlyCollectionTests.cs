using System.Collections.ObjectModel;

namespace NetFabric.UnitTests;

public class ReadOnlyCollectionTests
{
    public static TheoryData<int[]> Data
        => new()
        {
            Array.Empty<int>(),
            new int[] { 0 },
            new int[] { 1 },
            new int[] { 0, 1, 2, 3, 4, 5, 6, 7 },
        };

    [Theory]
    [MemberData(nameof(Data))]
    public void TestAllEnumerationInterfaces(int[] source)
    {
        // Arrange

        // Act
        var result = new ReadOnlyCollection<int>(source);

        // Assert
        _ = result.Must()
            .BeEnumerableOf<int>()
            .BeEqualTo(source);
    }
}
