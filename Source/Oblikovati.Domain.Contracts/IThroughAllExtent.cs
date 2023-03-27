using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IThroughAllExtent
{

    IPartFeature Parent { get; }
    PartFeatureExtentDirectionEnum Direction { get; set; }
}
