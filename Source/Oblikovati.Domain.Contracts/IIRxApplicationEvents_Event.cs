using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IIRxApplicationEvents_Event
{
    void add_OnNewDocument(IRxApplicationEvents_OnNewDocumentEventHandler handler);
    void remove_OnNewDocument(IRxApplicationEvents_OnNewDocumentEventHandler handler);
    void add_OnOpenDocument(IRxApplicationEvents_OnOpenDocumentEventHandler handler);
    void remove_OnOpenDocument(IRxApplicationEvents_OnOpenDocumentEventHandler handler);
    void add_OnSaveDocument(IRxApplicationEvents_OnSaveDocumentEventHandler handler);
    void remove_OnSaveDocument(IRxApplicationEvents_OnSaveDocumentEventHandler handler);
    void add_OnCloseDocument(IRxApplicationEvents_OnCloseDocumentEventHandler handler);
    void remove_OnCloseDocument(IRxApplicationEvents_OnCloseDocumentEventHandler handler);
    void add_OnActivateDocument(IRxApplicationEvents_OnActivateDocumentEventHandler handler);
    void remove_OnActivateDocument(IRxApplicationEvents_OnActivateDocumentEventHandler handler);
    void add_OnDeactivateDocument(IRxApplicationEvents_OnDeactivateDocumentEventHandler handler);
    void remove_OnDeactivateDocument(IRxApplicationEvents_OnDeactivateDocumentEventHandler handler);
    void add_OnNewView(IRxApplicationEvents_OnNewViewEventHandler handler);
    void remove_OnNewView(IRxApplicationEvents_OnNewViewEventHandler handler);
    void add_OnCloseView(IRxApplicationEvents_OnCloseViewEventHandler handler);
    void remove_OnCloseView(IRxApplicationEvents_OnCloseViewEventHandler handler);
    void add_OnActivateView(IRxApplicationEvents_OnActivateViewEventHandler handler);
    void remove_OnActivateView(IRxApplicationEvents_OnActivateViewEventHandler handler);
    void add_OnDeactivateView(IRxApplicationEvents_OnDeactivateViewEventHandler handler);
    void remove_OnDeactivateView(IRxApplicationEvents_OnDeactivateViewEventHandler handler);
    void add_OnQuit(IRxApplicationEvents_OnQuitEventHandler handler);
    void remove_OnQuit(IRxApplicationEvents_OnQuitEventHandler handler);
}
