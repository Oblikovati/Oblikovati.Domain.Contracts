using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IButtonDefinitionSink
{
    void OnExecute(INameValueMap Context);
    void OnHelp(INameValueMap Context, out HandlingCodeEnum HandlingCode);
}
