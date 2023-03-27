namespace Oblikovati.Domain.Contracts;

public interface IDockableWindows : IList<IDockableWindow>
{

    IDockableWindowsEvents Events { get; }
    IDockableWindow Add(string ClientId, string InternalName, string Title);
    IWebBrowserDockableWindow AddWithWebBrowser(string ClientId, string InternalName, string Title);
}
