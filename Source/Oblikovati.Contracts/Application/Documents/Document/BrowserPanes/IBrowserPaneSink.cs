using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.Document.BrowserPanes;

public interface IBrowserPaneSink
{
    void OnActivate();
    void OnDeactivate();
    void OnHelp(EventTiming BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
}