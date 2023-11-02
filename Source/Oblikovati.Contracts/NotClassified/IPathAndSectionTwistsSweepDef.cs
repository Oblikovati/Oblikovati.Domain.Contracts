using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.SweepFeature;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.Parameters;

namespace Oblikovati.Contracts.NotClassified;

public interface IPathAndSectionTwistsSweepDef
{
    ISweepFeature Parent { get; }
    IParameter TaperAngle { get; }
    SweepProfileOrientationEnum ProfileOrientation { get; set; }
    void GetSectionTwists(out IObjectCollection SectionTwistPoints, out IObjectCollection SectionTwistVectors);
    void SetSectionTwists(IObjectCollection SectionTwistPoints, IObjectCollection SectionTwistVectors);
}