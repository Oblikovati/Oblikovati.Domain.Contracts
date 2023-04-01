using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application;

public interface IHardwareOptions : IInjectableSingletonEntity
{
    GraphicsDriverTypeEnum GraphicsDriverType { get; set; }
    bool WarnForUnrecommendedDriver { get; set; }
    bool WarnForDriverErrors { get; set; }
    GraphicsOptimizationEnum GraphicsOptimization { get; set; }
    string Diagnostics { get; }
    GraphicsSettingTypeEnum GraphicsSettingType { get; set; }
    bool UseSoftwareGraphics { get; set; }
}