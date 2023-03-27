namespace Oblikovati.Domain.Contracts;

public interface IIRxApplicationAddInSiteOld
{

    object CreateCommand(string CommandName, int CommandID, object InstallInTools);
}
