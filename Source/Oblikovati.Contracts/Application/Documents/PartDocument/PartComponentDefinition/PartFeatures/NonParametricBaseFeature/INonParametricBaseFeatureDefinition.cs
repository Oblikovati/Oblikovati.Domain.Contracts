using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.
    NonParametricBaseFeature;

public interface INonParametricBaseFeatureDefinition
{
    IObjectCollection BRepEntities { get; set; }
    bool DeleteOriginal { get; set; }
    bool IsAssociative { get; set; }
    BaseFeatureOutputTypeEnum OutputType { get; set; }
    IComponentOccurrence TargetOccurrence { get; set; }
}