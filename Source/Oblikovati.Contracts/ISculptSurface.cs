using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts;

public interface ISculptSurface
{
    PartFeatureExtentDirectionEnum Direction { get; set; }
    object Surface { get; set; }
}