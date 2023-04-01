using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.WebBrowserDialogs;

public interface IWebBrowserDialogEventsSink
{
    void OnClose(EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnHelp(INameValueMap Context, out HandlingCodeEnum HandlingCode);
}