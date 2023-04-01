using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    BendFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    CornerFeature;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts;

public interface ICornerDefinition
{
    ICornerFeature Parent { get; }
    object GapWidth { get; set; }
    IEdgeCollection Edges { get; set; }
    bool IsRippedCorner { get; set; }
    CornerTypeEnum CornerType { get; set; }
    IBendOptions BendOptions { get; set; }
    ICornerOptions CornerOptions { get; set; }
    bool AlignedCornerExtension { get; set; }
    double PercentOverlap { get; set; }
    CornerDefinitionTypeEnum CornerDefinitionType { get; set; }
    ICornerDefinition Copy();
}