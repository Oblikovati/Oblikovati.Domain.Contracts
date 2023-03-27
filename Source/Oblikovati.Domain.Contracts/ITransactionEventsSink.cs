using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ITransactionEventsSink
{
    void OnCommit(ITransaction Transaction, INameValueMap Context, EventTimingEnum BeforeOrAfter, out HandlingCodeEnum HandlingCode);
    void OnUndo(ITransaction Transaction, INameValueMap Context, EventTimingEnum BeforeOrAfter, out HandlingCodeEnum HandlingCode);
    void OnRedo(ITransaction Transaction, INameValueMap Context, EventTimingEnum BeforeOrAfter, out HandlingCodeEnum HandlingCode);
    void OnAbort(ITransaction Transaction, INameValueMap Context, EventTimingEnum BeforeOrAfter);
    void OnDelete(ITransaction Transaction, INameValueMap Context, EventTimingEnum BeforeOrAfter);
}
