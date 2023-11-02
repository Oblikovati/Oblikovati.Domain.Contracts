namespace Oblikovati.Contracts.NotClassified;

public interface IEdges : IList<IEdges>
{
    IEdge Item { get; }
}