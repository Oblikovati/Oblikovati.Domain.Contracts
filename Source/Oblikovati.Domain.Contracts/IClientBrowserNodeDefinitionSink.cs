using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IClientBrowserNodeDefinitionSink
{
    void OnActivate(INameValueMap Context);
    void OnGetDisplayObjects(out IObjectCollection Objects, INameValueMap Context);
    void OnLabelEdit(string NewLabel, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
}
