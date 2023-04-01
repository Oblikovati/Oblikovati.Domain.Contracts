using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.TransactionManager;

public interface ITransactionEventsSink
{
    void OnCommit(ITransaction Transaction, INameValueMap Context, EventTimingEnum BeforeOrAfter,
        out HandlingCodeEnum HandlingCode);

    void OnUndo(ITransaction Transaction, INameValueMap Context, EventTimingEnum BeforeOrAfter,
        out HandlingCodeEnum HandlingCode);

    void OnRedo(ITransaction Transaction, INameValueMap Context, EventTimingEnum BeforeOrAfter,
        out HandlingCodeEnum HandlingCode);

    void OnAbort(ITransaction Transaction, INameValueMap Context, EventTimingEnum BeforeOrAfter);
    void OnDelete(ITransaction Transaction, INameValueMap Context, EventTimingEnum BeforeOrAfter);
}