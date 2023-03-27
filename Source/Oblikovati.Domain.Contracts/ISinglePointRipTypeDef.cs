using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ISinglePointRipTypeDef
{
    IRipDefinition Parent { get; }
    object Point { get; set; }
    IParameter GapSize { get; }
    PartFeatureExtentDirectionEnum GapSide { get; set; }
}
