namespace Oblikovati.Domain.Contracts;

public interface IProfile3DProxy : IList<IProfile3DProxy>
{

    int Count { get; }
    IProfilePath3D Item { get; }
    ISketch3D Parent { get; }
    IAttributeSets AttributeSets { get; }
    IWires Wires { get; }
    IProfile3D NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    IEnumerator GetEnumerator();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Delete();
}
