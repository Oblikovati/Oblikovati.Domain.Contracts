namespace Oblikovati.Domain.Contracts;

public interface IEdgeUseDefinitions : IList<IEdgeUseDefinitions>
{

    IEdgeUseDefinition Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IEdgeUseDefinition Add(IEdgeDefinition EdgeDefinition, bool IsOpposedToEdge);
}
