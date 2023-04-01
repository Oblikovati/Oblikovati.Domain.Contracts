namespace Oblikovati.Contracts.Application.DisplayOptions;

public interface IWireframeDisplayOptions
{
    bool DepthDimming { get; set; }
    bool SilhouettesForActiveComponents { get; set; }
    bool DimmedHiddenEdgesForActiveComponents { get; set; }
    bool SilhouettesForEnabledComponents { get; set; }
    bool DimmedHiddenEdgesForEnabledComponents { get; set; }
    bool SilhouettesForBackgroundComponents { get; set; }
}