using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.SweepFeature;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.NotClassified;

public interface IPathAndGuideRailSweepDef
{
    ISweepFeature Parent { get; }
    SweepProfileScalingEnum ProfileScaling { get; set; }
    IPath GuideRail { get; set; }
}