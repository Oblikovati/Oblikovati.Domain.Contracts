using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IBrowserNodeDefinitionSink_Event
{
    void add_OnLabelEdit(BrowserNodeDefinitionSink_OnLabelEditEventHandler handler);
    void remove_OnLabelEdit(BrowserNodeDefinitionSink_OnLabelEditEventHandler handler);
}
