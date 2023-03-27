using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IHelpEventsSink
{
    void OnApplicationHelp(INameValueMap Context, out HandlingCodeEnum HandlingCode);
}
