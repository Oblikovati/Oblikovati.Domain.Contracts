using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.MirrorFeature;

public interface IMirrorFeatures : IList<IMirrorFeatures>
{
    IMirrorFeature Item { get; }


    IMirrorFeature _Add(IObjectCollection ParentFeatures, object MirrorPlaneEntity, bool AdjustToModel);

    IMirrorFeature Add(IObjectCollection ParentFeatures, object MirrorPlaneEntity, bool RemoveOriginal,
        PatternComputeTypeEnum ComputeType);

    IMirrorFeature AddByDefinition(IMirrorFeatureDefinition Definition);

    IMirrorFeatureDefinition CreateDefinition(IObjectCollection ParentFeatures, object MirrorPlaneEntity,
        PatternComputeTypeEnum ComputeType);
}