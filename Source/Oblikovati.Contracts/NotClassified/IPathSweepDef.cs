using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.SweepFeature;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.Parameters;

namespace Oblikovati.Contracts.NotClassified;

public interface IPathSweepDef
{
    ISweepFeature Parent { get; }
    SweepProfileOrientationEnum ProfileOrientation { get; set; }
    IParameter TaperAngle { get; }
}