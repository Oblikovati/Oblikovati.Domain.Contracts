using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Sketch2D.Profiles;

public interface IWire
{
    ISurfaceBody Parent { get; }
    IEdgeUses EdgeUses { get; }
    IEdges Edges { get; }
    bool IsPlanar { get; }
    IWires OffsetPlanarWire(IUnitVector Normal, double Distance, OffsetCornerClosureTypeEnum CornerClosureType);
}