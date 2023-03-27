namespace Oblikovati.Domain.Contracts;

public interface IProfilePath3D : IList<IProfilePath3D>
{

    IProfile3D Parent { get; }
    int Count { get; }
    IProfileEntity3D Item { get; }
    bool Closed { get; }
    IAttributeSets AttributeSets { get; }
    IEnumerator GetEnumerator();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
