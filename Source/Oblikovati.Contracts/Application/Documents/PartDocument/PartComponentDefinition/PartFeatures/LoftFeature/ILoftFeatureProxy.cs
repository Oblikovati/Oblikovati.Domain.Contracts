using Oblikovati.Contracts.Application.AssetLibraries;
using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;
using Oblikovati.Contracts.Application.Documents.DrawingDocument.DrawingStylesManager;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.PartFeature;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.ClientGraphics.ComponentDefinition;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.NotClassified;
using Oblikovati.Contracts.Parameters;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.LoftFeature;

public interface ILoftFeatureProxy
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
    bool Closed { get; }
    IFace StartFace { get; }
    IFace EndFace { get; }
    IFaces SideFaces { get; }
    IParameter FirstSectionAngle { get; }
    LoftConditionEnum FirstSectionCondition { get; }
    IParameter FirstSectionImpact { get; }
    IParameter LastSectionAngle { get; }
    LoftConditionEnum LastSectionCondition { get; }
    IParameter LastSectionImpact { get; }
    IMapPointCurves MapPointCurves { get; }
    PartFeatureOperationEnum Operation { get; }
    IObjectCollection Rails { get; }
    IObjectCollection Sections { get; }
    object Centerline { get; }
    bool FirstSectionDirectionReversed { get; }
    object FirstSectionTangentPlane { get; }
    bool LastSectionDirectionReversed { get; }
    object LastSectionTangentPlane { get; }
    ILoftRails LoftRails { get; }
    LoftTypeEnum LoftType { get; }
    bool MergeTangentFaces { get; }
    ILoftDefinition Definition { get; set; }
    ILoftFeature NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
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
}