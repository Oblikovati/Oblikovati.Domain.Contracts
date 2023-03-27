using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IRevolveFeatures : IList<IRevolveFeatures>
{

    IRevolveFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IRevolveFeature _AddFull(IProfile Profile, ISketchLine AxisEntity, PartFeatureOperationEnum Operation);
    IRevolveFeature _AddByAngle(IProfile Profile, ISketchLine AxisEntity, object Angle, PartFeatureExtentDirectionEnum ExtentDirection, PartFeatureOperationEnum Operation);
    IRevolveFeature AddFull(IProfile Profile, object AxisEntity, PartFeatureOperationEnum Operation);
    IRevolveFeature AddByAngle(IProfile Profile, object AxisEntity, object Angle, PartFeatureExtentDirectionEnum ExtentDirection, PartFeatureOperationEnum Operation);
    IRevolveFeature AddByFromToExtent(IProfile Profile, object AxisEntity, object FromFace, bool ExtendFromFace, object ToFace, bool ExtendToFace, PartFeatureExtentDirectionEnum ExtentDirection, bool MinimumSolution, PartFeatureOperationEnum Operation);
    IRevolveFeature AddByToFaceExtent(IProfile Profile, object AxisEntity, object ToFace, bool ExtendToFace, PartFeatureExtentDirectionEnum ExtentDirection, bool MinimumSolution, PartFeatureOperationEnum Operation);
    IRevolveFeature AddByToNextExtent(IProfile Profile, object AxisEntity, PartFeatureExtentDirectionEnum ExtentDirection, ISurfaceBody Terminator, PartFeatureOperationEnum Operation);
}
