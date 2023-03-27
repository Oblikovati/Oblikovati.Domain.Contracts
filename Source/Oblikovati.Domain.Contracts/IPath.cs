namespace Oblikovati.Domain.Contracts;

public interface IPath : IList<IPath>
{

    int Count { get; }
    IPathEntity Item { get; }
    bool Closed { get; }
    IWires Wires { get; }
    IAttributeSets AttributeSets { get; }
    IEnumerator GetEnumerator();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
