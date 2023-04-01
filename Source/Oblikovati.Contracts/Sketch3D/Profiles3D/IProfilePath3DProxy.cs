using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;
using Oblikovati.Contracts.Attributes;

namespace Oblikovati.Contracts.Sketch3D.Profiles3D;

public interface IProfilePath3DProxy : IList<IProfilePath3DProxy>
{
    IProfile3D Parent { get; }

    IProfileEntity3D Item { get; }
    bool Closed { get; }
    IAttributeSets AttributeSets { get; }
    IProfilePath3D NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }

    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}