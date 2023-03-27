using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IPanelBarEventsSink
{
    void OnCommandBarSelection(ICommandBar CommandBar, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
}
