using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ISweepDefinition
{

    ISweepFeature Parent { get; }
    IObjectCollection AffectedBodies { get; set; }
    IObjectCollection AffectedOccurrences { get; set; }
    IPath GuideRail { get; set; }
    object GuideSurface { get; set; }
    PartFeatureOperationEnum Operation { get; set; }
    IPath Path { get; set; }
    IProfile Profile { get; set; }
    SweepProfileOrientationEnum ProfileOrientation { get; set; }
    SweepProfileScalingEnum ProfileScaling { get; set; }
    SweepTypeEnum SweepType { get; set; }
    object TaperAngle { get; set; }
    object TwistAngle { get; set; }
    ISweepDefinition Copy();
    void GetSectionTwists(out IObjectCollection SectionTwistPoints, out IObjectCollection SectionTwistVectors);
    void SetSectionTwists(IObjectCollection SectionTwistPoints, IObjectCollection SectionTwistVectors);
}
