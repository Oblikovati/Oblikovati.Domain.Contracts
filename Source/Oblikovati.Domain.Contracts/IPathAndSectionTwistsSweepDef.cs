using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IPathAndSectionTwistsSweepDef
{

    ISweepFeature Parent { get; }
    IParameter TaperAngle { get; }
    SweepProfileOrientationEnum ProfileOrientation { get; set; }
    void GetSectionTwists(out IObjectCollection SectionTwistPoints, out IObjectCollection SectionTwistVectors);
    void SetSectionTwists(IObjectCollection SectionTwistPoints, IObjectCollection SectionTwistVectors);
}
