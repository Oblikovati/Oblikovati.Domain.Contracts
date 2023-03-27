using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ISketchDrivenPatternDefinition
{

    IObjectCollection AffectedOccurrences { get; set; }
    IObjectCollection AffectedBodies { get; set; }
    object BasePoint { get; set; }
    IFaceCollection ReferenceFaces { get; set; }
    PatternComputeTypeEnum ComputeType { get; set; }
    PartFeatureOperationEnum Operation { get; set; }
    IObjectCollection ParentFeatures { get; set; }
    bool PatternOfBody { get; }
    object Sketch { get; set; }
    ISketchDrivenPatternDefinition Copy();
}
