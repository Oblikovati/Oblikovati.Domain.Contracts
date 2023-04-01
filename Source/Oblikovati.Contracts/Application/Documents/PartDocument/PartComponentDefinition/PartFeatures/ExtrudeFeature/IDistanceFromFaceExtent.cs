using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.PartFeature;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.ExtrudeFeature;

public interface IDistanceFromFaceExtent
{
    IPartFeature Parent { get; }
    PartFeatureExtentDirectionEnum Direction { get; set; }
    PartFeatureExtentDirectionEnum AlternateSolutionDirection { get; set; }
    bool MinimumSolution { get; set; }
    object Distance { get; }
    object DistanceTwo { get; }
    bool IsTwoDirectional { get; set; }
    bool ExtendFromFace { get; set; }
    object FromFace { get; set; }
}