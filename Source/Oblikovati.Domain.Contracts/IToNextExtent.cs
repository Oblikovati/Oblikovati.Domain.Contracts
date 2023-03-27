using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IToNextExtent
{

    IPartFeature Parent { get; }
    PartFeatureExtentDirectionEnum Direction { get; set; }
    ISurfaceBody Terminator { get; set; }
}
