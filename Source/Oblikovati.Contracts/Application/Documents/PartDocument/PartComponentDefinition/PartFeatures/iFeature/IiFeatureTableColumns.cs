namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.iFeature;

public interface IiFeatureTableColumns : IList<IiFeatureTableColumns>
{
    IiFeatureTableColumn Item { get; }
}