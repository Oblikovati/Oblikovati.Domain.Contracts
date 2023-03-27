using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IDockableWindowsEventsSink_Event
{
    void add_OnHelp(DockableWindowsEventsSink_OnHelpEventHandler handler);
    void remove_OnHelp(DockableWindowsEventsSink_OnHelpEventHandler handler);
    void add_OnHide(DockableWindowsEventsSink_OnHideEventHandler handler);
    void remove_OnHide(DockableWindowsEventsSink_OnHideEventHandler handler);
    void add_OnShow(DockableWindowsEventsSink_OnShowEventHandler handler);
    void remove_OnShow(DockableWindowsEventsSink_OnShowEventHandler handler);
}
