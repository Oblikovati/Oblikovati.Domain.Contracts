using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.PartFeature;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.ExtrudeFeature;

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