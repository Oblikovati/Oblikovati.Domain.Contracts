using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface ITransactionEventsSink_Event
{
    void add_OnCommit(TransactionEventsSink_OnCommitEventHandler handler);
    void remove_OnCommit(TransactionEventsSink_OnCommitEventHandler handler);
    void add_OnUndo(TransactionEventsSink_OnUndoEventHandler handler);
    void remove_OnUndo(TransactionEventsSink_OnUndoEventHandler handler);
    void add_OnRedo(TransactionEventsSink_OnRedoEventHandler handler);
    void remove_OnRedo(TransactionEventsSink_OnRedoEventHandler handler);
    void add_OnAbort(TransactionEventsSink_OnAbortEventHandler handler);
    void remove_OnAbort(TransactionEventsSink_OnAbortEventHandler handler);
    void add_OnDelete(TransactionEventsSink_OnDeleteEventHandler handler);
    void remove_OnDelete(TransactionEventsSink_OnDeleteEventHandler handler);
}
