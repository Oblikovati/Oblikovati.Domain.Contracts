namespace Oblikovati.Domain.Contracts;

public interface IEdgeUses : IList<IEdgeUses>
{
    IEdgeUse Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
}
