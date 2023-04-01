using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.PartFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    BendFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    UnfoldFeature;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    ContourFlangeFeature;

public interface IContourFlangeDefinition
{
    bool ApplyAutoMitering { get; set; }
    IBendOptions BendOptions { get; set; }
    object BendRadius { get; set; }
    ICornerOptions CornerOptions { get; set; }
    IEdgeCollection Edges { get; set; }
    PartFeatureExtentDirectionEnum ExtentDirection { get; set; }
    object MiterGap { get; set; }
    IContourFlangeFeature Parent { get; }
    IPath Path { get; set; }
    IUnfoldMethod UnfoldMethod { get; set; }
    PartFeatureExtentEnum DefaultWidthExtentType { get; }
    IPartFeatureExtent DefaultWidthExtent { get; }
    bool ExtendFaces { get; set; }
    bool IsUnfoldMethodOverridden { get; set; }
    PartFeatureOperationEnum Operation { get; set; }
    IObjectCollection AffectedBodies { get; set; }
    bool UseDefaultSheetMetalRule { get; set; }
    ISheetMetalStyle SheetMetalRule { get; set; }
    IContourFlangeDefinition Copy();
    void SetCenteredWidthExtent(IEdge Edge, object Width);
    void SetDistanceExtent(object Distance, PartFeatureExtentDirectionEnum ExtentDirection);
    void SetEdgeWidthExtent(IEdge Edge);
    void SetFromToWidthExtent(IEdge Edge, object FromEntity, object ToEntity);

    void SetOffsetWidthExtent(IEdge Edge, object OffsetEntityOne, object OffsetDistanceOne, object OffsetEntityTwo,
        object OffsetDistanceTwo);

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
}