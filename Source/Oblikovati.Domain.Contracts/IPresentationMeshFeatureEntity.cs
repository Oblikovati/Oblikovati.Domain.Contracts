using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IPresentationMeshFeatureEntity
{

    IGraphicsCoordinateSet CoordinateSet { get; }
    IGraphicsIndexSet CoordinateIndexSet { get; }
    ColorBindingEnum ColorBinding { get; }
    IGraphicsColorSet ColorSet { get; }
    IGraphicsIndexSet ColorIndexSet { get; }
    NormalBindingEnum NormalBinding { get; }
    IGraphicsNormalSet NormalSet { get; }
    IGraphicsIndexSet NormalIndexSet { get; }
    IPresentationMeshFeature Parent { get; }
}
