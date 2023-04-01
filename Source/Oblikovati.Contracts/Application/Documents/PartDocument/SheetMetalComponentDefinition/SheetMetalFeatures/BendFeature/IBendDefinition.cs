using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    UnfoldFeature;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    BendFeature;

public interface IBendDefinition
{
    IEdgeCollection Edges { get; set; }
    object BendRadius { get; set; }
    bool ExtendFaces { get; set; }
    DoubleBendTypeEnum DoubleBendType { get; set; }
    bool IsDoubleBendFirstEdgeFixed { get; set; }
    IBendOptions BendOptions { get; set; }
    IUnfoldMethod UnfoldMethod { get; set; }

    bool IsUnfoldMethodOverridden { get; set; }
    IBendDefinition Copy();
}