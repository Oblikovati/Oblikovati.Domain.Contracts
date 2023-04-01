using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.ColorSchemes;

public interface IColorSchemes : IList<IColorScheme>
{
    BackgroundTypeEnum BackgroundType { get; set; }
    ApplicationFrameColorTypeEnum ApplicationFrameColor { get; set; }
    IconsColorTypeEnum IconsColor { get; set; }
    InterfaceStyleEnum InterfaceStyle { get; set; }
    bool EnableEnhancedHighlighting { get; set; }
    bool EnablePrehighlight { get; set; }
}