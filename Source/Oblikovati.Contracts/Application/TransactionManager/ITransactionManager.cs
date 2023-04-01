using Oblikovati.Contracts.Application.Documents.Document;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.TransactionManager;

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