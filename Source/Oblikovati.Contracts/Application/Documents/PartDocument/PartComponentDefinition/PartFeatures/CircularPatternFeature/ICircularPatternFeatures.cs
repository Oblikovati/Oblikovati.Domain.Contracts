using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.
    CircularPatternFeature;

public interface ICircularPatternFeatures : IList<ICircularPatternFeatures>
{
    ICircularPatternFeature Item { get; }


    ICircularPatternFeature _Add(IObjectCollection ParentFeatures, object AxisEntity, bool NaturalAxisDirection,
        object Count, object Angle, bool FitWithinAngle, bool AdjustToModel);

    ICircularPatternFeature Add(IObjectCollection ParentFeatures, object AxisEntity, bool NaturalAxisDirection,
        object Count, object Angle, bool FitWithinAngle, PatternComputeTypeEnum ComputeType);

    ICircularPatternFeature AddByDefinition(ICircularPatternFeatureDefinition Definition);

    ICircularPatternFeatureDefinition CreateDefinition(IObjectCollection ParentFeatures, object AxisEntity,
        bool NaturalAxisDirection, object Count, object Angle, bool FitWithinAngle);
}