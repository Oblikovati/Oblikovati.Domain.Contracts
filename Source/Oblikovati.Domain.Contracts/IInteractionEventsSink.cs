using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IInteractionEventsSink
{
    void OnActivate();
    void OnTerminate();
    void OnSuspend();
    void OnResume();
    void OnHelp(EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
}
