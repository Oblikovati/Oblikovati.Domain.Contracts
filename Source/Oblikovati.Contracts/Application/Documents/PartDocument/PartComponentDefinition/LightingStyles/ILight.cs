using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.LightingStyles;

public interface ILight
{
    ILightingStyle Parent { get; }
    LightTypeEnum LightType { get; set; }
    LightDefinitionTypeEnum LightDefinitionType { get; set; }
    IColor Color { get; set; }
    double Intensity { get; set; }
    bool On { get; set; }
    IPoint Position { get; set; }
    IVector Direction { get; set; }
    double SpotLightFalloff { get; set; }
    double SpotLightInnerAngle { get; set; }
    double SpotLightCutoffAngle { get; set; }
    double ConstantAttenuation { get; set; }
    double LinearAttenuation { get; set; }
    double QuadraticAttenuation { get; set; }
}