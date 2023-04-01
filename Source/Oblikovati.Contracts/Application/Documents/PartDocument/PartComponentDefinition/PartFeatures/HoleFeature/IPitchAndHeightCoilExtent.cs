using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.PartFeature;
using Oblikovati.Contracts.Parameters;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.HoleFeature;

public interface IPitchAndHeightCoilExtent
{
    IPartFeature Parent { get; }
    IParameter Pitch { get; }
    IParameter Height { get; }
    IParameter TaperAngle { get; }
}