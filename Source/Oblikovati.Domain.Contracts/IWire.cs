using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IWire
{

    ISurfaceBody Parent { get; }
    IEdgeUses EdgeUses { get; }
    IEdges Edges { get; }
    bool IsPlanar { get; }
    IWires OffsetPlanarWire(IUnitVector Normal, double Distance, OffsetCornerClosureTypeEnum CornerClosureType);
}
