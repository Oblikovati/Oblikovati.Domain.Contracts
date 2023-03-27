using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface INonParametricBaseFeatureDefinition
{

    IObjectCollection BRepEntities { get; set; }
    bool DeleteOriginal { get; set; }
    bool IsAssociative { get; set; }
    BaseFeatureOutputTypeEnum OutputType { get; set; }
    IComponentOccurrence TargetOccurrence { get; set; }
}
