using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.Document.BrowserPanes;

public interface IClientBrowserNodeDefinitionSink
{
    void OnActivate(INameValueMap Context);
    void OnGetDisplayObjects(out IObjectCollection Objects, INameValueMap Context);

    void OnLabelEdit(string NewLabel, EventTiming BeforeOrAfter, INameValueMap Context,
        out HandlingCodeEnum HandlingCode);
}