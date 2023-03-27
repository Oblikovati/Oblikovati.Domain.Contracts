using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IDockableWindowsEventsSink
{
    void OnHelp(IDockableWindow DockableWindow, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnHide(IDockableWindow DockableWindow, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnShow(IDockableWindow DockableWindow, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
}
