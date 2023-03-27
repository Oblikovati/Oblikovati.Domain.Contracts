namespace Oblikovati.Domain.Contracts;

public interface IVertices : IList<IVertices>
{
    IVertex Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
}
