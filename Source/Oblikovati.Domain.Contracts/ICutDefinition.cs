using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ICutDefinition
{

    bool CutAcrossBends { get; }
    IPartFeatureExtent Extent { get; }
    PartFeatureExtentEnum ExtentType { get; }
    ICutFeature Parent { get; }
    IProfile Profile { get; set; }
    bool CutNormalToFlat { get; set; }
    void SetCutAcrossBendsExtent(object Distance);
    void SetToExtent(object ToFace, bool ExtendToFace);
    void SetToNextExtent(PartFeatureExtentDirectionEnum Direction);
    void SetThroughAllExtent(PartFeatureExtentDirectionEnum Direction);
    void SetFromToExtent(object FromFace, bool ExtendFromFace, object ToFace, bool ExtendToFace);
    void SetDistanceExtent(object Distance, PartFeatureExtentDirectionEnum Direction);
}
