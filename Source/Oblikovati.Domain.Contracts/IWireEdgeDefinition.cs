namespace Oblikovati.Domain.Contracts;

public interface IWireEdgeDefinition
{

    int AssociativeID { get; set; }
    bool IsParamReversed { get; set; }
    object ModelSpaceCurve { get; set; }
    IVertexDefinition StartVertex { get; set; }
    IVertexDefinition EndVertex { get; set; }
}
