namespace Oblikovati.Domain.Contracts;

public interface IEdgeLoopDefinitions : IList<IEdgeLoopDefinitions>
{

    IEdgeLoopDefinition Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IEdgeLoopDefinition Add();
}
