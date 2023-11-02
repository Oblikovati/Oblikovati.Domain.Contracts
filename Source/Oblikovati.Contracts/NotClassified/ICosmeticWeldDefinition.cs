using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.NotClassified;

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