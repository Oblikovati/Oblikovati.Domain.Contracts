using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IIRxDocumentEvents
{
    void OnSave(EventTimingEnum BeforeOrAfter);
    void OnClose(EventTimingEnum BeforeOrAfter);
    void OnActivate();
    void OnDeactivate();
    void OnNewView(IView ViewObject);
    void OnCloseView(IView ViewObject);
    void OnActivateView(IView ViewObject);
    void OnDeactivateView(IView ViewObject);
}
