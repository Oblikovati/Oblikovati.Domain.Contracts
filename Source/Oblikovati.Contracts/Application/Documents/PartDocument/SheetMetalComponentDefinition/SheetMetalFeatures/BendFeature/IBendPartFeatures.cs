using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.Sketch2D;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    BendFeature;

public interface IBendPartFeatures : IList<IBendPartFeatures>
{
    IBendPartFeature Item { get; }


    IBendPartFeature Add(ISketchLine BendLine, BendPartTypeEnum BendPartType, object InputOne, object InputTwo,
        PartFeatureExtentDirectionEnum BendSide, bool BendInSketchNormalDirection, object Body, bool BendMinimum);
}