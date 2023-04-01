using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    RipFeature;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.Parameters;

namespace Oblikovati.Contracts;

public interface ISinglePointRipTypeDef
{
    IRipDefinition Parent { get; }
    object Point { get; set; }
    IParameter GapSize { get; }
    PartFeatureExtentDirectionEnum GapSide { get; set; }
}