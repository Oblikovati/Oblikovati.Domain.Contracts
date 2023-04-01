using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    BendFeature;

public interface IBendOptions
{
    BendTransitionEnum BendTransition { get; set; }
    BendReliefShapeEnum BendReliefShape { get; set; }
    object BendReliefWidth { get; set; }
    object BendReliefDepth { get; set; }
    object MinimumRemnant { get; set; }
    object BendTransitionArcRadius { get; set; }

    IBendOptions Copy();
}