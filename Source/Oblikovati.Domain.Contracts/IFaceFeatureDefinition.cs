using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

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
