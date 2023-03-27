namespace Oblikovati.Domain.Contracts;

public interface IFaceDefinition
{

    int AssociativeID { get; set; }
    IEdgeLoopDefinitions EdgeLoopDefinitions { get; }
    object SurfaceGeometry { get; set; }
    bool IsParamReversed { get; set; }
}
