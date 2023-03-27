using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ISplitFeature
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
    bool FaceSplitSplitAll { get; }
    bool PartSplitRemovePositiveSide { get; set; }
    object SplitTool { get; set; }
    SplitToolTypeEnum SplitToolType { get; }
    SplitTypeEnum SplitType { get; }
    bool RemovePositiveSide { get; set; }
    void Delete(bool RetainConsumedSketches, bool RetainDependentFeaturesAndSketches, bool RetainDependentWorkFeatures);
    IRenderStyle GetRenderStyle(out StyleSourceTypeEnum StyleSourceType);
    void SetRenderStyle(StyleSourceTypeEnum StyleSourceType, object RenderStyle);
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void SetEndOfPart(bool Before);
    void RemoveParticipant(IComponentOccurrence Occurrence);
    bool GetSuppressionCondition(out IParameter Parameter, out ComparisonTypeEnum ComparisonType, out object Expression);
    void SetSuppressionCondition(IParameter Parameter, ComparisonTypeEnum ComparisonType, object Expression);
    void SetAffectedBodies(IObjectCollection Bodies);
    void SetToSplitFaces(object SplitTool, bool SplitAll, object FacesOrBody);
    void SetToSplitPart(object SplitTool, bool RemovePositiveSide);
    void SetToSplitBody(object SplitTool, ISurfaceBody Body);
    void SetToTrimSolid(object SplitTool, ISurfaceBody Body, bool RemovePositiveSide);
}
