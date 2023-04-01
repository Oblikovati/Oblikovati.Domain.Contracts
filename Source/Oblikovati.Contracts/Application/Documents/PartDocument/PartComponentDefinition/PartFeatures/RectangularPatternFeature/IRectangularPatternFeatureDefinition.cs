using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.
    RectangularPatternFeature;

public interface IRectangularPatternFeatureDefinition
{
    IObjectCollection AffectedBodies { get; set; }
    IObjectCollection AffectedOccurrences { get; set; }
    PatternComputeTypeEnum ComputeType { get; set; }
    bool NaturalXDirection { get; set; }
    bool NaturalYDirection { get; set; }
    PartFeatureOperationEnum Operation { get; set; }
    PatternOrientationEnum OrientationMethod { get; set; }
    IObjectCollection ParentFeatures { get; set; }
    bool PatternOfBody { get; }
    object XCount { get; set; }
    object XDirectionEntity { get; set; }
    PatternSpacingTypeEnum XDirectionSpacingType { get; set; }
    object XDirectionStartPoint { get; set; }
    object XSpacing { get; set; }
    bool XDirectionMidPlanePattern { get; set; }
    object YCount { get; set; }
    object YDirectionEntity { get; set; }
    PatternSpacingTypeEnum YDirectionSpacingType { get; set; }
    object YDirectionStartPoint { get; set; }
    object YSpacing { get; set; }
    bool YDirectionMidPlanePattern { get; set; }
    IRectangularPatternFeatureDefinition Copy();
}