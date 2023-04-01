using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.PartFeature;
using Oblikovati.Contracts.Parameters;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.HoleFeature;

public interface IRevolutionAndHeightCoilExtent
{
    IPartFeature Parent { get; }
    IParameter Height { get; }
    IParameter Revolution { get; }
    IParameter TaperAngle { get; }
}