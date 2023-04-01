using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.SweepFeature;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.Sketch2D.Profiles;

namespace Oblikovati.Contracts;

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