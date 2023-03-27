using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IRevolveFeatureProxy
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
    object AxisEntity { get; set; }
    ISketchLine _AxisEntity { get; set; }
    IFaces StartFaces { get; }
    IFaces EndFaces { get; }
    IFaces SideFaces { get; }
    IProfile Profile { get; set; }
    PartFeatureOperationEnum Operation { get; set; }
    PartFeatureExtentEnum ExtentType { get; }
    IPartFeatureExtent Extent { get; }
    IPartFeatureExtent ExtentTwo { get; }
    PartFeatureExtentEnum ExtentTwoType { get; }
    bool IsTwoDirectional { get; }
    IRevolveFeature NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    void Delete(bool RetainConsumedSketches, bool RetainDependentFeaturesAndSketches, bool RetainDependentWorkFeatures);
    IRenderStyle GetRenderStyle(out StyleSourceTypeEnum StyleSourceType);
    void SetRenderStyle(StyleSourceTypeEnum StyleSourceType, object RenderStyle);
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void SetEndOfPart(bool Before);
    void RemoveParticipant(IComponentOccurrence Occurrence);
    bool GetSuppressionCondition(out IParameter Parameter, out ComparisonTypeEnum ComparisonType, out object Expression);
    void SetSuppressionCondition(IParameter Parameter, ComparisonTypeEnum ComparisonType, object Expression);
    void SetAffectedBodies(IObjectCollection Bodies);
    void SetFullExtent();
    void SetAngleExtent(object Angle, PartFeatureExtentDirectionEnum ExtentDirection);
    void SetFromToExtent(object FromFace, bool ExtendFromFace, object ToFace, bool ExtendToFace, PartFeatureExtentDirectionEnum ExtentDirection, bool MinimumSolution);
    void SetToFaceExtent(object ToFace, bool ExtendToFace, PartFeatureExtentDirectionEnum ExtentDirection, bool MinimumSolution);
    void SetToNextExtent(PartFeatureExtentDirectionEnum ExtentDirection, ISurfaceBody Terminator);
    void AddParticipant(IComponentOccurrence Occurrence);
}
