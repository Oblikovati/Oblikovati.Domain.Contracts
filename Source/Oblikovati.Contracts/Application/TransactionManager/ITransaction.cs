using Oblikovati.Contracts.Application.Documents.Document;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.TransactionManager;

public interface ITransaction
{
    ITransactionManager Parent { get; }

    int Id { get; }
    string DisplayName { get; }
    IDocument Document { get; }
    bool HasParentTransaction { get; }
    ITransaction ParentTransaction { get; }
    ICheckPointsEnumerator CheckPoints { get; }
    ITransactionsEnumerator ChildTransactions { get; }
    TransactionStateEnum State { get; }
    bool MergeWithPrevious { get; set; }
    void IdentifyForDocumentOpen(IDocument Document);
    void End();
    void Abort();
}