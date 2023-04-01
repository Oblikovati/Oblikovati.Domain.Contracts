using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.Sketch2D.Profiles;

namespace Oblikovati.Contracts.Sketch3D.Profiles3D;

public interface IProfile3D : IList<IProfile3D>
{
    IProfilePath3D Item { get; }
    ISketch3D Parent { get; }
    IAttributeSets AttributeSets { get; }
    IWires Wires { get; }

    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Delete();
}