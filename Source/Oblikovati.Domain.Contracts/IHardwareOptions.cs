using Oblikovati.Domain.Contracts.DependencyInjection;
using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

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
