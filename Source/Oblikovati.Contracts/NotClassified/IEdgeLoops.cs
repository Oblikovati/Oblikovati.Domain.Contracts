namespace Oblikovati.Contracts.NotClassified;

public interface IEdgeLoops : IList<IEdgeLoops>
{
    IEdgeLoop Item { get; }
}