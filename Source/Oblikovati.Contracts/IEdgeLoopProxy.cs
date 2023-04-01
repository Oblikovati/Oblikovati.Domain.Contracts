using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Attributes;

namespace Oblikovati.Contracts;

public interface IEdgeLoopProxy
{
    ISurfaceBody Parent { get; }
    IEdgeUses EdgeUses { get; }
    IEdges Edges { get; }
    IFace Face { get; }
    bool IsOuterEdgeLoop { get; }
    IBox RangeBox { get; }
    IAttributeSets AttributeSets { get; }
    int TransientKey { get; }
    IEdgeLoop NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}