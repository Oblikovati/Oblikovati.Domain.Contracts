using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IIRxUserInputEvents
{
    void OnStartCommand(CommandIDEnum CommandID);
    void OnStopCommand(CommandIDEnum CommandID);
}
