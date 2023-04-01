using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    BendFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    UnfoldFeature;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.Sketch2D;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    FoldFeature;

public interface IFoldDefinition
{
    IFoldFeature Parent { get; }
    object BendAngle { get; set; }
    ISketchLine BendLine { get; set; }
    BendLocationEnum BendLocation { get; set; }
    IBendOptions BendOptions { get; set; }
    object BendRadius { get; set; }
    bool IsPositiveBendDirection { get; set; }
    bool IsPositiveBendSide { get; set; }
    IUnfoldMethod UnfoldMethod { get; set; }
    bool IsUnfoldMethodOverridden { get; set; }
    IFoldDefinition Copy();
}