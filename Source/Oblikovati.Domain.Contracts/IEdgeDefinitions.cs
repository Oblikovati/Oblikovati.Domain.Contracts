namespace Oblikovati.Domain.Contracts;

public interface IEdgeDefinitions : IList<IEdgeDefinitions>
{

    IEdgeDefinition Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IEdgeDefinition Add(IVertexDefinition StartVertex, IVertexDefinition EndVertex, object ModelSpaceCurve, object ParameterSpaceCurveOne, object FaceOne, object ParameterSpaceCurveTwo, object FaceTwo);
}
