using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.NotClassified;

public interface ISculptSurface
{
    PartFeatureExtentDirectionEnum Direction { get; set; }
    object Surface { get; set; }
}