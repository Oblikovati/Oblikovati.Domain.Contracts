using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ISolidSweepDefinition
{

    ISweepFeature Parent { get; }
    IObjectCollection AffectedBodies { get; set; }
    bool KeepToolbody { get; set; }
    PartFeatureOperationEnum Operation { get; set; }
    SweepProfileOrientationEnum Orientation { get; set; }
    IPath Path { get; set; }
    ISurfaceBody ToolBody { get; set; }
    object TwistAngle { get; set; }
    object TwistAxis { get; set; }
    object AlignToVector { get; set; }
    ISolidSweepDefinition Copy();
    void SetTwistInfo(object TwistAngle, object TwistAxis);
    void SetOrientationInfo(SweepProfileOrientationEnum Orientation, object AlignToVector);
}
