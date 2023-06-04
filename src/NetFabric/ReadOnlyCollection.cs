namespace NetFabric;

public class ReadOnlyCollection<T>
    : IReadOnlyList<T>
{
    readonly T[] array;

    public ReadOnlyCollection(T[] array)
        => this.array = array;

    public T this[int index]
        => array[index];

    public int Count
        => array.Length;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Enumerator GetEnumerator()
        => new(array);

    IEnumerator<T> IEnumerable<T>.GetEnumerator()
        => GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator()
        => GetEnumerator();

    public struct Enumerator : IEnumerator<T>
    {
        readonly T[] array;
        int index;

        internal Enumerator(T[] array)
        {
            this.array = array;
            index = -1;
        }

        public readonly ref readonly T Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => ref array[index];
        }
        T IEnumerator<T>.Current
            => Current;
        object? IEnumerator.Current
            => Current;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
            => ++index < array.Length;

        bool IEnumerator.MoveNext()
            => MoveNext();

        public void Reset()
            => index = -1;

        public void Dispose() { }
    }
}
