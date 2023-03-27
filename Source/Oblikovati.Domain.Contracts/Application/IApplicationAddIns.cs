namespace Oblikovati.Domain.Contracts.Application;

public interface IApplicationAddIns : IList<IApplicationAddIn>
{
    //IApplicationAddIn ItemById { get; }
    void UpdateAddInList();
}
