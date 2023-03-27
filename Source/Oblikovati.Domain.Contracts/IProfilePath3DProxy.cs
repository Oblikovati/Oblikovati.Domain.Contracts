namespace Oblikovati.Domain.Contracts;

public interface IProfilePath3DProxy : IList<IProfilePath3DProxy>
{

    IProfile3D Parent { get; }
    int Count { get; }
    IProfileEntity3D Item { get; }
    bool Closed { get; }
    IAttributeSets AttributeSets { get; }
    IProfilePath3D NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    IEnumerator GetEnumerator();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
