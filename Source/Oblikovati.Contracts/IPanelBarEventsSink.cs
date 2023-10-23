using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Application.UserInterfaceManager.CommandBars;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts;

public interface IPanelBarEventsSink
{
    void OnCommandBarSelection(ICommandBar CommandBar, EventTiming BeforeOrAfter, INameValueMap Context,
        out HandlingCodeEnum HandlingCode);
}