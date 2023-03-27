using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IPathSweepDef
{

    ISweepFeature Parent { get; }
    SweepProfileOrientationEnum ProfileOrientation { get; set; }
    IParameter TaperAngle { get; }
}
