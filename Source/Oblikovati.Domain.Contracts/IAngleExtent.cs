using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IAngleExtent
{

    IPartFeature Parent { get; }
    IParameter Angle { get; }
    PartFeatureExtentDirectionEnum Direction { get; set; }
}
