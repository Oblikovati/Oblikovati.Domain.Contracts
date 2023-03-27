namespace Oblikovati.Domain.Contracts;

public interface IEdgeLoop
{

    ISurfaceBody Parent { get; }
    IEdgeUses EdgeUses { get; }
    IEdges Edges { get; }
    IFace Face { get; }
    bool IsOuterEdgeLoop { get; }
    IBox RangeBox { get; }
    IAttributeSets AttributeSets { get; }
    int TransientKey { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
