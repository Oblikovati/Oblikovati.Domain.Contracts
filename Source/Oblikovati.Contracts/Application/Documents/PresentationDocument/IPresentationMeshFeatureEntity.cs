using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.GraphicsDataSets;

namespace Oblikovati.Contracts.Application.Documents.PresentationDocument;

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