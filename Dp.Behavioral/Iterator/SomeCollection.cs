namespace Dp.Behavioral.Iterator;

using System.Collections;

/// <summary>
/// TODO: Implement implementation.
/// </summary>
/// <typeparam name="T">Any type.</typeparam>
internal class SomeCollection<T> : IEnumerable<T>
{
    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// The enumerator for <see cref="SomeCollection{T}"/>.
/// TODO: Incomplete implementation.
/// </summary>
/// <typeparam name="T">Any type.</typeparam>
/// <param name="root">The root of the element.</param>
internal class SomeCollectionEnumerator<T>(T root) : IEnumerator<T>
{
    public T Root { get; set; } = root;

    public T Current { get; set; } = root;

    object IEnumerator.Current => throw new NotImplementedException();

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public bool MoveNext()
    {
        return this.Current != null;
    }

    public void Reset()
    {
        this.Current = this.Root;
    }
}
