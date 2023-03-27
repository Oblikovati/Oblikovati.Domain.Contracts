using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IPointToPointRipTypeDef
{
    IRipDefinition Parent { get; }
    object PointOne { get; set; }
    object PointTwo { get; set; }
    IParameter GapSize { get; }
    PartFeatureExtentDirectionEnum GapSide { get; set; }
}
