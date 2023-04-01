using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Sketch2D;

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