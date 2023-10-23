namespace Oblikovati.Contracts.Application.TransactionManager;

public interface ICheckPoint
{
    /// <summary>
    /// Gets the numeric identifier of this check point.
    /// </summary>
    Guid Id { get; }
    /// <summary>
    /// Gets the user-friendly display name of this check point.
    /// </summary>
    string DisplayName { get; }
    /// <summary>
    /// Gets the transaction in which this check point is defined.
    /// </summary>
    ITransaction ContainingTransaction { get; }
}