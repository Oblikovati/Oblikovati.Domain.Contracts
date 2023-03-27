using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

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
