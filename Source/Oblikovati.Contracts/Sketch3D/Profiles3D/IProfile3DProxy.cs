using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.Sketch2D.Profiles;

namespace Oblikovati.Contracts.Sketch3D.Profiles3D;

public interface IProfile3DProxy : IList<IProfile3DProxy>
{
    IProfilePath3D Item { get; }
    ISketch3D Parent { get; }
    IAttributeSets AttributeSets { get; }
    IWires Wires { get; }
    IProfile3D NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }

    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Delete();
}