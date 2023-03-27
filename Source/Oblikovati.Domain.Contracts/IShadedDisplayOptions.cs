using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IShadedDisplayOptions
{

    bool DepthDimming { get; set; }
    bool EdgeDisplayForActiveComponents { get; set; }
    bool EdgeDisplayForEnabledComponents { get; set; }
    IColor EdgeColorForActiveComponents { get; set; }
    IColor EdgeColorForEnabledComponents { get; set; }
    bool ShadedBackgroundComponents { get; set; }
    bool ShadedEnabledComponents { get; set; }
    int ShadeOpacityForBackgroundComponents { get; set; }
    int ShadeOpacityForEnabledComponents { get; set; }
    bool SilhouettesForActiveComponents { get; set; }
    bool SilhouettesForBackgroundComponents { get; set; }
    bool SilhouettesForEnabledComponents { get; set; }
    TransparencyTypeEnum TransparencyType { get; set; }
}
