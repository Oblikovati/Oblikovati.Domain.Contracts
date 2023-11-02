using Oblikovati.Contracts.Application.TransientBRep;

namespace Oblikovati.Contracts.NotClassified;

public interface IEdgeDefinitions : IList<IEdgeDefinitions>
{
    IEdgeDefinition Item { get; }


    IEdgeDefinition Add(IVertexDefinition StartVertex, IVertexDefinition EndVertex, object ModelSpaceCurve,
        object ParameterSpaceCurveOne, object FaceOne, object ParameterSpaceCurveTwo, object FaceTwo);
}