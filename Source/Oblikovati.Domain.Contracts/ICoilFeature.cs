using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ICoilFeature
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
    bool AxisDirectionReversed { get; set; }
    IProfile Profile { get; set; }
    PartFeatureOperationEnum Operation { get; set; }
    bool ClockwiseRotation { get; set; }
    PartFeatureExtentEnum ExtentType { get; }
    IPartFeatureExtent Extent { get; }
    bool FlatStartType { get; set; }
    IParameter StartTransitionAngle { get; }
    IParameter StartFlatAngle { get; }
    bool FlatEndType { get; set; }
    IParameter EndTransitionAngle { get; }
    IParameter EndFlatAngle { get; }
    void Delete(bool RetainConsumedSketches, bool RetainDependentFeaturesAndSketches, bool RetainDependentWorkFeatures);
    IRenderStyle GetRenderStyle(out StyleSourceTypeEnum StyleSourceType);
    void SetRenderStyle(StyleSourceTypeEnum StyleSourceType, object RenderStyle);
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void SetEndOfPart(bool Before);
    void RemoveParticipant(IComponentOccurrence Occurrence);
    bool GetSuppressionCondition(out IParameter Parameter, out ComparisonTypeEnum ComparisonType, out object Expression);
    void SetSuppressionCondition(IParameter Parameter, ComparisonTypeEnum ComparisonType, object Expression);
    void SetAffectedBodies(IObjectCollection Bodies);
    void SetPitchAndRevolutionExtent(object Pitch, object Revolution, object TaperAngle);
    void SetRevolutionAndHeightExtent(object Revolution, object Height, object TaperAngle);
    void SetPitchAndHeightExtent(object Pitch, object Height, object TaperAngle);
    void SetSpiralExtent(object Pitch, object Revolution);
}
