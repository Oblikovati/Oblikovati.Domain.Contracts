using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.PartFeature;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.ExtrudeFeature;

public interface IThroughAllExtent
{
    IPartFeature Parent { get; }
    PartFeatureExtentDirectionEnum Direction { get; set; }
}