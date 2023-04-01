using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.PartFeature;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.Parameters;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.Extent;

public interface ILegacyDistanceHeightExtent
{
    IPartFeature Parent { get; }
    IParameter Distance { get; }
    PartFeatureExtentDirectionEnum FlangeDirection { get; set; }
}