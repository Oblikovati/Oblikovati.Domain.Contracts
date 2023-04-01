namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.MeshFeature;

public interface IMeshFeatureSets : IList<IMeshFeatureSets>
{
    IMeshFeatureSet Item { get; }

    IMeshFeatureSet Add(string FullName);
}