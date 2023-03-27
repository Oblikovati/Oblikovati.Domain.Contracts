using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IClientBrowserNodeDefinitionSink_Event
{
    void add_OnActivate(ClientBrowserNodeDefinitionSink_OnActivateEventHandler handler);
    void remove_OnActivate(ClientBrowserNodeDefinitionSink_OnActivateEventHandler handler);
    void add_OnGetDisplayObjects(ClientBrowserNodeDefinitionSink_OnGetDisplayObjectsEventHandler handler);
    void remove_OnGetDisplayObjects(ClientBrowserNodeDefinitionSink_OnGetDisplayObjectsEventHandler handler);
    void add_OnLabelEdit(ClientBrowserNodeDefinitionSink_OnLabelEditEventHandler handler);
    void remove_OnLabelEdit(ClientBrowserNodeDefinitionSink_OnLabelEditEventHandler handler);
}
