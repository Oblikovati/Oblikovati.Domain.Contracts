using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.PartFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    BendFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    UnfoldFeature;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    FlangeFeature;

public interface IFlangeDefinition
{
    bool ApplyAutoMitering { get; set; }
    IBendOptions BendOptions { get; set; }
    BendPositionEnum BendPosition { get; set; }
    object BendRadius { get; set; }
    ICornerOptions CornerOptions { get; set; }
    IEdgeCollection Edges { get; set; }
    object FlangeAngle { get; set; }
    IPartFeatureExtent HeightExtent { get; }
    PartFeatureExtentEnum HeightExtentType { get; }
    object MiterGap { get; set; }
    IFlangeFeature Parent { get; }
    IUnfoldMethod UnfoldMethod { get; set; }
    IPartFeatureExtent DefaultWidthExtent { get; }
    PartFeatureExtentEnum DefaultWidthExtentType { get; }
    bool IsUnfoldMethodOverridden { get; set; }
    object FlangeAngleReferencePlane { get; set; }
    IFlangeDefinition Copy();
    void SetCenteredWidthExtent(IEdge Edge, object Width);

    void SetDistanceHeightExtent(object Distance, PartFeatureExtentDirectionEnum ExtentDirection,
        HeightDatumTypeEnum HeightDatumType);

    void SetEdgeWidthExtent(IEdge Edge);
    void SetFromToWidthExtent(IEdge Edge, object FromEntity, object ToEntity);

    void SetLegacyDistanceHeightExtent(object Distance, PartFeatureExtentDirectionEnum ExtentDirection,
        HeightDatumTypeEnum HeightDatumType);

    void SetOffsetWidthExtent(IEdge Edge, object OffsetEntityOne, object OffsetDistanceOne, object OffsetEntityTwo,
        object OffsetDistanceTwo);

    void SetToHeightExtent(object ToEntity, object Offset);

    void SetWidthOffsetWidthExtent(IEdge Edge, object Width, object OffsetDistance, object OffsetEntity,
        bool PositiveDirection);

    void SetCenteredDefaultWidthExtent(object Width);
    void SetEdgeDefaultWidthExtent();
    void SetFromToDefaultWidthExtent(object FromEntity, object ToEntity);

    void SetOffsetDefaultWidthExtent(object OffsetEntityOne, object OffsetDistanceOne, object OffsetEntityTwo,
        object OffsetDistanceTwo);

    void SetWidthOffsetDefaultWidthExtent(object Width, object OffsetDistance, object OffsetEntity,
        bool PositiveDirection);

    IPartFeatureExtent GetWidthExtent(IEdge Edge);
    PartFeatureExtentEnum GetWidthExtentType(IEdge Edge, out bool HasOverride);
    void RemoveOverrideWidthExtent(IEdge Edge);
}