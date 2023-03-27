using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IBrowserPanesSink_Event
{
    void add_OnBrowserNodeActivate(BrowserPanesSink_OnBrowserNodeActivateEventHandler handler);
    void remove_OnBrowserNodeActivate(BrowserPanesSink_OnBrowserNodeActivateEventHandler handler);
    void add_OnBrowserNodeGetDisplayObjects(BrowserPanesSink_OnBrowserNodeGetDisplayObjectsEventHandler handler);
    void remove_OnBrowserNodeGetDisplayObjects(BrowserPanesSink_OnBrowserNodeGetDisplayObjectsEventHandler handler);
    void add_OnBrowserNodeLabelEdit(BrowserPanesSink_OnBrowserNodeLabelEditEventHandler handler);
    void remove_OnBrowserNodeLabelEdit(BrowserPanesSink_OnBrowserNodeLabelEditEventHandler handler);
    void add_OnBrowserNodeDeleteEntry(BrowserPanesSink_OnBrowserNodeDeleteEntryEventHandler handler);
    void remove_OnBrowserNodeDeleteEntry(BrowserPanesSink_OnBrowserNodeDeleteEntryEventHandler handler);
    void add_OnBrowserNodesReorder(BrowserPanesSink_OnBrowserNodesReorderEventHandler handler);
    void remove_OnBrowserNodesReorder(BrowserPanesSink_OnBrowserNodesReorderEventHandler handler);
}
