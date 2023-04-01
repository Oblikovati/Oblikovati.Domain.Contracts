namespace Oblikovati.Contracts;

public interface IEdgeLoops : IList<IEdgeLoops>
{
    IEdgeLoop Item { get; }
}