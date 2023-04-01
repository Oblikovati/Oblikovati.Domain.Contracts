using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts.Application;

public interface IThemeManager
{
    ITheme ActiveTheme { get; }
    IThemesEnumerator Themes { get; }
    IColor GetComponentThemeColor(string ComponentName);
}