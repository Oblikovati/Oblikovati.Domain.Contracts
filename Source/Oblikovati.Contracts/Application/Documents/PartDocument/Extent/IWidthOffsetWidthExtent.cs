using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.PartFeature;
using Oblikovati.Contracts.Parameters;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.Extent;

public interface IWidthOffsetWidthExtent
{
    IPartFeature Parent { get; }
    IEdge Edge { get; }
    IParameter Width { get; }
    IParameter OffsetDistance { get; }
    object OffsetEntity { get; }
    bool PositiveDirection { get; }
}