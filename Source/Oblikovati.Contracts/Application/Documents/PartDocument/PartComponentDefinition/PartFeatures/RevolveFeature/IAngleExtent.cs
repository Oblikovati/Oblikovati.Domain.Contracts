using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.PartFeature;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.Parameters;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.RevolveFeature;

public interface IAngleExtent
{
    IPartFeature Parent { get; }
    IParameter Angle { get; }
    PartFeatureExtentDirectionEnum Direction { get; set; }
}