namespace Oblikovati.Domain.Contracts;

public interface IIRxEdgeLoop
{
    IIRxEnumEdgeUses EdgeUses { get; }
    IIRxEnumEdges Edges { get; }
    IIRxFace Face { get; }
    short IsOuterEdgeLoop { get; }
    IIRxBox RangeBox { get; }
}
