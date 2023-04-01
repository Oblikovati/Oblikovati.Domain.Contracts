using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.ViewFramesEnumerator;

public interface IViewFrame
{
    IViewTabsEnumerator ViewTabs { get; }
    IViewTabGroupsEnumerator ViewTabGroups { get; }
    bool IsDefault { get; }
    string Caption { get; }
    int Top { get; }
    int Left { get; }
    int Height { get; set; }
    int Width { get; set; }
    WindowsSizeEnum WindowState { get; set; }
    void Arrange(object Value);
    void RestorePreviousLayout();
    void Close();
    void Move(int Top, int Left, int Height, int Width);
}