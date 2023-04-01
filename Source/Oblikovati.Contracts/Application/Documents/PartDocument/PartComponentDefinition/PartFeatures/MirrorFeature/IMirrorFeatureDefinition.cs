using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.MirrorFeature;

public interface IMirrorFeatureDefinition
{
    IObjectCollection AffectedBodies { get; set; }
    PatternComputeTypeEnum ComputeType { get; set; }
    PartFeatureOperationEnum Operation { get; set; }
    IObjectCollection ParentFeatures { get; set; }
    bool MirrorOfBody { get; }
    object MirrorPlaneEntity { get; set; }
    bool RemoveOriginal { get; set; }
    IMirrorFeatureDefinition Copy();
}