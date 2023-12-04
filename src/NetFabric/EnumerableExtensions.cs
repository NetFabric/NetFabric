using System.Runtime.InteropServices;

namespace NetFabric;

#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP1_0_OR_GREATER

/// <summary>
/// Provides a set of extension methods for working with types implementing <see cref="System.Collections.Generic.IEnumerable{T}"/>.
/// </summary>
public static class EnumerableExtensions
{
    /// <summary>
    /// Tries to retrieve a <see cref="ReadOnlySpan{TSource}"/> representation of the elements in the specified <see cref="System.Collections.Generic.IEnumerable{TSource}"/>.
    /// </summary>
    /// <typeparam name="TSource">The type of elements in the source sequence.</typeparam>
    /// <param name="source">The source <see cref="System.Collections.Generic.IEnumerable{TSource}"/> to convert to a <see cref="ReadOnlySpan{TSource}"/>.</param>
    /// <param name="span">When this method returns, contains the <see cref="ReadOnlySpan{TSource}"/> representing the elements in the source sequence, if the conversion is successful; otherwise, an empty <see cref="ReadOnlySpan{TSource}"/>.</param>
    /// <returns>
    /// <c>true</c> if the <see cref="ReadOnlySpan{TSource}"/> representation of the source sequence is obtained successfully; otherwise, <c>false</c>.
    /// </returns>
    /// <remarks>
    /// This method attempts to convert the source sequence to a <see cref="ReadOnlySpan{TSource}"/>. If the conversion is successful, <paramref name="span"/> will contain the <see cref="ReadOnlySpan{TSource}"/> representing the elements in the source sequence, and the method returns <c>true</c>. Otherwise, <paramref name="span"/> will be an empty <see cref="ReadOnlySpan{TSource}"/>, and the method returns <c>false</c>.
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool TryGetSpan<TSource>(this IEnumerable<TSource> source, out ReadOnlySpan<TSource> span)
    {
        if (source.GetType() == typeof(TSource[]))
        {
            span = Unsafe.As<TSource[]>(source);
            return true;
        }

        if (source.GetType() == typeof(List<TSource>))
        {
            span = CollectionsMarshal.AsSpan(Unsafe.As<List<TSource>>(source));
            return true;
        }

        span = default;
        return false;
    }
}

#endif