using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.PartFeature;
using Oblikovati.Contracts.NotClassified;
using Oblikovati.Contracts.Parameters;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.Extent;

public interface ICenteredWidthExtent
{
    IPartFeature Parent { get; }
    IEdge Edge { get; }
    IParameter Width { get; }
}