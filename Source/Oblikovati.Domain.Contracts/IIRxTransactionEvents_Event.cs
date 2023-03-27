using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IIRxTransactionEvents_Event
{
    void add_OnCommit(IRxTransactionEvents_OnCommitEventHandler handler);
    void remove_OnCommit(IRxTransactionEvents_OnCommitEventHandler handler);
    void add_OnUndo(IRxTransactionEvents_OnUndoEventHandler handler);
    void remove_OnUndo(IRxTransactionEvents_OnUndoEventHandler handler);
    void add_OnRedo(IRxTransactionEvents_OnRedoEventHandler handler);
    void remove_OnRedo(IRxTransactionEvents_OnRedoEventHandler handler);
    void add_OnAbort(IRxTransactionEvents_OnAbortEventHandler handler);
    void remove_OnAbort(IRxTransactionEvents_OnAbortEventHandler handler);
    void add_OnDelete(IRxTransactionEvents_OnDeleteEventHandler handler);
    void remove_OnDelete(IRxTransactionEvents_OnDeleteEventHandler handler);
}
