namespace Oblikovati.Domain.Contracts;

public interface IEdgeDefinition
{

    int AssociativeID { get; set; }
    IFaceDefinition FaceOne { get; set; }
    IFaceDefinition FaceTwo { get; set; }
    bool IsParamReversed { get; set; }
    object ModelSpaceCurve { get; set; }
    object ParameterSpaceCurveOne { get; set; }
    object ParameterSpaceCurveTwo { get; set; }
    IVertexDefinition StartVertex { get; set; }
    IVertexDefinition EndVertex { get; set; }
}
