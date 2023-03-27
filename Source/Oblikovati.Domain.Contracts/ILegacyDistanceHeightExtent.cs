using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ILegacyDistanceHeightExtent
{

    IPartFeature Parent { get; }
    IParameter Distance { get; }
    PartFeatureExtentDirectionEnum FlangeDirection { get; set; }
}
