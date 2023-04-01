using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.Sketch2D.Profiles;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.CoilFeature;

public interface ICoilFeatures : IList<ICoilFeatures>
{
    ICoilFeature Item { get; }


    ICoilFeature AddByPitchAndRevolution(IProfile Profile, object AxisEntity, object Pitch, object Revolution,
        PartFeatureOperationEnum Operation, bool AxisDirectionReversed, bool ClockwiseRotation, object TaperAngle,
        bool FlatStartType, object StartTransitionAngle, object StartFlatAngle, bool FlatEndType,
        object EndTransitionAngle, object EndFlatAngle);

    ICoilFeature AddByRevolutionAndHeight(IProfile Profile, object AxisEntity, object Revolution, object Height,
        PartFeatureOperationEnum Operation, bool AxisDirectionReversed, bool ClockwiseRotation, object TaperAngle,
        bool FlatStartType, object StartTransitionAngle, object StartFlatAngle, bool FlatEndType,
        object EndTransitionAngle, object EndFlatAngle);

    ICoilFeature AddByPitchAndHeight(IProfile Profile, object AxisEntity, object Pitch, object Height,
        PartFeatureOperationEnum Operation, bool AxisDirectionReversed, bool ClockwiseRotation, object TaperAngle,
        bool FlatStartType, object StartTransitionAngle, object StartFlatAngle, bool FlatEndType,
        object EndTransitionAngle, object EndFlatAngle);

    ICoilFeature AddSpiral(IProfile Profile, object AxisEntity, object Pitch, object Revolution,
        PartFeatureOperationEnum Operation, bool AxisDirectionReversed, bool ClockwiseRotation);
}