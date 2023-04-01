using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.PartFeature;
using Oblikovati.Contracts.Parameters;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.Extent;

public interface IToHeightExtent
{
    IPartFeature Parent { get; }
    IParameter Offset { get; }
    object ToEntity { get; }
}