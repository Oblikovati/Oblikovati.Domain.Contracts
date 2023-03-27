using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IFromToExtent
{

    IPartFeature Parent { get; }
    object ToFace { get; set; }
    bool ExtendToFace { get; set; }
    object FromFace { get; set; }
    bool ExtendFromFace { get; set; }
    bool MinimumSolution { get; set; }
    bool SolutionDirectionReversed { get; set; }
    PartFeatureExtentDirectionEnum Direction { get; set; }
}
