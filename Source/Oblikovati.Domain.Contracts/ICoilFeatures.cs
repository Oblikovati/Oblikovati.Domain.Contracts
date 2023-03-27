using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ICoilFeatures : IList<ICoilFeatures>
{

    ICoilFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    ICoilFeature AddByPitchAndRevolution(IProfile Profile, object AxisEntity, object Pitch, object Revolution, PartFeatureOperationEnum Operation, bool AxisDirectionReversed, bool ClockwiseRotation, object TaperAngle, bool FlatStartType, object StartTransitionAngle, object StartFlatAngle, bool FlatEndType, object EndTransitionAngle, object EndFlatAngle);
    ICoilFeature AddByRevolutionAndHeight(IProfile Profile, object AxisEntity, object Revolution, object Height, PartFeatureOperationEnum Operation, bool AxisDirectionReversed, bool ClockwiseRotation, object TaperAngle, bool FlatStartType, object StartTransitionAngle, object StartFlatAngle, bool FlatEndType, object EndTransitionAngle, object EndFlatAngle);
    ICoilFeature AddByPitchAndHeight(IProfile Profile, object AxisEntity, object Pitch, object Height, PartFeatureOperationEnum Operation, bool AxisDirectionReversed, bool ClockwiseRotation, object TaperAngle, bool FlatStartType, object StartTransitionAngle, object StartFlatAngle, bool FlatEndType, object EndTransitionAngle, object EndFlatAngle);
    ICoilFeature AddSpiral(IProfile Profile, object AxisEntity, object Pitch, object Revolution, PartFeatureOperationEnum Operation, bool AxisDirectionReversed, bool ClockwiseRotation);
}
