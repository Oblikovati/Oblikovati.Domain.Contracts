namespace Oblikovati.Domain.Contracts;

public interface IThemeManager
{
    ITheme ActiveTheme { get; }
    IThemesEnumerator Themes { get; }
    IColor GetComponentThemeColor(string ComponentName);
}
