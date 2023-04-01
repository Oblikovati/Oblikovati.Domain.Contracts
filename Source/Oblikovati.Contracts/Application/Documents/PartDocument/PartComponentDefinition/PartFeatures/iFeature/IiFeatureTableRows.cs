namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.iFeature;

public interface IiFeatureTableRows : IList<IiFeatureTableRows>
{
    IiFeatureTableRow Item { get; }
}