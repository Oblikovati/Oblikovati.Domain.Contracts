using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.PartFeature;
using Oblikovati.Contracts.Parameters;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.HoleFeature;

public interface IPitchAndRevolutionCoilExtent
{
    IPartFeature Parent { get; }
    IParameter Pitch { get; }
    IParameter Revolution { get; }
    IParameter TaperAngle { get; }
}