namespace Oblikovati.Contracts;

public interface IEdgeUses : IList<IEdgeUses>
{
    IEdgeUse Item { get; }
}