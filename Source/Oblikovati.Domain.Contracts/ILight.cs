using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

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
