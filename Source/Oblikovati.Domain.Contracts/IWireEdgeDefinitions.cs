namespace Oblikovati.Domain.Contracts;

public interface IWireEdgeDefinitions : IList<IWireEdgeDefinitions>
{

    IWireEdgeDefinition Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IWireEdgeDefinition Add(IVertexDefinition StartVertex, IVertexDefinition EndVertex, object ModelSpaceCurve);
}
