using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.PartFeature;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.Parameters;

namespace Oblikovati.Contracts.NotClassified;

public interface IChamferDefinition
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