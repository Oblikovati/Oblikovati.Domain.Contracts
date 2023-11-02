namespace Oblikovati.Contracts.NotClassified;

public interface IEdgeUses : IList<IEdgeUses>
{
    IEdgeUse Item { get; }
}