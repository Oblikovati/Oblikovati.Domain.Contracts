using Oblikovati.Contracts.Attributes;

namespace Oblikovati.Contracts.Sketch3D.Profiles3D;

public interface IProfilePath3D : IList<IProfilePath3D>
{
    IProfile3D Parent { get; }

    IProfileEntity3D Item { get; }
    bool Closed { get; }
    IAttributeSets AttributeSets { get; }

    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}