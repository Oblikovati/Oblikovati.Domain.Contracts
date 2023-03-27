using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ICornerOptions
{
    CornerReliefShapeEnum CornerReliefShape { get; set; }
    object CornerReliefSize { get; set; }
    bool IsTwoBend { get; }

    CornerReliefPlacementEnum CornerReliefPlacement { get; set; }
    ICornerOptions Copy();
}
