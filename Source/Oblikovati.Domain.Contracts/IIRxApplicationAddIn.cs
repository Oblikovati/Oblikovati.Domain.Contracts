using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IIRxApplicationAddIn
{
    Guid ClassId { get; }
    string ProgId { get; }
    string DisplayName { get; }
    string ShortDisplayName { get; }
    string Description { get; }
    short StartUpEnabled { get; set; }
    ApplicationAddInTypeEnum AddInType { get; }
    short Activated { get; }
    void GetInterface(Guid InterfaceIID, out IntPtr ppInterfacePtr);
    void Activate();
    void Deactivate();
}
