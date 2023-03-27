using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IDistanceExtent
{

    IPartFeature Parent { get; }
    IParameter Distance { get; }
    PartFeatureExtentDirectionEnum Direction { get; set; }
}
