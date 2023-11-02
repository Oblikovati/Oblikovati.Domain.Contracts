using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    CornerChamferFeature;

public interface ICornerChamferDefinition
{
    IChamferDefinition ChamferDefinition { get; }
    ChamferDefinitionTypeEnum ChamferDefinitionType { get; }
    IEdgeCollection CornerEdges { get; set; }
    ICornerChamferFeature Parent { get; }
    ICornerChamferDefinition Copy();
    void SetDistance(IEdgeCollection CornerEdges, object Distance);
    void SetDistanceAndAngle(IEdgeCollection CornerEdges, IFace Face, object Distance, object Angle);
    void SetTwoDistances(IEdge CornerEdge, IFace Face, object DistanceOne, object DistanceTwo);
}