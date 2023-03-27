using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IModelingSettings
{

    IDocument Parent { get; }
    bool AdaptivelyUsedInAssembly { get; set; }
    bool CompactModelHistory { get; set; }
    string Snap3DAngle { get; set; }
    string Snap3DDistance { get; set; }
    ModelDiameterFromThreadEnum TappedHoleDiameter { get; set; }
    bool UpdateLegacyHoles { get; set; }
    bool AdvancedFeatureValidation { get; set; }
    bool AutoFindErrorsAfterManualRepair { get; set; }
    bool AllowSectioningThruPart { get; set; }
    InteractiveContactAnalysisEnum InteractiveContactAnalysis { get; set; }
    InteractiveContactSurfacesEnum InteractiveContactSurfaces { get; set; }
    bool MaintainEnhancedGraphicsDetail { get; set; }
    string SolidBodyNamePrefix { get; set; }
    string SurfaceBodyNamePrefix { get; set; }
    IUserCoordinateSystemSettings UserCoordinateSystemSettings { get; }
    double InitialDrawingViewHeight { get; set; }
    double InitialDrawingViewWidth { get; set; }
    bool ShowConstraintStateInBrowser { get; set; }
}
