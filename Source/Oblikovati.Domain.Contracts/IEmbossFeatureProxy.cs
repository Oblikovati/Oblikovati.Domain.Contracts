using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IEmbossFeatureProxy
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
    EmbossTypeEnum EmbossType { get; }
    IParameter Depth { get; }
    PartFeatureExtentDirectionEnum Direction { get; set; }
    IProfile Profile { get; set; }
    IParameter Taper { get; }
    IRenderStyle TopFaceColor { get; set; }
    IFace WrapFace { get; set; }
    bool WrapToFace { get; }
    IAsset TopFaceAppearance { get; set; }
    AppearanceSourceTypeEnum TopFaceAppearanceSourceType { get; set; }
    IEmbossFeature NativeObject { get; }
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
    void SetEmbossFromFace(object Distance, PartFeatureExtentDirectionEnum ExtentDirection, object WrapFace);
    void SetEngraveFromFace(object Distance, PartFeatureExtentDirectionEnum ExtentDirection, object WrapFace);
    void SetEmbossEngraveFromPlane(object Taper, PartFeatureExtentDirectionEnum ExtentDirection);
}
