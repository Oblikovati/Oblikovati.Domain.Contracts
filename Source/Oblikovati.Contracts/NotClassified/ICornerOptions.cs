using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.NotClassified;

public interface ICornerOptions
{
    CornerReliefShapeEnum CornerReliefShape { get; set; }
    object CornerReliefSize { get; set; }
    bool IsTwoBend { get; }

    CornerReliefPlacementEnum CornerReliefPlacement { get; set; }
    ICornerOptions Copy();
}