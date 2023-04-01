using Oblikovati.Contracts.Application.WebBrowserDialogs;

namespace Oblikovati.Contracts.Application.UserInterfaceManager.DockableWindows;

public interface IDockableWindows : IList<IDockableWindow>
{
    IDockableWindowsEvents Events { get; }
    IDockableWindow Add(string ClientId, string InternalName, string Title);
    IWebBrowserDockableWindow AddWithWebBrowser(string ClientId, string InternalName, string Title);
}