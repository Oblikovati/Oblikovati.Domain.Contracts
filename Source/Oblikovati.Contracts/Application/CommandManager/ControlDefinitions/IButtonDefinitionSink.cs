using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.CommandManager.ControlDefinitions;

public interface IButtonDefinitionSink
{
    void OnExecute(INameValueMap Context);
    void OnHelp(INameValueMap Context, out HandlingCodeEnum HandlingCode);
}