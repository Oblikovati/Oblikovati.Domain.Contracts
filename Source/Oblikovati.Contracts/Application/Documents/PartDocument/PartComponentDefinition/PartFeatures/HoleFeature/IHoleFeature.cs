using Oblikovati.Contracts.Application.AssetLibraries;
using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;
using Oblikovati.Contracts.Application.Documents.DrawingDocument.DrawingStylesManager;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.PartFeature;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.ClientGraphics.ComponentDefinition;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.Parameters;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.HoleFeature;

public interface IHoleFeature
{
    IComponentDefinition Parent { get; }
    IAttributeSets AttributeSets { get; }
    string Name { get; set; }
    HealthStatusEnum HealthStatus { get; }
    bool Adaptive { get; set; }
    IBox RangeBox { get; }
    IFaces Faces { get; }
    ISurfaceBody SurfaceBody { get; }
    bool Suppressed { get; set; }
    IComponentOccurrencesEnumerator Participants { get; }
    IParametersEnumerator Parameters { get; }
    bool Shared { get; set; }
    bool ConsumeInputs { get; set; }
    bool IsOwnedByFeature { get; }
    IPartFeature OwnedBy { get; }
    IFeatureDimensions FeatureDimensions { get; }
    ISurfaceBodies SurfaceBodies { get; }
    string ExtendedName { get; }
    IAsset Appearance { get; set; }
    AppearanceSourceTypeEnum AppearanceSourceType { get; set; }
    HoleTypeEnum HoleType { get; }
    bool Tapped { get; set; }
    object TapInfo { get; set; }
    bool FlatBottom { get; }
    IParameter BottomTipAngle { get; }
    IParameter HoleDiameter { get; }
    IParameter CBoreDiameter { get; }
    IParameter CSinkDiameter { get; }
    IParameter CBoreDepth { get; }
    IParameter CSinkAngle { get; }
    IParameter SpotFaceDiameter { get; }
    IParameter SpotFaceDepth { get; }
    IFaces EndFaces { get; }
    IFaces SideFaces { get; }
    IPlanarSketch Sketch { get; }
    IObjectCollection HoleCenterPoints { get; set; }
    PartFeatureExtentEnum ExtentType { get; }
    IPartFeatureExtent Extent { get; }
    double Depth { get; }
    IHoleClearanceInfo ClearanceInfo { get; set; }
    bool IsClearanceHole { get; }
    double CSinkDepth { get; }
    HolePlacementTypeEnum PlacementType { get; }
    IHolePlacementDefinition PlacementDefinition { get; set; }
    bool ExtendStart { get; set; }
    void Delete(bool RetainConsumedSketches, bool RetainDependentFeaturesAndSketches, bool RetainDependentWorkFeatures);
    IRenderStyle GetRenderStyle(out StyleSourceTypeEnum StyleSourceType);
    void SetRenderStyle(StyleSourceTypeEnum StyleSourceType, object RenderStyle);
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void SetEndOfPart(bool Before);
    void RemoveParticipant(IComponentOccurrence Occurrence);

    bool GetSuppressionCondition(out IParameter Parameter, out ComparisonTypeEnum ComparisonType,
        out object Expression);

    void SetSuppressionCondition(IParameter Parameter, ComparisonTypeEnum ComparisonType, object Expression);
    void SetAffectedBodies(IObjectCollection Bodies);
    void SetDrilled();
    void SetCBore(object CBoreDiameter, object CBoreDepth);
    void SetCSink(object CSinkDiameter, object CSinkAngle);
    void SetSpotFace(object SpotFaceDiameter, object SpotFaceDepth);

    void SetDistanceExtent(object Depth, PartFeatureExtentDirectionEnum ExtentDirection, bool FlatBottom,
        object BottomTipAngle);

    void SetToFaceExtent(object ToFace, bool ExtendToFace);
    void SetThroughAllExtent(PartFeatureExtentDirectionEnum ExtentDirection);
    void AddParticipant(IComponentOccurrence Occurrence);
}