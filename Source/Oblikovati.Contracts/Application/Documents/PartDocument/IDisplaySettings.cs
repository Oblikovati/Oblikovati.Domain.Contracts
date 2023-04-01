using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.PartDocument;

public interface IDisplaySettings
{
    bool DepthDimming { get; set; }
    bool DisplaySilhouettes { get; set; }
    IColor EdgeColor { get; set; }
    IGroundPlaneSettings GroundPlaneSettings { get; }
    int HiddenLineDimmingPercent { get; set; }
    DisplayModeEnum NewWindowDisplayMode { get; set; }
    ProjectionTypeEnum NewWindowProjectionType { get; set; }
    bool NewWindowShowGroundPlane { get; set; }
    bool NewWindowShowGroundReflections { get; set; }

    bool SolidLinesForHiddenEdges { get; set; }
    bool NewWindowShowAmbientShadows { get; set; }
    bool NewWindowShowGroundShadows { get; set; }
    bool NewWindowShowObjectShadows { get; set; }
    bool UseRayTracingForRealisticDisplay { get; set; }
    RayTracingQualityEnum RayTracingQuality { get; set; }
    bool AreTexturesOn { get; set; }
}