namespace Oblikovati.Domain.Contracts;

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
