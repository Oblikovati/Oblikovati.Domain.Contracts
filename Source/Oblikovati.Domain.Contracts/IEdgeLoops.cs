namespace Oblikovati.Domain.Contracts;

public interface IEdgeLoops : IList<IEdgeLoops>
{
    IEdgeLoop Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
}
