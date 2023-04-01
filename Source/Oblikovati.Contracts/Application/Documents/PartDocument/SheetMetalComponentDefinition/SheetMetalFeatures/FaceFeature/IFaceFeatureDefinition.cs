using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    BendFeature;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.Sketch2D.Profiles;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    FaceFeature;

public interface IFaceFeatureDefinition
{
    PartFeatureExtentDirectionEnum Direction { get; set; }
    IBendDefinition BendDefinition { get; set; }
    IProfile Profile { get; set; }
    IFaceFeature Parent { get; }
    PartFeatureOperationEnum Operation { get; set; }
    IObjectCollection AffectedBodies { get; set; }
    bool UseDefaultSheetMetalRule { get; set; }
    ISheetMetalStyle SheetMetalRule { get; set; }
}