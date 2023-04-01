namespace Oblikovati.Contracts;

public interface IEdges : IList<IEdges>
{
    IEdge Item { get; }
}