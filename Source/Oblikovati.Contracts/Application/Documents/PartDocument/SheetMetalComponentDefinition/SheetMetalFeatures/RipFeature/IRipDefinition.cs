using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    RipFeature;

public interface IRipDefinition
{
    IRipFeature Parent { get; }
    IFace RipFace { get; set; }
    RipTypeEnum RipType { get; }
    object RipTypeDefinition { get; }
    void SetSinglePointRipType(IFace RipFace, object Point, object GapSize, PartFeatureExtentDirectionEnum GapSide);

    void SetPointToPointRipType(IFace RipFace, object PointOne, object PointTwo, object GapSize,
        PartFeatureExtentDirectionEnum GapSide);

    void SetFaceExtentsRipType(IFace RipFace);
    IRipDefinition Copy();
}