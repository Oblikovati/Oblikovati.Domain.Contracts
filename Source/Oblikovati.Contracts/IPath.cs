using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.Sketch2D.Profiles;

namespace Oblikovati.Contracts;

public interface IPath : IList<IPath>
{
    IPathEntity Item { get; }
    bool Closed { get; }
    IWires Wires { get; }
    IAttributeSets AttributeSets { get; }

    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}