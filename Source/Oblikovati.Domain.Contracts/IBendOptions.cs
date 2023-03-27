using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IBendOptions
{
    BendTransitionEnum BendTransition { get; set; }
    BendReliefShapeEnum BendReliefShape { get; set; }
    object BendReliefWidth { get; set; }
    object BendReliefDepth { get; set; }
    object MinimumRemnant { get; set; }
    object BendTransitionArcRadius { get; set; }

    IBendOptions Copy();
}
