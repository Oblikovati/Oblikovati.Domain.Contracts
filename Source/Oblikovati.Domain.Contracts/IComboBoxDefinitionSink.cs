using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IComboBoxDefinitionSink
{
    void OnSelect(INameValueMap Context);
    void OnHelp(INameValueMap Context, out HandlingCodeEnum HandlingCode);
}
