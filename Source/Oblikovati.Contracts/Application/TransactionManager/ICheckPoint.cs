namespace Oblikovati.Contracts.Application.TransactionManager;

public interface ICheckPoint
{
    ITransactionManager Parent { get; }

    int Id { get; }
    string DisplayName { get; }
    ITransaction ContainingTransaction { get; }
}