using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ICircularPatternFeatures : IList<ICircularPatternFeatures>
{

    ICircularPatternFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    ICircularPatternFeature _Add(IObjectCollection ParentFeatures, object AxisEntity, bool NaturalAxisDirection, object Count, object Angle, bool FitWithinAngle, bool AdjustToModel);
    ICircularPatternFeature Add(IObjectCollection ParentFeatures, object AxisEntity, bool NaturalAxisDirection, object Count, object Angle, bool FitWithinAngle, PatternComputeTypeEnum ComputeType);
    ICircularPatternFeature AddByDefinition(ICircularPatternFeatureDefinition Definition);
    ICircularPatternFeatureDefinition CreateDefinition(IObjectCollection ParentFeatures, object AxisEntity, bool NaturalAxisDirection, object Count, object Angle, bool FitWithinAngle);
}
