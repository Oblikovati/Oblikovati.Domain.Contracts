namespace Oblikovati.Domain.Contracts;

public interface IProfile3D : IList<IProfile3D>
{

    int Count { get; }
    IProfilePath3D Item { get; }
    ISketch3D Parent { get; }
    IAttributeSets AttributeSets { get; }
    IWires Wires { get; }
    IEnumerator GetEnumerator();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Delete();
}
