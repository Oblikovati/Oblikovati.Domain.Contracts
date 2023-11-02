using Oblikovati.Contracts.Application.AssetLibraries;
using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;
using Oblikovati.Contracts.Application.Documents.DrawingDocument.DrawingStylesManager;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.
    CircularPatternFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.PartFeature;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.ClientGraphics.ComponentDefinition;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.NotClassified;
using Oblikovati.Contracts.Parameters;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.
    RectangularPatternFeature;

public interface IRectangularPatternFeature
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
    IFeaturePatternElements PatternElements { get; }
    IObjectCollection ParentFeatures { get; set; }
    object XDirectionEntity { get; set; }
    bool NaturalXDirection { get; set; }
    IParameter XCount { get; }
    IParameter XSpacing { get; }
    PatternSpacingTypeEnum XDirectionSpacingType { get; set; }
    object XDirectionStartPoint { get; set; }
    object YDirectionEntity { get; set; }
    bool NaturalYDirection { get; set; }
    IParameter YCount { get; }
    IParameter YSpacing { get; }
    PatternSpacingTypeEnum YDirectionSpacingType { get; set; }
    object YDirectionStartPoint { get; set; }
    bool _AdjustToModel { get; }
    PatternOrientationEnum OrientationMethod { get; set; }
    PatternComputeTypeEnum ComputeType { get; set; }
    bool PatternOfBody { get; }
    bool XDirectionMidPlanePattern { get; set; }
    bool YDirectionMidPlanePattern { get; set; }
    bool SurfacesVisible { get; set; }
    bool SurfacesOpaque { get; set; }
    bool NewBodyOperation { get; set; }
    IRectangularPatternFeatureDefinition Definition { get; set; }
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
    void AddParticipant(IComponentOccurrence Occurrence);
}