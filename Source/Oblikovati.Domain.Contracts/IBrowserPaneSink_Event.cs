using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IBrowserPaneSink_Event
{
    void add_OnActivate(BrowserPaneSink_OnActivateEventHandler handler);
    void remove_OnActivate(BrowserPaneSink_OnActivateEventHandler handler);
    void add_OnDeactivate(BrowserPaneSink_OnDeactivateEventHandler handler);
    void remove_OnDeactivate(BrowserPaneSink_OnDeactivateEventHandler handler);
    void add_OnHelp(BrowserPaneSink_OnHelpEventHandler handler);
    void remove_OnHelp(BrowserPaneSink_OnHelpEventHandler handler);
}
