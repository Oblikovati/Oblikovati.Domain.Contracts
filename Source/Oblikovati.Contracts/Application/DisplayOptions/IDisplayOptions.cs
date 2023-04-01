using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.DisplayOptions;

public interface IDisplayOptions : IInjectableSingletonEntity
{
    int HiddenLineDimmingPercent { get; set; }
    double MinimumFrameRate { get; set; }
    IShadedDisplayOptions ShadedDisplayOptions { get; }
    IWireframeDisplayOptions WireframeDisplayOptions { get; }
    double ViewTransitionTime { get; set; }
    DisplayQualityEnum DisplayQuality { get; set; }
    bool ReverseZoomDirection { get; set; }
    bool SolidLinesForHiddenEdges { get; set; }
    bool ZoomToCursor { get; set; }
    OrbitTypeEnum DefaultOrbitType { get; set; }
    DisplayModeEnum NewWindowDisplayMode { get; set; }
    ProjectionTypeEnum NewWindowProjectionType { get; set; }
    bool DepthDimming { get; set; }
    bool DisplaySilhouettes { get; set; }
    IColor EdgeColor { get; set; }
    IColor InactiveComponentsEdgeColor { get; set; }
    bool InactiveComponentsEdgeDisplay { get; set; }
    bool InactiveComponentsShaded { get; set; }
    int InactiveComponentsShadeOpacity { get; set; }
    bool NewWindowShowGroundPlane { get; set; }
    bool NewWindowShowGroundReflections { get; set; }
    bool UseDocumentDisplaySettings { get; set; }
    bool NewWindowShowAmbientShadows { get; set; }
    bool NewWindowShowGroundShadows { get; set; }
    bool NewWindowShowObjectShadows { get; set; }
    bool Show3DIndicator { get; set; }
    bool ShowXYZAxisLabels { get; set; }
    bool UseRayTracingForRealisticDisplay { get; set; }
    RayTracingQualityEnum RayTracingQuality { get; set; }
    bool AreTexturesOn { get; set; }
    bool TrackSelection { get; set; }
}