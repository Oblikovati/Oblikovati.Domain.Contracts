using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IExtrudeFeatures : IList<IExtrudeFeatures>
{

    IExtrudeFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IExtrudeFeature AddByDistanceExtent(IProfile Profile, object Distance, PartFeatureExtentDirectionEnum ExtentDirection, PartFeatureOperationEnum Operation, object TaperAngle);
    IExtrudeFeature AddByToFaceExtent(IProfile Profile, object ToFace, bool ExtendToFace, PartFeatureOperationEnum Operation, object TaperAngle);
    IExtrudeFeature AddByToExtent(IProfile Profile, object ToEntity, PartFeatureOperationEnum Operation, bool ExtendToFace, object TaperAngle);
    IExtrudeFeature AddByFromToExtent(IProfile Profile, object FromFace, bool ExtendFromFace, object ToFace, bool ExtendToFace, PartFeatureOperationEnum Operation, object TaperAngle);
    IExtrudeFeature _AddByToNextExtent(IProfile Profile, PartFeatureExtentDirectionEnum ExtentDirection, PartFeatureOperationEnum Operation, object TaperAngle);
    IExtrudeFeature AddByToNextExtent(IProfile Profile, PartFeatureExtentDirectionEnum ExtentDirection, ISurfaceBody Terminator, PartFeatureOperationEnum Operation, object TaperAngle);
    IExtrudeFeature AddByThroughAllExtent(IProfile Profile, PartFeatureExtentDirectionEnum ExtentDirection, PartFeatureOperationEnum Operation, object TaperAngle);
    IExtrudeFeature Add(IExtrudeDefinition Definition);
    IExtrudeDefinition CreateExtrudeDefinition(IProfile Profile, PartFeatureOperationEnum Operation);
}
