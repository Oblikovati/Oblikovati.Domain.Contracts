using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.Sketch2D.Profiles;

namespace Oblikovati.Contracts;

public interface IPathProxy : IList<IPathProxy>
{
    IPathEntity Item { get; }
    bool Closed { get; }
    IWires Wires { get; }
    IAttributeSets AttributeSets { get; }
    IPath NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }

    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}