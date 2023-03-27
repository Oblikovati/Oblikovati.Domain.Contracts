using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IIRxApplicationEvents
{
    void OnNewDocument(IDocument DocumentObject);
    void OnOpenDocument(IDocument DocumentObject);
    void OnSaveDocument(IDocument Document, EventTimingEnum BeforeOrAfter);
    void OnCloseDocument(IDocument Document, EventTimingEnum BeforeOrAfter);
    void OnActivateDocument(IDocument DocumentObject);
    void OnDeactivateDocument(IDocument DocumentObject);
    void OnNewView(IView ViewObject);
    void OnCloseView(IView ViewObject);
    void OnActivateView(IView ViewObject);
    void OnDeactivateView(IView ViewObject);
    void OnQuit();
}
