using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

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
