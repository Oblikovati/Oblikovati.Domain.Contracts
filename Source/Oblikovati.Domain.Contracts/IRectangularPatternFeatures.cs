using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IRectangularPatternFeatures : IList<IRectangularPatternFeatures>
{

    IRectangularPatternFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IPath CreatePath(object SketchCurve);
    IRectangularPatternFeature _Add2(IObjectCollection ParentFeatures, object XDirectionEntity, bool NaturalXDirection, object XCount, object XSpacing, PatternSpacingTypeEnum XSpacingType, object XDirectionStartPoint, object YDirectionEntity, bool NaturalYDirection, object YCount, object YSpacing, PatternSpacingTypeEnum YSpacingType, object YDirectionStartPoint, bool AdjustToModel, PatternOrientationEnum OrientationMethod);
    IRectangularPatternFeature Add(IObjectCollection ParentFeatures, object XDirectionEntity, bool NaturalXDirection, object XCount, object XSpacing, PatternSpacingTypeEnum XSpacingType, object XDirectionStartPoint, object YDirectionEntity, bool NaturalYDirection, object YCount, object YSpacing, PatternSpacingTypeEnum YSpacingType, object YDirectionStartPoint, PatternComputeTypeEnum ComputeType, PatternOrientationEnum OrientationMethod);
    IRectangularPatternFeature AddByDefinition(IRectangularPatternFeatureDefinition Definition);
    IRectangularPatternFeatureDefinition CreateDefinition(IObjectCollection ParentFeatures, object XDirectionEntity, bool NaturalXDirection, object XCount, object XSpacing, PatternSpacingTypeEnum XSpacingType);
}
