namespace Oblikovati.Domain.Contracts;

public interface IPathProxy : IList<IPathProxy>
{

    int Count { get; }
    IPathEntity Item { get; }
    bool Closed { get; }
    IWires Wires { get; }
    IAttributeSets AttributeSets { get; }
    IPath NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    IEnumerator GetEnumerator();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
