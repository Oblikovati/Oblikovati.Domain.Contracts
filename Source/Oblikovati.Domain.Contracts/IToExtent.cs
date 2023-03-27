using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IToExtent
{

    IPartFeature Parent { get; }
    object ToFace { get; set; }
    object ToEntity { get; set; }
    bool ExtendToFace { get; set; }
    bool MinimumSolution { get; set; }
    bool SolutionDirectionReversed { get; set; }
    PartFeatureExtentDirectionEnum Direction { get; set; }
}
