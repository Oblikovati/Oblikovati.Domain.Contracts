using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IFoldDefinition
{

    IFoldFeature Parent { get; }
    object BendAngle { get; set; }
    ISketchLine BendLine { get; set; }
    BendLocationEnum BendLocation { get; set; }
    IBendOptions BendOptions { get; set; }
    object BendRadius { get; set; }
    bool IsPositiveBendDirection { get; set; }
    bool IsPositiveBendSide { get; set; }
    IUnfoldMethod UnfoldMethod { get; set; }
    bool IsUnfoldMethodOverridden { get; set; }
    IFoldDefinition Copy();
}
