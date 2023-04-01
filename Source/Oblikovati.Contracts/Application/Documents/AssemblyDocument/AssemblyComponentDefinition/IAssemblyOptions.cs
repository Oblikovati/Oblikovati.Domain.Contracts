using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition;

public interface IAssemblyOptions : IInjectableSingletonEntity
{
    bool OnlyActiveComponentIsOpaque { get; set; }
    bool PartFeaturesInitiallyAdaptive { get; set; }
    bool DeferUpdate { get; set; }
    bool DeleteComponentPatternSources { get; set; }
    bool EnableConstraintRedundancyAnalysis { get; set; }
    bool SectionAllParts { get; set; }
    bool FromToExtentsMatePlane { get; set; }
    bool FromToExtentsAdaptFeature { get; set; }
    bool EnableCrossPartEdgeLoopProjection { get; set; }
    ZoomTargetComponentWithiMateEnum ZoomTargetComponentWithiMate { get; set; }
    bool ConstraintAudioNotification { get; set; }
    bool UseiMate { get; set; }
    bool EnableRelatedConstraintFailureAnalysis { get; set; }
    LevelOfDetailEnum DefaultLevelOfDetail { get; set; }
    DesignViewTypeEnum DefaultDesignView { get; set; }
    bool DefaultDesignViewIsAssociative { get; set; }
    bool UseLastOccurrenceOrientationForPlacement { get; set; }
    bool DisplayComponentNamesInConstraints { get; set; }
    bool SkipAllUnresolvedFiles { get; set; }
    bool EnableCrossPartSketchGeometryProjection { get; set; }
    bool EnableAssemblyLite { get; set; }
    int AssemblyLiteMinimumUniqueDocument { get; set; }
    bool EnableAssemblyExpress { get; set; }
    int AssemblyExpressMinimumUniqueDocument { get; set; }
    bool PlaceAndGroundFirstComponentAtOrigin { get; set; }
}