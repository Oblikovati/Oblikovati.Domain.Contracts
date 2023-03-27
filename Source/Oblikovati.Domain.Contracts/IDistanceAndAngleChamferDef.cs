using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IDistanceAndAngleChamferDef
{

    IPartFeature Parent { get; }
    ChamferDefinitionTypeEnum DefinitionType { get; }
    IEdgeCollection ChamferedEdges { get; set; }
    bool AutomaticEdgeChain { get; }
    bool PreserveAllFeatures { get; set; }
    bool CornerSetback { get; set; }
    IFace Face { get; }
    IParameter Distance { get; }
    IParameter Angle { get; }
    IParameter DistanceOne { get; }
    IParameter DistanceTwo { get; }
    IPartialChamferEdges PartialChamferEdges { get; set; }
    IPartialChamferEdges CreatePartialChamferEdges();
}
