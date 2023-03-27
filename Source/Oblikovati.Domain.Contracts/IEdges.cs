namespace Oblikovati.Domain.Contracts;

public interface IEdges : IList<IEdges>
{
    IEdge Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
}
