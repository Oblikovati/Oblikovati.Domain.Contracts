﻿using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ISweepFeature
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
    IFaces EndFaces { get; }
    IFaces SideFaces { get; }
    PartFeatureOperationEnum Operation { get; set; }
    IPath Path { get; set; }
    IProfile Profile { get; set; }
    IFaces StartFaces { get; }
    IParameter TaperAngle { get; }
    I_SweepDefinition _Definition { get; }
    SweepDefinitionTypeEnum DefinitionType { get; }
    ISweepDefinition Definition { get; set; }
    bool IsSolidSweep { get; }
    ISolidSweepDefinition SolidSweepDefinition { get; set; }
    void Delete(bool RetainConsumedSketches, bool RetainDependentFeaturesAndSketches, bool RetainDependentWorkFeatures);
    IRenderStyle GetRenderStyle(out StyleSourceTypeEnum StyleSourceType);
    void SetRenderStyle(StyleSourceTypeEnum StyleSourceType, object RenderStyle);
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void SetEndOfPart(bool Before);
    void RemoveParticipant(IComponentOccurrence Occurrence);
    bool GetSuppressionCondition(out IParameter Parameter, out ComparisonTypeEnum ComparisonType, out object Expression);
    void SetSuppressionCondition(IParameter Parameter, ComparisonTypeEnum ComparisonType, object Expression);
    void SetAffectedBodies(IObjectCollection Bodies);
    void SetUsingPath(SweepProfileOrientationEnum ProfileOrientation, object TaperAngle);
    void SetUsingPathAndGuideRail(IPath GuideRail, SweepProfileScalingEnum ProfileScaling);
    void SetUsingPathAndGuideSurface(object GuideSurface);
    void SetUsingPathAndSectionTwists(IObjectCollection SectionTwistPoints, IObjectCollection SectionTwistVectors, SweepProfileOrientationEnum ProfileOrientation, object TaperAngle);
    void AddParticipant(IComponentOccurrence Occurrence);
}
