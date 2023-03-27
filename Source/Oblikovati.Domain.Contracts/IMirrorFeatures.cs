using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IMirrorFeatures : IList<IMirrorFeatures>
{

    IMirrorFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IMirrorFeature _Add(IObjectCollection ParentFeatures, object MirrorPlaneEntity, bool AdjustToModel);
    IMirrorFeature Add(IObjectCollection ParentFeatures, object MirrorPlaneEntity, bool RemoveOriginal, PatternComputeTypeEnum ComputeType);
    IMirrorFeature AddByDefinition(IMirrorFeatureDefinition Definition);
    IMirrorFeatureDefinition CreateDefinition(IObjectCollection ParentFeatures, object MirrorPlaneEntity, PatternComputeTypeEnum ComputeType);
}
