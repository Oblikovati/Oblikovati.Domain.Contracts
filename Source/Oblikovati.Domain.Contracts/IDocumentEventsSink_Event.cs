using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IDocumentEventsSink_Event
{
    void add_OnSave(DocumentEventsSink_OnSaveEventHandler handler);
    void remove_OnSave(DocumentEventsSink_OnSaveEventHandler handler);
    void add_OnClose(DocumentEventsSink_OnCloseEventHandler handler);
    void remove_OnClose(DocumentEventsSink_OnCloseEventHandler handler);
    void add_OnActivate(DocumentEventsSink_OnActivateEventHandler handler);
    void remove_OnActivate(DocumentEventsSink_OnActivateEventHandler handler);
    void add_OnDeactivate(DocumentEventsSink_OnDeactivateEventHandler handler);
    void remove_OnDeactivate(DocumentEventsSink_OnDeactivateEventHandler handler);
    void add_OnChangeSelectSet(DocumentEventsSink_OnChangeSelectSetEventHandler handler);
    void remove_OnChangeSelectSet(DocumentEventsSink_OnChangeSelectSetEventHandler handler);
    void add_OnChange(DocumentEventsSink_OnChangeEventHandler handler);
    void remove_OnChange(DocumentEventsSink_OnChangeEventHandler handler);
    void add_OnDelete(DocumentEventsSink_OnDeleteEventHandler handler);
    void remove_OnDelete(DocumentEventsSink_OnDeleteEventHandler handler);
}
