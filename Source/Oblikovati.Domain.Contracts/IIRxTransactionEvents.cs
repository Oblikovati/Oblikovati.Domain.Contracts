using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IIRxTransactionEvents
{
    void OnCommit(ITransaction Transaction, EventTimingEnum BeforeOrAfter, out HandlingCodeEnum HandlingCode);
    void OnUndo(ITransaction Transaction, EventTimingEnum BeforeOrAfter, out HandlingCodeEnum HandlingCode);
    void OnRedo(ITransaction Transaction, EventTimingEnum BeforeOrAfter, out HandlingCodeEnum HandlingCode);
    void OnAbort(ITransaction Transaction, EventTimingEnum BeforeOrAfter);
    void OnDelete(ITransaction Transaction, EventTimingEnum BeforeOrAfter);
}
