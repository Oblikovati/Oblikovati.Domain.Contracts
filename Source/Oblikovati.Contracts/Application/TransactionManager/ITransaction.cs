using Oblikovati.Contracts.Application.Documents.Document;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.TransactionManager;

public interface ITransaction
{
    /// <summary>
    /// Gets the unique identifier for this transaction.
    /// </summary>
    Guid Id { get; }
    
    /// <summary>
    /// Gets the display name of this transaction.
    /// </summary>
    string DisplayName { get; }
    /// <summary>
    /// Gets the affected by this transaction.
    /// </summary>
    IDocument Document { get; }
    /// <summary>
    /// Gets the Boolean flag indicating if this transaction is a child of another transaction.
    /// </summary>
    bool HasParentTransaction { get; }
    /// <summary>
    /// Property that returns the parent transaction, if one exists; else returns null.
    /// </summary>
    ITransaction ParentTransaction { get; }
    /// <summary>
    /// Gets the enumeration of all of the check points that may be present in this transaction.
    /// </summary>
    ICheckPointsEnumerator CheckPoints { get; }
    /// <summary>
    /// Gets the enumeration of all of the child transactions that this transaction may contain.
    /// </summary>
    ITransactionsEnumerator ChildTransactions { get; }
    /// <summary>
    /// Property that returns a TransactionStateEnum that describes the current state of the transaction.
    /// </summary>
    TransactionState State { get; }
    /// <summary>
    /// Gets and sets whether to merge this transaction with the previously committed transaction.
    /// </summary>
    bool MergeWithPrevious { get; set; }

    /// <summary>
    /// Method that ends this transaction. This method will fail if this transaction is not the current transaction.
    /// </summary>
    void End();
    /// <summary>
    /// Method that aborts this transaction. This method will fail if this transaction is not the current transaction.
    /// </summary>
    void Abort();
}