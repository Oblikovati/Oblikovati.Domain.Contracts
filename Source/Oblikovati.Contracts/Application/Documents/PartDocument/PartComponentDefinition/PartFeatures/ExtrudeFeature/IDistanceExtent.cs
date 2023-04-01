using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.PartFeature;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.Parameters;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.ExtrudeFeature;

public interface IDistanceExtent
{
    IPartFeature Parent { get; }
    IParameter Distance { get; }
    PartFeatureExtentDirectionEnum Direction { get; set; }
}