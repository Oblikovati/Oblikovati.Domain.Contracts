using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.CommandManager.InteractionEvents;

public interface IInteractionEventsSink
{
    void OnActivate();
    void OnTerminate();
    void OnSuspend();
    void OnResume();
    void OnHelp(EventTiming BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
}