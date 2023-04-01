namespace Oblikovati.Contracts.Application.ApplicationAddIns;

public interface IApplicationAddIns : IList<IApplicationAddIn>
{
    //IApplicationAddIn ItemById { get; }
    void UpdateAddInList();
}