using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ITransactionManager : IInjectableSingletonEntity
{
    ITransactionsEnumerator CommittedTransactions { get; }
    ITransactionsEnumerator UndoneTransactions { get; }
    ITransaction CurrentTransaction { get; }
    ITransactionEvents TransactionEvents { get; }
    ITransaction StartTransaction(IDocument Document, string DisplayName);
    ITransaction StartGlobalTransaction(IDocument Document, string DisplayName);
    ICheckPoint SetCheckPoint();
    void UndoTransaction();
    void GoToCheckPoint(ICheckPoint CheckPoint);
    void RedoTransaction();
    ITransaction _StartUnidentifiedTransaction();
    ITransaction StartTransactionForDocumentOpen(string DisplayName);
    void ClearAllTransactions();
    ITransaction StartTransactionWithOptions(IDocument Document, string DisplayName, INameValueMap Options);
    ITransaction EndTransaction();
    void AbortTransaction(TransactionPointEnum TransactionPoint, object TransactionObject);
}
