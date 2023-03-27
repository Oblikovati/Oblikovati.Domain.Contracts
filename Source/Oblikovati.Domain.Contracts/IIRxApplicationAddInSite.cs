namespace Oblikovati.Domain.Contracts;

public interface IIRxApplicationAddInSite : IIRxApplicationAddInSiteOld
{

    IIRxApplicationAddIn ApplicationAddIn { get; }
    object CreateCommand(string CommandName, int CommandID, object InstallInTools);
}
