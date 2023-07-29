namespace NetFabric;

/// <summary>
/// Represents a <see cref="System.Collections.Generic.IReadOnlyList{T}"/> that provides a read-only collection of elements.
/// </summary>
/// <typeparam name="T">The type of elements in the collection.</typeparam>
/// <remarks>
/// This class can be used to wrap an array as a readonly collection, providing efficient iteration
/// through the elements while maintaining read-only semantics. It implements the IReadOnlyList&lt;T&gt;
/// interface and offers a way to efficiently access and traverse the underlying array.
/// </remarks>
/// <remarks>
/// Initializes a new instance of the <see cref="ReadOnlyCollection{T}"/> class with the provided array.
/// </remarks>
/// <param name="array">The array to be used as the collection.</param>
public class ReadOnlyCollection<T>(T[] array) : IReadOnlyList<T>
{
    /// <summary>
    /// Gets the element at the specified index in the collection.
    /// </summary>
    /// <param name="index">The zero-based index of the element to get.</param>
    /// <returns>The element at the specified index.</returns>
    public T this[int index]
        => array[index];

    /// <summary>
    /// Gets the number of elements in the collection.
    /// </summary>
    public int Count
        => array.Length;

    /// <summary>
    /// Returns an enumerator that efficiently iterates through the collection.
    /// </summary>
    /// <returns>An enumerator for the collection.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Enumerator GetEnumerator()
        => new(array);

    /// <summary>
    /// Returns an enumerator that iterates through the collection.
    /// </summary>
    /// <returns>An enumerator for the collection.</returns>
    IEnumerator<T> IEnumerable<T>.GetEnumerator()
        => GetEnumerator();

    /// <summary>
    /// Returns an enumerator that iterates through the collection.
    /// </summary>
    /// <returns>An enumerator for the collection.</returns>
    IEnumerator IEnumerable.GetEnumerator()
        => GetEnumerator();

    /// <summary>
    /// Represents an enumerator for efficiently iterating through the collection.
    /// </summary>
    public struct Enumerator : IEnumerator<T>
    {
        /// <summary>
        /// The private readonly array that stores the collection elements.
        /// </summary>
        readonly T[] array;

        /// <summary>
        /// The index representing the current position during enumeration.
        /// </summary>
        int index;

        /// <summary>
        /// Initializes a new instance of the <see cref="Enumerator"/> struct with the provided array.
        /// </summary>
        /// <param name="array">The array to be used for enumeration.</param>
        internal Enumerator(T[] array)
        {
            this.array = array;
            index = -1;
        }

        /// <summary>
        /// Gets the current element in a read-only manner by reference.
        /// </summary>
        public readonly ref readonly T Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => ref array[index];
        }

        /// <summary>
        /// Gets the current element in the collection.
        /// </summary>
        readonly T IEnumerator<T>.Current
            => Current;

        /// <summary>
        /// Gets the current element in the collection.
        /// </summary>
        readonly object? IEnumerator.Current
            => Current;

        /// <summary>
        /// Moves to the next element in the collection.
        /// </summary>
        /// <returns><c>true</c> if the enumerator successfully advanced to the next element; <c>false</c> if the enumerator has passed the end of the collection.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
            => ++index < array.Length;

        /// <summary>
        /// Moves to the next element in the collection.
        /// </summary>
        /// <returns><c>true</c> if the enumerator successfully advanced to the next element; <c>false</c> if the enumerator has passed the end of the collection.</returns>
        bool IEnumerator.MoveNext()
            => MoveNext();

        /// <summary>
        /// Resets the enumerator to its initial state.
        /// </summary>
        public void Reset()
            => index = -1;

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting resources used by the enumerator (no resources to dispose in this case).
        /// </summary>
        public readonly void Dispose() { }
    }
}
