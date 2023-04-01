using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.PartFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    BendFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    UnfoldFeature;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    HemFeature;

public interface IHemDefinition
{
    IBendOptions BendOptions { get; set; }
    IEdgeCollection Edges { get; set; }
    HemTypeEnum HemType { get; }
    object HemTypeDefinition { get; }
    IHemFeature Parent { get; }
    IUnfoldMethod UnfoldMethod { get; set; }
    PartFeatureExtentEnum WidthExtentType { get; }
    IPartFeatureExtent WidthExtent { get; }
    bool IsOnEdgeSide { get; set; }
    bool IsUnfoldMethodOverridden { get; set; }
    IHemDefinition Copy();
    void SetDoubleHemType(object Gap, object Length);
    void SetRolledHemType(object Radius, object Angle);
    void SetSingleHemType(object Gap, object Length);
    void SetTeardropHemType(object Radius, object Angle);
    void SetCenteredWidthExtent(object Width);
    void SetEdgeWidthExtent();
    void SetFromToWidthExtent(object FromEntity, object ToEntity);

    void SetOffsetWidthExtent(object OffsetEntityOne, object OffsetDistanceOne, object OffsetEntityTwo,
        object OffsetDistanceTwo);

    void SetWidthOffsetWidthExtent(object Width, object OffsetDistance, object OffsetEntity, bool PositiveDirection);
}