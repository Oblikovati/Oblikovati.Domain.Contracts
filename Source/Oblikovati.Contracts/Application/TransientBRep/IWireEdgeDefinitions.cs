namespace Oblikovati.Contracts.Application.TransientBRep;

public interface IWireEdgeDefinitions : IList<IWireEdgeDefinitions>
{
    IWireEdgeDefinition Item { get; }


    IWireEdgeDefinition Add(IVertexDefinition StartVertex, IVertexDefinition EndVertex, object ModelSpaceCurve);
}