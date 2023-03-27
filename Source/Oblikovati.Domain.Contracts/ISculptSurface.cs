using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ISculptSurface
{
    PartFeatureExtentDirectionEnum Direction { get; set; }
    object Surface { get; set; }
}
