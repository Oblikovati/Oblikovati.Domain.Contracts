using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IWebBrowserDialogEventsSink_Event
{
    void add_OnClose(WebBrowserDialogEventsSink_OnCloseEventHandler handler);
    void remove_OnClose(WebBrowserDialogEventsSink_OnCloseEventHandler handler);
    void add_OnHelp(WebBrowserDialogEventsSink_OnHelpEventHandler handler);
    void remove_OnHelp(WebBrowserDialogEventsSink_OnHelpEventHandler handler);
}
