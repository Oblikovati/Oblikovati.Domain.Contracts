using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ICosmeticWeldDefinition
{

    object Area { get; set; }
    PartFeatureExtentEnum ExtentType { get; }
    IEdgeCollection Edges { get; set; }
    object FromFace { get; }
    object ToFace { get; }
    void SetFromToExtent(object FromFace, object ToFace);
    void SetThroughAllExtent();
    ICosmeticWeldDefinition Copy();
}
