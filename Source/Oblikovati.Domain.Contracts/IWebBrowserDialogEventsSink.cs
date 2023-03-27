using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IWebBrowserDialogEventsSink
{
    void OnClose(EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnHelp(INameValueMap Context, out HandlingCodeEnum HandlingCode);
}
