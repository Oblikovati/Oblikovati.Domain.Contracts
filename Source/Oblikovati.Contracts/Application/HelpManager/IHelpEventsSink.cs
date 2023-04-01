using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.HelpManager;

public interface IHelpEventsSink
{
    void OnApplicationHelp(INameValueMap Context, out HandlingCodeEnum HandlingCode);
}