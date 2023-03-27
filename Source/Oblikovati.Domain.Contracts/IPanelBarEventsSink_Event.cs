using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IPanelBarEventsSink_Event
{
    void add_OnCommandBarSelection(PanelBarEventsSink_OnCommandBarSelectionEventHandler handler);
    void remove_OnCommandBarSelection(PanelBarEventsSink_OnCommandBarSelectionEventHandler handler);
}
