using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IWebBrowserDialog
{
    WindowsSizeEnum DisabledWindowState { get; set; }
    int Height { get; set; }
    int HWND { get; }
    string InternalName { get; }
    int Left { get; set; }
    bool Modal { get; }
    string Title { get; set; }
    int Top { get; set; }
    bool Visible { get; set; }
    IWebBrowserDialogEvents WebBrowserDialogEvents { get; }
    int Width { get; set; }
    WindowsSizeEnum WindowState { get; set; }
    void Delete();
    void Move(int Top, int Left, int Height, int Width);
    void Navigate(string Url);
    void Refresh();
}
