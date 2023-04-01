using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    RipFeature;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.Parameters;

namespace Oblikovati.Contracts;

public interface IPointToPointRipTypeDef
{
    IRipDefinition Parent { get; }
    object PointOne { get; set; }
    object PointTwo { get; set; }
    IParameter GapSize { get; }
    PartFeatureExtentDirectionEnum GapSide { get; set; }
}