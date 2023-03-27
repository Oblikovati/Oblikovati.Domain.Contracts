using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IIRxDocumentEvents_Event
{
    void add_OnSave(IRxDocumentEvents_OnSaveEventHandler handler);
    void remove_OnSave(IRxDocumentEvents_OnSaveEventHandler handler);
    void add_OnClose(IRxDocumentEvents_OnCloseEventHandler handler);
    void remove_OnClose(IRxDocumentEvents_OnCloseEventHandler handler);
    void add_OnActivate(IRxDocumentEvents_OnActivateEventHandler handler);
    void remove_OnActivate(IRxDocumentEvents_OnActivateEventHandler handler);
    void add_OnDeactivate(IRxDocumentEvents_OnDeactivateEventHandler handler);
    void remove_OnDeactivate(IRxDocumentEvents_OnDeactivateEventHandler handler);
    void add_OnNewView(IRxDocumentEvents_OnNewViewEventHandler handler);
    void remove_OnNewView(IRxDocumentEvents_OnNewViewEventHandler handler);
    void add_OnCloseView(IRxDocumentEvents_OnCloseViewEventHandler handler);
    void remove_OnCloseView(IRxDocumentEvents_OnCloseViewEventHandler handler);
    void add_OnActivateView(IRxDocumentEvents_OnActivateViewEventHandler handler);
    void remove_OnActivateView(IRxDocumentEvents_OnActivateViewEventHandler handler);
    void add_OnDeactivateView(IRxDocumentEvents_OnDeactivateViewEventHandler handler);
    void remove_OnDeactivateView(IRxDocumentEvents_OnDeactivateViewEventHandler handler);
}
