using Oblikovati.Contracts.ClientGraphics.ComponentDefinition;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.iFeature;

public interface IiFeatureComponents : IList<IiFeatureComponents>
{
    IiFeatureComponent Item { get; }
    IComponentDefinition Parent { get; }
    IiFeatureComponent Add(IiFeatureDefinition Definition);
    IiFeatureDefinition CreateDefinition(string FullFileName);
}