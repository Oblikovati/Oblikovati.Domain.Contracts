using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IPathAndGuideRailSweepDef
{

    ISweepFeature Parent { get; }
    SweepProfileScalingEnum ProfileScaling { get; set; }
    IPath GuideRail { get; set; }
}
