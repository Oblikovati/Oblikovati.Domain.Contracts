namespace Oblikovati.Contracts.Application.ApplicationAddIns;

public interface IApplicationAddInServer
{
    void Activate(IApplicationAddInSite AddInSite, bool FirstTime);
    void Deactivate();
    void ExecuteCommand(int CommandID);
}