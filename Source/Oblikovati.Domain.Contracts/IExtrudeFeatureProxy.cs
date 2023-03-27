using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IExtrudeFeatureProxy
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
    IFaces StartFaces { get; }
    IFaces EndFaces { get; }
    IFaces SideFaces { get; }
    IParameter TaperAngle { get; }
    PartFeatureOperationEnum Operation { get; set; }
    IProfile Profile { get; set; }
    PartFeatureExtentEnum ExtentType { get; }
    IPartFeatureExtent Extent { get; }
    IPartFeatureExtent ExtentTwo { get; }
    PartFeatureExtentEnum ExtentTwoType { get; }
    bool IsTwoDirectional { get; }
    IParameter TaperAngleTwo { get; }
    IExtrudeDefinition Definition { get; set; }
    IExtrudeFeature NativeObject { get; }
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
    void SetDistanceExtent(object Distance, PartFeatureExtentDirectionEnum ExtentDirection);
    void SetToFaceExtent(object ToFace, bool ExtendToFace);
    void SetToExtent(object ToEntity, bool ExtendToFace);
    void SetFromToExtent(object FromFace, bool ExtendFromFace, object ToFace, bool ExtendToFace);
    void _SetToNextExtent(PartFeatureExtentDirectionEnum ExtentDirection);
    void SetToNextExtent(PartFeatureExtentDirectionEnum ExtentDirection, ISurfaceBody Terminator);
    void SetThroughAllExtent(PartFeatureExtentDirectionEnum ExtentDirection);
    void AddParticipant(IComponentOccurrence Occurrence);
}
