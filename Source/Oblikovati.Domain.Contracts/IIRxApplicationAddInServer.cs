namespace Oblikovati.Domain.Contracts;

public interface IIRxApplicationAddInServer
{
    object Automation { get; }
    void Activate(IIRxApplicationAddInSite pAddInSite, short FirstTime);
    void Deactivate();
    void ExecuteCommand(int CommandID);
}
