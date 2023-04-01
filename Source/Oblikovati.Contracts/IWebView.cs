using Oblikovati.Contracts.Application.ViewFramesEnumerator;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts;

public interface IWebView
{
    string Caption { get; set; }
    string InternalName { get; }
    int Height { get; set; }
    int Width { get; set; }
    int HWND { get; }
    int Left { get; set; }
    int Top { get; set; }

    WindowsSizeEnum WindowState { get; set; }
    bool Visible { get; set; }
    IViewTab ViewTab { get; }
    void Activate();
    void Close();
    void Move(int Top, int Left, int Height, int Width);
    void StartAction(string ActionType, object ActionData);
    void Navigate(string Url);
}