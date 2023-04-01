using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.PartFeature;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.Extent;

public interface IEdgeWidthExtent
{
    IPartFeature Parent { get; }
    IEdge Edge { get; }
}