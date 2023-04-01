using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.PartFeature;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.Extent;

public interface IFromToWidthExtent
{
    IPartFeature Parent { get; }
    IEdge Edge { get; }
    object FromEntity { get; }
    object ToEntity { get; }
}