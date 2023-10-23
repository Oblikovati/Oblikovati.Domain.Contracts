using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.TransactionManager;

public interface ITransactionEvents
{
    public struct OnCommitEventArgs
    {
        public ITransaction Transaction;
        public EventTiming BeforeOrAfter;
    }
    public EventHandler<OnCommitEventArgs> OnCommit { get; set; }
    public struct OnUndoEventArgs
    {
        public ITransaction Transaction;
        public EventTiming BeforeOrAfter;
    }
    public EventHandler<OnUndoEventArgs> OnUndo { get; set; }
    public struct OnRedoEventArgs
    {
        public ITransaction Transaction;
        public EventTiming BeforeOrAfter;
    }
    public EventHandler<OnRedoEventArgs> OnRedo { get; set; }
    public struct OnAbortEventArgs
    {
        public ITransaction Transaction;
        public EventTiming BeforeOrAfter;
    }
    public EventHandler<OnAbortEventArgs> OnAbort { get; set; }
    public struct OnDeleteEventArgs
    {
        public ITransaction Transaction;
        public EventTiming BeforeOrAfter;
    }
    public EventHandler<OnDeleteEventArgs> OnDelete { get; set; }
}