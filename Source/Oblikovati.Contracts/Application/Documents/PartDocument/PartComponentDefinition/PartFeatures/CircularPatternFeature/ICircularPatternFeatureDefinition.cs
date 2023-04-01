using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.
    CircularPatternFeature;

public interface ICircularPatternFeatureDefinition
{
    IObjectCollection AffectedBodies { get; set; }
    IObjectCollection AffectedOccurrences { get; set; }
    PatternComputeTypeEnum ComputeType { get; set; }
    object Angle { get; set; }
    object Count { get; set; }
    bool LockRotation { get; set; }
    object PatternRadiusPoint { get; set; }
    object RotationAxis { get; set; }
    bool MidPlanePattern { get; set; }
    bool NaturalRotationAxisDirection { get; set; }
    PartFeatureOperationEnum Operation { get; set; }
    PatternPositioningMethodEnum PositioningMethod { get; set; }
    IObjectCollection ParentFeatures { get; set; }
    bool PatternOfBody { get; }
    ICircularPatternFeatureDefinition Copy();
}